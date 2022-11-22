using System.Diagnostics;

namespace FileExplorer
{
    public partial class FileExplorer : Form
    {
        public FileExplorer()
        {
            InitializeComponent();
        }

        private void FileExplorer_Load(object sender, EventArgs e)
        {
            string[] drives = Environment.GetLogicalDrives();

            foreach (string drive in drives)
            {
                DriveInfo di = new DriveInfo(drive);

                TreeNode node = new TreeNode(drive.Substring(0, 1));
                node.Tag = drive;

                if (di.IsReady == true)
                    node.Nodes.Add("...");
                this.treeView.Nodes.Add(node);
            }

            foreach (string drive in drives)
            {
                DriveInfo di = new DriveInfo(drive);
                ListViewItem item = new ListViewItem(drive);
                item.Tag = drive;
                item.SubItems.Add("Drive");
                item.SubItems.Add(di.TotalSize.ToString() + " bytes");
                item.SubItems.Add(Directory.GetCreationTime(drive).ToString());
                item.SubItems.Add(Directory.GetLastWriteTime(drive).ToString());
                listView.Items.Add(item);
            }
        }

        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count > 0)
            {
                if (e.Node.Nodes[0].Text == "..." && e.Node.Nodes[0].Tag == null)
                {
                    treeViewRefresh(e.Node);
                }
            }
        }

        private void listView_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem selected_item = listView.SelectedItems[0];
            FileAttributes attr = File.GetAttributes(selected_item.Tag.ToString());
            if (attr.HasFlag(FileAttributes.Directory))
            {
                listViewRefresh(selected_item.Tag.ToString());
            }
            else
            {
                Process p = new Process();
                p.StartInfo = new ProcessStartInfo(selected_item.Tag.ToString())
                {
                    UseShellExecute = true
                };
                p.Start();
            }
        }

        private void treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var selected_item = e.Node;
            listViewRefresh(selected_item.Tag.ToString());
        }

        private void TsUp_Click(object sender, EventArgs e)
        {
            TreeNode selected_node = treeView.SelectedNode.Parent;
            if (selected_node != null)
            {
                selected_node.Collapse();
            }
            DirectoryInfo selected_dir = listView.SelectedItems[0].Tag as DirectoryInfo;
            if (selected_dir.Parent != null)
            {
                listViewRefresh(selected_dir.Parent.ToString());
            }
        }
        private void listViewRefresh(string path)
        {
            listView.Items.Clear();
            string[] dirs = Directory.GetDirectories(path);
            foreach (string dir in dirs)
            {
                DirectoryInfo di = new DirectoryInfo(dir);
                if (!di.Attributes.HasFlag(FileAttributes.Hidden))
                {
                    ListViewItem item = new ListViewItem(Path.GetFileName(dir));
                    item.Tag = dir;
                    item.SubItems.Add("Folder");
                    item.SubItems.Add("");
                    item.SubItems.Add(Directory.GetCreationTime(dir).ToString());
                    item.SubItems.Add(Directory.GetLastWriteTime(dir).ToString());
                    listView.Items.Add(item);
                }
            }
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                FileInfo fi = new FileInfo(file);
                if (!fi.Attributes.HasFlag(FileAttributes.Hidden))
                {
                    ListViewItem item = new ListViewItem(Path.GetFileName(file));
                    item.Tag = file;
                    item.SubItems.Add(Path.GetExtension(file));
                    item.SubItems.Add(file.Length.ToString());
                    item.SubItems.Add(Directory.GetCreationTime(file).ToString());
                    item.SubItems.Add(Directory.GetLastWriteTime(file).ToString());
                    listView.Items.Add(item);
                }
            }
        }
        private void treeViewRefresh(TreeNode this_node)
        {
            this_node.Nodes.Clear();

            string[] dirs = Directory.GetDirectories(this_node.Tag.ToString());

            foreach (string dir in dirs)
            {
                DirectoryInfo di = new DirectoryInfo(dir);
                if (!di.Attributes.HasFlag(FileAttributes.Hidden))
                {
                    TreeNode node = new TreeNode(di.Name, 0, 1);
                    try
                    {
                        node.Tag = dir;
                        if (di.GetDirectories().Count() > 0)
                            node.Nodes.Add(null, "...", 0, 0);
                    }
                    catch (UnauthorizedAccessException)
                    {
                        node.ImageIndex = 12;
                        node.SelectedImageIndex = 12;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "DirectoryLister",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        this_node.Nodes.Add(node);
                    }
                }
            }
        }
    }
}