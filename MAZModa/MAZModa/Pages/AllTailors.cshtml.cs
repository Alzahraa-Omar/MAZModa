using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MAZModa.Data;
using MAZModa.Models;
using MAZModa.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MAZModa.Pages
{
    public class AllTailorsModel : PageModel
    {
        
        public MAZModaDbContext context { get; set; }
        

        public ICollection<Tailor> Tailors { get; set; }
        public AllTailorsModel(MAZModaDbContext _context)
        {
            context = _context;
            Tailors = context.Tailor.OrderByDescending(t => t.Rate).ToList();

        }

        public void OnGet()
        {
           
        }
    }
}