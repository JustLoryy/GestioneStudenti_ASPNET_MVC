using GestioneStudenti.Data;
using Microsoft.AspNetCore.Mvc;

namespace GestioneStudenti.Services
{
    public class SimpleStorage : IStorage
    {
        //private readonly List<Student> _students = new List<Student>();
        private readonly ApplicationDbContext _context;

        public SimpleStorage(ApplicationDbContext context)
        {
            _context = context;
        }
       // private readonly ApplicationDbContext _context;
        public void AddStudent(Student s)
        {
            //ApplicationDbContext context = new ApplicationDbContext();
            _context.Students.Add(s);
            _context.SaveChanges();
            //s.id = _context.Students.
            //s.id = _students.Count + 1;
            //_students.Add(s);
        }
        public void SaveStudent(Student s)
        {
            //ApplicationDbContext context = new ApplicationDbContext();
             //_context.Students.Where(w => w.id == s.id).FirstOrDefault();
             _context.Students.Update(s);
            _context.SaveChanges();
            //_context.SaveChanges();
            //var index = _students.FindIndex(st => st.id == s.id);
            // _students[index] = s;
        }
        public List<Student> GetStudents()
        {
            return _context.Students.ToList();
        }
        public Student GetStudent(int id)
        {
            return _context.Students.Where(s => s.id == id).First();
        }
        public void DeleteStudent(int id)
        {
            var index = _context.Students.Where(st => st.id == id).First();
            _context.Students.Remove(index);
            _context.SaveChanges();
        }
    }
}
