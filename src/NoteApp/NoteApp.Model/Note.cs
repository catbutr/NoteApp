using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Model
{
    /// <summary>
    /// Перечисление категорий заметок
    /// </summary>
    public enum NoteCategory
    {
        Work,
        Home,
        Health,
        People,
        Documents,
        Finances,
        Miscellaneous
    }

    /// <summary>
    /// Описание заметки
    /// </summary>
    public class Note
    {
        /// <summary>
        /// Название заметки
        /// </summary>
        private string _noteTitle;

        /// <summary>
        /// Категория заметки
        /// </summary>
        private NoteCategory _noteCategory;

        /// <summary>
        /// Текст заметки
        /// </summary>
        private string _noteText;

        /// <summary>
        /// Время создания заметки
        /// </summary>
        private DateTime _noteCreationDate;

        /// <summary>
        /// Время обновления заметки
        /// </summary>
        private DateTime _noteUpdateDate;

        /// <summary>
        /// Возвращает или задаёт имя заметки
        /// </summary>
        public string Title
        {
            get
            {
                return _noteTitle;
            }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException($"number of charachters in the name should be less or equal to 50"
                        + $" but was {value.Length}");
                }
                _noteTitle = value;
                _noteUpdateDate = DateTime.Now;
            }
        }

        /// <summary>
        /// Возвращает или задаёт категорию заметки
        /// </summary>
        public NoteCategory Category
        {
            get
            {
                return _noteCategory;
            }
            set
            {
                _noteCategory = value;
                _noteUpdateDate = DateTime.Now;
            }
        }

        /// <summary>
        /// Возвращает или задаёт текст заметки
        /// </summary>
        public string Text
        {
            get
            {
                return _noteText;
            }
            set
            {
                _noteText = value;
                _noteUpdateDate = DateTime.Now;
            }
        }

        /// <summary>
        /// Возвращяет время создания заметки
        /// </summary>
        public DateTime CreationTime
        {
            get
            {
                return _noteCreationDate;
            }
            private set
            {
                _noteCreationDate = value;
            }
        }

        /// <summary>
        /// Возвращяет или задаёт время обновления заметки
        /// </summary>
        public DateTime UpdateTime
        {
            get
            {
                return _noteUpdateDate;
            }
            set
            {
                _noteUpdateDate = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр книги
        /// </summary>
        public Note(string title = "Без названия", NoteCategory category = NoteCategory.Miscellaneous, string text = "без текста")
        {
            Title = title;
            Category = category;
            Text = text;
            CreationTime = DateTime.Now;
        }
    }
}