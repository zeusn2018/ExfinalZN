using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.Pregunta5
{
    public class SandwichDecorator : Sandwich
    {
        protected Sandwich sandwich;

        public SandwichDecorator(Sandwich sandwich)
        {
            this.sandwich = sandwich;
        }

        public override String Make()
        {
            return "1";
        }


        public override String getDescription()
        {
            return sandwich.description;
        }

        
        public override double calculateCost()
        {
            return sandwich.calculateCost();
        }



    }
}
