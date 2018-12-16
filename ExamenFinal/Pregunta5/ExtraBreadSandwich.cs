using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.Pregunta5
{
    public class ExtraBreadSandwich: Sandwich
    {
        public ExtraBreadSandwich()
        {
            this.description = "ExtraBreadSandwich";
        }

        public override double calculateCost()
        {
            return 7.00;
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
