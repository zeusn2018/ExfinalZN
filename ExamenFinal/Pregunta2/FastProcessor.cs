namespace ExamenParcial
{
    public class FastProcessor : Processor
    {
        private string description;

        public FastProcessor()
        {
            this.type = ProcessorType.DualCore;
            this.frequency = ProcessorFrequency.Fast;
            this.price = 320;
            this.description = string.Format("Processor: {0} {1}", this.type.ToString(), this.frequency.ToString());
        }

        public string getDescription()
        {
            return description;
        }
    }
}