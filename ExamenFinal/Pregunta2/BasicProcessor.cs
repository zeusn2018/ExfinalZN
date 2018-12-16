namespace ExamenParcial
{
    public class BasicProcessor : Processor
    {
        private string description;

        public BasicProcessor()
        {
            this.type = ProcessorType.DualCore;
            this.frequency = ProcessorFrequency.Low;
            this.price = 250;
            this.description = string.Format("Processor: {0} {1}", this.type.ToString(), this.frequency.ToString());
        }

        public string getDescription()
        {
            return description;
        }
    }
}