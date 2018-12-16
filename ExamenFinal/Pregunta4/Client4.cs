using System;

namespace ExamenFinal.Pregunta4
{
    class Client4
    {
        static void Main(string[] args)
        {
            String Message = "Hello";            

            IMessaging ez = new EZMessenger();
            IMessaging quick = new QuickMessenger();
            IMessaging vip = new VIPMessenger();

            Console.WriteLine("SecureEZMessenger.....");
            AbstractMessenger ezmessenger = new SecureEZMessenger();

            ezmessenger.MessageSender = ez;
            ezmessenger.Send(Message);

            ezmessenger.MessageSender = quick;
            ezmessenger.Send(Message);

            ezmessenger.MessageSender = vip;
            ezmessenger.Send(Message);

            Console.WriteLine("\n");
            Console.WriteLine("SecureQuickMessenger.....");
            AbstractMessenger quickmessenger = new SecureQuickMessenger();

            quickmessenger.MessageSender = ez;
            quickmessenger.Send(Message);

            quickmessenger.MessageSender = quick;
            quickmessenger.Send(Message);

            quickmessenger.MessageSender = vip;
            quickmessenger.Send(Message);

            Console.WriteLine("\n");
            Console.WriteLine("SecureVIPMessenger.....");
            AbstractMessenger vipmessenger = new SecureVIPMessenger();

            vipmessenger.MessageSender = ez;
            vipmessenger.Send(Message);

            vipmessenger.MessageSender = quick;
            vipmessenger.Send(Message);

            vipmessenger.MessageSender = vip;
            vipmessenger.Send(Message);

            Console.WriteLine("\n");
            Console.WriteLine("SelfDestructingEZMessenger.....");
            AbstractMessenger desezmessenger = new SelfDestructingEZMessenger();

            desezmessenger.MessageSender = ez;
            desezmessenger.Send(Message);

            desezmessenger.MessageSender = quick;
            desezmessenger.Send(Message);

            desezmessenger.MessageSender = vip;
            desezmessenger.Send(Message);

            Console.WriteLine("\n");
            Console.WriteLine("SelfDestructingEZMessenger.....");
            //AbstractMessenger desquickmessenger = new SelfDestructingQuickMessenger();

            desquickmessenger.MessageSender = ez;
            desquickmessenger.Send(Message);

            desquickmessenger.MessageSender = quick;
            desquickmessenger.Send(Message);

            desquickmessenger.MessageSender = vip;
            desquickmessenger.Send(Message);

            //Console.WriteLine("\n");
            //Console.WriteLine("SelfDestructingVIPMessenger.....");
            //AbstractMessenger desvipmessenger = new SelfDestructingVIPMessenger();

            //desvipmessenger.MessageSender = ez;
            //desvipmessenger.Send(Message);

            //desvipmessenger.MessageSender = quick;
            //desvipmessenger.Send(Message);

            //desvipmessenger.MessageSender = vip;
            //desvipmessenger.Send(Message);

            //QuickMessenger quickMessenger = new QuickMessenger();
            //quickMessenger.Send(Message);

            //SecureQuickMessenger secureQuickMessenger = new SecureQuickMessenger();
            //secureQuickMessenger.Send(Message);

            //SelfDestructingQuickMessenger selfDestructingQuickMessenger = new SelfDestructingQuickMessenger();
            //selfDestructingQuickMessenger.Send(Message);

            //VIPMessenger vipMessenger = new VIPMessenger();
            //vipMessenger.Send(Message);

            //SecureVIPMessenger secureVIPMessenger = new SecureVIPMessenger();
            //secureVIPMessenger.Send(Message);

            //SelfDestructingVIPMessenger selfDestructingVIPMessenger = new SelfDestructingVIPMessenger();
            //selfDestructingVIPMessenger.Send(Message);

            //EZMessenger ezMessenger = new EZMessenger();
            //ezMessenger.Send(Message);

            //SecureEZMessenger secureEZMessenger = new SecureEZMessenger();
            //secureEZMessenger.Send(Message);

            //SelfDestructingEZMessenger selfDestructingEZMessenger = new SelfDestructingEZMessenger();
            //selfDestructingEZMessenger.Send(Message);

            Console.ReadLine();
        }
    }
}
