using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Model
{
    /// <summary>
    /// Представление сборника заметок
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Сборник заметок
        /// </summary>
        private Note[] _projects;

        /// <summary>
        /// Геттеры и сеттеры для сборника заметок
        /// </summary>
        public Note[] Projects
        {
            get
            {
                return _projects;
            }
            set
            {
                _projects = value;
            }
        }


    }
}
