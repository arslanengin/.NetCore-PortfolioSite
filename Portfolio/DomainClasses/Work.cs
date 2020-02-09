using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.DomainClasses
{
    public class Work
    {
        public int WorkID{ get; set; }
        public string WorkName { get; set; }
        public string WorkDescription { get; set; }

        public int CategoryID { get; set; }
        public string MainPhoto { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
    }
}
