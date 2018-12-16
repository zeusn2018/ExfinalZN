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
            this.description = string.Format("Processor: {0} ", this.ToString());
        }

        public override ProcessorType getType()
        {
            return type;
        }

        public override ProcessorFrequency getFrequency()
        {
            return frequency;
        }

        public override float getPrice()
        {
            return price;
        }

        public override string ToString()
        {
            return this.type.ToString() + " | " + EnumExtensions.GetProcessorFrequency(this.frequency) + " | " + this.price.ToString();
        }

        public override string getDescription()
        {
            return description;
        }
    }
}