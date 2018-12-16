namespace ExamenParcial
{
    public class TurboProcessor : Processor
    {
        private string description;

        public TurboProcessor()
        {
            this.type = ProcessorType.DualCore;
            this.frequency = ProcessorFrequency.Turbo;
            this.price = 490;
            this.description = string.Format("Processor: %s %s", this.type.ToString(), this.frequency.ToString());
        }

        public string getDescription()
        {
            return description;
        }
    }
}