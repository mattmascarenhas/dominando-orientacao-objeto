using DominandoOB.NotificationContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominandoOB.ContentContext {
    public class Article: Content {
        //article deriva de content, e está vazia, pois tudo que ela precisa ja está no content
        //não tem problema de uma classe que deriva de outra ficar vazia
        public Article(string title, string url): base(title, url) {
        }
    }
}
