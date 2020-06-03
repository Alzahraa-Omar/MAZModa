using MAZModa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAZModa.ViewModels
{
    public class StylePhoto
    {
        public Style Style { get; set; }
        public ICollection<Photo> Photos { get; set; }
    }
}
