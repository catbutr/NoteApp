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
            noteNameTextbox.Text = _note.Title;
            noteRichTextbox.Text = _note.Text;
            noteCategoryCombobox.SelectedIndex = (int)_note.Category;
            dateTimePickerCreated.Value = _note.CreationTime;
            dateTimePickerUpdated.Value = _note.UpdateTime;
        }

        private void UpdateNote()
        {
            NoteCategory newCategory;
            Enum.TryParse<NoteCategory>(noteCategoryCombobox.Text, out newCategory);
            _note.Title = noteNameTextbox.Text;
            _note.Text = noteRichTextbox.Text;
            _note.Category = newCategory;
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
            _note.Text = noteRichTextbox.Text;
        }

        private void newNoteNameTextbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _note.Title = noteNameTextbox.Text;
                noteNameTextbox.BackColor = Color.White;
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message);
                noteNameTextbox.BackColor = Color.LightPink;
            }
        }
    }
}