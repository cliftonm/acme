using System;
using System.Windows.Forms;

namespace acme
{
	public static class ExtensionMethods
	{
		public static string RightOf(this String src, string s)
		{
			string ret = String.Empty;
			int idx = src.IndexOf(s);

			if (idx != -1)
			{
				ret = src.Substring(idx + s.Length);
			}

			return ret;
		}

		public static string RightOfRightmostOf(this string src, char c)
		{
			string ret = String.Empty;
			int idx = src.LastIndexOf(c);

			if (idx != -1)
			{
				ret = src.Substring(idx + 1);
			}

			return ret;
		}

		/// <summary>
		/// Asynchronous invoke on application thread.  Will return immediately unless invocation is not required.
		/// </summary>
		public static void BeginInvoke(this Control control, Action action)
		{
			if (control.InvokeRequired)
			{
				// We want a synchronous call here!!!!
				control.BeginInvoke((Delegate)action);
			}
			else
			{
				action();
			}
		}

		/// <summary>
		/// Synchronous invoke on application thread.  Will not return until action is completed.
		/// </summary>
		public static void Invoke(this Control control, Action action)
		{
			if (control.InvokeRequired)
			{
				// We want a synchronous call here!!!!
				control.Invoke((Delegate)action);
			}
			else
			{
				action();
			}
		}
	}
}
