using System;

namespace ExamenFinal.Pregunta5
{
    public class LargeBreadSandwich : Sandwich
    {
        public LargeBreadSandwich()
        {
            this.description = "LargeBreadSandwich";
        }

        public override double calculateCost()
        {
            return 5.00;
        }

        public override string getDescription()
        {
            return this.description;
        }

        public override string Make()
        {
            return this.description;
        }
    }
}
