namespace Utility
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
			this.menuStripMain = new System.Windows.Forms.MenuStrip();
			this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.memoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.analyseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.busToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SPIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TWIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ethernetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.signalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.platformToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.raspberryPIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.STK500ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.basys3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.enGBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.esESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.labelVersion = new System.Windows.Forms.Label();
			this.linkLabelWeb = new System.Windows.Forms.LinkLabel();
			this.labelVersionNr = new System.Windows.Forms.Label();
			this.pictureBoxBanner = new System.Windows.Forms.PictureBox();
			this.menuStripMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStripMain
			// 
			this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.modulToolStripMenuItem,
            this.analyseToolStripMenuItem,
            this.platformToolStripMenuItem,
            this.helpToolStripMenuItem});
			resources.ApplyResources(this.menuStripMain, "menuStripMain");
			this.menuStripMain.Name = "menuStripMain";
			// 
			// startToolStripMenuItem
			// 
			this.startToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveToolStripMenuItem,
            this.saveasToolStripMenuItem,
            this.toolStripSeparator2,
            this.printToolStripMenuItem,
            this.toolStripSeparator4,
            this.quitToolStripMenuItem});
			this.startToolStripMenuItem.Image = global::Utility.ResourceIcon.application_16xLG;
			this.startToolStripMenuItem.Name = "startToolStripMenuItem";
			resources.ApplyResources(this.startToolStripMenuItem, "startToolStripMenuItem");
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Image = global::Utility.ResourceIcon.action_create_16xLG;
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			resources.ApplyResources(this.newToolStripMenuItem, "newToolStripMenuItem");
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Image = global::Utility.ResourceIcon.folder_Open_16xLG;
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Image = global::Utility.ResourceIcon.save_16xLG;
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
			// 
			// saveasToolStripMenuItem
			// 
			this.saveasToolStripMenuItem.Name = "saveasToolStripMenuItem";
			resources.ApplyResources(this.saveasToolStripMenuItem, "saveasToolStripMenuItem");
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
			// 
			// printToolStripMenuItem
			// 
			this.printToolStripMenuItem.Image = global::Utility.ResourceIcon.printer_16xLG;
			this.printToolStripMenuItem.Name = "printToolStripMenuItem";
			resources.ApplyResources(this.printToolStripMenuItem, "printToolStripMenuItem");
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.Image = global::Utility.ResourceIcon.action_Cancel_16xLG;
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			resources.ApplyResources(this.quitToolStripMenuItem, "quitToolStripMenuItem");
			// 
			// modulToolStripMenuItem
			// 
			this.modulToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memoryToolStripMenuItem,
            this.displayToolStripMenuItem});
			this.modulToolStripMenuItem.Image = global::Utility.ResourceIcon.Processor;
			this.modulToolStripMenuItem.Name = "modulToolStripMenuItem";
			resources.ApplyResources(this.modulToolStripMenuItem, "modulToolStripMenuItem");
			// 
			// memoryToolStripMenuItem
			// 
			this.memoryToolStripMenuItem.Image = global::Utility.ResourceIcon.MemoryWindow_6537;
			this.memoryToolStripMenuItem.Name = "memoryToolStripMenuItem";
			resources.ApplyResources(this.memoryToolStripMenuItem, "memoryToolStripMenuItem");
			// 
			// displayToolStripMenuItem
			// 
			this.displayToolStripMenuItem.Image = global::Utility.ResourceIcon.mobile_16xLG;
			this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
			resources.ApplyResources(this.displayToolStripMenuItem, "displayToolStripMenuItem");
			// 
			// analyseToolStripMenuItem
			// 
			this.analyseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.busToolStripMenuItem,
            this.ethernetToolStripMenuItem,
            this.signalToolStripMenuItem});
			this.analyseToolStripMenuItem.Image = global::Utility.ResourceIcon.glasses_16xLG;
			this.analyseToolStripMenuItem.Name = "analyseToolStripMenuItem";
			resources.ApplyResources(this.analyseToolStripMenuItem, "analyseToolStripMenuItem");
			// 
			// busToolStripMenuItem
			// 
			this.busToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SPIToolStripMenuItem,
            this.TWIToolStripMenuItem,
            this.CANToolStripMenuItem});
			this.busToolStripMenuItem.Image = global::Utility.ResourceIcon.hardware_16xLG;
			this.busToolStripMenuItem.Name = "busToolStripMenuItem";
			resources.ApplyResources(this.busToolStripMenuItem, "busToolStripMenuItem");
			// 
			// SPIToolStripMenuItem
			// 
			this.SPIToolStripMenuItem.Name = "SPIToolStripMenuItem";
			resources.ApplyResources(this.SPIToolStripMenuItem, "SPIToolStripMenuItem");
			// 
			// TWIToolStripMenuItem
			// 
			this.TWIToolStripMenuItem.Name = "TWIToolStripMenuItem";
			resources.ApplyResources(this.TWIToolStripMenuItem, "TWIToolStripMenuItem");
			// 
			// CANToolStripMenuItem
			// 
			this.CANToolStripMenuItem.Name = "CANToolStripMenuItem";
			resources.ApplyResources(this.CANToolStripMenuItem, "CANToolStripMenuItem");
			// 
			// ethernetToolStripMenuItem
			// 
			this.ethernetToolStripMenuItem.Image = global::Utility.ResourceIcon.Diagram_16XLG;
			this.ethernetToolStripMenuItem.Name = "ethernetToolStripMenuItem";
			resources.ApplyResources(this.ethernetToolStripMenuItem, "ethernetToolStripMenuItem");
			// 
			// signalToolStripMenuItem
			// 
			this.signalToolStripMenuItem.Image = global::Utility.ResourceIcon.lightningBolt_16xLG;
			this.signalToolStripMenuItem.Name = "signalToolStripMenuItem";
			resources.ApplyResources(this.signalToolStripMenuItem, "signalToolStripMenuItem");
			// 
			// platformToolStripMenuItem
			// 
			this.platformToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raspberryPIToolStripMenuItem,
            this.STK500ToolStripMenuItem,
            this.basys3ToolStripMenuItem});
			this.platformToolStripMenuItem.Image = global::Utility.ResourceIcon.Partition_16xLG;
			this.platformToolStripMenuItem.Name = "platformToolStripMenuItem";
			resources.ApplyResources(this.platformToolStripMenuItem, "platformToolStripMenuItem");
			// 
			// raspberryPIToolStripMenuItem
			// 
			this.raspberryPIToolStripMenuItem.Name = "raspberryPIToolStripMenuItem";
			resources.ApplyResources(this.raspberryPIToolStripMenuItem, "raspberryPIToolStripMenuItem");
			this.raspberryPIToolStripMenuItem.Click += new System.EventHandler(this.platformToolStripMenuItem_Click);
			// 
			// STK500ToolStripMenuItem
			// 
			this.STK500ToolStripMenuItem.Name = "STK500ToolStripMenuItem";
			resources.ApplyResources(this.STK500ToolStripMenuItem, "STK500ToolStripMenuItem");
			this.STK500ToolStripMenuItem.Click += new System.EventHandler(this.platformToolStripMenuItem_Click);
			// 
			// basys3ToolStripMenuItem
			// 
			this.basys3ToolStripMenuItem.Name = "basys3ToolStripMenuItem";
			resources.ApplyResources(this.basys3ToolStripMenuItem, "basys3ToolStripMenuItem");
			this.basys3ToolStripMenuItem.Click += new System.EventHandler(this.platformToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem,
            this.toolStripSeparator1,
            this.githubToolStripMenuItem,
            this.versionToolStripMenuItem});
			this.helpToolStripMenuItem.Image = global::Utility.ResourceIcon.LightBulb_16xLG;
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
			// 
			// languageToolStripMenuItem
			// 
			this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enGBToolStripMenuItem,
            this.deATToolStripMenuItem,
            this.esESToolStripMenuItem});
			this.languageToolStripMenuItem.Image = global::Utility.ResourceIcon.book_Open_16xLG;
			this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
			resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
			// 
			// enGBToolStripMenuItem
			// 
			this.enGBToolStripMenuItem.Image = global::Utility.ResourceIcon.en_GB;
			this.enGBToolStripMenuItem.Name = "enGBToolStripMenuItem";
			resources.ApplyResources(this.enGBToolStripMenuItem, "enGBToolStripMenuItem");
			this.enGBToolStripMenuItem.Click += new System.EventHandler(this.githubToolStripMenuItem_Language);
			// 
			// deATToolStripMenuItem
			// 
			this.deATToolStripMenuItem.Image = global::Utility.ResourceIcon.de_AT;
			this.deATToolStripMenuItem.Name = "deATToolStripMenuItem";
			resources.ApplyResources(this.deATToolStripMenuItem, "deATToolStripMenuItem");
			this.deATToolStripMenuItem.Click += new System.EventHandler(this.githubToolStripMenuItem_Language);
			// 
			// esESToolStripMenuItem
			// 
			this.esESToolStripMenuItem.Image = global::Utility.ResourceIcon.es_ES;
			this.esESToolStripMenuItem.Name = "esESToolStripMenuItem";
			resources.ApplyResources(this.esESToolStripMenuItem, "esESToolStripMenuItem");
			this.esESToolStripMenuItem.Click += new System.EventHandler(this.githubToolStripMenuItem_Language);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
			// 
			// githubToolStripMenuItem
			// 
			this.githubToolStripMenuItem.Image = global::Utility.ResourceIcon.WebForm_ASPX__815_16x;
			this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
			resources.ApplyResources(this.githubToolStripMenuItem, "githubToolStripMenuItem");
			this.githubToolStripMenuItem.Click += new System.EventHandler(this.githubToolStripMenuItem_Click);
			// 
			// versionToolStripMenuItem
			// 
			this.versionToolStripMenuItem.Image = global::Utility.ResourceIcon.WebPartManager_6047;
			this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
			resources.ApplyResources(this.versionToolStripMenuItem, "versionToolStripMenuItem");
			// 
			// labelVersion
			// 
			resources.ApplyResources(this.labelVersion, "labelVersion");
			this.labelVersion.Name = "labelVersion";
			// 
			// linkLabelWeb
			// 
			resources.ApplyResources(this.linkLabelWeb, "linkLabelWeb");
			this.linkLabelWeb.Name = "linkLabelWeb";
			this.linkLabelWeb.TabStop = true;
			// 
			// labelVersionNr
			// 
			resources.ApplyResources(this.labelVersionNr, "labelVersionNr");
			this.labelVersionNr.Name = "labelVersionNr";
			// 
			// pictureBoxBanner
			// 
			this.pictureBoxBanner.BackgroundImage = global::Utility.ResourceIcon.logo;
			resources.ApplyResources(this.pictureBoxBanner, "pictureBoxBanner");
			this.pictureBoxBanner.Name = "pictureBoxBanner";
			this.pictureBoxBanner.TabStop = false;
			// 
			// FormMain
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.labelVersionNr);
			this.Controls.Add(this.linkLabelWeb);
			this.Controls.Add(this.labelVersion);
			this.Controls.Add(this.pictureBoxBanner);
			this.Controls.Add(this.menuStripMain);
			this.MainMenuStrip = this.menuStripMain;
			this.Name = "FormMain";
			this.menuStripMain.ResumeLayout(false);
			this.menuStripMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStripMain;
		private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem platformToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem STK500ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem basys3ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBoxBanner;
		private System.Windows.Forms.Label labelVersion;
		private System.Windows.Forms.LinkLabel linkLabelWeb;
		private System.Windows.Forms.Label labelVersionNr;
		private System.Windows.Forms.ToolStripMenuItem raspberryPIToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deATToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem enGBToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem esESToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem modulToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem memoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem analyseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem busToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SPIToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem TWIToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CANToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ethernetToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem signalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveasToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
	}
}

