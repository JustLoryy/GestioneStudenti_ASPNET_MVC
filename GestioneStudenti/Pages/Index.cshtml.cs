using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GestioneStudenti.Services;

namespace GestioneStudenti.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IStorage _storage;

        public IndexModel(ILogger<IndexModel> logger, IStorage _ss)
        {
            _logger = logger;
            _storage = _ss;
        }

        public List<Student> Students => _storage.GetStudents();
    }
}