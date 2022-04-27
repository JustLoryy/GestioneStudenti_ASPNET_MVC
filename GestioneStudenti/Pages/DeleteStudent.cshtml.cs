using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GestioneStudenti.Services;

namespace GestioneStudenti.Pages
{
    public class DeleteStudentModel : PageModel
    {
        private readonly IStorage _storage;
        public Student student { get; set; }
        public DeleteStudentModel(IStorage storage)
        {
            _storage = storage;
        }
        public void OnGet(int id)
        {
            student = _storage.GetStudent(id);
        }
        public IActionResult OnPost(int id)
        {
            _storage.DeleteStudent(id);
            return Redirect("/");
        }
    }
}
