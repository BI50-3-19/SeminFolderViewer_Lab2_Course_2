
namespace FolderViewer
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.Location = new System.Drawing.Point(690, 12);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(103, 41);
            this.selectFolderButton.TabIndex = 1;
            this.selectFolderButton.Text = "Выберите папку";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.SelectFolderButton_Click);
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 59);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(776, 535);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListView_ItemSelectionChanged);
            // 
            // pathBox
            // 
            this.pathBox.Enabled = false;
            this.pathBox.Location = new System.Drawing.Point(12, 23);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(659, 20);
            this.pathBox.TabIndex = 3;
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(827, 59);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(331, 534);
            this.treeView.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 609);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.selectFolderButton);
            this.Name = "MainForm";
            this.Text = "FolderViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.TextBox pathBox;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.ListView listView;

        #endregion

        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.TreeView treeView;
    }
}

