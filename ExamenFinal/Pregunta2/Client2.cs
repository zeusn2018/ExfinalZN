using System;

namespace ExamenParcial
{
    public class Client2
    {
        static void Main(string[] args)
        {
            Computer basicComputer = new Computer(new WhiteFinish(), new SmallHardDisk(), new BasicProcessor(), new BasicMemory());
            Console.WriteLine("Basic Computer:\n" + basicComputer.getDescription());

            Console.WriteLine("\n**********************\n");

            Computer officeComputer = new Computer(new WhiteFinish(), new MediumHardDisk(), new FastProcessor(), new AdvancedMemory());
            Console.WriteLine("Office Computer:\n" + officeComputer.getDescription());

            Console.WriteLine("\n**********************\n");

            Computer developerComputer = new Computer(new BlackFinish(), new MediumHardDisk(), new FastProcessor(), new ProMemory());
            Console.WriteLine("Developer Computer:\n" + developerComputer.getDescription());

            Console.WriteLine("\n**********************\n");

            Computer highEndComputer = new Computer(new BlackFinish(), new HugeFlash(), new HighEndProcessor(), new ProMemory());
            Console.WriteLine("HighEnd Computer Computer:\n" + highEndComputer.getDescription());

            Console.ReadLine();
        }
    }
}