namespace ExamenParcial
{
    public class HighEndProcessor : Processor
    {
        private string description;

        public HighEndProcessor()
        {
            this.type = ProcessorType.QuadCore;
            this.frequency = ProcessorFrequency.Turbo;
            this.price = 900;
            this.description = string.Format("Processor: {0} {1}", this.type.ToString(), this.frequency.ToString());
        }

        public string getDescription()
        {
            return description;
        }
    }
}