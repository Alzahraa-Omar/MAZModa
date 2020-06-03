using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MAZModa.Data;
using MAZModa.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MAZModa.Pages
{
    public class ShowStyleModel : PageModel
    {
        public MAZModaDbContext Context { get; set; }
        public ICollection<string> All { get; set; }
        private string _uid;
        public Customeuser Cuser { get; set; }
        private readonly UserManager<Customeuser> _userManager;

        public void OnGet(int ID)

        {
            
            var wanted_style = Context.Photo.Find(ID);
            if (wanted_style != null)
            {
                All = Context.Photo.Where(p => p.Id == ID).Select(P => P.PhotoPath).ToList();

              
             //ViewData["alls"]= Context.Photo.Where(p => p.Id == ID).Select(P => P.PhotoPath).ToList();
            }

        }
        public IActionResult OnPost()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToPage("Login");
            }

            _uid = _userManager.GetUserId(User);
            Cuser = Context.Users.Find(_uid);
            return Page();
        }

    }
}