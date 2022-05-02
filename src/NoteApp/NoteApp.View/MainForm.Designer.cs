
namespace NoteApp.View
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.noteListBox = new System.Windows.Forms.ListBox();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.showCategoryLabel = new System.Windows.Forms.Label();
            this.noteRichTextbox = new System.Windows.Forms.RichTextBox();
            this.updatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.createdDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.updatedLabel = new System.Windows.Forms.Label();
            this.createdCategoryLabel = new System.Windows.Forms.Label();
            this.noteCategoryLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.noteListBox);
            this.splitContainer1.Panel1.Controls.Add(this.editButton);
            this.splitContainer1.Panel1.Controls.Add(this.deleteButton);
            this.splitContainer1.Panel1.Controls.Add(this.addButton);
            this.splitContainer1.Panel1.Controls.Add(this.categoryComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.showCategoryLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.noteRichTextbox);
            this.splitContainer1.Panel2.Controls.Add(this.updatedDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.createdDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.updatedLabel);
            this.splitContainer1.Panel2.Controls.Add(this.createdCategoryLabel);
            this.splitContainer1.Panel2.Controls.Add(this.noteCategoryLabel);
            this.splitContainer1.Panel2.Controls.Add(this.categoryLabel);
            this.splitContainer1.Panel2.Controls.Add(this.titleLabel);
            this.splitContainer1.Size = new System.Drawing.Size(953, 640);
            this.splitContainer1.SplitterDistance = 317;
            this.splitContainer1.TabIndex = 0;
            // 
            // noteListBox
            // 
            this.noteListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteListBox.FormattingEnabled = true;
            this.noteListBox.HorizontalScrollbar = true;
            this.noteListBox.Location = new System.Drawing.Point(7, 40);
            this.noteListBox.Name = "noteListBox";
            this.noteListBox.Size = new System.Drawing.Size(309, 537);
            this.noteListBox.TabIndex = 8;
            this.noteListBox.SelectedIndexChanged += new System.EventHandler(this.UpdatedIndex);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Image = ((System.Drawing.Image)(resources.GetObject("editButton.Image")));
            this.editButton.Location = new System.Drawing.Point(61, 580);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(48, 48);
            this.editButton.TabIndex = 13;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.AccessibleName = "";
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.Location = new System.Drawing.Point(115, 580);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(48, 48);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.RemoveObject);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.Location = new System.Drawing.Point(7, 580);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(48, 48);
            this.addButton.TabIndex = 11;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Work",
            "Home",
            "Health",
            "People",
            "Documents",
            "Finances",
            "Miscellaneous",
            "All"});
            this.categoryComboBox.Location = new System.Drawing.Point(55, 13);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(261, 21);
            this.categoryComboBox.TabIndex = 10;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.UpdateCategory);
            // 
            // showCategoryLabel
            // 
            this.showCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.showCategoryLabel.Location = new System.Drawing.Point(4, 15);
            this.showCategoryLabel.Name = "showCategoryLabel";
            this.showCategoryLabel.Size = new System.Drawing.Size(89, 19);
            this.showCategoryLabel.TabIndex = 9;
            this.showCategoryLabel.Text = "Category:";
            // 
            // noteRichTextbox
            // 
            this.noteRichTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteRichTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noteRichTextbox.Location = new System.Drawing.Point(4, 79);
            this.noteRichTextbox.Name = "noteRichTextbox";
            this.noteRichTextbox.ReadOnly = true;
            this.noteRichTextbox.Size = new System.Drawing.Size(619, 555);
            this.noteRichTextbox.TabIndex = 7;
            this.noteRichTextbox.Text = "";
            // 
            // updatedDateTimePicker
            // 
            this.updatedDateTimePicker.Enabled = false;
            this.updatedDateTimePicker.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.updatedDateTimePicker.Location = new System.Drawing.Point(252, 53);
            this.updatedDateTimePicker.Name = "updatedDateTimePicker";
            this.updatedDateTimePicker.Size = new System.Drawing.Size(129, 20);
            this.updatedDateTimePicker.TabIndex = 6;
            // 
            // createdDateTimePicker
            // 
            this.createdDateTimePicker.Enabled = false;
            this.createdDateTimePicker.Location = new System.Drawing.Point(54, 53);
            this.createdDateTimePicker.Name = "createdDateTimePicker";
            this.createdDateTimePicker.Size = new System.Drawing.Size(129, 20);
            this.createdDateTimePicker.TabIndex = 5;
            // 
            // updatedLabel
            // 
            this.updatedLabel.AutoSize = true;
            this.updatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.updatedLabel.Location = new System.Drawing.Point(196, 56);
            this.updatedLabel.Name = "updatedLabel";
            this.updatedLabel.Size = new System.Drawing.Size(51, 13);
            this.updatedLabel.TabIndex = 4;
            this.updatedLabel.Text = "Updated:";
            // 
            // createdCategoryLabel
            // 
            this.createdCategoryLabel.AutoSize = true;
            this.createdCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.createdCategoryLabel.Location = new System.Drawing.Point(3, 56);
            this.createdCategoryLabel.Name = "createdCategoryLabel";
            this.createdCategoryLabel.Size = new System.Drawing.Size(47, 13);
            this.createdCategoryLabel.TabIndex = 3;
            this.createdCategoryLabel.Text = "Created:";
            // 
            // noteCategoryLabel
            // 
            this.noteCategoryLabel.AutoSize = true;
            this.noteCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.noteCategoryLabel.Location = new System.Drawing.Point(60, 34);
            this.noteCategoryLabel.Name = "noteCategoryLabel";
            this.noteCategoryLabel.Size = new System.Drawing.Size(76, 13);
            this.noteCategoryLabel.TabIndex = 2;
            this.noteCategoryLabel.Text = "categoryName";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.categoryLabel.Location = new System.Drawing.Point(3, 34);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(52, 13);
            this.categoryLabel.TabIndex = 1;
            this.categoryLabel.Text = "Category:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.titleLabel.Location = new System.Drawing.Point(2, 11);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(72, 20);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Note title";
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(953, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuStripItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitMenuStripItem
            // 
            this.exitMenuStripItem.Name = "exitMenuStripItem";
            this.exitMenuStripItem.Size = new System.Drawing.Size(93, 22);
            this.exitMenuStripItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStripMenuItem,
            this.EditStripMenuItem,
            this.removeStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addStripMenuItem
            // 
            this.addStripMenuItem.Name = "addStripMenuItem";
            this.addStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.addStripMenuItem.Text = "Add Note";
            this.addStripMenuItem.Click += new System.EventHandler(this.AddStripItem_Click);
            // 
            // EditStripMenuItem
            // 
            this.EditStripMenuItem.Name = "EditStripMenuItem";
            this.EditStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.EditStripMenuItem.Text = "Edit Note";
            // 
            // removeStripMenuItem
            // 
            this.removeStripMenuItem.Name = "removeStripMenuItem";
            this.removeStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.removeStripMenuItem.Text = "Remove Note";
            this.removeStripMenuItem.Click += new System.EventHandler(this.RemoveObject);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutStripMenuItem
            // 
            this.aboutStripMenuItem.Name = "aboutStripMenuItem";
            this.aboutStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutStripMenuItem.Text = "About";
            this.aboutStripMenuItem.Click += new System.EventHandler(this.AboutStripItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 664);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "mainForm";
            this.Text = "NoteApp";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker updatedDateTimePicker;
        private System.Windows.Forms.DateTimePicker createdDateTimePicker;
        private System.Windows.Forms.Label updatedLabel;
        private System.Windows.Forms.Label createdCategoryLabel;
        private System.Windows.Forms.Label noteCategoryLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.RichTextBox noteRichTextbox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label showCategoryLabel;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem addStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutStripMenuItem;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ListBox noteListBox;
    }
}

