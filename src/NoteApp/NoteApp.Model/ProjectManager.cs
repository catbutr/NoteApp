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
    /// 
    /// </summary>
    public class ProjectManager
    {
        /// <summary>
        /// 
        /// </summary>
        private string _serialized;

        private const string path = @"..\\My Documents\\NoteApp.notes";

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

        public Note Deserialize()
        {
            Note newNote = JsonConvert.DeserializeObject<Note>(_serialized);
            return newNote;
        }
    }
}
