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