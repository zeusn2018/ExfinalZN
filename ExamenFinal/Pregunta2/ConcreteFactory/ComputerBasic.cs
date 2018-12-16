using ExamenParcial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.Pregunta2.ConcreteFactory
{
    public class ComputerBasic: Computer
    {
        public override Memory memory()
        {
            return new BasicMemory();
        }
        public override Processor processor()
        {
            return new BasicProcessor();
        }
        public override Storage storage()
        {
            return new SmallHardDisk();
        }
        public override Finish finish()
        {
            return new BlackFinish();
        }
    }
}
