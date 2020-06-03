using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAZModa.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Describtion { get; set; }

        public string Title { get; set; }
        public string PhotoPath { get; set; }
        public string Date { get; set; }
        public bool IsDisplayed { get; set; }
    }
}
