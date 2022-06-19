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
        //Todo:
        //Выбирается последняя отредактированная заметка+
        //Сброс категории при очистке всех элементов одной категории+
        //Все формы с заглавной буквы+
        //Правильное оформление кода+
        //Перенести дебаг в отдельной 
        //Обработчик в самый конец+
        //Модификаторы везде и для всего+
        //Клон для проекта
        //all в константу+
        /// <summary>
        /// Названия заметок для случайной генерации
        /// </summary>
        List<string> testTitles = new List<string> { "Каждый", "Охотник", "Желает", "Знать", "Где", "Живёт", "Фазан" };

        private const string categoryAll = "All";

        /// <summary>
        /// Текст заметок для случайной генерации
        /// </summary>
        List<string> testText = new List<string> {"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do",
            " eiusmod tempor incididunt ut labore et dolore magna aliqua Ut enim ad minim veniam, quis nostrud exercitation ullamco",
            "laboris nisi ut aliquip ex ea commodo consequat.",
            "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " ,
            "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia",
            " deserunt mollit anim id est laborum." };

        private const string AllNotes = "all";
        public static string FileName { get; private set; } = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
    + @"\NoteApp\NoteApp.txt";

        public NoteCategory ParseCategory(string parseableString)
        {
            return (NoteCategory)Enum.Parse(typeof(NoteCategory),
                parseableString);
        }

        public mainForm()
        {
            InitializeComponent();
            _project = ProjectManager.LoadFromFile(FileName);
            categoryComboBox.SelectedItem = "All";
        }

        /// <summary>
        /// Случайное распределение
        /// </summary>
        public Random random = new Random();

        /// <summary>
        /// Сборник заметок
        /// </summary>
        private Project _project = new Project();
        List<Note> _currentNotes = new List<Note> { };

        /// <summary>
        /// Открытие окна редактирования заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newNotePicturebox_Click(object sender, EventArgs e)
        {
            Form newNoteForm = new NoteForm();
            newNoteForm.ShowDialog();
        }

        /// <summary>
        /// Открытие окна создания заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNoteStripItem_Click(object sender, EventArgs e)
        {
            AddRandomNote();
            UpdateListView();
        }

        /// <summary>
        /// Открытие окна "о создателях"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutNoteStripItem_Click(object sender, EventArgs e)
        {
            Form newAboutForm = new AboutForm();
            newAboutForm.ShowDialog();
        }

        /// <summary>
        /// Открытие окна создания заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            //Переброс данных
            var copyProject = _project;
            var newNoteForm = new NoteForm();
            newNoteForm.ShowDialog();
            var newNote = newNoteForm.Note;

            if (newNoteForm.DialogResult == DialogResult.OK)
            {
                //Добавление новой заметки
                copyProject.Notes.Add(newNote);
                _project = copyProject;
                //Красивое оформление
                UpdateListView();
                CategorySelector(newNote.Category);
            }
            UpdateComboBoxCategory();
            SortListBox();
        }

        /// <summary>
        /// Открытие окна редактирования заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editButton_Click(object sender, EventArgs e)
        {
            //Переброс данных
            var _clonedProject = _currentNotes;
            var selectedIndex = noteListBox.SelectedIndex;
            if (selectedIndex < 0)
            {
                return;
            }
            var selectedNote = _clonedProject[selectedIndex];
            var newNoteForm = new NoteForm();
            newNoteForm.Note = selectedNote;
            newNoteForm.ShowDialog();

            if (newNoteForm.DialogResult == DialogResult.OK)
            {
                var updatedNote = newNoteForm.Note;
                //Удаление старых данных
                noteListBox.Items.RemoveAt(selectedIndex);
                _clonedProject.RemoveAt(selectedIndex);
                _clonedProject.Insert(selectedIndex, updatedNote);
                _currentNotes = _clonedProject;
                UpdateListView();
                //В метод
                CategorySelector(updatedNote.Category);
            }
            UpdateComboBoxCategory();
            SortListBox();

        }

        /// <summary>
        /// Удаление заметки с выводом сообщения и 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (noteListBox.Items.Count == 0)
            {
                return;
            }
            DialogResult result = MessageBox.Show(@"Do you really wanna remove " + _project.Notes[noteListBox.SelectedIndex].Title,
                "Message",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Stop);
            if (result == DialogResult.OK)
            {
                RemoveNote();
                UpdateListView();
            }
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
                ClearSelectedNote();
            }
            else
            {
                UpdateSelectedObject(selected);
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
            Application.Exit();
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProjectManager.SaveToFile(_project, FileName);
            DialogResult result = MessageBox.Show(@"Do you really want to exit the app? ",
                                                   "Message",
                                                    MessageBoxButtons.OKCancel,
                                                    MessageBoxIcon.Stop,
                                                    MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }


        private void CategorySelector(NoteCategory selectedCategory)
        {
            if (categoryComboBox.SelectedItem.ToString() == "All")
            {
                UpdateSelectedObject(noteListBox.Items.Count - 1);
            }
            else
            {
                string parseableString = categoryComboBox.GetItemText(categoryComboBox.SelectedItem);
                if (selectedCategory == ParseCategory(parseableString))
                {
                    UpdateSelectedObject(noteListBox.Items.Count - 1);
                }
            }
        }

        /// <summary>
        /// Обновление списка заметок
        /// </summary>
        private void UpdateListView()
        {
            noteListBox.Items.Clear();
            for (int i = 0; i < _currentNotes.Count; ++i)
            {
                noteListBox.Items.Add(_currentNotes[i].Title);
            }
        }

        /// <summary>
        /// Добавить случайно сгенерированную заметку
        /// </summary>
        private void AddRandomNote()
        {
            int randomTitleIndex = random.Next(testTitles.Count);
            int randomTextIndex = random.Next(testText.Count);
            Array values = Enum.GetValues(typeof(NoteCategory));
            int randomCategory = random.Next(values.Length);
            Note newNote = new Note(testTitles[randomTitleIndex], 
                (NoteCategory)values.GetValue(randomCategory), 
                testText[randomTextIndex]);
            _project.Notes.Add(newNote);
            UpdateComboBoxCategory();
            UpdateListView();
        }

        /// <summary>
        /// Удалить заметку
        /// </summary>
        private void RemoveNote()
        {
            int selected = noteListBox.SelectedIndex;
            if (selected == -1)
            {
                return;
            }
            noteListBox.Items.RemoveAt(selected);
            var removedElement = _currentNotes[selected];
            _currentNotes.RemoveAt(selected);
            _project.Notes.Remove(removedElement);
            var itemCount = noteListBox.Items.Count;
            if (itemCount > 0)
            {
                noteListBox.SelectedItem = noteListBox.Items[0];
            }
            else
            {
                categoryComboBox.SelectedIndex = 7;
                UpdateComboBoxCategory();
                noteListBox.SelectedItem = noteListBox.Items[0];
            }
        }

        /// <summary>
        /// Обновление правой части интерфейча при выборе заметки 
        /// </summary>
        /// <param name="index"></param>
        private void UpdateSelectedObject(int index)
        {
            Note currentIndex = _currentNotes[index];
            noteRichTextbox.Text = currentIndex.Text;
            titleLabel.Text = currentIndex.Title;
            noteCategoryLabel.Text = currentIndex.Category.ToString();
            createdDateTimePicker.Value = currentIndex.CreationTime;
            updatedDateTimePicker.Value = currentIndex.UpdateTime;
        }


        /// <summary>
        /// Очистка правой части интерфейса
        /// </summary>
        private void ClearSelectedNote()
        {
            noteRichTextbox.Text = " ";
            titleLabel.Text = "Note Title";
            noteCategoryLabel.Text = " ";
        }

        /// <summary>
        /// Обновление списка заметок при смене активной категории
        /// </summary>
        private void UpdateComboBoxCategory()
        {
            var selected = categoryComboBox.SelectedItem;
            noteListBox.Items.Clear();
            if (selected.ToString() == categoryAll)
            {
                _currentNotes = _project.Notes;
                for (int i = 0; i < _currentNotes.Count; ++i)
                {
                    noteListBox.Items.Add(_currentNotes[i].Title);
                }
            }
            else
            {
                var selectedNotesByCategory =
                    from notes in _project.Notes
                    where (categoryComboBox.SelectedIndex == (int)notes.Category)
                    select notes;
                List<Note> selectedNotesByCategoryList = selectedNotesByCategory.ToList();
                _currentNotes = selectedNotesByCategoryList;
                for (int i = 0; i < _currentNotes.Count; ++i)
                {
                    noteListBox.Items.Add(_currentNotes[i].Title);
                }
            }
            UpdateListView();
        }

        //В project
        /// <summary>
        /// Сортировка ListBox по дате обновления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortListBox()
        {
            noteListBox.Items.Clear();
            var orderedSelectedNotesByUpdateTime =
                from notes in _project.Notes
                orderby notes.UpdateTime descending
                select notes;
            List<Note> orderedSelectedNotesByUpdateTimeList = orderedSelectedNotesByUpdateTime.ToList();
            _currentNotes = orderedSelectedNotesByUpdateTimeList;
            for (int i = 0; i < _currentNotes.Count; ++i)
            {
                noteListBox.Items.Add(_currentNotes[i].Title);
            }
            _project.Notes = _currentNotes;
            UpdateComboBoxCategory();
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ProjectManager.SaveToFile(_project, FileName);
            DialogResult result = MessageBox.Show(@"Do you really want to exit the app? ",
                                                   "Message",
                                                    MessageBoxButtons.OKCancel,
                                                    MessageBoxIcon.Stop,
                                                    MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}