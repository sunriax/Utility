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
			this.progressBarSetup = new System.Windows.Forms.ProgressBar();
			this.labelFrequency = new System.Windows.Forms.Label();
			this.buttonDisable = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonEnable = new System.Windows.Forms.Button();
			this.labelAmplitude = new System.Windows.Forms.Label();
			this.textBoxAmplitude = new System.Windows.Forms.TextBox();
			this.textBoxOffset = new System.Windows.Forms.TextBox();
			this.labelOffset = new System.Windows.Forms.Label();
			this.trackBarAmplitude = new System.Windows.Forms.TrackBar();
			this.trackBarOffset = new System.Windows.Forms.TrackBar();
			this.buttonSetup = new System.Windows.Forms.Button();
			this.comboBoxUnit = new System.Windows.Forms.ComboBox();
			this.textBoxFrequencySetup = new System.Windows.Forms.TextBox();
			this.textBoxFrequency = new System.Windows.Forms.TextBox();
			this.comboBoxSignal = new System.Windows.Forms.ComboBox();
			this.trackBarFrequency = new System.Windows.Forms.TrackBar();
			this.labelVersionNr = new System.Windows.Forms.Label();
			this.linkLabelWeb = new System.Windows.Forms.LinkLabel();
			this.labelVersion = new System.Windows.Forms.Label();
			this.pictureBoxBanner = new System.Windows.Forms.PictureBox();
			this.listViewQueue = new System.Windows.Forms.ListView();
			this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Frequency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Amplitude = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Offset = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.labelLastSettings = new System.Windows.Forms.Label();
			this.checkBoxDebug = new System.Windows.Forms.CheckBox();
			this.Wave = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxWave)).BeginInit();
			this.menuStripMain.SuspendLayout();
			this.groupBoxSettings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarAmplitude)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarOffset)).BeginInit();
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
			this.saveToolStripMenuItem.Image = global::WaveUtility.ResourceIcon.save_16xLG;
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.saveToolStripMenuItem.Text = "Speichern";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Image = global::WaveUtility.ResourceIcon.folder_Closed_16xLG;
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
			this.printToolStripMenuItem.Image = global::WaveUtility.ResourceIcon.printer_16xLG;
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
			this.quitToolStripMenuItem.Image = global::WaveUtility.ResourceIcon.action_Cancel_16xLG;
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
			this.versionToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.versionToolStripMenuItem.Text = "Version";
			// 
			// githubToolStripMenuItem
			// 
			this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
			this.githubToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.githubToolStripMenuItem.Text = "Github";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(139, 6);
			// 
			// updateToolStripMenuItem
			// 
			this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
			this.updateToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.updateToolStripMenuItem.Text = "Aktualisieren";
			// 
			// groupBoxSettings
			// 
			this.groupBoxSettings.Controls.Add(this.progressBarSetup);
			this.groupBoxSettings.Controls.Add(this.labelFrequency);
			this.groupBoxSettings.Controls.Add(this.buttonDisable);
			this.groupBoxSettings.Controls.Add(this.label3);
			this.groupBoxSettings.Controls.Add(this.buttonEnable);
			this.groupBoxSettings.Controls.Add(this.labelAmplitude);
			this.groupBoxSettings.Controls.Add(this.textBoxAmplitude);
			this.groupBoxSettings.Controls.Add(this.textBoxOffset);
			this.groupBoxSettings.Controls.Add(this.labelOffset);
			this.groupBoxSettings.Controls.Add(this.trackBarAmplitude);
			this.groupBoxSettings.Controls.Add(this.trackBarOffset);
			this.groupBoxSettings.Controls.Add(this.buttonSetup);
			this.groupBoxSettings.Controls.Add(this.comboBoxUnit);
			this.groupBoxSettings.Controls.Add(this.textBoxFrequencySetup);
			this.groupBoxSettings.Controls.Add(this.textBoxFrequency);
			this.groupBoxSettings.Controls.Add(this.comboBoxSignal);
			this.groupBoxSettings.Controls.Add(this.trackBarFrequency);
			this.groupBoxSettings.Location = new System.Drawing.Point(317, 28);
			this.groupBoxSettings.Name = "groupBoxSettings";
			this.groupBoxSettings.Size = new System.Drawing.Size(255, 229);
			this.groupBoxSettings.TabIndex = 2;
			this.groupBoxSettings.TabStop = false;
			this.groupBoxSettings.Text = "Einstellungen";
			// 
			// progressBarSetup
			// 
			this.progressBarSetup.Location = new System.Drawing.Point(152, 194);
			this.progressBarSetup.Name = "progressBarSetup";
			this.progressBarSetup.Size = new System.Drawing.Size(90, 21);
			this.progressBarSetup.TabIndex = 18;
			// 
			// labelFrequency
			// 
			this.labelFrequency.AutoSize = true;
			this.labelFrequency.Location = new System.Drawing.Point(52, 43);
			this.labelFrequency.Name = "labelFrequency";
			this.labelFrequency.Size = new System.Drawing.Size(51, 13);
			this.labelFrequency.TabIndex = 17;
			this.labelFrequency.Text = "Frequenz";
			// 
			// buttonDisable
			// 
			this.buttonDisable.Location = new System.Drawing.Point(88, 193);
			this.buttonDisable.Name = "buttonDisable";
			this.buttonDisable.Size = new System.Drawing.Size(55, 23);
			this.buttonDisable.TabIndex = 16;
			this.buttonDisable.Text = "Aus";
			this.buttonDisable.UseVisualStyleBackColor = true;
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
			// buttonEnable
			// 
			this.buttonEnable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.buttonEnable.Location = new System.Drawing.Point(7, 193);
			this.buttonEnable.Name = "buttonEnable";
			this.buttonEnable.Size = new System.Drawing.Size(55, 23);
			this.buttonEnable.TabIndex = 14;
			this.buttonEnable.Text = "Ein";
			this.buttonEnable.UseVisualStyleBackColor = false;
			// 
			// labelAmplitude
			// 
			this.labelAmplitude.AutoSize = true;
			this.labelAmplitude.Location = new System.Drawing.Point(190, 23);
			this.labelAmplitude.Name = "labelAmplitude";
			this.labelAmplitude.Size = new System.Drawing.Size(53, 13);
			this.labelAmplitude.TabIndex = 13;
			this.labelAmplitude.Text = "Amplitude";
			// 
			// textBoxAmplitude
			// 
			this.textBoxAmplitude.Location = new System.Drawing.Point(200, 164);
			this.textBoxAmplitude.Name = "textBoxAmplitude";
			this.textBoxAmplitude.Size = new System.Drawing.Size(42, 20);
			this.textBoxAmplitude.TabIndex = 12;
			this.textBoxAmplitude.Text = "2,5";
			this.textBoxAmplitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textBoxOffset
			// 
			this.textBoxOffset.Location = new System.Drawing.Point(152, 164);
			this.textBoxOffset.Name = "textBoxOffset";
			this.textBoxOffset.Size = new System.Drawing.Size(42, 20);
			this.textBoxOffset.TabIndex = 11;
			this.textBoxOffset.Text = "0";
			this.textBoxOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// labelOffset
			// 
			this.labelOffset.AutoSize = true;
			this.labelOffset.Location = new System.Drawing.Point(149, 23);
			this.labelOffset.Name = "labelOffset";
			this.labelOffset.Size = new System.Drawing.Size(35, 13);
			this.labelOffset.TabIndex = 10;
			this.labelOffset.Text = "Offset";
			// 
			// trackBarAmplitude
			// 
			this.trackBarAmplitude.LargeChange = 10;
			this.trackBarAmplitude.Location = new System.Drawing.Point(200, 54);
			this.trackBarAmplitude.Maximum = 100;
			this.trackBarAmplitude.Name = "trackBarAmplitude";
			this.trackBarAmplitude.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.trackBarAmplitude.Size = new System.Drawing.Size(45, 104);
			this.trackBarAmplitude.TabIndex = 9;
			this.trackBarAmplitude.Value = 50;
			// 
			// trackBarOffset
			// 
			this.trackBarOffset.LargeChange = 10;
			this.trackBarOffset.Location = new System.Drawing.Point(149, 54);
			this.trackBarOffset.Maximum = 50;
			this.trackBarOffset.Minimum = -50;
			this.trackBarOffset.Name = "trackBarOffset";
			this.trackBarOffset.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.trackBarOffset.Size = new System.Drawing.Size(45, 104);
			this.trackBarOffset.TabIndex = 8;
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
			// textBoxFrequencySetup
			// 
			this.textBoxFrequencySetup.Location = new System.Drawing.Point(7, 20);
			this.textBoxFrequencySetup.Name = "textBoxFrequencySetup";
			this.textBoxFrequencySetup.ReadOnly = true;
			this.textBoxFrequencySetup.Size = new System.Drawing.Size(136, 20);
			this.textBoxFrequencySetup.TabIndex = 4;
			this.textBoxFrequencySetup.Text = "---";
			this.textBoxFrequencySetup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
			// comboBoxSignal
			// 
			this.comboBoxSignal.FormattingEnabled = true;
			this.comboBoxSignal.Items.AddRange(new object[] {
            "Rechteck",
            "Sägezahn",
            "Dreieck",
            "Sinus"});
			this.comboBoxSignal.Location = new System.Drawing.Point(7, 137);
			this.comboBoxSignal.Name = "comboBoxSignal";
			this.comboBoxSignal.Size = new System.Drawing.Size(136, 21);
			this.comboBoxSignal.TabIndex = 1;
			// 
			// trackBarFrequency
			// 
			this.trackBarFrequency.LargeChange = 10;
			this.trackBarFrequency.Location = new System.Drawing.Point(7, 59);
			this.trackBarFrequency.Maximum = 1000;
			this.trackBarFrequency.Name = "trackBarFrequency";
			this.trackBarFrequency.Size = new System.Drawing.Size(136, 45);
			this.trackBarFrequency.TabIndex = 0;
			this.trackBarFrequency.Value = 100;
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
            this.Id,
            this.Wave,
            this.Frequency,
            this.Amplitude,
            this.Offset});
			this.listViewQueue.FullRowSelect = true;
			this.listViewQueue.HideSelection = false;
			this.listViewQueue.Location = new System.Drawing.Point(12, 282);
			this.listViewQueue.MultiSelect = false;
			this.listViewQueue.Name = "listViewQueue";
			this.listViewQueue.Size = new System.Drawing.Size(300, 68);
			this.listViewQueue.TabIndex = 1;
			this.listViewQueue.UseCompatibleStateImageBehavior = false;
			this.listViewQueue.View = System.Windows.Forms.View.Details;
			// 
			// Id
			// 
			this.Id.Text = "Id";
			this.Id.Width = 37;
			// 
			// Frequency
			// 
			this.Frequency.Text = "Frequenz";
			// 
			// Amplitude
			// 
			this.Amplitude.Text = "Amplitude";
			// 
			// Offset
			// 
			this.Offset.Text = "Offset";
			this.Offset.Width = 50;
			// 
			// labelLastSettings
			// 
			this.labelLastSettings.AutoSize = true;
			this.labelLastSettings.Location = new System.Drawing.Point(12, 266);
			this.labelLastSettings.Name = "labelLastSettings";
			this.labelLastSettings.Size = new System.Drawing.Size(102, 13);
			this.labelLastSettings.TabIndex = 19;
			this.labelLastSettings.Text = "Letzte Einstellungen";
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
			// Wave
			// 
			this.Wave.Text = "Signal";
			this.Wave.Width = 62;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 361);
			this.Controls.Add(this.checkBoxDebug);
			this.Controls.Add(this.labelLastSettings);
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
			((System.ComponentModel.ISupportInitialize)(this.trackBarAmplitude)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarOffset)).EndInit();
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
		private System.Windows.Forms.ComboBox comboBoxSignal;
		private System.Windows.Forms.TextBox textBoxFrequency;
		private System.Windows.Forms.TextBox textBoxFrequencySetup;
		private System.Windows.Forms.ComboBox comboBoxUnit;
		private System.Windows.Forms.Button buttonSetup;
		private System.Windows.Forms.TrackBar trackBarAmplitude;
		private System.Windows.Forms.TrackBar trackBarOffset;
		private System.Windows.Forms.TextBox textBoxAmplitude;
		private System.Windows.Forms.TextBox textBoxOffset;
		private System.Windows.Forms.Label labelOffset;
		private System.Windows.Forms.Label labelAmplitude;
		private System.Windows.Forms.Button buttonEnable;
		private System.Windows.Forms.Button buttonDisable;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label labelFrequency;
		private System.Windows.Forms.ProgressBar progressBarSetup;
		private System.Windows.Forms.Label labelVersionNr;
		private System.Windows.Forms.LinkLabel linkLabelWeb;
		private System.Windows.Forms.Label labelVersion;
		private System.Windows.Forms.PictureBox pictureBoxBanner;
		private System.Windows.Forms.ListView listViewQueue;
		private System.Windows.Forms.Label labelLastSettings;
		private System.Windows.Forms.ColumnHeader Id;
		private System.Windows.Forms.ColumnHeader Frequency;
		private System.Windows.Forms.ColumnHeader Amplitude;
		private System.Windows.Forms.ColumnHeader Offset;
		private System.Windows.Forms.CheckBox checkBoxDebug;
		private System.Windows.Forms.ColumnHeader Wave;
	}
}

