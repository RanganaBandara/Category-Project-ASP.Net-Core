using ap.Data;
using ap.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ap.Pages.categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public IEnumerable<Category> Categories { get; set; }

		public IndexModel(ApplicationDbContext db)
        {
            _db = db;

        }
        public void OnGet()
        {
            Categories = _db.category;
        }
    }
}
