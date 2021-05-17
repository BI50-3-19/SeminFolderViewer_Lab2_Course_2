using System;
using System.Windows.Forms;

namespace FolderViewer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string path;

        private void render()
        {
            if (path != null)
            {
                
            }
        }

        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            var dialogResult = folderBrowserDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                render();
                path = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
