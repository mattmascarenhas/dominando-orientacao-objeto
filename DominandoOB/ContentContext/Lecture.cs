using DominandoOB.ContentContext.Enums;
using DominandoOB.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominandoOB.ContentContext
{
    public class Lecture: Base {
        public int Order { get; set; }
        public string Title { get; set; }
        public EContentLevel Level { get; set; }
    }
}
