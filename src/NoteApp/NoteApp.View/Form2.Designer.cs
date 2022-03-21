
namespace NoteApp.View
{
    partial class NewNoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePickerCreated = new System.Windows.Forms.DateTimePicker();
            this.CategoryUpdatedLabel = new System.Windows.Forms.Label();
            this.CategoryCreatedLabel = new System.Windows.Forms.Label();
            this.dateTimePickerUpdated = new System.Windows.Forms.DateTimePicker();
            this.noteNameLabel = new System.Windows.Forms.Label();
            this.noteNameTextbox = new System.Windows.Forms.TextBox();
            this.noteCategoryLabel = new System.Windows.Forms.Label();
            this.newNoteCategoryCombobox = new System.Windows.Forms.ComboBox();
            this.newNoteRichTextbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // dateTimePickerCreated
            // 
            this.dateTimePickerCreated.Enabled = false;
            this.dateTimePickerCreated.Location = new System.Drawing.Point(94, 75);
            this.dateTimePickerCreated.Name = "dateTimePickerCreated";
            this.dateTimePickerCreated.Size = new System.Drawing.Size(129, 20);
            this.dateTimePickerCreated.TabIndex = 9;
            // 
            // CategoryUpdatedLabel
            // 
            this.CategoryUpdatedLabel.AutoSize = true;
            this.CategoryUpdatedLabel.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.CategoryUpdatedLabel.Location = new System.Drawing.Point(229, 76);
            this.CategoryUpdatedLabel.Name = "CategoryUpdatedLabel";
            this.CategoryUpdatedLabel.Size = new System.Drawing.Size(95, 19);
            this.CategoryUpdatedLabel.TabIndex = 8;
            this.CategoryUpdatedLabel.Text = "Обновлена:";
            // 
            // CategoryCreatedLabel
            // 
            this.CategoryCreatedLabel.AutoSize = true;
            this.CategoryCreatedLabel.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.CategoryCreatedLabel.Location = new System.Drawing.Point(13, 76);
            this.CategoryCreatedLabel.Name = "CategoryCreatedLabel";
            this.CategoryCreatedLabel.Size = new System.Drawing.Size(77, 19);
            this.CategoryCreatedLabel.TabIndex = 7;
            this.CategoryCreatedLabel.Text = "Создана:";
            // 
            // dateTimePickerUpdated
            // 
            this.dateTimePickerUpdated.Enabled = false;
            this.dateTimePickerUpdated.Location = new System.Drawing.Point(330, 75);
            this.dateTimePickerUpdated.Name = "dateTimePickerUpdated";
            this.dateTimePickerUpdated.Size = new System.Drawing.Size(129, 20);
            this.dateTimePickerUpdated.TabIndex = 10;
            // 
            // noteNameLabel
            // 
            this.noteNameLabel.AutoSize = true;
            this.noteNameLabel.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.noteNameLabel.Location = new System.Drawing.Point(13, 9);
            this.noteNameLabel.Name = "noteNameLabel";
            this.noteNameLabel.Size = new System.Drawing.Size(86, 19);
            this.noteNameLabel.TabIndex = 11;
            this.noteNameLabel.Text = "Название:";
            // 
            // noteNameTextbox
            // 
            this.noteNameTextbox.Location = new System.Drawing.Point(105, 8);
            this.noteNameTextbox.Name = "noteNameTextbox";
            this.noteNameTextbox.Size = new System.Drawing.Size(683, 20);
            this.noteNameTextbox.TabIndex = 12;
            // 
            // noteCategoryLabel
            // 
            this.noteCategoryLabel.AutoSize = true;
            this.noteCategoryLabel.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.noteCategoryLabel.Location = new System.Drawing.Point(13, 43);
            this.noteCategoryLabel.Name = "noteCategoryLabel";
            this.noteCategoryLabel.Size = new System.Drawing.Size(89, 19);
            this.noteCategoryLabel.TabIndex = 13;
            this.noteCategoryLabel.Text = "Категория:";
            // 
            // newNoteCategoryCombobox
            // 
            this.newNoteCategoryCombobox.FormattingEnabled = true;
            this.newNoteCategoryCombobox.Location = new System.Drawing.Point(105, 43);
            this.newNoteCategoryCombobox.Name = "newNoteCategoryCombobox";
            this.newNoteCategoryCombobox.Size = new System.Drawing.Size(121, 21);
            this.newNoteCategoryCombobox.TabIndex = 14;
            // 
            // newNoteRichTextbox
            // 
            this.newNoteRichTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newNoteRichTextbox.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.newNoteRichTextbox.Location = new System.Drawing.Point(17, 112);
            this.newNoteRichTextbox.Name = "newNoteRichTextbox";
            this.newNoteRichTextbox.Size = new System.Drawing.Size(771, 326);
            this.newNoteRichTextbox.TabIndex = 15;
            this.newNoteRichTextbox.Text = "";
            // 
            // NewNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newNoteRichTextbox);
            this.Controls.Add(this.newNoteCategoryCombobox);
            this.Controls.Add(this.noteCategoryLabel);
            this.Controls.Add(this.noteNameTextbox);
            this.Controls.Add(this.noteNameLabel);
            this.Controls.Add(this.dateTimePickerUpdated);
            this.Controls.Add(this.dateTimePickerCreated);
            this.Controls.Add(this.CategoryUpdatedLabel);
            this.Controls.Add(this.CategoryCreatedLabel);
            this.Name = "NewNoteForm";
            this.Text = "Add/Edit Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerCreated;
        private System.Windows.Forms.Label CategoryUpdatedLabel;
        private System.Windows.Forms.Label CategoryCreatedLabel;
        private System.Windows.Forms.DateTimePicker dateTimePickerUpdated;
        private System.Windows.Forms.Label noteNameLabel;
        private System.Windows.Forms.TextBox noteNameTextbox;
        private System.Windows.Forms.Label noteCategoryLabel;
        private System.Windows.Forms.ComboBox newNoteCategoryCombobox;
        private System.Windows.Forms.RichTextBox newNoteRichTextbox;
    }
}