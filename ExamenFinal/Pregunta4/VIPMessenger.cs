using System;

namespace ExamenFinal.Pregunta4
{
    class VIPMessenger : IMessaging
    {
        public void Send(String Message)
        {
            Console.WriteLine("Message '" + Message + "' sent via P2P");
        }
    }
}
