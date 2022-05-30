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

        private Note _note = new Note();

        private string _titleError;
        private string _textError;

        public Note Note
        {
            get
            {
                return _note;
            }
            set
            {
                Note _clonnedNote = value;
                //Note _clonnedNote = new Note();
                //_clonnedNote.Title = _note.Title;
                //_clonnedNote.Text = _note.Text;
                //_clonnedNote.Category = _note.Category;
                if (_clonnedNote != null)
                {
                    noteCategoryCombobox.SelectedIndex = (int)_clonnedNote.Category;
                    noteRichTextbox.Text = _clonnedNote.Text;
                    noteTitleTextbox.Text = _clonnedNote.Title;
                    noteCategoryCombobox.SelectedIndex = (int)_clonnedNote.Category;
                }
                _note = _clonnedNote;

            }
        }

        public NewNoteForm()
        {
            InitializeComponent();
            UpdateForm();
            noteCategoryCombobox.SelectedIndex = (int)_note.Category;
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

            if (_textError == string.Empty)
            {
                return true;
            }
            else
            {
                MessageBox.Show(_textError);
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
            try
            {
                noteRichTextbox.BackColor = Color.White;
                _textError = "";
                _note.Text = noteRichTextbox.Text;
                okButton.Enabled = true;
            }
            catch (ArgumentException exception)
            {
                _textError = exception.Message;
                MessageBox.Show(exception.Message);
                noteRichTextbox.BackColor = Color.HotPink;
                okButton.Enabled = false;
            }
        }

        private void newNoteNameTextbox_TextChanged(object sender, EventArgs e)
        {
        }

        private void UpdateTitle(object sender, EventArgs e)
        {
            try
            {
                noteTitleTextbox.BackColor = Color.White;
                _titleError = "";
                _note.Title = noteTitleTextbox.Text;
                okButton.Enabled = true;
            }
            catch (ArgumentException exception)
            {
                _titleError = exception.Message;
                MessageBox.Show(exception.Message);
                noteTitleTextbox.BackColor = Color.HotPink;
                okButton.Enabled = false;
            }
        }
    }
}