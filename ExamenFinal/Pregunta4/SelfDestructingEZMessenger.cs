using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.Pregunta4
{
    class SelfDestructingEZMessenger : AbstractMessenger
    {
        public override void Send(String Message)
        {
            Message = "☠" + Message + "☠";
            MessageSender.Send(Message);
            //base.Send(Message);
        }
    }
}
