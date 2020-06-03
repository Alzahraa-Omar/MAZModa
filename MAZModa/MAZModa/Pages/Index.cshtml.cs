using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MAZModa.Data;
using MAZModa.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MAZModa.Pages
{
    public class IndexModel : PageModel
    {
        public MAZModaDbContext Context { get; set; }
        private readonly ILogger<IndexModel> _logger;
       

        public IndexModel(ILogger<IndexModel> logger )
        {
            _logger = logger;
            
        }

        public void OnGet()
        {
            //var wanted_style = Context.Photo.Find(ID);
            //if (wanted_style != null)
            //{
            //    ICollection<string> all = Context.Photo.Where(p => p.Id == ID).Select(P => P.PhotoPath).ToList();

            //    RedirectToPage("ShowStyle", all);
            //}
        }
       
    }
}

