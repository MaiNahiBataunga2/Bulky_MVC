using BulkyWebRazor_Temp.Data;
using BulkyWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Categories
{
    [BindProperties]
    public class CreateModel : PageModel
    {

        private readonly AppDbContext _dbContext;

        public Category Category { get; set; }

        public CreateModel(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;

        }

        public void OnGet()
        {

        }

        public IActionResult OnPost() 
        {
            _dbContext.Categories.Add(Category);
            _dbContext.SaveChanges();
            return RedirectToPage("Index");

        }
    }
}
