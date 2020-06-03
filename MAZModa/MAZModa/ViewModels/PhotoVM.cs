using MAZModa.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAZModa.ViewModels
{
    public class PhotoVM
    {
        public int Id { get; set; }
        public IFormFile Photo { get; set; }
        public int StyleId { get; set; }

        public virtual Style Style { get; set; }
    }
}
