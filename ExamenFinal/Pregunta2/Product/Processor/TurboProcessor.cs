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