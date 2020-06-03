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
    public class RecommendedShopsModel : PageModel
    {
        public MAZModaDbContext context { get; set; }

        public int RecommendedStyleId { get; set; }
        public ICollection<Shop> RecommendedShopsList { get; set; }
        public int ValueId { get; set; }
        public RecommendedShopsModel(MAZModaDbContext _context)
        {
            context = _context;
        }
        public void OnGet(int StyleId)
        {
            this.RecommendedStyleId = StyleId;
            ICollection<int> ShopIds = context.StyleShop.Where(shop => shop.StyleId == RecommendedStyleId).Select(shop => shop.ShopId).ToList();



            RecommendedShopsList = context.Shop.Where(sh => sh.Id == ValueId).ToList();


            foreach (var item in ShopIds)
            {

                Shop selectedShop = context.Shop.Find(item);
                RecommendedShopsList.Add(selectedShop);
            }

        }
    }
}