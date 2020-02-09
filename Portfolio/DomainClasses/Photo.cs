using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.DomainClasses
{
    public class Photo
    {
        public int PhotoID { get; set; }
        public int WorkID { get; set; }
        public string PhotoName { get; set; }
        public virtual Work Work { get; set; }


    }
}
