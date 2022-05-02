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
    public partial class NewNoteForm : Form
    {
        public NewNoteForm()
        {
            InitializeComponent();
            UpdateForm();
        }

        private Note _note = new Note();

        private void UpdateForm()
        {
            newNoteNameTextbox.Text = _note.Name;
            newNoteRichTextbox.Text = _note.Text;
            newNoteCategoryCombobox.SelectedIndex = (int)_note.Category;
            dateTimePickerCreated.Value = _note.CreationTime;
            dateTimePickerUpdated.Value = _note.UpdateTime;
        }

        private void UpdateNote()
        {
            _note.Name = newNoteNameTextbox.Text;
            _note.Text = newNoteRichTextbox.Text;
            int selected = newNoteCategoryCombobox.SelectedIndex;
            switch (selected)
            {
                //    { Work, Home, Health, People, Documents, Finances, Miscellaneous }
                case 0:
                    _note.Category = NoteCategory.Work;
                    break;
                case 1:
                    _note.Category = NoteCategory.Home;
                    break;
                case 2:
                    _note.Category = NoteCategory.Health;
                    break;
                case 3:
                    _note.Category = NoteCategory.People;
                    break;
                case 4:
                    _note.Category = NoteCategory.Documents;
                    break;
                case 5:
                    _note.Category = NoteCategory.Finances;
                    break;
                case 6:
                    _note.Category = NoteCategory.Miscellaneous;
                    break;
            }
            _note.UpdateTime = DateTime.Now;
        }


        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CategoryUpdatedLabel_Click(object sender, EventArgs e)
        {

        }

        private void CategoryCreatedLabel_Click(object sender, EventArgs e)
        {

        }

        private void UpdateText(object sender, EventArgs e)
        {
            _note.Text = newNoteRichTextbox.Text;
        }
    }
}
