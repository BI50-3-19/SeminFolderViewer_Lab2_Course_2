
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
            this.directoryBackwardButton = new System.Windows.Forms.Button();
            this.directoryForwardButton = new System.Windows.Forms.Button();
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
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderButton_Click);
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 92);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(776, 502);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_ItemSelectionChanged);
            // 
            // pathBox
            // 
            this.pathBox.Enabled = false;
            this.pathBox.Location = new System.Drawing.Point(12, 23);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(659, 20);
            this.pathBox.TabIndex = 3;
            // 
            // directoryBackwardButton
            // 
            this.directoryBackwardButton.Enabled = false;
            this.directoryBackwardButton.Location = new System.Drawing.Point(12, 54);
            this.directoryBackwardButton.Name = "directoryBackwardButton";
            this.directoryBackwardButton.Size = new System.Drawing.Size(44, 29);
            this.directoryBackwardButton.TabIndex = 4;
            this.directoryBackwardButton.Text = "<";
            this.directoryBackwardButton.UseVisualStyleBackColor = true;
            this.directoryBackwardButton.Click += new System.EventHandler(this.directoryBackwardButton_Click);
            // 
            // directoryForwardButton
            // 
            this.directoryForwardButton.Enabled = false;
            this.directoryForwardButton.Location = new System.Drawing.Point(62, 54);
            this.directoryForwardButton.Name = "directoryForwardButton";
            this.directoryForwardButton.Size = new System.Drawing.Size(44, 29);
            this.directoryForwardButton.TabIndex = 5;
            this.directoryForwardButton.Text = ">";
            this.directoryForwardButton.UseVisualStyleBackColor = true;
            this.directoryForwardButton.Click += new System.EventHandler(this.directoryForwardButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 606);
            this.Controls.Add(this.directoryForwardButton);
            this.Controls.Add(this.directoryBackwardButton);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.selectFolderButton);
            this.Name = "MainForm";
            this.Text = "FolderViewer";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button directoryBackwardButton;
        private System.Windows.Forms.Button directoryForwardButton;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.TextBox pathBox;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.ListView listView;

        #endregion

        private System.Windows.Forms.Button selectFolderButton;
    }
}

