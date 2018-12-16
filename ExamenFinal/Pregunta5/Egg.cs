using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.Pregunta5
{
    public class Egg : SandwichDecorator
    {
        public Egg(Sandwich sandwich) : base(sandwich)
        {
            this.description = "Egg";
        }

        
        public override String getDescription()
        {
            //return String.format("%s, %s", sandwich.getDescription(), this.description);
            return String.Format("%s, %s", sandwich.getDescription(), this.description);
        }

        
        public override double calculateCost()
        {
            return this.sandwich.calculateCost() + 1.00;
        }
    }
}
