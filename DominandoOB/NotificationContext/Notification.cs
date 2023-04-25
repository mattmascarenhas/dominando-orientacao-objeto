using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominandoOB.NotificationContext {
    public sealed class Notification {
        //sealed nao deixa que essa classe seja extendida, por motivos de padronização
        public Notification() {

        }
        public Notification(string property, string message) {
            Property = property;
            Message = message;
        }

        public string Property { get; set; }
        public string Message { get; set; }

    }
}
