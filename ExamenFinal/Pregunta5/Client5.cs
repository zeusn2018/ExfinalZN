using System;

namespace ExamenFinal.Pregunta5
{
    class Client5
    {
        static void Main(string[] args)
        {
            SmallBreadSandwich smallBreadSandwich = new SmallBreadSandwich();
            Console.WriteLine(smallBreadSandwich.Make());
            LargeBreadSandwich largeBreadSandwich = new LargeBreadSandwich();
            Console.WriteLine(smallBreadSandwich.Make());
            ExtraBreadSandwich extraBreadSandwich = new ExtraBreadSandwich();
            Console.WriteLine(smallBreadSandwich.Make());


            Console.ReadLine();
        }
    }
}
