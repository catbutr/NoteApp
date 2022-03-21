
namespace NoteApp.View
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("1\\n");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("2");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("3");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("4");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("5");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("6");
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("7");
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("8");
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.editNotePicturebox = new System.Windows.Forms.PictureBox();
            this.newNotePicturebox = new System.Windows.Forms.PictureBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.showCategoryLabel = new System.Windows.Forms.Label();
            this.noteListView = new System.Windows.Forms.ListView();
            this.noteRichTextbox = new System.Windows.Forms.RichTextBox();
            this.dateTimePickerUpdated = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCreated = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.CategoryCreatedLabel = new System.Windows.Forms.Label();
            this.CategoryNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutStripItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editNotePicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newNotePicturebox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.editNotePicturebox);
            this.splitContainer1.Panel1.Controls.Add(this.newNotePicturebox);
            this.splitContainer1.Panel1.Controls.Add(this.categoryComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.showCategoryLabel);
            this.splitContainer1.Panel1.Controls.Add(this.noteListView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.noteRichTextbox);
            this.splitContainer1.Panel2.Controls.Add(this.dateTimePickerUpdated);
            this.splitContainer1.Panel2.Controls.Add(this.dateTimePickerCreated);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.CategoryCreatedLabel);
            this.splitContainer1.Panel2.Controls.Add(this.CategoryNameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.TitleLabel);
            this.splitContainer1.Size = new System.Drawing.Size(953, 640);
            this.splitContainer1.SplitterDistance = 317;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "E:\\NoteApp\\src\\NoteApp\\NoteApp.View\\Delete.png";
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(88, 602);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 26);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // editNotePicturebox
            // 
            this.editNotePicturebox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editNotePicturebox.Image = ((System.Drawing.Image)(resources.GetObject("editNotePicturebox.Image")));
            this.editNotePicturebox.ImageLocation = "E:\\NoteApp\\src\\NoteApp\\NoteApp.View\\Edit.png";
            this.editNotePicturebox.InitialImage = null;
            this.editNotePicturebox.Location = new System.Drawing.Point(52, 602);
            this.editNotePicturebox.Name = "editNotePicturebox";
            this.editNotePicturebox.Size = new System.Drawing.Size(30, 26);
            this.editNotePicturebox.TabIndex = 11;
            this.editNotePicturebox.TabStop = false;
            // 
            // newNotePicturebox
            // 
            this.newNotePicturebox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newNotePicturebox.ImageLocation = "E:\\NoteApp\\src\\NoteApp\\NoteApp.View\\Add.png";
            this.newNotePicturebox.InitialImage = null;
            this.newNotePicturebox.Location = new System.Drawing.Point(16, 602);
            this.newNotePicturebox.Name = "newNotePicturebox";
            this.newNotePicturebox.Size = new System.Drawing.Size(30, 26);
            this.newNotePicturebox.TabIndex = 8;
            this.newNotePicturebox.TabStop = false;
            this.newNotePicturebox.Click += new System.EventHandler(this.newNotePicturebox_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(107, 18);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryComboBox.TabIndex = 10;
            // 
            // showCategoryLabel
            // 
            this.showCategoryLabel.AutoSize = true;
            this.showCategoryLabel.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.showCategoryLabel.Location = new System.Drawing.Point(12, 20);
            this.showCategoryLabel.Name = "showCategoryLabel";
            this.showCategoryLabel.Size = new System.Drawing.Size(89, 19);
            this.showCategoryLabel.TabIndex = 9;
            this.showCategoryLabel.Text = "Категория:";
            // 
            // noteListView
            // 
            this.noteListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.noteListView.Font = new System.Drawing.Font("Bahnschrift", 18F);
            this.noteListView.HideSelection = false;
            this.noteListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17,
            listViewItem18});
            this.noteListView.Location = new System.Drawing.Point(3, 48);
            this.noteListView.Name = "noteListView";
            this.noteListView.Size = new System.Drawing.Size(311, 491);
            this.noteListView.TabIndex = 8;
            this.noteListView.UseCompatibleStateImageBehavior = false;
            this.noteListView.View = System.Windows.Forms.View.List;
            // 
            // noteRichTextbox
            // 
            this.noteRichTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteRichTextbox.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noteRichTextbox.Location = new System.Drawing.Point(23, 117);
            this.noteRichTextbox.Name = "noteRichTextbox";
            this.noteRichTextbox.ReadOnly = true;
            this.noteRichTextbox.Size = new System.Drawing.Size(597, 511);
            this.noteRichTextbox.TabIndex = 7;
            this.noteRichTextbox.Text = resources.GetString("noteRichTextbox.Text");
            // 
            // dateTimePickerUpdated
            // 
            this.dateTimePickerUpdated.Enabled = false;
            this.dateTimePickerUpdated.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dateTimePickerUpdated.Location = new System.Drawing.Point(336, 91);
            this.dateTimePickerUpdated.Name = "dateTimePickerUpdated";
            this.dateTimePickerUpdated.Size = new System.Drawing.Size(129, 20);
            this.dateTimePickerUpdated.TabIndex = 6;
            // 
            // dateTimePickerCreated
            // 
            this.dateTimePickerCreated.Enabled = false;
            this.dateTimePickerCreated.Location = new System.Drawing.Point(100, 91);
            this.dateTimePickerCreated.Name = "dateTimePickerCreated";
            this.dateTimePickerCreated.Size = new System.Drawing.Size(129, 20);
            this.dateTimePickerCreated.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.label2.Location = new System.Drawing.Point(235, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Обновлена:";
            // 
            // CategoryCreatedLabel
            // 
            this.CategoryCreatedLabel.AutoSize = true;
            this.CategoryCreatedLabel.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.CategoryCreatedLabel.Location = new System.Drawing.Point(19, 92);
            this.CategoryCreatedLabel.Name = "CategoryCreatedLabel";
            this.CategoryCreatedLabel.Size = new System.Drawing.Size(77, 19);
            this.CategoryCreatedLabel.TabIndex = 3;
            this.CategoryCreatedLabel.Text = "Создана:";
            // 
            // CategoryNameLabel
            // 
            this.CategoryNameLabel.AutoSize = true;
            this.CategoryNameLabel.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.CategoryNameLabel.Location = new System.Drawing.Point(114, 56);
            this.CategoryNameLabel.Name = "CategoryNameLabel";
            this.CategoryNameLabel.Size = new System.Drawing.Size(116, 19);
            this.CategoryNameLabel.TabIndex = 2;
            this.CategoryNameLabel.Text = "categoryName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.label1.Location = new System.Drawing.Point(19, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Категория:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Bahnschrift", 18F);
            this.TitleLabel.Location = new System.Drawing.Point(18, 20);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(215, 29);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Название заметки";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(953, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddStripItem,
            this.EditStripItem,
            this.RemoveStripItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutStripItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // ExitItem
            // 
            this.ExitItem.Name = "ExitItem";
            this.ExitItem.Size = new System.Drawing.Size(180, 22);
            this.ExitItem.Text = "Exit";
            // 
            // AddStripItem
            // 
            this.AddStripItem.Name = "AddStripItem";
            this.AddStripItem.Size = new System.Drawing.Size(180, 22);
            this.AddStripItem.Text = "Add Note";
            this.AddStripItem.Click += new System.EventHandler(this.AddStripItem_Click);
            // 
            // EditStripItem
            // 
            this.EditStripItem.Name = "EditStripItem";
            this.EditStripItem.Size = new System.Drawing.Size(180, 22);
            this.EditStripItem.Text = "Edit Note";
            // 
            // RemoveStripItem
            // 
            this.RemoveStripItem.Name = "RemoveStripItem";
            this.RemoveStripItem.Size = new System.Drawing.Size(180, 22);
            this.RemoveStripItem.Text = "Remove Note";
            // 
            // AboutStripItem
            // 
            this.AboutStripItem.Name = "AboutStripItem";
            this.AboutStripItem.Size = new System.Drawing.Size(180, 22);
            this.AboutStripItem.Text = "About";
            this.AboutStripItem.Click += new System.EventHandler(this.AboutStripItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 664);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editNotePicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newNotePicturebox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker dateTimePickerUpdated;
        private System.Windows.Forms.DateTimePicker dateTimePickerCreated;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CategoryCreatedLabel;
        private System.Windows.Forms.Label CategoryNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.RichTextBox noteRichTextbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox editNotePicturebox;
        private System.Windows.Forms.PictureBox newNotePicturebox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label showCategoryLabel;
        private System.Windows.Forms.ListView noteListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitItem;
        private System.Windows.Forms.ToolStripMenuItem AddStripItem;
        private System.Windows.Forms.ToolStripMenuItem EditStripItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveStripItem;
        private System.Windows.Forms.ToolStripMenuItem AboutStripItem;
    }
}

