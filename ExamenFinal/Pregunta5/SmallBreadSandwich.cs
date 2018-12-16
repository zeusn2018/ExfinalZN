using System;

namespace ExamenFinal.Pregunta5
{
    public class SmallBreadSandwich : Sandwich
    { 
        
        public SmallBreadSandwich()
        {
            this.description = "SmallBreadSandwich";
        }
                
        public override String getDescription()
        {
            return this.description;
        }
                
        public override double calculateCost()
        {
            return 3.00;
        }

        public override string Make()
        {
            return this.description;
        }
    }
}
