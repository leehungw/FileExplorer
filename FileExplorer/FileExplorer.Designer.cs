namespace FileExplorer
{
    partial class FileExplorer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileExplorer));
            this.MenuScripts = new System.Windows.Forms.MenuStrip();
            this.MScrFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MScrRename_File = new System.Windows.Forms.ToolStripMenuItem();
            this.MScrDelete_File = new System.Windows.Forms.ToolStripMenuItem();
            this.MScr_Seperator_FIle = new System.Windows.Forms.ToolStripSeparator();
            this.MScrExit_File = new System.Windows.Forms.ToolStripMenuItem();
            this.MScrEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MScrCopy_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.MScrCut_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.MScrPaste_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.MScrViews = new System.Windows.Forms.ToolStripMenuItem();
            this.MScrLargeIC_Views = new System.Windows.Forms.ToolStripMenuItem();
            this.MScrSmallIC_Views = new System.Windows.Forms.ToolStripMenuItem();
            this.MScrList_Views = new System.Windows.Forms.ToolStripMenuItem();
            this.MScrDetails_Views = new System.Windows.Forms.ToolStripMenuItem();
            this.MScrHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MScrAbout_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.TsUp = new System.Windows.Forms.ToolStripButton();
            this.TsRefresh = new System.Windows.Forms.ToolStripButton();
            this.TsCopy = new System.Windows.Forms.ToolStripButton();
            this.TsCut = new System.Windows.Forms.ToolStripButton();
            this.TsPaste = new System.Windows.Forms.ToolStripButton();
            this.TsDelete = new System.Windows.Forms.ToolStripButton();
            this.TsViews = new System.Windows.Forms.ToolStripDropDownButton();
            this.TsLargeIcon_Views = new System.Windows.Forms.ToolStripMenuItem();
            this.TsSmallIcon_Views = new System.Windows.Forms.ToolStripMenuItem();
            this.TsList_Views = new System.Windows.Forms.ToolStripMenuItem();
            this.TsDetails_Views = new System.Windows.Forms.ToolStripMenuItem();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.treeView = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.SplitterTreeView = new System.Windows.Forms.Splitter();
            this.listView = new System.Windows.Forms.ListView();
            this.CHeaderName = new System.Windows.Forms.ColumnHeader();
            this.CHeaderType = new System.Windows.Forms.ColumnHeader();
            this.CHeaderSize = new System.Windows.Forms.ColumnHeader();
            this.CHeaderCreatedDate = new System.Windows.Forms.ColumnHeader();
            this.CHeaderModifiedDate = new System.Windows.Forms.ColumnHeader();
            this.SpliterListView = new System.Windows.Forms.Splitter();
            this.MenuScripts.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuScripts
            // 
            this.MenuScripts.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuScripts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MScrFile,
            this.MScrEdit,
            this.MScrViews,
            this.MScrHelp});
            this.MenuScripts.Location = new System.Drawing.Point(0, 0);
            this.MenuScripts.Name = "MenuScripts";
            this.MenuScripts.Size = new System.Drawing.Size(800, 28);
            this.MenuScripts.TabIndex = 0;
            this.MenuScripts.Text = "MenuScript";
            // 
            // MScrFile
            // 
            this.MScrFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MScrRename_File,
            this.MScrDelete_File,
            this.MScr_Seperator_FIle,
            this.MScrExit_File});
            this.MScrFile.Name = "MScrFile";
            this.MScrFile.Size = new System.Drawing.Size(46, 24);
            this.MScrFile.Text = "File";
            // 
            // MScrRename_File
            // 
            this.MScrRename_File.Name = "MScrRename_File";
            this.MScrRename_File.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.MScrRename_File.Size = new System.Drawing.Size(224, 26);
            this.MScrRename_File.Text = "Rename";
            // 
            // MScrDelete_File
            // 
            this.MScrDelete_File.Name = "MScrDelete_File";
            this.MScrDelete_File.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.MScrDelete_File.Size = new System.Drawing.Size(224, 26);
            this.MScrDelete_File.Text = "Delete";
            // 
            // MScr_Seperator_FIle
            // 
            this.MScr_Seperator_FIle.Name = "MScr_Seperator_FIle";
            this.MScr_Seperator_FIle.Size = new System.Drawing.Size(221, 6);
            // 
            // MScrExit_File
            // 
            this.MScrExit_File.Name = "MScrExit_File";
            this.MScrExit_File.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.MScrExit_File.Size = new System.Drawing.Size(224, 26);
            this.MScrExit_File.Text = "Exit";
            // 
            // MScrEdit
            // 
            this.MScrEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MScrCopy_Edit,
            this.MScrCut_Edit,
            this.MScrPaste_Edit});
            this.MScrEdit.Name = "MScrEdit";
            this.MScrEdit.Size = new System.Drawing.Size(49, 24);
            this.MScrEdit.Text = "Edit";
            // 
            // MScrCopy_Edit
            // 
            this.MScrCopy_Edit.Name = "MScrCopy_Edit";
            this.MScrCopy_Edit.Size = new System.Drawing.Size(224, 26);
            this.MScrCopy_Edit.Text = "Copy";
            // 
            // MScrCut_Edit
            // 
            this.MScrCut_Edit.Name = "MScrCut_Edit";
            this.MScrCut_Edit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.MScrCut_Edit.Size = new System.Drawing.Size(224, 26);
            this.MScrCut_Edit.Text = "Cut";
            // 
            // MScrPaste_Edit
            // 
            this.MScrPaste_Edit.Name = "MScrPaste_Edit";
            this.MScrPaste_Edit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.MScrPaste_Edit.Size = new System.Drawing.Size(224, 26);
            this.MScrPaste_Edit.Text = "Paste";
            // 
            // MScrViews
            // 
            this.MScrViews.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MScrLargeIC_Views,
            this.MScrSmallIC_Views,
            this.MScrList_Views,
            this.MScrDetails_Views});
            this.MScrViews.Name = "MScrViews";
            this.MScrViews.Size = new System.Drawing.Size(61, 24);
            this.MScrViews.Text = "Views";
            // 
            // MScrLargeIC_Views
            // 
            this.MScrLargeIC_Views.Name = "MScrLargeIC_Views";
            this.MScrLargeIC_Views.Size = new System.Drawing.Size(224, 26);
            this.MScrLargeIC_Views.Text = "Large icon";
            // 
            // MScrSmallIC_Views
            // 
            this.MScrSmallIC_Views.Name = "MScrSmallIC_Views";
            this.MScrSmallIC_Views.Size = new System.Drawing.Size(224, 26);
            this.MScrSmallIC_Views.Text = "Small icon";
            // 
            // MScrList_Views
            // 
            this.MScrList_Views.Name = "MScrList_Views";
            this.MScrList_Views.Size = new System.Drawing.Size(224, 26);
            this.MScrList_Views.Text = "List";
            // 
            // MScrDetails_Views
            // 
            this.MScrDetails_Views.Name = "MScrDetails_Views";
            this.MScrDetails_Views.Size = new System.Drawing.Size(224, 26);
            this.MScrDetails_Views.Text = "Details";
            // 
            // MScrHelp
            // 
            this.MScrHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MScrAbout_Help});
            this.MScrHelp.Name = "MScrHelp";
            this.MScrHelp.Size = new System.Drawing.Size(55, 24);
            this.MScrHelp.Text = "Help";
            // 
            // MScrAbout_Help
            // 
            this.MScrAbout_Help.Name = "MScrAbout_Help";
            this.MScrAbout_Help.Size = new System.Drawing.Size(224, 26);
            this.MScrAbout_Help.Text = "About";
            // 
            // ToolStrip
            // 
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsUp,
            this.TsRefresh,
            this.TsCopy,
            this.TsCut,
            this.TsPaste,
            this.TsDelete,
            this.TsViews});
            this.ToolStrip.Location = new System.Drawing.Point(0, 28);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(800, 27);
            this.ToolStrip.TabIndex = 1;
            this.ToolStrip.Text = "ToolStrip";
            // 
            // TsUp
            // 
            this.TsUp.Image = ((System.Drawing.Image)(resources.GetObject("TsUp.Image")));
            this.TsUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsUp.Name = "TsUp";
            this.TsUp.Size = new System.Drawing.Size(52, 24);
            this.TsUp.Text = "Up";
            this.TsUp.Click += new System.EventHandler(this.TsUp_Click);
            // 
            // TsRefresh
            // 
            this.TsRefresh.Image = ((System.Drawing.Image)(resources.GetObject("TsRefresh.Image")));
            this.TsRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsRefresh.Name = "TsRefresh";
            this.TsRefresh.Size = new System.Drawing.Size(82, 24);
            this.TsRefresh.Text = "Refresh";
            // 
            // TsCopy
            // 
            this.TsCopy.Image = ((System.Drawing.Image)(resources.GetObject("TsCopy.Image")));
            this.TsCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsCopy.Name = "TsCopy";
            this.TsCopy.Size = new System.Drawing.Size(67, 24);
            this.TsCopy.Text = "Copy";
            // 
            // TsCut
            // 
            this.TsCut.Image = ((System.Drawing.Image)(resources.GetObject("TsCut.Image")));
            this.TsCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsCut.Name = "TsCut";
            this.TsCut.Size = new System.Drawing.Size(55, 24);
            this.TsCut.Text = "Cut";
            // 
            // TsPaste
            // 
            this.TsPaste.Image = ((System.Drawing.Image)(resources.GetObject("TsPaste.Image")));
            this.TsPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsPaste.Name = "TsPaste";
            this.TsPaste.Size = new System.Drawing.Size(67, 24);
            this.TsPaste.Text = "Paste";
            // 
            // TsDelete
            // 
            this.TsDelete.Image = ((System.Drawing.Image)(resources.GetObject("TsDelete.Image")));
            this.TsDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsDelete.Name = "TsDelete";
            this.TsDelete.Size = new System.Drawing.Size(77, 24);
            this.TsDelete.Text = "Delete";
            // 
            // TsViews
            // 
            this.TsViews.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsLargeIcon_Views,
            this.TsSmallIcon_Views,
            this.TsList_Views,
            this.TsDetails_Views});
            this.TsViews.Image = ((System.Drawing.Image)(resources.GetObject("TsViews.Image")));
            this.TsViews.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsViews.Name = "TsViews";
            this.TsViews.Size = new System.Drawing.Size(81, 24);
            this.TsViews.Text = "Views";
            // 
            // TsLargeIcon_Views
            // 
            this.TsLargeIcon_Views.Name = "TsLargeIcon_Views";
            this.TsLargeIcon_Views.Size = new System.Drawing.Size(224, 26);
            this.TsLargeIcon_Views.Text = "Large icon";
            // 
            // TsSmallIcon_Views
            // 
            this.TsSmallIcon_Views.Name = "TsSmallIcon_Views";
            this.TsSmallIcon_Views.Size = new System.Drawing.Size(224, 26);
            this.TsSmallIcon_Views.Text = "Small icon";
            // 
            // TsList_Views
            // 
            this.TsList_Views.Name = "TsList_Views";
            this.TsList_Views.Size = new System.Drawing.Size(224, 26);
            this.TsList_Views.Text = "List";
            // 
            // TsDetails_Views
            // 
            this.TsDetails_Views.Name = "TsDetails_Views";
            this.TsDetails_Views.Size = new System.Drawing.Size(224, 26);
            this.TsDetails_Views.Text = "Details";
            // 
            // SplitContainer
            // 
            this.SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.Location = new System.Drawing.Point(0, 55);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.treeView);
            this.SplitContainer.Panel1.Controls.Add(this.SplitterTreeView);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.listView);
            this.SplitContainer.Panel2.Controls.Add(this.SpliterListView);
            this.SplitContainer.Size = new System.Drawing.Size(800, 395);
            this.SplitContainer.SplitterDistance = 266;
            this.SplitContainer.TabIndex = 2;
            // 
            // treeView
            // 
            this.treeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imageList;
            this.treeView.Location = new System.Drawing.Point(4, 0);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageIndex = 0;
            this.treeView.Size = new System.Drawing.Size(260, 393);
            this.treeView.TabIndex = 1;
            this.treeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView_BeforeExpand);
            this.treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseDoubleClick);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "folder_icon.png");
            // 
            // SplitterTreeView
            // 
            this.SplitterTreeView.Location = new System.Drawing.Point(0, 0);
            this.SplitterTreeView.Name = "SplitterTreeView";
            this.SplitterTreeView.Size = new System.Drawing.Size(4, 393);
            this.SplitterTreeView.TabIndex = 0;
            this.SplitterTreeView.TabStop = false;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CHeaderName,
            this.CHeaderType,
            this.CHeaderSize,
            this.CHeaderCreatedDate,
            this.CHeaderModifiedDate});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.Location = new System.Drawing.Point(4, 0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(524, 393);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.ItemActivate += new System.EventHandler(this.listView_ItemActivate);
            // 
            // CHeaderName
            // 
            this.CHeaderName.Text = "Name";
            this.CHeaderName.Width = 150;
            // 
            // CHeaderType
            // 
            this.CHeaderType.Text = "Type";
            // 
            // CHeaderSize
            // 
            this.CHeaderSize.Text = "Size";
            // 
            // CHeaderCreatedDate
            // 
            this.CHeaderCreatedDate.Text = "Created Date";
            this.CHeaderCreatedDate.Width = 120;
            // 
            // CHeaderModifiedDate
            // 
            this.CHeaderModifiedDate.Text = "Modified Date";
            this.CHeaderModifiedDate.Width = 120;
            // 
            // SpliterListView
            // 
            this.SpliterListView.Location = new System.Drawing.Point(0, 0);
            this.SpliterListView.Name = "SpliterListView";
            this.SpliterListView.Size = new System.Drawing.Size(4, 393);
            this.SpliterListView.TabIndex = 0;
            this.SpliterListView.TabStop = false;
            // 
            // FileExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SplitContainer);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.MenuScripts);
            this.MainMenuStrip = this.MenuScripts;
            this.Name = "FileExplorer";
            this.Text = "FileExplorer";
            this.Load += new System.EventHandler(this.FileExplorer_Load);
            this.MenuScripts.ResumeLayout(false);
            this.MenuScripts.PerformLayout();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip MenuScripts;
        private ToolStripMenuItem MScrFile;
        private ToolStripMenuItem MScrEdit;
        private ToolStripMenuItem MScrViews;
        private ToolStripMenuItem MScrHelp;
        private ToolStripMenuItem MScrRename_File;
        private ToolStripMenuItem MScrDelete_File;
        private ToolStripMenuItem MScrCopy_Edit;
        private ToolStripMenuItem MScrCut_Edit;
        private ToolStripMenuItem MScrPaste_Edit;
        private ToolStripMenuItem MScrLargeIC_Views;
        private ToolStripSeparator MScr_Seperator_FIle;
        private ToolStripMenuItem MScrExit_File;
        private ToolStripMenuItem MScrSmallIC_Views;
        private ToolStripMenuItem MScrList_Views;
        private ToolStripMenuItem MScrDetails_Views;
        private ToolStripMenuItem MScrAbout_Help;
        private ToolStrip ToolStrip;
        private ToolStripButton TsUp;
        private ToolStripButton TsRefresh;
        private ToolStripButton TsCopy;
        private ToolStripButton TsCut;
        private ToolStripButton TsPaste;
        private ToolStripButton TsDelete;
        private ToolStripDropDownButton TsViews;
        private ToolStripMenuItem TsLargeIcon_Views;
        private ToolStripMenuItem TsSmallIcon_Views;
        private ToolStripMenuItem TsList_Views;
        private ToolStripMenuItem TsDetails_Views;
        private SplitContainer SplitContainer;
        private Splitter SpliterListView;
        private Splitter SplitterTreeView;
        private TreeView treeView;
        private ListView listView;
        private ColumnHeader CHeaderName;
        private ColumnHeader CHeaderType;
        private ColumnHeader CHeaderSize;
        private ColumnHeader CHeaderCreatedDate;
        private ColumnHeader CHeaderModifiedDate;
        private ImageList imageList;
    }
}