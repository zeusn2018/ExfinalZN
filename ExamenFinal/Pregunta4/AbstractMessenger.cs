using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.Pregunta4
{
    public abstract class AbstractMessenger
    {
        public IMessaging MessageSender { get; set; }
        public abstract void Send(String Message);

    }
}
