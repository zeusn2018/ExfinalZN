using System;

namespace ExamenFinal.Pregunta5
{
    class Client5
    {
        static void Main(string[] args)
        {
            Sandwich LargeBreadSandwich = new SmallBreadSandwich();

            LargeBreadSandwich = new Egg(LargeBreadSandwich);
            LargeBreadSandwich = new Chicken(LargeBreadSandwich);
            LargeBreadSandwich = new Bacon(LargeBreadSandwich);
            LargeBreadSandwich = new Beef(LargeBreadSandwich);
            LargeBreadSandwich = new Turkey(LargeBreadSandwich);

            Console.WriteLine(LargeBreadSandwich.Make());              


            //LargeBreadSandwich largeBreadSandwich = new LargeBreadSandwich();
            //Console.WriteLine(smallBreadSandwich.Make());

            //ExtraBreadSandwich extraBreadSandwich = new ExtraBreadSandwich();
            //Console.WriteLine(smallBreadSandwich.Make());


            Console.ReadLine();
        }

        //public static double round(double value)
        //{
        //    DecimalFormat newFormat = new DecimalFormat("#.#");
        //    return Double.valueOf(newFormat.format(value));
        //}
    }
}
