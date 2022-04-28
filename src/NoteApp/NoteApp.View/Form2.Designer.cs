
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewNoteForm));
            this.dateTimePickerCreated = new System.Windows.Forms.DateTimePicker();
            this.CategoryUpdatedLabel = new System.Windows.Forms.Label();
            this.CategoryCreatedLabel = new System.Windows.Forms.Label();
            this.dateTimePickerUpdated = new System.Windows.Forms.DateTimePicker();
            this.noteNameLabel = new System.Windows.Forms.Label();
            this.noteNameTextbox = new System.Windows.Forms.TextBox();
            this.noteCategoryLabel = new System.Windows.Forms.Label();
            this.newNoteCategoryCombobox = new System.Windows.Forms.ComboBox();
            this.newNoteRichTextbox = new System.Windows.Forms.RichTextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePickerCreated
            // 
            this.dateTimePickerCreated.Enabled = false;
            this.dateTimePickerCreated.Location = new System.Drawing.Point(56, 73);
            this.dateTimePickerCreated.Name = "dateTimePickerCreated";
            this.dateTimePickerCreated.Size = new System.Drawing.Size(129, 20);
            this.dateTimePickerCreated.TabIndex = 9;
            // 
            // CategoryUpdatedLabel
            // 
            this.CategoryUpdatedLabel.AutoSize = true;
            this.CategoryUpdatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CategoryUpdatedLabel.Location = new System.Drawing.Point(191, 77);
            this.CategoryUpdatedLabel.Name = "CategoryUpdatedLabel";
            this.CategoryUpdatedLabel.Size = new System.Drawing.Size(51, 13);
            this.CategoryUpdatedLabel.TabIndex = 8;
            this.CategoryUpdatedLabel.Text = "Updated:";
            // 
            // CategoryCreatedLabel
            // 
            this.CategoryCreatedLabel.AutoSize = true;
            this.CategoryCreatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CategoryCreatedLabel.Location = new System.Drawing.Point(3, 76);
            this.CategoryCreatedLabel.Name = "CategoryCreatedLabel";
            this.CategoryCreatedLabel.Size = new System.Drawing.Size(47, 13);
            this.CategoryCreatedLabel.TabIndex = 7;
            this.CategoryCreatedLabel.Text = "Created:";
            // 
            // dateTimePickerUpdated
            // 
            this.dateTimePickerUpdated.Enabled = false;
            this.dateTimePickerUpdated.Location = new System.Drawing.Point(248, 73);
            this.dateTimePickerUpdated.Name = "dateTimePickerUpdated";
            this.dateTimePickerUpdated.Size = new System.Drawing.Size(129, 20);
            this.dateTimePickerUpdated.TabIndex = 10;
            // 
            // noteNameLabel
            // 
            this.noteNameLabel.AutoSize = true;
            this.noteNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.noteNameLabel.Location = new System.Drawing.Point(3, 9);
            this.noteNameLabel.Name = "noteNameLabel";
            this.noteNameLabel.Size = new System.Drawing.Size(30, 13);
            this.noteNameLabel.TabIndex = 11;
            this.noteNameLabel.Text = "Title:";
            // 
            // noteNameTextbox
            // 
            this.noteNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteNameTextbox.Location = new System.Drawing.Point(39, 6);
            this.noteNameTextbox.Name = "noteNameTextbox";
            this.noteNameTextbox.Size = new System.Drawing.Size(755, 20);
            this.noteNameTextbox.TabIndex = 12;
            // 
            // noteCategoryLabel
            // 
            this.noteCategoryLabel.AutoSize = true;
            this.noteCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.noteCategoryLabel.Location = new System.Drawing.Point(3, 43);
            this.noteCategoryLabel.Name = "noteCategoryLabel";
            this.noteCategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.noteCategoryLabel.TabIndex = 13;
            this.noteCategoryLabel.Text = "Category:";
            // 
            // newNoteCategoryCombobox
            // 
            this.newNoteCategoryCombobox.FormattingEnabled = true;
            this.newNoteCategoryCombobox.Location = new System.Drawing.Point(56, 40);
            this.newNoteCategoryCombobox.Name = "newNoteCategoryCombobox";
            this.newNoteCategoryCombobox.Size = new System.Drawing.Size(738, 21);
            this.newNoteCategoryCombobox.TabIndex = 14;
            // 
            // newNoteRichTextbox
            // 
            this.newNoteRichTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newNoteRichTextbox.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.newNoteRichTextbox.Location = new System.Drawing.Point(6, 99);
            this.newNoteRichTextbox.Name = "newNoteRichTextbox";
            this.newNoteRichTextbox.Size = new System.Drawing.Size(788, 316);
            this.newNoteRichTextbox.TabIndex = 15;
            this.newNoteRichTextbox.Text = "";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.okButton.Location = new System.Drawing.Point(6, 421);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 16;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.Location = new System.Drawing.Point(87, 421);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // NewNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.newNoteRichTextbox);
            this.Controls.Add(this.newNoteCategoryCombobox);
            this.Controls.Add(this.noteCategoryLabel);
            this.Controls.Add(this.noteNameTextbox);
            this.Controls.Add(this.noteNameLabel);
            this.Controls.Add(this.dateTimePickerUpdated);
            this.Controls.Add(this.dateTimePickerCreated);
            this.Controls.Add(this.CategoryUpdatedLabel);
            this.Controls.Add(this.CategoryCreatedLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}