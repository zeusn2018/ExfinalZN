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