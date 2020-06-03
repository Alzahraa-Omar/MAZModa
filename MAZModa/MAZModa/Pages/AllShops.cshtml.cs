using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MAZModa.Data;
using MAZModa.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MAZModa.Pages
{
    public class AllShopsModel : PageModel
    {
        public MAZModaDbContext context { get; set; }
        public Shop shop { get; set; }
        public AllShopsModel(MAZModaDbContext _context)
        {
            context = _context;
        }
        public void OnGet()
        {

        }
    }
}