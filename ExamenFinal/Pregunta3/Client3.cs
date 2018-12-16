using System;

namespace ExamenFinal.Pregunta3
{
    class Client3
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 5, 7, 78, 9, 2, 24, 38, 78, 91, 96, 4, 6, 17, 101, 24, 38, 47, 37, 148, 2, 589 };
            bool HasDuplicates;
            IStrategy HasDuplicateStrategy;
            foreach (ComplexityType complexityType in Enum.GetValues(typeof(ComplexityType)))
            {
                switch (complexityType)
                {
                    case ComplexityType.Lineal:
                        HasDuplicateStrategy = new HasDuplicateValuesLinealStrategy();
                        HasDuplicates = HasDuplicateStrategy.HasDuplicateValues(numbers);
                        Console.WriteLine(ComplexityType.Lineal.ToString() + " - HasDuplicates: " + HasDuplicates);
                        break;
                    case ComplexityType.Cuadratic:
                        HasDuplicateStrategy = new HasDuplicateValuesCuadraticStrategy();
                        HasDuplicates = HasDuplicateStrategy.HasDuplicateValues(numbers);
                        Console.WriteLine(ComplexityType.Cuadratic.ToString() + " - HasDuplicates: " + HasDuplicates);
                        break;
                    case ComplexityType.Exponential:
                        HasDuplicateStrategy = new HasDuplicateValuesExponentialStrategy();
                        HasDuplicates = HasDuplicateStrategy.HasDuplicateValues(numbers);
                        Console.WriteLine(ComplexityType.Exponential.ToString() + " - HasDuplicates: " + HasDuplicates);
                        break;
                }
            }
            Console.ReadLine();
        }

        //public static bool HasDuplicateValuesCuadratic(int[] numbers)
        //{
        //    return true;
        //}

        //public static bool HasDuplicateValuesLineal(int[] numbers)
        //{
        //    return true;
        //}

        //public static bool HasDuplicateValuesExponential(int[] numbers)
        //{
        //    return true;
        //}

    }
}
