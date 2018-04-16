namespace WaveUtility
{
	partial class FormMain
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.pictureBoxWave = new System.Windows.Forms.PictureBox();
			this.menuStripMain = new System.Windows.Forms.MenuStrip();
			this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBoxSettings = new System.Windows.Forms.GroupBox();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.label4 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.trackBar2 = new System.Windows.Forms.TrackBar();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.buttonSetup = new System.Windows.Forms.Button();
			this.comboBoxUnit = new System.Windows.Forms.ComboBox();
			this.textBoxSignal = new System.Windows.Forms.TextBox();
			this.textBoxFrequency = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.trackBarFrequency = new System.Windows.Forms.TrackBar();
			this.labelVersionNr = new System.Windows.Forms.Label();
			this.linkLabelWeb = new System.Windows.Forms.LinkLabel();
			this.labelVersion = new System.Windows.Forms.Label();
			this.pictureBoxBanner = new System.Windows.Forms.PictureBox();
			this.listViewQueue = new System.Windows.Forms.ListView();
			this.labelLastSetting = new System.Windows.Forms.Label();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.checkBoxDebug = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxWave)).BeginInit();
			this.menuStripMain.SuspendLayout();
			this.groupBoxSettings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarFrequency)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxWave
			// 
			this.pictureBoxWave.BackColor = System.Drawing.Color.White;
			this.pictureBoxWave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxWave.Location = new System.Drawing.Point(12, 27);
			this.pictureBoxWave.Name = "pictureBoxWave";
			this.pictureBoxWave.Size = new System.Drawing.Size(300, 230);
			this.pictureBoxWave.TabIndex = 0;
			this.pictureBoxWave.TabStop = false;
			this.pictureBoxWave.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxWave_Paint);
			// 
			// menuStripMain
			// 
			this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.hilfeToolStripMenuItem});
			this.menuStripMain.Location = new System.Drawing.Point(0, 0);
			this.menuStripMain.Name = "menuStripMain";
			this.menuStripMain.Size = new System.Drawing.Size(584, 24);
			this.menuStripMain.TabIndex = 1;
			this.menuStripMain.Text = "menuStripMain";
			// 
			// startToolStripMenuItem
			// 
			this.startToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitToolStripMenuItem});
			this.startToolStripMenuItem.Image = global::WaveUtility.ResourceIcon.procedure_16xLG;
			this.startToolStripMenuItem.Name = "startToolStripMenuItem";
			this.startToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
			this.startToolStripMenuItem.Text = "Start";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.saveToolStripMenuItem.Text = "Speichern";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.openToolStripMenuItem.Text = "Öffnen";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// printToolStripMenuItem
			// 
			this.printToolStripMenuItem.Name = "printToolStripMenuItem";
			this.printToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.printToolStripMenuItem.Text = "Drucken";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.quitToolStripMenuItem.Text = "Beenden";
			// 
			// hilfeToolStripMenuItem
			// 
			this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem,
            this.githubToolStripMenuItem,
            this.toolStripSeparator3,
            this.updateToolStripMenuItem});
			this.hilfeToolStripMenuItem.Image = global::WaveUtility.ResourceIcon.LightBulb_16xLG;
			this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
			this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.hilfeToolStripMenuItem.Text = "Hilfe";
			// 
			// versionToolStripMenuItem
			// 
			this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
			this.versionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.versionToolStripMenuItem.Text = "Version";
			// 
			// githubToolStripMenuItem
			// 
			this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
			this.githubToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.githubToolStripMenuItem.Text = "Github";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
			// 
			// updateToolStripMenuItem
			// 
			this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
			this.updateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.updateToolStripMenuItem.Text = "Aktualisieren";
			// 
			// groupBoxSettings
			// 
			this.groupBoxSettings.Controls.Add(this.progressBar1);
			this.groupBoxSettings.Controls.Add(this.label4);
			this.groupBoxSettings.Controls.Add(this.button2);
			this.groupBoxSettings.Controls.Add(this.label3);
			this.groupBoxSettings.Controls.Add(this.button1);
			this.groupBoxSettings.Controls.Add(this.label2);
			this.groupBoxSettings.Controls.Add(this.textBox2);
			this.groupBoxSettings.Controls.Add(this.textBox1);
			this.groupBoxSettings.Controls.Add(this.label1);
			this.groupBoxSettings.Controls.Add(this.trackBar2);
			this.groupBoxSettings.Controls.Add(this.trackBar1);
			this.groupBoxSettings.Controls.Add(this.buttonSetup);
			this.groupBoxSettings.Controls.Add(this.comboBoxUnit);
			this.groupBoxSettings.Controls.Add(this.textBoxSignal);
			this.groupBoxSettings.Controls.Add(this.textBoxFrequency);
			this.groupBoxSettings.Controls.Add(this.comboBox1);
			this.groupBoxSettings.Controls.Add(this.trackBarFrequency);
			this.groupBoxSettings.Location = new System.Drawing.Point(317, 28);
			this.groupBoxSettings.Name = "groupBoxSettings";
			this.groupBoxSettings.Size = new System.Drawing.Size(255, 229);
			this.groupBoxSettings.TabIndex = 2;
			this.groupBoxSettings.TabStop = false;
			this.groupBoxSettings.Text = "Einstellungen";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(152, 164);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(90, 22);
			this.progressBar1.TabIndex = 18;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(52, 43);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 13);
			this.label4.TabIndex = 17;
			this.label4.Text = "Frequenz";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(88, 193);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(55, 23);
			this.button2.TabIndex = 16;
			this.button2.Text = "Aus";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(70, 198);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(12, 13);
			this.label3.TabIndex = 15;
			this.label3.Text = "/";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.button1.Location = new System.Drawing.Point(7, 193);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(55, 23);
			this.button1.TabIndex = 14;
			this.button1.Text = "Ein";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(190, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "Amplitude";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(200, 137);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(42, 20);
			this.textBox2.TabIndex = 12;
			this.textBox2.Text = "5";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(152, 137);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(42, 20);
			this.textBox1.TabIndex = 11;
			this.textBox1.Text = "0";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(149, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Offset";
			// 
			// trackBar2
			// 
			this.trackBar2.Location = new System.Drawing.Point(200, 54);
			this.trackBar2.Name = "trackBar2";
			this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.trackBar2.Size = new System.Drawing.Size(45, 77);
			this.trackBar2.TabIndex = 9;
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(149, 54);
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.trackBar1.Size = new System.Drawing.Size(45, 77);
			this.trackBar1.TabIndex = 8;
			// 
			// buttonSetup
			// 
			this.buttonSetup.Location = new System.Drawing.Point(7, 164);
			this.buttonSetup.Name = "buttonSetup";
			this.buttonSetup.Size = new System.Drawing.Size(136, 23);
			this.buttonSetup.TabIndex = 6;
			this.buttonSetup.Text = "Setup";
			this.buttonSetup.UseVisualStyleBackColor = true;
			// 
			// comboBoxUnit
			// 
			this.comboBoxUnit.FormattingEnabled = true;
			this.comboBoxUnit.Items.AddRange(new object[] {
            "mHz",
            "Hz",
            "kHz",
            "MHZ"});
			this.comboBoxUnit.Location = new System.Drawing.Point(85, 110);
			this.comboBoxUnit.Name = "comboBoxUnit";
			this.comboBoxUnit.Size = new System.Drawing.Size(58, 21);
			this.comboBoxUnit.TabIndex = 5;
			// 
			// textBoxSignal
			// 
			this.textBoxSignal.Location = new System.Drawing.Point(7, 20);
			this.textBoxSignal.Name = "textBoxSignal";
			this.textBoxSignal.Size = new System.Drawing.Size(136, 20);
			this.textBoxSignal.TabIndex = 4;
			this.textBoxSignal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBoxFrequency
			// 
			this.textBoxFrequency.Location = new System.Drawing.Point(7, 111);
			this.textBoxFrequency.Name = "textBoxFrequency";
			this.textBoxFrequency.Size = new System.Drawing.Size(72, 20);
			this.textBoxFrequency.TabIndex = 2;
			this.textBoxFrequency.Text = "100";
			this.textBoxFrequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Rechteck",
            "Sägezahn",
            "Dreieck",
            "Sinus"});
			this.comboBox1.Location = new System.Drawing.Point(7, 137);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(136, 21);
			this.comboBox1.TabIndex = 1;
			// 
			// trackBarFrequency
			// 
			this.trackBarFrequency.Location = new System.Drawing.Point(7, 59);
			this.trackBarFrequency.Name = "trackBarFrequency";
			this.trackBarFrequency.Size = new System.Drawing.Size(136, 45);
			this.trackBarFrequency.TabIndex = 0;
			// 
			// labelVersionNr
			// 
			this.labelVersionNr.AutoSize = true;
			this.labelVersionNr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelVersionNr.Location = new System.Drawing.Point(523, 319);
			this.labelVersionNr.Name = "labelVersionNr";
			this.labelVersionNr.Size = new System.Drawing.Size(22, 13);
			this.labelVersionNr.TabIndex = 8;
			this.labelVersionNr.Text = "1.0";
			// 
			// linkLabelWeb
			// 
			this.linkLabelWeb.AutoSize = true;
			this.linkLabelWeb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.linkLabelWeb.Location = new System.Drawing.Point(472, 337);
			this.linkLabelWeb.Name = "linkLabelWeb";
			this.linkLabelWeb.Size = new System.Drawing.Size(79, 13);
			this.linkLabelWeb.TabIndex = 7;
			this.linkLabelWeb.TabStop = true;
			this.linkLabelWeb.Text = "www.sunriax.at";
			// 
			// labelVersion
			// 
			this.labelVersion.AutoSize = true;
			this.labelVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelVersion.Location = new System.Drawing.Point(472, 319);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new System.Drawing.Size(45, 13);
			this.labelVersion.TabIndex = 6;
			this.labelVersion.Text = "Version:";
			// 
			// pictureBoxBanner
			// 
			this.pictureBoxBanner.BackgroundImage = global::WaveUtility.ResourceImage.logo_small;
			this.pictureBoxBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBoxBanner.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.pictureBoxBanner.Location = new System.Drawing.Point(472, 280);
			this.pictureBoxBanner.Name = "pictureBoxBanner";
			this.pictureBoxBanner.Size = new System.Drawing.Size(100, 32);
			this.pictureBoxBanner.TabIndex = 5;
			this.pictureBoxBanner.TabStop = false;
			// 
			// listViewQueue
			// 
			this.listViewQueue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.listViewQueue.Location = new System.Drawing.Point(12, 282);
			this.listViewQueue.Name = "listViewQueue";
			this.listViewQueue.Size = new System.Drawing.Size(300, 68);
			this.listViewQueue.TabIndex = 9;
			this.listViewQueue.UseCompatibleStateImageBehavior = false;
			// 
			// labelLastSetting
			// 
			this.labelLastSetting.AutoSize = true;
			this.labelLastSetting.Location = new System.Drawing.Point(12, 266);
			this.labelLastSetting.Name = "labelLastSetting";
			this.labelLastSetting.Size = new System.Drawing.Size(102, 13);
			this.labelLastSetting.TabIndex = 19;
			this.labelLastSetting.Text = "Letzte Einstellungen";
			// 
			// checkBoxDebug
			// 
			this.checkBoxDebug.AutoSize = true;
			this.checkBoxDebug.Location = new System.Drawing.Point(324, 282);
			this.checkBoxDebug.Name = "checkBoxDebug";
			this.checkBoxDebug.Size = new System.Drawing.Size(93, 17);
			this.checkBoxDebug.TabIndex = 20;
			this.checkBoxDebug.Text = "Debug Modus";
			this.checkBoxDebug.UseVisualStyleBackColor = true;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 361);
			this.Controls.Add(this.checkBoxDebug);
			this.Controls.Add(this.labelLastSetting);
			this.Controls.Add(this.listViewQueue);
			this.Controls.Add(this.labelVersionNr);
			this.Controls.Add(this.linkLabelWeb);
			this.Controls.Add(this.labelVersion);
			this.Controls.Add(this.pictureBoxBanner);
			this.Controls.Add(this.groupBoxSettings);
			this.Controls.Add(this.pictureBoxWave);
			this.Controls.Add(this.menuStripMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStripMain;
			this.Name = "FormMain";
			this.Text = "SUNriaX WaveUtility!";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxWave)).EndInit();
			this.menuStripMain.ResumeLayout(false);
			this.menuStripMain.PerformLayout();
			this.groupBoxSettings.ResumeLayout(false);
			this.groupBoxSettings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarFrequency)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxWave;
		private System.Windows.Forms.MenuStrip menuStripMain;
		private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
		private System.Windows.Forms.GroupBox groupBoxSettings;
		private System.Windows.Forms.TrackBar trackBarFrequency;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBoxFrequency;
		private System.Windows.Forms.TextBox textBoxSignal;
		private System.Windows.Forms.ComboBox comboBoxUnit;
		private System.Windows.Forms.Button buttonSetup;
		private System.Windows.Forms.TrackBar trackBar2;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label labelVersionNr;
		private System.Windows.Forms.LinkLabel linkLabelWeb;
		private System.Windows.Forms.Label labelVersion;
		private System.Windows.Forms.PictureBox pictureBoxBanner;
		private System.Windows.Forms.ListView listViewQueue;
		private System.Windows.Forms.Label labelLastSetting;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.CheckBox checkBoxDebug;
	}
}

