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
    public static class ProjectManager
    {
        public static string FileName { get; private set; } = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
            + @"\NoteApp\NoteApp.txt";

        public static void SaveToFile(Project project, string path)
        {
            if (!Directory.Exists(Path.GetDirectoryName(path)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path));
            }
            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter stream = new StreamWriter(path)) 
            using (JsonWriter writer = new JsonTextWriter(stream))
            {
                serializer.Serialize(writer, project);
            }

;        }

        public static Project LoadFromFile(string path)
        {
            Project project = new Project();
            if (!File.Exists(path))
            {
                return project;
            }
            using (StreamReader stream =  new StreamReader(path))
            {
                string projectContent = stream.ReadLine();
                if (string.IsNullOrEmpty(projectContent))
                {
                    return project;
                }
                try
                {
                    project = JsonConvert.DeserializeObject<Project>(projectContent);
                }
                catch
                {
                    return project;
                }
            }
            return project;
        }
    }
}
