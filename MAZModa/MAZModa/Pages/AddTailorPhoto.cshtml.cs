using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MAZModa.Data;
using MAZModa.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MAZModa.Pages
{
    public class AddTailorPhotoModel : PageModel
    {
        public MAZModaDbContext context { get; set; }
        public UserManager<Customeuser> _userManager { get; set; }
        public string CurrentUserId { get; set; }
        public Tailor CurrentTailor { get; set; }
        public TailorPhoto NewTailorPhoto { get; set; }

        public AddTailorPhotoModel(MAZModaDbContext _context)
        {
            context = _context;
        }
        public void OnGet()
        {
            //CurrentUserId = _userManager.GetUserId(User);
            //CurrentTailor = context.Tailor.Where(t => t.UserId == CurrentUserId).FirstOrDefault();
        }
        public void OnPost(IFormFile pic)
        {
            uploadPhoto(pic);
        }
        public void uploadPhoto(IFormFile file)
        {
            string fileName = file.FileName;
            string path = Path.Combine(Directory.GetCurrentDirectory(), "WWWroot/img/TailorPhotos", fileName);
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(fs);
            }
            //then i have to add the new tailor photo to database so i need to know the current user logined id 
            //NewTailorPhoto.PhotoPath = fileName;
            //NewTailorPhoto.TailorId = context.Tailor.Where(t => t.UserId == CurrentUserId).Select(t => t.Id).FirstOrDefault();
            //context.TailorPhoto.Add(NewTailorPhoto);
            //context.SaveChanges();
        }
    }
}