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
    public partial class NoteForm : Form
    {
        /// <summary>
        /// Сама заметка
        /// </summary>
        private Note _note = new Note();
        
        /// <summary>
        /// Ошибка в заглавии заметки
        /// </summary>
        private string _titleError;

        /// <summary>
        /// Ошибка в тексте заметки
        /// </summary>
        private string _textError;

        /// <summary>
        /// Передача заметки в основное окно
        /// </summary>
        public Note Note
        {
            get
            {
                return _note;
            }
            set
            {
                Note transferedNote = value;
                if (transferedNote != null)
                {
                    noteCategoryCombobox.SelectedIndex = (int)transferedNote.Category;
                    noteRichTextbox.Text = transferedNote.Text;
                    noteTitleTextbox.Text = transferedNote.Title;
                    noteCategoryCombobox.SelectedIndex = (int)transferedNote.Category;
                }
                _note = transferedNote;

            }
        }

        public NoteForm()
        {
            InitializeComponent();
            UpdateForm();
            noteCategoryCombobox.SelectedIndex = (int)_note.Category;
        }

        /// <summary>
        /// Обновление данных в форме
        /// </summary>
        private void UpdateForm()
        {
            noteTitleTextbox.Text = _note.Title;
            noteRichTextbox.Text = _note.Text;
            noteCategoryCombobox.SelectedIndex = (int)_note.Category;
            dateTimePickerCreated.Value = _note.CreationTime;
            dateTimePickerUpdated.Value = _note.UpdateTime;
        }

        /// <summary>
        /// Перевод строку в перечисление
        /// </summary>
        /// <param name="parseableString"></param>
        /// <returns></returns>
        public NoteCategory ParseCategory(string parseableString)
        {
            return (NoteCategory)Enum.Parse(typeof(NoteCategory),
                parseableString);
        }

        /// <summary>
        /// Обновление данных в заметке
        /// </summary>
        private void UpdateNote()
        {
            _note.Title = noteTitleTextbox.Text;
            _note.Text = noteRichTextbox.Text;
            string parseableString = noteCategoryCombobox.GetItemText(noteCategoryCombobox.SelectedItem);
            _note.Category = ParseCategory(parseableString);
            _note.UpdateTime = DateTime.Now;
        }

        /// <summary>
        /// Проверка содержания формы на ошибки
        /// </summary>
        /// <returns></returns>
        private bool CheckFormOnErrors()
        {
            if (_titleError == string.Empty || _textError == string.Empty)
            {
                return true;
            }
            else
            {
                //Все ошибки в одном окне
                if (_titleError == string.Empty)
                {
                    MessageBox.Show(_titleError);
                    return false;
                }
                else
                {
                    MessageBox.Show(_textError);
                    return false;
                }
            }

        }

        /// <summary>
        /// Реализация кнопки ок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okButton_Click(object sender, EventArgs e)
        {
            UpdateNote();
            CheckFormOnErrors();
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Реализация кнопки отмена
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Провека текста заметки на ошибки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void noteRichTextbox_TextChanged(object sender, EventArgs e)
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
                noteRichTextbox.BackColor = Color.FromArgb(255, 127, 127);
                okButton.Enabled = false;
            }
        }

        /// <summary>
        /// Проверка названия заметки на ошибки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void noteTitleTextbox_TextChanged(object sender, EventArgs e)
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
                //Вынести цвета в константу
                noteTitleTextbox.BackColor = Color.FromArgb(255,127,127);
                okButton.Enabled = false;
            }
        }
    }
}