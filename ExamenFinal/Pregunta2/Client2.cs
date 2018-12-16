using ExamenFinal.Pregunta2;
using ExamenFinal.Pregunta2.ConcreteFactory;
using System;

namespace ExamenParcial
{
    public class Client2
    {
        //Aplicar el patrón Abstract Factory
        static void Main(string[] args)
        {

            //crear y ejecutar una computadora básica
            Computer basicComputer = new ComputerBasic();
            ComputerUniverse universe = new ComputerUniverse(basicComputer);
            Console.Write("Basic Computer:\n" + universe.RunCharacteristicsMemory()
                            + "\n" + universe.RunCharacteristicsProcessor()
                            + "\n" + universe.RunCharacteristicsStorage()
                            + "\n" + universe.RunCharacteristicsFinish());

            Console.WriteLine("\n**********************\n");
            
            //crear y ejecutar una computadora Developer
            Computer developerComputer = new ComputerDeveloper();
            universe = new ComputerUniverse(developerComputer);
            Console.Write("Developer Computer:\n" + universe.RunCharacteristicsMemory()
                            + "\n" + universe.RunCharacteristicsProcessor()
                            + "\n" + universe.RunCharacteristicsStorage()
                            + "\n" + universe.RunCharacteristicsFinish());

            Console.WriteLine("\n**********************\n");

            //crear y ejecutar una computadora de oficina
            Computer officeComputer = new ComputerOffice();
            universe = new ComputerUniverse(officeComputer);
            Console.Write("Office Computer:\n" + universe.RunCharacteristicsMemory()
                            + "\n" + universe.RunCharacteristicsProcessor()
                            + "\n" + universe.RunCharacteristicsStorage()
                            + "\n" + universe.RunCharacteristicsFinish());

            Console.WriteLine("\n**********************\n");

            //crear y ejecutar una computadora de alta gama
            Computer highendComputer = new ComputerHighEnd();
            universe = new ComputerUniverse(highendComputer);
            Console.Write("Office HighEnd:\n" + universe.RunCharacteristicsMemory()
                            + "\n" + universe.RunCharacteristicsProcessor()
                            + "\n" + universe.RunCharacteristicsStorage()
                            + "\n" + universe.RunCharacteristicsFinish());

            Console.ReadLine();
        }
    }
}
