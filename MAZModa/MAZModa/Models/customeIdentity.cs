using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAZModa.Models
{
    public class Customeuser:IdentityUser
    {
        public string Gender{ get; set; }
        public int Age { get; set; }
        public string Location { get; set; }

    }
    public class Customerole:IdentityRole
    {
        
        public Customerole():base() { }
        public Customerole( string roleName):base(roleName)
        {

        }
        

        

    }
}
