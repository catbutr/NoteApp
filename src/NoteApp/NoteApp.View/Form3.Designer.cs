
namespace NoteApp.View
{
    partial class AboutForm
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
            this.AboutLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.FeedbackLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CopyrightLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AboutLabel
            // 
            this.AboutLabel.AutoSize = true;
            this.AboutLabel.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.AboutLabel.Location = new System.Drawing.Point(12, 9);
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(134, 19);
            this.AboutLabel.TabIndex = 0;
            this.AboutLabel.Text = "NoteApp ver 0.0.1";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.AuthorLabel.Location = new System.Drawing.Point(12, 41);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(185, 19);
            this.AuthorLabel.TabIndex = 1;
            this.AuthorLabel.Text = "Author: Pavel Karabatov";
            // 
            // FeedbackLabel
            // 
            this.FeedbackLabel.AutoSize = true;
            this.FeedbackLabel.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.FeedbackLabel.Location = new System.Drawing.Point(13, 75);
            this.FeedbackLabel.Name = "FeedbackLabel";
            this.FeedbackLabel.Size = new System.Drawing.Size(262, 17);
            this.FeedbackLabel.TabIndex = 2;
            this.FeedbackLabel.Text = "Feedback email: pkarabatov@gmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.label1.Location = new System.Drawing.Point(13, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Github:https://github.com/catbutr/NoteApp";
            // 
            // CopyrightLabel
            // 
            this.CopyrightLabel.AutoSize = true;
            this.CopyrightLabel.Location = new System.Drawing.Point(13, 224);
            this.CopyrightLabel.Name = "CopyrightLabel";
            this.CopyrightLabel.Size = new System.Drawing.Size(113, 13);
            this.CopyrightLabel.TabIndex = 4;
            this.CopyrightLabel.Text = "Pavel Karabatov 2022";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 246);
            this.Controls.Add(this.CopyrightLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FeedbackLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.AboutLabel);
            this.MaximizeBox = false;
            this.Name = "AboutForm";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AboutLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label FeedbackLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CopyrightLabel;
    }
}