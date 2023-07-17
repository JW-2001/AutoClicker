using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker
{
	public partial class Form1 : Form
	{
		[DllImport("User32.Dll", EntryPoint = "PostMessageA")]
		private static extern bool PostMessage(IntPtr hWnd, uint msg, int wParam, int lParam);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr GetForegroundWindow();

		[DllImport("user32.dll", SetLastError = true)]
		private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		[DllImport("user32.dll")]
		private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

		[DllImport("User32.dll")]
		private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

		public const int MOUSEEVENTF_LEFTDOWN = 0x02;
		public const int MOUSEEVENTF_LEFTUP = 0x04;

		public Form1()
		{
			InitializeComponent();
		}

		private void cpsTxtbox_TextChanged(object sender, EventArgs e)
		{
			cpsValue.Text = (cpsTxtbox.Text.ToString() + " CPS");
		}

		private void btnToggle_Click(object sender, EventArgs e)
		{
			if (btnToggle.Text.Contains("enable"))
			{
				btnToggle.Text = "disable";
			}
			else if (btnToggle.Text.Contains("disable"))
			{
				btnToggle.Text = "enable";
			}
		}

		private void btnToggle_TextChanged(object sender, EventArgs e)
		{
			if (btnToggle.Text.Contains("disable"))
			{
				Autoclicker.Start();
			}
			else
			{
				Autoclicker.Stop();
			}

			if (btnToggle.Text.Contains("disable"))
			{
				btnToggle.ForeColor = Color.FromArgb(80, 80, 80);
				btnToggle.BackColor = Color.Orange;
			}
			else if (btnToggle.Text.Contains("enable"))
			{
				btnToggle.ForeColor = Color.Orange;
				btnToggle.BackColor = Color.FromArgb(80, 80, 80);
			}
		}
		int min;
		int max;


		public string getActiveWindowName()
		{
			try
			{
				var activateHandle = GetForegroundWindow();

				Process[] processes = Process.GetProcesses();
				foreach (Process clsProcess in processes)
				{
					if (activateHandle == clsProcess.MainWindowHandle)
					{
						string processName = clsProcess.ProcessName;
						return processName;
					}
				}
			}
			catch { }
			return null;
		}


		private void Random_Tick(object sender, EventArgs e)
		{
			if (btnToggle.Text.Contains("disable"))
			{
				min = int.Parse(cpsTxtbox.Text.ToString()) - 6;
				max = int.Parse(cpsTxtbox.Text.ToString()) + 6;
				Random rand = new Random();
				randomTxt.Text = (rand.Next(min, max)).ToString();
			}
		}

		private void Autoclicker_Tick(object sender, EventArgs e)
		{
			try
			{
				Autoclicker.Interval = (640 / int.Parse(cpsTxtbox.Text.ToString()));
			}
			catch { }
			if (btnToggle.Text.Contains("disable"))
			{
				int x = Cursor.Position.X;
				int y = Cursor.Position.Y;
				mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, x, y, 0, 0);
			}
		}

		private void bindBtn_Click(object sender, EventArgs e)
		{
			bindBtn.Text = "...";
		}

		KeysConverter Key = new KeysConverter();

		private void Binding_Tick(object sender, EventArgs e)
		{
			if (bindBtn.Text != "none" && bindBtn.Text != "...")
			{
				Keys binding = (Keys)Key.ConvertFromString(bindBtn.Text.Replace("...", ""));
				if (GetAsyncKeyState(binding) < 0)
				{

					while (GetAsyncKeyState(binding) < 0)
					{
						Thread.Sleep(20);
					}
					if (btnToggle.Text.Contains("enable"))
					{
						btnToggle.Text = "disable";
					}
					else if (btnToggle.Text.Contains("disable"))
					{
						btnToggle.Text = "enable";
					}

					return;
				}
			}
		}

		private void bindBtn_KeyDown(object sender, KeyEventArgs e)
		{
			{
				string keydata = e.KeyData.ToString();
				if (!keydata.Contains("Alt"))
				{
					if (GetAsyncKeyState(Keys.Escape) < 0)
					{
						bindBtn.Text = "none";
					}
					else
					{
						bindBtn.Text = keydata;
					}
				}
			}
			KeysConverter Key = new KeysConverter();
		}

		private void randomTxt_TextChanged(object sender, EventArgs e)
		{

		}
	}
}