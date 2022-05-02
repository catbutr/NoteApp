
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
            this.aboutLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.githubLabel = new System.Windows.Forms.Label();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.emailLinkLabel = new System.Windows.Forms.LinkLabel();
            this.githubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.aboutLabel.Location = new System.Drawing.Point(12, 9);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(136, 20);
            this.aboutLabel.TabIndex = 0;
            this.aboutLabel.Text = "NoteApp ver 0.0.1";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.authorLabel.Location = new System.Drawing.Point(12, 33);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(179, 20);
            this.authorLabel.TabIndex = 1;
            this.authorLabel.Text = "Author: Pavel Karabatov";
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.AutoSize = true;
            this.feedbackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.feedbackLabel.Location = new System.Drawing.Point(13, 58);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(115, 17);
            this.feedbackLabel.TabIndex = 2;
            this.feedbackLabel.Text = "Feedback email: ";
            // 
            // githubLabel
            // 
            this.githubLabel.AutoSize = true;
            this.githubLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.githubLabel.Location = new System.Drawing.Point(13, 81);
            this.githubLabel.Name = "githubLabel";
            this.githubLabel.Size = new System.Drawing.Size(54, 17);
            this.githubLabel.TabIndex = 3;
            this.githubLabel.Text = "Github:";
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Location = new System.Drawing.Point(13, 224);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(113, 13);
            this.copyrightLabel.TabIndex = 4;
            this.copyrightLabel.Text = "Pavel Karabatov 2022";
            // 
            // emailLinkLabel
            // 
            this.emailLinkLabel.AutoSize = true;
            this.emailLinkLabel.Location = new System.Drawing.Point(121, 60);
            this.emailLinkLabel.Name = "emailLinkLabel";
            this.emailLinkLabel.Size = new System.Drawing.Size(119, 13);
            this.emailLinkLabel.TabIndex = 5;
            this.emailLinkLabel.TabStop = true;
            this.emailLinkLabel.Text = "pkarabatov@gmail.com";
            this.emailLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.emailLinkLabel_LinkClicked);
            // 
            // githubLinkLabel
            // 
            this.githubLinkLabel.AutoSize = true;
            this.githubLinkLabel.Location = new System.Drawing.Point(69, 83);
            this.githubLinkLabel.Name = "githubLinkLabel";
            this.githubLinkLabel.Size = new System.Drawing.Size(180, 13);
            this.githubLinkLabel.TabIndex = 6;
            this.githubLinkLabel.TabStop = true;
            this.githubLinkLabel.Text = "https://github.com/catbutr/NoteApp";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 246);
            this.Controls.Add(this.githubLinkLabel);
            this.Controls.Add(this.emailLinkLabel);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.githubLabel);
            this.Controls.Add(this.feedbackLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.aboutLabel);
            this.MaximizeBox = false;
            this.Name = "AboutForm";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label feedbackLabel;
        private System.Windows.Forms.Label githubLabel;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.LinkLabel emailLinkLabel;
        private System.Windows.Forms.LinkLabel githubLinkLabel;
    }
}