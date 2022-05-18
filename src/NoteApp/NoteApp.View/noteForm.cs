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

        private string _titleError;

        public Note Note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
                if (_note != null)
                {
                    noteCategoryCombobox.SelectedIndex = (int)_note.Category;
                    noteRichTextbox.Text = _note.Text;
                    noteTitleTextbox.Text = _note.Title;
                }
            }
        }
        private void UpdateForm()
        {
            noteTitleTextbox.Text = _note.Title;
            noteRichTextbox.Text = _note.Text;
            noteCategoryCombobox.SelectedIndex = (int)_note.Category;
            dateTimePickerCreated.Value = _note.CreationTime;
            dateTimePickerUpdated.Value = _note.UpdateTime;
        }

        private void UpdateNote()
        {
            _note.Title = noteTitleTextbox.Text;
            _note.Text = noteRichTextbox.Text;
            //Блок работы с категориями
            _note.Category = (NoteCategory)Enum.Parse(typeof(NoteCategory), noteCategoryCombobox.GetItemText(noteCategoryCombobox.SelectedItem));
            ////
            _note.UpdateTime = DateTime.Now;
        }

        private bool CheckFormOnErrors()
        {
            if (_titleError == string.Empty)
            {
                return true;
            }
            else
            {
                MessageBox.Show(_titleError);
                return false;
            }
        }


        private void okButton_Click(object sender, EventArgs e)
        {
            UpdateNote();
            DialogResult = DialogResult.OK;
            CheckFormOnErrors();
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
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
        }

        private void noteTitleTextbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                noteTitleTextbox.BackColor = Color.White;
                _titleError = "";
                _note.Title = noteTitleTextbox.Text;
            }
            catch (ArgumentException exception)
            {
                _titleError = exception.Message;
                MessageBox.Show(exception.Message);
                noteTitleTextbox.BackColor = Color.HotPink;
            }
        }
    }
}