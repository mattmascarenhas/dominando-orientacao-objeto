using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominandoOB.ContentContext {
    public class Career: Content {
        public IList<CareerItem> Items { get; set; }
        public int TotalCourse => Items.Count; // seria o get, nao tem o set nessa prop

        public Career(string title, string url) : base(title, url) {
            this.Items = new List<CareerItem>();
        }
    }

}
