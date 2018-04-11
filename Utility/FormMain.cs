using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Configuration;
using System.Threading;
using System.Globalization;

using Program;
using Notation;
using DataLib;
using PlatformLib;

namespace Utility
{
	public partial class FormMain : Form
	{
		// Plattform
		// 1.) STK500/Megacard
		// 2.) Raspberry PI
		// 3.) Basys3
		int platform;

		public FormMain()
		{
			// Initialize Language
			try
			{
				// Check if system language should be used
				if (ConfigurationManager.AppSettings[ResourceProgram.language] != ResourceProgram.none)
				{
					// Load language from App.config configuration
					Thread.CurrentThread.CurrentCulture = new CultureInfo(ConfigurationManager.AppSettings[ResourceProgram.language]);
					Thread.CurrentThread.CurrentUICulture = new CultureInfo(ConfigurationManager.AppSettings[ResourceProgram.language]);
				}
				else
				{
					// Try to setup the system language
					Thread.CurrentThread.CurrentCulture = new CultureInfo(CultureInfo.InstalledUICulture.ToString());
					Thread.CurrentThread.CurrentUICulture = new CultureInfo(CultureInfo.InstalledUICulture.ToString());
				}
			}
			catch
			{
				MessageBox.Show(ResourceNotation.MsgLanguageNotFound + CultureInfo.InstalledUICulture.ToString(), ResourceNotation.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}


			// Thread.CurrentThread.CurrentCulture = new CultureInfo("de-AT");
			// Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-AT");

			InitializeComponent();

		}

		private void githubToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start(ResourceNotation.Github);
			}
			catch
			{
				MessageBox.Show(ResourceNotation.HyperlinkError, ResourceNotation.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void githubToolStripMenuItem_Language(object sender, EventArgs e)
		{
			ToolStripMenuItem menudata = (ToolStripMenuItem)(sender);
			MessageBox.Show(ResourceNotation.LanguageSwitch, ResourceNotation.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);

		}

		private void platformToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem menudata = (ToolStripMenuItem)(sender);

			if (menudata.Name == STK500ToolStripMenuItem.Name)
			{
				platform = 1;

				if(STK500ToolStripMenuItem.Image == null)
				{
					STK500ToolStripMenuItem.Image = ResourceIcon.Symbols_Complete_and_ok_16xLG;
					raspberryPIToolStripMenuItem.Image = null;
					basys3ToolStripMenuItem.Image = null;
				}
				else
				{
					raspberryPIToolStripMenuItem.Image = null;
					STK500ToolStripMenuItem.Image = null;
					basys3ToolStripMenuItem.Image = null;
				}
			}
			else if (menudata.Name == raspberryPIToolStripMenuItem.Name)
			{
				platform = 2;

				if (raspberryPIToolStripMenuItem.Image == null)
				{
					STK500ToolStripMenuItem.Image = null;
					raspberryPIToolStripMenuItem.Image = ResourceIcon.Symbols_Complete_and_ok_16xLG;
					basys3ToolStripMenuItem.Image = null;
				}
				else
				{
					raspberryPIToolStripMenuItem.Image = null;
					STK500ToolStripMenuItem.Image = null;
					basys3ToolStripMenuItem.Image = null;
				}
			}
			
			else if(menudata.Name == basys3ToolStripMenuItem.Name)
			{
				platform = 3;

				if (basys3ToolStripMenuItem.Image == null)
				{
					STK500ToolStripMenuItem.Image = null;
					raspberryPIToolStripMenuItem.Image = null;
					basys3ToolStripMenuItem.Image = ResourceIcon.Symbols_Complete_and_ok_16xLG;
				}
				else
				{
					raspberryPIToolStripMenuItem.Image = null;
					STK500ToolStripMenuItem.Image = null;
					basys3ToolStripMenuItem.Image = null;
				}
			}
			else
			{
				platform = 0;

				raspberryPIToolStripMenuItem.Image = null;
				STK500ToolStripMenuItem.Image = null;
				basys3ToolStripMenuItem.Image = null;
			}

			


		}
	}
}
