using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace acme
{
	public partial class MainForm : Form
	{
		private const string CRLF = "\r\n";

		public MainForm()
		{
			InitializeComponent();
			Init();
			Shown += (sndr, args) => tbDomainName.Focus();
			var certExpDates = GetCertificateExpirationDates();
			int maxSubjectLength = certExpDates.Max(c => c.Subject.Length);
			tbExpirationDates.AppendText(String.Join(CRLF, certExpDates.OrderBy(c => c.ExpirationDate).Select(c => c.Subject.PadRight(maxSubjectLength) + " : " + c.ExpirationDate)));
		}

		private void Init()
		{
			string localIP = GetLocalIP();
			string routerIP = GetExternalIP();

			tbLocalIP.Text = localIP;
			tbRouterIP.Text = routerIP;
		}

		protected string GetLocalIP()
		{
			return GetLocalHostIPs().First().ToString();
		}

		protected string GetExternalIP()
		{
			string externalIP;
			externalIP = (new WebClient()).DownloadString("http://checkip.dyndns.org/");
			externalIP = (new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}")).Matches(externalIP)[0].ToString();

			return externalIP;
		}

		protected List<IPAddress> GetLocalHostIPs()
		{
			IPHostEntry host;
			host = Dns.GetHostEntry(Dns.GetHostName());
			List<IPAddress> ret = host.AddressList.Where(ip => ip.AddressFamily == AddressFamily.InterNetwork).ToList();

			return ret;
		}

		protected List<CertificateExpiration> GetCertificateExpirationDates()
		{
			List<CertificateExpiration> certExpirations = new List<CertificateExpiration>();
			// My netsh binding expects certs here:
			GetCertificatesIn(StoreName.Root, certExpirations);

			// acme.net puts IIS certs here:
			GetCertificatesIn(StoreName.My, certExpirations);
			return certExpirations;
		}

		protected void GetCertificatesIn(StoreName storeName, List<CertificateExpiration> certs)
		{
			X509Store store = new X509Store(storeName, StoreLocation.LocalMachine);
			store.Open(OpenFlags.OpenExistingOnly);

			foreach (var cert in store.Certificates)
			{
				if (cert.Issuer.Contains("Let's Encrypt Authority"))
				{
					certs.Add(new CertificateExpiration()
					{
						Subject = cert.Subject.RightOf("CN="),
						ExpirationDate = cert.NotAfter,
					});
				}
			}

			store.Close();
		}

		private Process LaunchAcmeDotNet(string domainName, string certPassword)
		{
			// -a: accept terms of service
			// -j: accept instructions (since we're running a server that will accept the challenge
			// -d: the domain
			// -p: the password for the cert.
			// -c: challenge provider (manual, not iis)
			// -i: server configuration provider (manual, not iis)
			// -s: letsencrypt server.  For staging server, use: https://acme-staging.api.letsencrypt.org

			string staging = rbStaging.Checked ? "-s https://acme-staging.api.letsencrypt.org " : "";
			string manualOptions = "-c manual-http-01 -i manual";		// challenge is handled by our micro server, not IIS, and manaul configuration of certificate
			string iisOptions = "-c manual-http-01 -i iis";				// challenge is handled by our micro server but cert is installed and configured in IIS
			string options = rbIIS.Checked ? iisOptions : manualOptions;
			Process p = Helpers.LaunchProcess(@"acme.net\acme.exe", String.Format(staging + "-a -j -d {0} -p {1} {2}", domainName, certPassword, options),
				stdout => this.Invoke(() => tbLog.AppendText(stdout + CRLF)),
				stderr => this.Invoke(() => tbLog.AppendText(stderr + CRLF)));

			return p;
		}

		private void Verify(string s, string msg, ref bool ok)
		{
			if (ok && String.IsNullOrEmpty(s))
			{
				MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				ok = false;
			}
		}

		// EVENTS:

		private void lblAboutAcme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(lblAboutAcme.Text);
		}

		private void lblLetsEncrypt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(lblLetsEncrypt.Text);
		}

		private void btnCreateAndRegisterCertificate_Click(object sender, EventArgs e)
		{
			tbLog.Clear();
			bool ok = true;

			Verify(tbDomainName.Text, "Domain Name must be specified.", ref ok);
			Verify(tbCertPassword.Text, "Certificate Password must be specified.", ref ok);

			if (ok)
			{
				try
				{
					// Remove old certs.
					// CAUTION!  If an error occurs, or your site has constant traffic, removing the old certificate before the new one is successfully installed can result in your user experiencing certificate errors!
					CertRegistration.RemoveCert(StoreName.My, tbDomainName.Text);
					CertRegistration.RemoveCert(StoreName.AuthRoot, tbDomainName.Text);

					AcmeChallengeServer server = new AcmeChallengeServer();
					server.ServerException += (_, args) => this.Invoke(() =>		// synchronous, so ok gets set to false.
					{
						tbLog.AppendText("Server exception: " + args.Exception.Message);
						ok = false;
					});


					if (ok)
					{
						server.Start(tbLocalIP.Text);
						Process p = LaunchAcmeDotNet(tbDomainName.Text, tbCertPassword.Text);

						p.Exited += (snd, args) =>
						{
							server.Stop();

							// Unfortunately, we don't get an exit code on error.
							// int ret = p.ExitCode;
							if (!tbLog.Text.Contains("acme:error:"))
							{
								if (rbNetsh.Checked)
								{
									CertRegistration.Register(tbDomainName.Text, tbCertPassword.Text, s => this.BeginInvoke(() => tbLog.AppendText(s + CRLF)));

									if (tbLog.Text.Contains("SSL Certificate successfully added"))
									{
										this.BeginInvoke(() => MessageBox.Show("Certificate successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information));
									}
									else
									{
										this.BeginInvoke(() => MessageBox.Show("Please review the log for errors.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error));
									}
								}
							}
							else
							{
								this.BeginInvoke(() => MessageBox.Show("Please review the log for errors.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error));
							}
						};
					}
				}
				catch (Exception ex)
				{
					tbLog.AppendText(ex.Message);
				}
			}
		}
	}

	public class CertificateExpiration
	{
		public string Subject { get; set; }
		public DateTime ExpirationDate { get; set; }

		public override string ToString()
		{
			return Subject + " : " + ExpirationDate.ToString();
		}
	}
}
