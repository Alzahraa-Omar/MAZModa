using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MAZModa.Data;
using MAZModa.Models;
using MAZModa.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace MAZModa.Pages
{
    public class AddStyleModel : PageModel
    {
        public MAZModaDbContext context { get; set; }

        
        //[BindProperty]
        //public StylePhoto StylePhotoVM { get; set; }
        
        public AddStyleModel(MAZModaDbContext _context)
        {
            context = _context;
            
        }
        public void OnGet()
        {

        }
        //public void OnPost(Style _style)
        //{
        //    context.Style.Add(_style);
        //    context.SaveChanges();
        //}
        //public void Delete(int _Id)
        //{
        //    Style deletedStyle = context.Style.Find(_Id);
        //    context.Remove(deletedStyle);
        //    context.SaveChanges();
        //}


        public void OnPost(string _Description, int _GenderId, int _CategoryId, int _DressCodeId, int _AgeId, int _WeihgtId, int _HeightId,IFormFile pic)
        {
            Style NewStyle = new Style()
            {
                StyleDescription = _Description,
                GenderId = _GenderId,
                CategoryId = _CategoryId,
                DressCodeId= _DressCodeId,
                AgeId= _AgeId,
                WeightId= _WeihgtId,
                HeightId= _HeightId
            };
            context.Style.Add(NewStyle);
            context.SaveChanges();
            int styleId = context.Style.Where(s => s.StyleDescription == _Description && s.GenderId == _GenderId && s.CategoryId == _CategoryId
              && s.DressCodeId == _DressCodeId && s.AgeId == _AgeId && s.WeightId == _WeihgtId && s.HeightId == _HeightId).Select(s => s.Id).FirstOrDefault();
            uploadPhoto(pic,styleId);
        }

        public void uploadPhoto(IFormFile file ,int _styleId)
        {
            string fileName = file.FileName;
            string path = Path.Combine(Directory.GetCurrentDirectory(), "WWWroot/img/styles", fileName);
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(fs);
            }
            //then i have to add the new style photo to database 
            Photo NewStylePhoto = new Photo()
            {
                PhotoPath = fileName,
                StyleId = _styleId
            };
            context.Photo.Add(NewStylePhoto);
            context.SaveChanges();
        }
    }
}