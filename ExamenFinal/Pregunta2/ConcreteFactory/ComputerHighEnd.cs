using ExamenParcial;

namespace ExamenFinal.Pregunta2.ConcreteFactory
{
    public class ComputerHighEnd: Computer
    {
        public override Memory memory()
        {
            return new ProMemory();
        }
        public override Processor processor()
        {
            return new TurboProcessor();
        }
        public override Storage storage()
        {
            return new HugeHardDisk();
        }
        public override Finish finish()
        {
            return new WhiteFinish();
        }
    }
}
