namespace GestioneStudenti.Services
{
    public interface IStorage
    {
        public void AddStudent(Student s);
        public void SaveStudent(Student s);
        public List<Student> GetStudents();
        public Student GetStudent(int id);
        public void DeleteStudent(int id);
    }
}
