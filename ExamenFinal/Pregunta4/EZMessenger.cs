using System;

namespace ExamenFinal.Pregunta4
{
    class EZMessenger : IMessaging
    {
        public void Send(string Message)
        {
            Console.WriteLine("Message '" + Message + "' sent via EZ");
        }
    }
}
