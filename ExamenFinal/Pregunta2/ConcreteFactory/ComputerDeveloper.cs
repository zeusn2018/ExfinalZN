using ExamenParcial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.Pregunta2.ConcreteFactory
{
    public class ComputerDeveloper: Computer
    {
        public override Memory memory()
        {
            return new AdvancedMemory();
        }
        public override Processor processor()
        {
            return new FastProcessor();
        }
        public override Storage storage()
        {
            return new MediumHardDisk();
        }
        public override Finish finish()
        {
            return new BlackFinish();
        }
    }
}
