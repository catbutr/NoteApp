
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
            this.noteCategoryCombobox = new System.Windows.Forms.ComboBox();
            this.noteRichTextbox = new System.Windows.Forms.RichTextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePickerCreated
            // 
            this.dateTimePickerCreated.Enabled = false;
            this.dateTimePickerCreated.Location = new System.Drawing.Point(57, 61);
            this.dateTimePickerCreated.Name = "dateTimePickerCreated";
            this.dateTimePickerCreated.Size = new System.Drawing.Size(129, 20);
            this.dateTimePickerCreated.TabIndex = 9;
            // 
            // CategoryUpdatedLabel
            // 
            this.CategoryUpdatedLabel.AutoSize = true;
            this.CategoryUpdatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CategoryUpdatedLabel.Location = new System.Drawing.Point(192, 64);
            this.CategoryUpdatedLabel.Name = "CategoryUpdatedLabel";
            this.CategoryUpdatedLabel.Size = new System.Drawing.Size(51, 13);
            this.CategoryUpdatedLabel.TabIndex = 8;
            this.CategoryUpdatedLabel.Text = "Updated:";
            this.CategoryUpdatedLabel.Click += new System.EventHandler(this.CategoryUpdatedLabel_Click);
            // 
            // CategoryCreatedLabel
            // 
            this.CategoryCreatedLabel.AutoSize = true;
            this.CategoryCreatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CategoryCreatedLabel.Location = new System.Drawing.Point(4, 64);
            this.CategoryCreatedLabel.Name = "CategoryCreatedLabel";
            this.CategoryCreatedLabel.Size = new System.Drawing.Size(47, 13);
            this.CategoryCreatedLabel.TabIndex = 7;
            this.CategoryCreatedLabel.Text = "Created:";
            this.CategoryCreatedLabel.Click += new System.EventHandler(this.CategoryCreatedLabel_Click);
            // 
            // dateTimePickerUpdated
            // 
            this.dateTimePickerUpdated.Enabled = false;
            this.dateTimePickerUpdated.Location = new System.Drawing.Point(249, 61);
            this.dateTimePickerUpdated.Name = "dateTimePickerUpdated";
            this.dateTimePickerUpdated.Size = new System.Drawing.Size(129, 20);
            this.dateTimePickerUpdated.TabIndex = 10;
            // 
            // noteNameLabel
            // 
            this.noteNameLabel.AutoSize = true;
            this.noteNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.noteNameLabel.Location = new System.Drawing.Point(4, 12);
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
            this.noteNameTextbox.Location = new System.Drawing.Point(57, 9);
            this.noteNameTextbox.Name = "noteNameTextbox";
            this.noteNameTextbox.Size = new System.Drawing.Size(736, 20);
            this.noteNameTextbox.TabIndex = 12;
            // 
            // noteCategoryLabel
            // 
            this.noteCategoryLabel.AutoSize = true;
            this.noteCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.noteCategoryLabel.Location = new System.Drawing.Point(4, 37);
            this.noteCategoryLabel.Name = "noteCategoryLabel";
            this.noteCategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.noteCategoryLabel.TabIndex = 13;
            this.noteCategoryLabel.Text = "Category:";
            // 
            // noteCategoryCombobox
            // 
            this.noteCategoryCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteCategoryCombobox.FormattingEnabled = true;
            this.noteCategoryCombobox.Items.AddRange(new object[] {
            "Work",
            "Home",
            "Health",
            "People",
            "Documents ",
            "Finances",
            "Miscellaneous"});
            this.noteCategoryCombobox.Location = new System.Drawing.Point(57, 34);
            this.noteCategoryCombobox.Name = "noteCategoryCombobox";
            this.noteCategoryCombobox.Size = new System.Drawing.Size(736, 21);
            this.noteCategoryCombobox.TabIndex = 14;
            // 
            // noteRichTextbox
            // 
            this.noteRichTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteRichTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.noteRichTextbox.Location = new System.Drawing.Point(6, 86);
            this.noteRichTextbox.Name = "noteRichTextbox";
            this.noteRichTextbox.Size = new System.Drawing.Size(787, 329);
            this.noteRichTextbox.TabIndex = 15;
            this.noteRichTextbox.Text = "";
            this.noteRichTextbox.TextChanged += new System.EventHandler(this.UpdateText);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(638, 421);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 16;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(719, 421);
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
            this.Controls.Add(this.noteRichTextbox);
            this.Controls.Add(this.noteCategoryCombobox);
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
        private System.Windows.Forms.ComboBox noteCategoryCombobox;
        private System.Windows.Forms.RichTextBox noteRichTextbox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}