using System;

namespace ExamenFinal.Pregunta4
{
    class QuickMessenger: IMessaging
    {

        public void Send(string Message)
        {
            Console.WriteLine("Message '" + Message + "' sent via e-mail");
        }

        //public void Send(string Message)
        //{
        //    Console.WriteLine("Message '" + Message + "' sent via e-mail");
        //}

    }
}
