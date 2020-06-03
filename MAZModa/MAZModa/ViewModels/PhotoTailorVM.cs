using MAZModa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAZModa.ViewModels
{
    public class PhotoTailorVM
    {
        public Tailor Tailor { get; set; }

        public ICollection<TailorPhoto> TailorPhotoList { get; set; }
    }
}
