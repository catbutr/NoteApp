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

        /// <summary>
        /// Названия заметок для случайной генерации
        /// </summary>
        List<string> testTitles = new List<string> { "Каждый", "Охотник", "Желает", "Знать", "Где", "Живёт", "Фазан" };

        /// <summary>
        /// Текст заметок для случайной генерации
        /// </summary>
        List<string> testText = new List<string> {"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do",
            " eiusmod tempor incididunt ut labore et dolore magna aliqua Ut enim ad minim veniam, quis nostrud exercitation ullamco",
            "laboris nisi ut aliquip ex ea commodo consequat.",
            "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " ,
            "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia",
            " deserunt mollit anim id est laborum." };


        public mainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Случайное распределение
        /// </summary>
        Random rnd = new Random();

        /// <summary>
        /// Сборник заметок
        /// </summary>
        private Project _project = new Project();

        /// <summary>
        /// Открытие окна редактирования заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newNotePicturebox_Click(object sender, EventArgs e)
        {
            Form ifrm = new NewNoteForm();
            ifrm.ShowDialog();
        }

        /// <summary>
        /// Открытие окна создания заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddStripItem_Click(object sender, EventArgs e)
        {
            AddNote();
            UpdateListView();
        }

        /// <summary>
        /// Открытие окна "о создателях"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutStripItem_Click(object sender, EventArgs e)
        {
            Form ifrm = new AboutForm();
            ifrm.ShowDialog();
        }

        /// <summary>
        /// Открытие окна создания заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            Form ifrm = new NewNoteForm();
            ifrm.ShowDialog();
        }

        /// <summary>
        /// Открытие окна редактирования заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editButton_Click(object sender, EventArgs e)
        {
            Form ifrm = new NewNoteForm();
            ifrm.ShowDialog();
        }

        /// <summary>
        /// Обновление списка заметок
        /// </summary>
        private void UpdateListView()
        {
            noteListBox.Items.Clear();
            for (int i = 0; i < _project.Notes.Count; ++i)
            {
                noteListBox.Items.Add(_project.Notes[i].Title);
            }
        }

        /// <summary>
        /// Добавить случайно сгенерированную заметку
        /// </summary>
        private void AddNote()
        {
            int randomTitleIndex = rnd.Next(testTitles.Count);
            int randomTextIndex = rnd.Next(testText.Count);
            Array values = Enum.GetValues(typeof(NoteCategory));
            int randomCategory = rnd.Next(values.Length);
            Note newNote = new Note(testTitles[randomTitleIndex], (NoteCategory)values.GetValue(randomCategory), testText[randomTextIndex]);
            _project.Notes.Add(newNote);
        }

        /// <summary>
        /// Удалить заметку
        /// </summary>
        private void RemoveObject()
        {
            int selected = noteListBox.SelectedIndex;
            if (selected == -1)
            {
                return;
            }
            noteListBox.Items.RemoveAt(selected);
            _project.Notes.RemoveAt(selected);
        }

        /// <summary>
        /// Удаление заметки с выводом сообщения и 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveObject(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(@"Do you really wanna remove " + _project.Notes[noteListBox.SelectedIndex].Title,
                "Message",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Stop);
            if (result == DialogResult.OK)
            {
                RemoveObject();
                UpdateListView();
            }
        }

        /// <summary>
        /// Обновление правой части интерфейча при выборе заметки 
        /// </summary>
        /// <param name="index"></param>
        private void UpdateSelectedObject(int index)
        {
            noteRichTextbox.Text = _project.Notes[index].Text;
            titleLabel.Text = _project.Notes[index].Title;
            noteCategoryLabel.Text = _project.Notes[index].Category.ToString();
            createdDateTimePicker.Value = _project.Notes[index].CreationTime;
            updatedDateTimePicker.Value = _project.Notes[index].UpdateTime;
        }


        /// <summary>
        /// Очистка правой части интерфейса
        /// </summary>
        private void ClearSelectedObject()
        {
            noteRichTextbox.Text = " ";
            titleLabel.Text = "Note Title";
            noteCategoryLabel.Text = " ";
        }

        /// <summary>
        /// Обновление интерфейса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Обновление списка заметок при смене активной категории
        /// </summary>
        private void UpdateComboBoxCategory()
        {
            int selected = categoryComboBox.SelectedIndex;
            noteListBox.Items.Clear();
            for (int i = 0; i < _project.Notes.Count; ++i)
            {
                if (selected == (int)_project.Notes[i].Category)
                {
                    noteListBox.Items.Add(_project.Notes[i].Title);
                }
            }
            if (selected == 7)
            {
                for (int i = 0; i < _project.Notes.Count; ++i)
                {
                    noteListBox.Items.Add(_project.Notes[i].Title);
                }
            }
        }

        /// <summary>
        /// Обновление списка заметок при смене активной категории
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateCategory(object sender, EventArgs e)
        {
            UpdateComboBoxCategory();
        }

        /// <summary>
        /// Выход из приложения при помощи 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitStripElement(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(@"Do you really want to exit the app? ",
                                                   "Message",
                                                    MessageBoxButtons.OKCancel,
                                                    MessageBoxIcon.Stop,
                                                    MessageBoxDefaultButton.Button1,
                                                    MessageBoxOptions.ServiceNotification);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}