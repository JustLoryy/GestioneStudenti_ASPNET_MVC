namespace GestioneStudenti.Services
{
    public class SimpleStorage : IStorage
    {
        private readonly List<Student> _students = new List<Student>();

        public void AddStudent(Student s)
        {
            s.id = _students.Count + 1;
            _students.Add(s);
        }
        public void SaveStudent(Student s)
        {
            var index = _students.FindIndex(st => st.id == s.id);
            _students[index] = s;
        }
        public List<Student> GetStudents()
        {
            return _students;
        }
        public Student GetStudent(int id)
        {
            return _students.First(s => s.id == id);
        }
        public void DeleteStudent(int id)
        {
            var index = _students.FindIndex(st => st.id == id);
            _students.RemoveAt(index);
        }
    }
}
