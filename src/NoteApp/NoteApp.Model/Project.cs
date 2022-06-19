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
        /// Геттеры и сеттеры для сборника заметок
        /// </summary>
        public List<Note> Notes { get; set; } = new List<Note>();


        public object Clone() => new Project();
    }
}