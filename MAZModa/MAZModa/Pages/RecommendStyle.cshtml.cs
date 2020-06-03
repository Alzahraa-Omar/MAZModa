using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MAZModa.Data;
using MAZModa.Models;
using MAZModa.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MAZModa.Pages
{
    //[Authorize(Roles="Shop")]
    //[Authorize(Roles = "Tailor")]
    //[Authorize(Roles = "User")]
    public class RecommendStyleModel : PageModel
    {
       
        public MAZModaDbContext context { get; set; }

        public int selectedStyleId { get; set; }
        public RecommendStyleModel(MAZModaDbContext _context)
        {
            this.context = _context;
        }

        public void OnGet()
        {
            
        }

        public IActionResult OnPost(int _GenderId, int _CategoryId, int _DressCodeId, int _AgeId, int _WeihgtId, int _HeightId)
        {
            selectedStyleId = context.Style.Where(s => s.GenderId == _GenderId && s.CategoryId == _CategoryId
                && s.AgeId == _AgeId && s.DressCodeId == _DressCodeId && s.WeightId == _WeihgtId
                && s.HeightId == _HeightId).Select(s => s.Id).FirstOrDefault();
            if (selectedStyleId == 0)
            {
                if (_GenderId == 2)
                    selectedStyleId = 73;
                else
                    selectedStyleId = 74;
            }
            if (_GenderId == 0 || _CategoryId == 0 || _DressCodeId == 0 || _AgeId == 0 || _WeihgtId == 0 || _HeightId == 0)
            {
                
            }
            return RedirectToPage("/Shared/RecommendResult", new { StyleId = selectedStyleId });
        }

        //public void OnPost(int _GenderId, int _CategoryId, int _DressCodeId, int _AgeId, int _WeihgtId, int _HeightId)
        //{
        //    selectedStyleId = context.Style.Where(s => s.GenderId == _GenderId && s.CategoryId == _CategoryId
        //        && s.AgeId == _AgeId && s.DressCodeId == _DressCodeId && s.WeightId == _WeihgtId
        //        && s.HeightId == _HeightId).Select(s => s.Id).FirstOrDefault();
        //}
    }
}