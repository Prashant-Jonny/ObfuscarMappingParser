﻿namespace ObfuscarMappingParser
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.odMapping = new System.Windows.Forms.OpenFileDialog();
      this.statusStrip = new System.Windows.Forms.StatusStrip();
      this.spbLoading = new System.Windows.Forms.ToolStripProgressBar();
      this.slblSelected = new System.Windows.Forms.ToolStripStatusLabel();
      this.ilIcons = new System.Windows.Forms.ImageList(this.components);
      this.tsTools = new System.Windows.Forms.ToolStrip();
      this.btnOpen = new System.Windows.Forms.ToolStripDropDownButton();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.miOpenBtn = new System.Windows.Forms.ToolStripMenuItem();
      this.btnCrashLogs = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.lblSearch = new System.Windows.Forms.ToolStripLabel();
      this.tbSearch = new System.Windows.Forms.ToolStripTextBox();
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.mmFile = new System.Windows.Forms.ToolStripMenuItem();
      this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
      this.miRecents = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
      this.miManagePDBs = new System.Windows.Forms.ToolStripMenuItem();
      this.miAttachPDB = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.miExit = new System.Windows.Forms.ToolStripMenuItem();
      this.miView = new System.Windows.Forms.ToolStripMenuItem();
      this.miSortAscending = new System.Windows.Forms.ToolStripMenuItem();
      this.miSortDescending = new System.Windows.Forms.ToolStripMenuItem();
      this.miSortNewAscending = new System.Windows.Forms.ToolStripMenuItem();
      this.miSortNewDesc = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.miGroupNamespace = new System.Windows.Forms.ToolStripMenuItem();
      this.miShowModule = new System.Windows.Forms.ToolStripMenuItem();
      this.miGroupModules = new System.Windows.Forms.ToolStripMenuItem();
      this.miUseColumns = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.miStatistics = new System.Windows.Forms.ToolStripMenuItem();
      this.miSettings = new System.Windows.Forms.ToolStripMenuItem();
      this.mmSearch = new System.Windows.Forms.ToolStripMenuItem();
      this.miCrashlogs = new System.Windows.Forms.ToolStripMenuItem();
      this.miStacktrace = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
      this.miSearch = new System.Windows.Forms.ToolStripMenuItem();
      this.mmHelp = new System.Windows.Forms.ToolStripMenuItem();
      this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
      this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.miCopyOldName = new System.Windows.Forms.ToolStripMenuItem();
      this.miCopyFullOldName = new System.Windows.Forms.ToolStripMenuItem();
      this.miCopyNewName = new System.Windows.Forms.ToolStripMenuItem();
      this.miCopyFullNewName = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
      this.miOpenVS = new System.Windows.Forms.ToolStripMenuItem();
      this.odPDB = new System.Windows.Forms.OpenFileDialog();
      this.ptvElements = new BrokenEvent.Shared.TreeView.PineappleTreeView();
      this.odSourceFile = new System.Windows.Forms.OpenFileDialog();
      this.statusStrip.SuspendLayout();
      this.tsTools.SuspendLayout();
      this.menuStrip.SuspendLayout();
      this.contextMenuStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // odMapping
      // 
      this.odMapping.Filter = "XML files (*.xml)|*.xml";
      // 
      // statusStrip
      // 
      this.statusStrip.AllowMerge = false;
      this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spbLoading,
            this.slblSelected});
      this.statusStrip.Location = new System.Drawing.Point(0, 528);
      this.statusStrip.Name = "statusStrip";
      this.statusStrip.ShowItemToolTips = true;
      this.statusStrip.Size = new System.Drawing.Size(727, 22);
      this.statusStrip.TabIndex = 1;
      this.statusStrip.Text = "statusStrip";
      // 
      // spbLoading
      // 
      this.spbLoading.Enabled = false;
      this.spbLoading.Name = "spbLoading";
      this.spbLoading.Size = new System.Drawing.Size(100, 16);
      this.spbLoading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
      // 
      // slblSelected
      // 
      this.slblSelected.Name = "slblSelected";
      this.slblSelected.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
      this.slblSelected.Size = new System.Drawing.Size(0, 17);
      // 
      // ilIcons
      // 
      this.ilIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilIcons.ImageStream")));
      this.ilIcons.TransparentColor = System.Drawing.Color.Transparent;
      this.ilIcons.Images.SetKeyName(0, "Namespace.png");
      this.ilIcons.Images.SetKeyName(1, "NoNamespace.png");
      this.ilIcons.Images.SetKeyName(2, "Class.png");
      this.ilIcons.Images.SetKeyName(3, "Event.png");
      this.ilIcons.Images.SetKeyName(4, "Field.png");
      this.ilIcons.Images.SetKeyName(5, "Method.png");
      this.ilIcons.Images.SetKeyName(6, "Property.png");
      this.ilIcons.Images.SetKeyName(7, "Assembly.png");
      this.ilIcons.Images.SetKeyName(8, "multiple.png");
      this.ilIcons.Images.SetKeyName(9, "pdb.png");
      // 
      // tsTools
      // 
      this.tsTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.btnCrashLogs,
            this.toolStripSeparator1,
            this.lblSearch,
            this.tbSearch});
      this.tsTools.Location = new System.Drawing.Point(0, 24);
      this.tsTools.Name = "tsTools";
      this.tsTools.Size = new System.Drawing.Size(727, 25);
      this.tsTools.TabIndex = 4;
      this.tsTools.Text = "toolStrip1";
      // 
      // btnOpen
      // 
      this.btnOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.miOpenBtn});
      this.btnOpen.Image = global::ObfuscarMappingParser.Properties.Resources.Open;
      this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnOpen.Name = "btnOpen";
      this.btnOpen.Size = new System.Drawing.Size(65, 22);
      this.btnOpen.Text = "Open";
      this.btnOpen.DropDownOpening += new System.EventHandler(this.btnOpen_DropDownOpening);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(128, 6);
      // 
      // miOpenBtn
      // 
      this.miOpenBtn.Image = global::ObfuscarMappingParser.Properties.Resources.Open;
      this.miOpenBtn.Name = "miOpenBtn";
      this.miOpenBtn.Size = new System.Drawing.Size(131, 22);
      this.miOpenBtn.Text = "Open file...";
      this.miOpenBtn.Click += new System.EventHandler(this.btnOpen_Click);
      // 
      // btnCrashLogs
      // 
      this.btnCrashLogs.Enabled = false;
      this.btnCrashLogs.Image = global::ObfuscarMappingParser.Properties.Resources.Stacktrace;
      this.btnCrashLogs.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnCrashLogs.Name = "btnCrashLogs";
      this.btnCrashLogs.Size = new System.Drawing.Size(81, 22);
      this.btnCrashLogs.Text = "Stacktrace";
      this.btnCrashLogs.ToolTipText = "Deobfuscate stacktrace";
      this.btnCrashLogs.Click += new System.EventHandler(this.btnCrashLogs_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // lblSearch
      // 
      this.lblSearch.Name = "lblSearch";
      this.lblSearch.Size = new System.Drawing.Size(78, 22);
      this.lblSearch.Text = "Quick search:";
      this.lblSearch.ToolTipText = "Type full name of entity end press <Enter> to search";
      // 
      // tbSearch
      // 
      this.tbSearch.Enabled = false;
      this.tbSearch.Name = "tbSearch";
      this.tbSearch.Size = new System.Drawing.Size(200, 25);
      this.tbSearch.ToolTipText = "Type full name of entity end press <Enter> to search";
      this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
      // 
      // menuStrip
      // 
      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmFile,
            this.miView,
            this.mmSearch,
            this.mmHelp});
      this.menuStrip.Location = new System.Drawing.Point(0, 0);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Size = new System.Drawing.Size(727, 24);
      this.menuStrip.TabIndex = 3;
      this.menuStrip.Text = "menuStrip1";
      // 
      // mmFile
      // 
      this.mmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpen,
            this.miRecents,
            this.toolStripSeparator6,
            this.miManagePDBs,
            this.miAttachPDB,
            this.toolStripSeparator2,
            this.miExit});
      this.mmFile.Name = "mmFile";
      this.mmFile.Size = new System.Drawing.Size(37, 20);
      this.mmFile.Text = "File";
      this.mmFile.DropDownOpening += new System.EventHandler(this.mmFile_DropDownOpening);
      // 
      // miOpen
      // 
      this.miOpen.Image = global::ObfuscarMappingParser.Properties.Resources.Open;
      this.miOpen.Name = "miOpen";
      this.miOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.miOpen.Size = new System.Drawing.Size(169, 22);
      this.miOpen.Text = "Open...";
      this.miOpen.Click += new System.EventHandler(this.btnOpen_Click);
      // 
      // miRecents
      // 
      this.miRecents.Name = "miRecents";
      this.miRecents.Size = new System.Drawing.Size(169, 22);
      this.miRecents.Text = "Recent";
      // 
      // toolStripSeparator6
      // 
      this.toolStripSeparator6.Name = "toolStripSeparator6";
      this.toolStripSeparator6.Size = new System.Drawing.Size(166, 6);
      // 
      // miManagePDBs
      // 
      this.miManagePDBs.Enabled = false;
      this.miManagePDBs.Name = "miManagePDBs";
      this.miManagePDBs.Size = new System.Drawing.Size(169, 22);
      this.miManagePDBs.Text = "Manage .PDB files";
      this.miManagePDBs.Click += new System.EventHandler(this.miManagePDBs_Click);
      // 
      // miAttachPDB
      // 
      this.miAttachPDB.Enabled = false;
      this.miAttachPDB.Name = "miAttachPDB";
      this.miAttachPDB.Size = new System.Drawing.Size(169, 22);
      this.miAttachPDB.Text = "Attach .PDB file...";
      this.miAttachPDB.Click += new System.EventHandler(this.miAttachPDB_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(166, 6);
      // 
      // miExit
      // 
      this.miExit.Name = "miExit";
      this.miExit.Size = new System.Drawing.Size(169, 22);
      this.miExit.Text = "Exit";
      this.miExit.Click += new System.EventHandler(this.miExit_Click);
      // 
      // miView
      // 
      this.miView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSortAscending,
            this.miSortDescending,
            this.miSortNewAscending,
            this.miSortNewDesc,
            this.toolStripSeparator4,
            this.miGroupNamespace,
            this.miShowModule,
            this.miGroupModules,
            this.miUseColumns,
            this.toolStripSeparator5,
            this.miStatistics,
            this.miSettings});
      this.miView.Name = "miView";
      this.miView.Size = new System.Drawing.Size(44, 20);
      this.miView.Text = "View";
      // 
      // miSortAscending
      // 
      this.miSortAscending.Image = global::ObfuscarMappingParser.Properties.Resources.SortAscending;
      this.miSortAscending.Name = "miSortAscending";
      this.miSortAscending.Size = new System.Drawing.Size(251, 22);
      this.miSortAscending.Text = "Sort by original name ascending";
      this.miSortAscending.Click += new System.EventHandler(this.miSorting_Click);
      // 
      // miSortDescending
      // 
      this.miSortDescending.Image = global::ObfuscarMappingParser.Properties.Resources.SortDescending;
      this.miSortDescending.Name = "miSortDescending";
      this.miSortDescending.Size = new System.Drawing.Size(251, 22);
      this.miSortDescending.Text = "Sort by original name descending";
      this.miSortDescending.Click += new System.EventHandler(this.miSorting_Click);
      // 
      // miSortNewAscending
      // 
      this.miSortNewAscending.Image = global::ObfuscarMappingParser.Properties.Resources.SortAscending;
      this.miSortNewAscending.Name = "miSortNewAscending";
      this.miSortNewAscending.Size = new System.Drawing.Size(251, 22);
      this.miSortNewAscending.Text = "Sort by new name ascending";
      this.miSortNewAscending.Click += new System.EventHandler(this.miSorting_Click);
      // 
      // miSortNewDesc
      // 
      this.miSortNewDesc.Image = global::ObfuscarMappingParser.Properties.Resources.SortDescending;
      this.miSortNewDesc.Name = "miSortNewDesc";
      this.miSortNewDesc.Size = new System.Drawing.Size(251, 22);
      this.miSortNewDesc.Text = "Sort by new name descending";
      this.miSortNewDesc.Click += new System.EventHandler(this.miSorting_Click);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(248, 6);
      // 
      // miGroupNamespace
      // 
      this.miGroupNamespace.Image = global::ObfuscarMappingParser.Properties.Resources.SortUsingNamespace;
      this.miGroupNamespace.Name = "miGroupNamespace";
      this.miGroupNamespace.Size = new System.Drawing.Size(251, 22);
      this.miGroupNamespace.Text = "Group by original namespace";
      this.miGroupNamespace.Click += new System.EventHandler(this.miGroupNamespace_Click);
      // 
      // miShowModule
      // 
      this.miShowModule.Image = global::ObfuscarMappingParser.Properties.Resources.AssemblyIcon;
      this.miShowModule.Name = "miShowModule";
      this.miShowModule.Size = new System.Drawing.Size(251, 22);
      this.miShowModule.Text = "Show module";
      this.miShowModule.Click += new System.EventHandler(this.miShowModule_Click);
      // 
      // miGroupModules
      // 
      this.miGroupModules.Image = global::ObfuscarMappingParser.Properties.Resources.AssemblyIcon;
      this.miGroupModules.Name = "miGroupModules";
      this.miGroupModules.Size = new System.Drawing.Size(251, 22);
      this.miGroupModules.Text = "Group by modules";
      this.miGroupModules.Click += new System.EventHandler(this.miGroupModules_Click);
      // 
      // miUseColumns
      // 
      this.miUseColumns.Image = global::ObfuscarMappingParser.Properties.Resources.Tree;
      this.miUseColumns.Name = "miUseColumns";
      this.miUseColumns.Size = new System.Drawing.Size(251, 22);
      this.miUseColumns.Text = "Use columns in tree";
      this.miUseColumns.Click += new System.EventHandler(this.miUseColumns_Click);
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(248, 6);
      // 
      // miStatistics
      // 
      this.miStatistics.Enabled = false;
      this.miStatistics.Name = "miStatistics";
      this.miStatistics.Size = new System.Drawing.Size(251, 22);
      this.miStatistics.Text = "Statistics";
      this.miStatistics.Click += new System.EventHandler(this.miStatistics_Click);
      // 
      // miSettings
      // 
      this.miSettings.Name = "miSettings";
      this.miSettings.Size = new System.Drawing.Size(251, 22);
      this.miSettings.Text = "Settings...";
      this.miSettings.Click += new System.EventHandler(this.miSettings_Click);
      // 
      // mmSearch
      // 
      this.mmSearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCrashlogs,
            this.miStacktrace,
            this.toolStripSeparator8,
            this.miSearch});
      this.mmSearch.Enabled = false;
      this.mmSearch.Name = "mmSearch";
      this.mmSearch.Size = new System.Drawing.Size(54, 20);
      this.mmSearch.Text = "Search";
      // 
      // miCrashlogs
      // 
      this.miCrashlogs.Image = global::ObfuscarMappingParser.Properties.Resources.Stacktrace;
      this.miCrashlogs.Name = "miCrashlogs";
      this.miCrashlogs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.miCrashlogs.Size = new System.Drawing.Size(245, 22);
      this.miCrashlogs.Text = "Deobfuscate stacktrace...";
      this.miCrashlogs.Click += new System.EventHandler(this.btnCrashLogs_Click);
      // 
      // miStacktrace
      // 
      this.miStacktrace.Image = global::ObfuscarMappingParser.Properties.Resources.Stacktrace2;
      this.miStacktrace.Name = "miStacktrace";
      this.miStacktrace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
      this.miStacktrace.Size = new System.Drawing.Size(245, 22);
      this.miStacktrace.Text = "Analyze stacktrace...";
      this.miStacktrace.Click += new System.EventHandler(this.miStacktrace_Click);
      // 
      // toolStripSeparator8
      // 
      this.toolStripSeparator8.Name = "toolStripSeparator8";
      this.toolStripSeparator8.Size = new System.Drawing.Size(242, 6);
      // 
      // miSearch
      // 
      this.miSearch.Image = global::ObfuscarMappingParser.Properties.Resources.Search;
      this.miSearch.Name = "miSearch";
      this.miSearch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
      this.miSearch.Size = new System.Drawing.Size(245, 22);
      this.miSearch.Text = "Search...";
      this.miSearch.Click += new System.EventHandler(this.miSearch_Click);
      // 
      // mmHelp
      // 
      this.mmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAbout});
      this.mmHelp.Name = "mmHelp";
      this.mmHelp.Size = new System.Drawing.Size(44, 20);
      this.mmHelp.Text = "Help";
      // 
      // miAbout
      // 
      this.miAbout.Name = "miAbout";
      this.miAbout.Size = new System.Drawing.Size(107, 22);
      this.miAbout.Text = "About";
      this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
      // 
      // contextMenuStrip
      // 
      this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCopyOldName,
            this.miCopyFullOldName,
            this.miCopyNewName,
            this.miCopyFullNewName,
            this.toolStripSeparator7,
            this.miOpenVS});
      this.contextMenuStrip.Name = "contextMenuStrip";
      this.contextMenuStrip.Size = new System.Drawing.Size(181, 120);
      this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
      // 
      // miCopyOldName
      // 
      this.miCopyOldName.Name = "miCopyOldName";
      this.miCopyOldName.Size = new System.Drawing.Size(180, 22);
      this.miCopyOldName.Text = "Copy old name";
      this.miCopyOldName.Click += new System.EventHandler(this.miCopyOldName_Click);
      // 
      // miCopyFullOldName
      // 
      this.miCopyFullOldName.Name = "miCopyFullOldName";
      this.miCopyFullOldName.Size = new System.Drawing.Size(180, 22);
      this.miCopyFullOldName.Text = "Copy full old name";
      this.miCopyFullOldName.Click += new System.EventHandler(this.miCopyFullOldName_Click);
      // 
      // miCopyNewName
      // 
      this.miCopyNewName.Name = "miCopyNewName";
      this.miCopyNewName.Size = new System.Drawing.Size(180, 22);
      this.miCopyNewName.Text = "Copy new name";
      this.miCopyNewName.Click += new System.EventHandler(this.miCopyNewName_Click);
      // 
      // miCopyFullNewName
      // 
      this.miCopyFullNewName.Name = "miCopyFullNewName";
      this.miCopyFullNewName.Size = new System.Drawing.Size(180, 22);
      this.miCopyFullNewName.Text = "Copy full new name";
      this.miCopyFullNewName.Click += new System.EventHandler(this.miCopyFullNewName_Click);
      // 
      // toolStripSeparator7
      // 
      this.toolStripSeparator7.Name = "toolStripSeparator7";
      this.toolStripSeparator7.Size = new System.Drawing.Size(177, 6);
      // 
      // miOpenVS
      // 
      this.miOpenVS.Image = global::ObfuscarMappingParser.Properties.Resources.Editor;
      this.miOpenVS.Name = "miOpenVS";
      this.miOpenVS.Size = new System.Drawing.Size(180, 22);
      this.miOpenVS.Text = "Open in editor";
      this.miOpenVS.Click += new System.EventHandler(this.miOpenVS_Click);
      // 
      // odPDB
      // 
      this.odPDB.DefaultExt = "pdb";
      this.odPDB.Filter = "Program database (*.pdb)|*.pdb";
      this.odPDB.Multiselect = true;
      // 
      // ptvElements
      // 
      this.ptvElements.AutoScroll = true;
      this.ptvElements.AutoScrollMinSize = new System.Drawing.Size(710, 0);
      this.ptvElements.AutoSizeColumns = true;
      this.ptvElements.CollapseImage = global::ObfuscarMappingParser.Properties.Resources.Collapse;
      this.ptvElements.ContextMenuStrip = this.contextMenuStrip;
      this.ptvElements.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ptvElements.ExpandImage = global::ObfuscarMappingParser.Properties.Resources.Expand;
      this.ptvElements.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
      this.ptvElements.FullRowSelect = true;
      this.ptvElements.ImageList = this.ilIcons;
      this.ptvElements.ItemHeight = 16;
      this.ptvElements.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(139)))));
      this.ptvElements.Location = new System.Drawing.Point(0, 49);
      this.ptvElements.Name = "ptvElements";
      this.ptvElements.SelectedNode = null;
      this.ptvElements.ShowToolTip = true;
      this.ptvElements.Size = new System.Drawing.Size(727, 479);
      this.ptvElements.TabIndex = 5;
      this.ptvElements.Text = "pineappleTreeView1";
      this.ptvElements.NodeSelect += new System.EventHandler<BrokenEvent.Shared.TreeView.NodeSelectEventArgs>(this.ptvElements_NodeSelect);
      this.ptvElements.DoubleClick += new System.EventHandler(this.ptvElements_DoubleClick);
      // 
      // odSourceFile
      // 
      this.odSourceFile.FileName = "openFileDialog1";
      // 
      // MainForm
      // 
      this.AllowDrop = true;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(727, 550);
      this.Controls.Add(this.ptvElements);
      this.Controls.Add(this.tsTools);
      this.Controls.Add(this.menuStrip);
      this.Controls.Add(this.statusStrip);
      this.Name = "MainForm";
      this.Text = "Obfuscar Mapping Parser";
      this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
      this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
      this.statusStrip.ResumeLayout(false);
      this.statusStrip.PerformLayout();
      this.tsTools.ResumeLayout(false);
      this.tsTools.PerformLayout();
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.contextMenuStrip.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.OpenFileDialog odMapping;
    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.ToolStripStatusLabel slblSelected;
    private System.Windows.Forms.ImageList ilIcons;
    private System.Windows.Forms.ToolStrip tsTools;
    private System.Windows.Forms.ToolStripButton btnCrashLogs;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripLabel lblSearch;
    private System.Windows.Forms.ToolStripTextBox tbSearch;
    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStripMenuItem mmFile;
    private System.Windows.Forms.ToolStripMenuItem miOpen;
    private System.Windows.Forms.ToolStripMenuItem miRecents;
    private System.Windows.Forms.ToolStripMenuItem miExit;
    private System.Windows.Forms.ToolStripMenuItem mmHelp;
    private System.Windows.Forms.ToolStripMenuItem miAbout;
    private BrokenEvent.Shared.TreeView.PineappleTreeView ptvElements;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripDropDownButton btnOpen;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem miOpenBtn;
    private System.Windows.Forms.ToolStripMenuItem mmSearch;
    private System.Windows.Forms.ToolStripMenuItem miCrashlogs;
    private System.Windows.Forms.ToolStripMenuItem miView;
    private System.Windows.Forms.ToolStripMenuItem miSortAscending;
    private System.Windows.Forms.ToolStripMenuItem miSortDescending;
    private System.Windows.Forms.ToolStripMenuItem miSortNewAscending;
    private System.Windows.Forms.ToolStripMenuItem miSortNewDesc;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripMenuItem miGroupNamespace;
    private System.Windows.Forms.ToolStripMenuItem miShowModule;
    private System.Windows.Forms.ToolStripProgressBar spbLoading;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripMenuItem miStatistics;
    private System.Windows.Forms.ToolStripMenuItem miGroupModules;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
    private System.Windows.Forms.ToolStripMenuItem miCopyOldName;
    private System.Windows.Forms.ToolStripMenuItem miCopyFullOldName;
    private System.Windows.Forms.ToolStripMenuItem miOpenVS;
    private System.Windows.Forms.ToolStripMenuItem miCopyNewName;
    private System.Windows.Forms.ToolStripMenuItem miCopyFullNewName;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    private System.Windows.Forms.ToolStripMenuItem miAttachPDB;
    private System.Windows.Forms.OpenFileDialog odPDB;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    private System.Windows.Forms.ToolStripMenuItem miSettings;
    private System.Windows.Forms.ToolStripMenuItem miSearch;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
    private System.Windows.Forms.ToolStripMenuItem miStacktrace;
    private System.Windows.Forms.ToolStripMenuItem miUseColumns;
    private System.Windows.Forms.OpenFileDialog odSourceFile;
    private System.Windows.Forms.ToolStripMenuItem miManagePDBs;
  }
}

