using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MAZModa.Data;
using MAZModa.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MAZModa.Pages.Shared
{
    public class RecommendResultModel : PageModel
    {
        public MAZModaDbContext context { get; set; }
        public int StyleId { get; set; }

        public RecommendResultModel(MAZModaDbContext _context)
        {
            this.context = _context;
        }
        public void OnGet(int StyleId)
        {
            this.StyleId = StyleId;
        }
        public IActionResult OnPost()
        {
            return RedirectToPage("/RecommendedShops",new { StyleId = StyleId });
        }
    }
}