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

        private string _path;

        private void Render()
        {
            if (_path != null)
            {
                
            }
        }

        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            var dialogResult = folderBrowserDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Render();
                _path = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
