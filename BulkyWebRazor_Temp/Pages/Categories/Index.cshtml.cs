using BulkyWebRazor_Temp.Data;
using BulkyWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _dbContext;

        public List<Category> CategoryList { get; set; }

        public IndexModel(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
            
        }

        public void OnGet()
        {
            CategoryList = _dbContext.Categories.ToList();
        }
    }
}
