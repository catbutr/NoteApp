using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteApp.View
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void newNotePicturebox_Click(object sender, EventArgs e)
        {
            Form ifrm = new NewNoteForm();
            ifrm.ShowDialog();
        }

        private void AddStripItem_Click(object sender, EventArgs e)
        {
            Form ifrm = new NewNoteForm();
            ifrm.ShowDialog();
        }

        private void AboutStripItem_Click(object sender, EventArgs e)
        {
            Form ifrm = new AboutForm();
            ifrm.ShowDialog();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Form ifrm = new NewNoteForm();
            ifrm.ShowDialog();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Form ifrm = new NewNoteForm();
            ifrm.ShowDialog();
        }
    }
}
