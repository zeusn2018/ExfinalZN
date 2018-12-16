using System;

namespace ExamenFinal.Pregunta4
{
    class SecureEZMessenger: AbstractMessenger 
    {
        private String Encrypt(String Message)
        {
            Message = Message.Substring(Message.Length - 1) + Message.Substring(0, Message.Length - 1);
            return Message;
        }

        public override void Send(String Message)
        {
            Message = Encrypt(Message);
            MessageSender.Send(Message);
        }


    }
}
