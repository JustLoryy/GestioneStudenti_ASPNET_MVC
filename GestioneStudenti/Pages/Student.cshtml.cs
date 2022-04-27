using GestioneStudenti.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GestioneStudenti.Pages
{
    public class StudentModel : PageModel
    {
        [BindProperty]
        public Student student { get; set; }
        public readonly IStorage _storage;

        public StudentModel(IStorage storage)
        {
            _storage = storage;
        }
        public void OnGet(int id)
        {
            if (id == 0) student = new Student();
            else student = _storage.GetStudent(id);
        }
        public IActionResult OnPost()
        {
            if (student.id == 0) _storage.AddStudent(student);
            else _storage.SaveStudent(student);
            return Redirect("/");
        }
    }
}
