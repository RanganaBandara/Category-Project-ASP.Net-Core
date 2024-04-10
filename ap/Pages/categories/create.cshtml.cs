using ap.Data;
using ap.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ap.Pages.categories
{
    public class createModel : PageModel
    {
        private readonly ApplicationDbContext _db;
		public Category Category { get; set; }

		public createModel(ApplicationDbContext db)
        {
            _db = db;

        }
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost(Category category)
        {

            if (category.name == category.displayorder.ToString())
            {
                ModelState.AddModelError("category.name", "cannot same");
            }
                if (ModelState.IsValid)
                {
                    await _db.category.AddAsync(category);
                    await _db.SaveChangesAsync();
                    return RedirectToPage("Index");
                }
            
            return Page();
        }
    }
}
