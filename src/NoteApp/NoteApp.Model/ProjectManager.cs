using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NoteApp.Model
{
    /// <summary>
    /// Представление менеджера проекта
    /// </summary>
    public class ProjectManager
    {
        /// <summary>
        /// сериализированная строка
        /// </summary>
        private string _serialized;

        /// <summary>
        /// Константа пути
        /// </summary>
        private const string path = @"..\\My Documents\\NoteApp.notes";

        /// <summary>
        /// Конверсия значений в сериализированную строку и сохранение её в файл
        /// </summary>
        /// <param name="myProjects"></param>
        public ProjectManager(Project myProjects = null)
        {
            _serialized = JsonConvert.SerializeObject(myProjects);
            using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] buffer = Encoding.Default.GetBytes(_serialized);
                // запись массива байтов в файл
                fstream.Write(buffer, 0, buffer.Length);
                Console.WriteLine("Текст записан в файл");
            }
        }

        /// <summary>
        /// Десериализация строки
        /// </summary>
        /// <returns></returns>
        public Note Deserialize()
        {
            Note newNote = JsonConvert.DeserializeObject<Note>(_serialized);
            return newNote;
        }
    }
}
