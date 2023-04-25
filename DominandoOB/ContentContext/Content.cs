using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DominandoOB.SharedContext;

namespace DominandoOB.ContentContext
{
    public abstract class Content: Base {
        public string Title { get; set; }
        public string Url { get; set; }

        public Content(string title, string url) {
            this.Title = title;
            this.Url = url;
        }
    }
}
