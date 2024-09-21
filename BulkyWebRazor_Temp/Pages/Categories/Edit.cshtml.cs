using BulkyWebRazor_Temp.Data;
using BulkyWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Categories
{
    [BindProperties]
    public class EditModel : PageModel
    {

        private readonly AppDbContext _dbContext;

        public Category Category { get; set; }

        public EditModel(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;

        }

        public void OnGet(int? id)
        {
            if (id != null && id != 0)
                Category = _dbContext.Categories.Find(id);
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _dbContext.Categories.Update(Category);
                _dbContext.SaveChanges();
                // TempData["success"] = "Category Updated Successfully...";
                return RedirectToPage("Index");
            }
            return Page();

        }
    }
}
