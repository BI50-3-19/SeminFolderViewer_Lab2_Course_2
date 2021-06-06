using System;
using System.IO;
using System.Windows.Forms;

namespace FolderViewer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            var imagesList = new ImageList() { };
            imagesList.Images.Add("file", Properties.Resources.file);
            imagesList.Images.Add("folder", Properties.Resources.folder);

            listView.LargeImageList = imagesList;

            listView.Groups.Add("files", "Files");
            listView.Groups.Add("directories", "Folders");
        }

        private string _path;

        private void Render()
        {
            if (_path != null)
            {
                listView.Clear();
                pathBox.Text = _path.Replace("\\", "/");

                var dirFiles = Directory.GetFiles(_path);
                var dirCatalogs = Directory.GetDirectories(_path);
                
                foreach (var file in dirFiles)
                {
                    var correctElementPath = file.Remove(0, file.LastIndexOf('\\') + 1);

                    var elementViewItem = new ListViewItem()
                    {
                        Text = correctElementPath,
                        ImageKey = "file",
                        Group = listView.Groups[0]
                    };

                    listView.Items.Add(elementViewItem);
                }
                
                foreach (var directory in dirCatalogs)
                {
                    var correctElementPath = directory.Remove(0, directory.LastIndexOf('\\') + 1);

                    var elementViewItem = new ListViewItem()
                    {
                        Text = correctElementPath,
                        ImageKey = "folder",
                        Group = listView.Groups[1]
                    };

                    listView.Items.Add(elementViewItem);
                }
            }
        }

        private void SelectFolderButton_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            var dialogResult = folderBrowserDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                // _history.Clear();
                _path = folderBrowserDialog.SelectedPath;
                Render();
            }
        }
        
        private void ListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.Item.ImageKey == "folder")
            {
                _path += $"\\{e.Item.Text}";
                /*
                if (directoryBackwardButton.Enabled == false && _history.IndexOf(_path) == 0)
                {
                    _history.Clear();
                }
                */
                Render();
            }
        }
    }
}
