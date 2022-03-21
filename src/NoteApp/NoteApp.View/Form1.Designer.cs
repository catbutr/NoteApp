
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dateTimePickerUpdated = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCreated = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.CategoryCreatedLabel = new System.Windows.Forms.Label();
            this.CategoryNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.noteRichTextbox = new System.Windows.Forms.RichTextBox();
            this.noteListView = new System.Windows.Forms.ListView();
            this.showCategoryLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.newNotePicturebox = new System.Windows.Forms.PictureBox();
            this.editNotePicturebox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newNotePicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editNotePicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
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
            this.splitContainer1.Size = new System.Drawing.Size(953, 664);
            this.splitContainer1.SplitterDistance = 317;
            this.splitContainer1.TabIndex = 0;
            // 
            // dateTimePickerUpdated
            // 
            this.dateTimePickerUpdated.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dateTimePickerUpdated.Location = new System.Drawing.Point(336, 91);
            this.dateTimePickerUpdated.Name = "dateTimePickerUpdated";
            this.dateTimePickerUpdated.Size = new System.Drawing.Size(129, 20);
            this.dateTimePickerUpdated.TabIndex = 6;
            // 
            // dateTimePickerCreated
            // 
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
            // noteRichTextbox
            // 
            this.noteRichTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteRichTextbox.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noteRichTextbox.Location = new System.Drawing.Point(23, 117);
            this.noteRichTextbox.Name = "noteRichTextbox";
            this.noteRichTextbox.ReadOnly = true;
            this.noteRichTextbox.Size = new System.Drawing.Size(597, 535);
            this.noteRichTextbox.TabIndex = 7;
            this.noteRichTextbox.Text = resources.GetString("noteRichTextbox.Text");
            // 
            // noteListView
            // 
            this.noteListView.Font = new System.Drawing.Font("Bahnschrift", 18F);
            this.noteListView.HideSelection = false;
            this.noteListView.Location = new System.Drawing.Point(3, 56);
            this.noteListView.Name = "noteListView";
            this.noteListView.Size = new System.Drawing.Size(311, 450);
            this.noteListView.TabIndex = 8;
            this.noteListView.UseCompatibleStateImageBehavior = false;
            // 
            // showCategoryLabel
            // 
            this.showCategoryLabel.AutoSize = true;
            this.showCategoryLabel.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.showCategoryLabel.Location = new System.Drawing.Point(12, 28);
            this.showCategoryLabel.Name = "showCategoryLabel";
            this.showCategoryLabel.Size = new System.Drawing.Size(89, 19);
            this.showCategoryLabel.TabIndex = 9;
            this.showCategoryLabel.Text = "Категория:";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(107, 26);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryComboBox.TabIndex = 10;
            // 
            // newNotePicturebox
            // 
            this.newNotePicturebox.Location = new System.Drawing.Point(16, 626);
            this.newNotePicturebox.Name = "newNotePicturebox";
            this.newNotePicturebox.Size = new System.Drawing.Size(30, 26);
            this.newNotePicturebox.TabIndex = 8;
            this.newNotePicturebox.TabStop = false;
            // 
            // editNotePicturebox
            // 
            this.editNotePicturebox.Location = new System.Drawing.Point(52, 626);
            this.editNotePicturebox.Name = "editNotePicturebox";
            this.editNotePicturebox.Size = new System.Drawing.Size(30, 26);
            this.editNotePicturebox.TabIndex = 11;
            this.editNotePicturebox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(88, 626);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 26);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 664);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.newNotePicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editNotePicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
    }
}

