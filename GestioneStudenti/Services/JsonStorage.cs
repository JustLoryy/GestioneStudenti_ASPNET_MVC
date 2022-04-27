using Newtonsoft.Json;
namespace GestioneStudenti.Services
{
    public class JsonStorage : IStorage
    {
        private const string filePath = "db.json";
        private readonly List<Student> students;
        public JsonStorage()
        {
            if (File.Exists(filePath))
            {
                var jsonString = File.ReadAllText(filePath);
                students = JsonConvert.DeserializeObject<List<Student>>(jsonString);
            }
            else
            {
                students = new List<Student>();
            }
        }

        public void AddStudent(Student s)
        {
            s.id = students.Count + 1;
            students.Add(s);
            SaveJsonData();
        }
        public void DeleteStudent(int id)
        {
            var index = students.FindIndex(st => st.id == id);
            students.RemoveAt(index);
            SaveJsonData();
        }
        public Student GetStudent(int id)
        {
            return students.First(s => s.id == id);
        }
        public List<Student> GetStudents()
        {
            return students;
        }
        public void SaveStudent(Student s)
        {
            var index = students.FindIndex(st => st.id == s.id);
            students[index] = s;
            SaveJsonData();
        }
        public void SaveJsonData()
        {
            var jsonString = JsonConvert.SerializeObject(students);
            File.WriteAllText(filePath, jsonString);
        }
    }
}
