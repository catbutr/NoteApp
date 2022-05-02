using NoteApp.Model;
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

        string testText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do" +
            " eiusmod tempor incididunt ut labore et dolore magna aliqua Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat." +
            "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia" +
            " deserunt mollit anim id est laborum.";
       
        public mainForm()
        {
            InitializeComponent();
        }

        static Note defaultNote = new Note();
        static List<Note> defaultList = new List<Note> {defaultNote};
        private Project _project = new Project(defaultList);


        private void newNotePicturebox_Click(object sender, EventArgs e)
        {
            Form ifrm = new NewNoteForm();
            ifrm.ShowDialog();
        }

        private void AddStripItem_Click(object sender, EventArgs e)
        {
            AddNote();
            UpdateListView();
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

        private void UpdateListView()
        {
            noteListBox.Items.Clear();
            for (int i = 0; i< _project.Projects.Count; ++i)
            {
                noteListBox.Items.Add(_project.Projects[i].Name);
            }
        }

        private void AddNote()
        {
            Note newNote = new Note("Новый день наш ждёт товарищи, вперёд, c богом", NoteCategory.Work,testText);
            _project.Projects.Add(newNote);
        }

        private void AddNoteTest()
        {
            Note newNote = new Note("ыфывфывфы", NoteCategory.Miscellaneous, testText);
            noteListBox.Items.Add(newNote.Name);
        }

        private void RemoveObject()
        {
            int selected = noteListBox.SelectedIndex;
            if (selected == -1)
            {
                return;
            }
            noteListBox.Items.RemoveAt(selected);
            _project.Projects.RemoveAt(selected);
        }

        private void RemoveObject(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(@"Do you really wanna remove " + _project.Projects[noteListBox.SelectedIndex].Name,
                "Message", 
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Stop,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.ServiceNotification);
            if (result == DialogResult.OK)
            {
                RemoveObject();
                UpdateListView();
            }
        }



        private void UpdateSelectedObject(int index)
        {
            noteRichTextbox.Text = _project.Projects[index].Text;
            titleLabel.Text = _project.Projects[index].Name;
            noteCategoryLabel.Text = _project.Projects[index].Category.ToString();
            createdDateTimePicker.Value = _project.Projects[index].CreationTime;
            updatedDateTimePicker.Value = _project.Projects[index].UpdateTime;
        }

        private void ClearSelectedObject()
        {
            noteRichTextbox.Text = " ";
            titleLabel.Text = "Note Title";
            noteCategoryLabel.Text = " ";
        }

        private void UpdatedIndex(object sender, EventArgs e)
        {
            int selected = noteListBox.SelectedIndex;
            if (selected == -1)
            {
                ClearSelectedObject();
            }
            else
            {
                UpdateSelectedObject(selected);
            }
        }

        private void UpdateComboBoxCategory()
        {
            int selected = categoryComboBox.SelectedIndex;
            noteListBox.Items.Clear();
            for (int i = 0; i < _project.Projects.Count; ++i)
            {
                if (selected == (int) _project.Projects[i].Category)
                {
                    noteListBox.Items.Add(_project.Projects[i].Name);
                }
            }
            if (selected == 7)
            {
                for (int i = 0; i < _project.Projects.Count; ++i)
                {
                    noteListBox.Items.Add(_project.Projects[i].Name);
                }
            }
        }

        private void UpdateCategory(object sender, EventArgs e)
        {
            UpdateComboBoxCategory();
        }
    }
}
