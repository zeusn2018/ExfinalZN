namespace ExamenParcial
{
    public class Processor
    {
        protected ProcessorType type;
        protected ProcessorFrequency frequency;
        protected float price;

        public ProcessorType getType()
        {
            return type;
        }

        public ProcessorFrequency getFrequency()
        {
            return frequency;
        }

        public float getPrice()
        {
            return price;
        }

        public override string ToString()
        {
            return this.type.ToString() + " | " + EnumExtensions.GetProcessorFrequency(this.frequency) + " | " + this.price;
        }
    }
}