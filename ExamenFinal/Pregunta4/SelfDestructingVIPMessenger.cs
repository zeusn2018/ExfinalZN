using System;

namespace ExamenFinal.Pregunta4
{
    class SelfDestructingVIPMessenger : AbstractMessenger
    {
        public override void Send(String Message)
        {
            Message = "☠" + Message + "☠";
            MessageSender.Send(Message);
            //base.Send(Message);
        }
    }
}
