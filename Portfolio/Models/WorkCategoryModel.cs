using Portfolio.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class WorkCategoryModel
    {
        public List<Work> Works { get; set; }
        public List<Category> Categories { get; set; }
        public List<Photo> Photos { get; set; }
    }
}
