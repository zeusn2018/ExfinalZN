namespace ExamenParcial
{
    public abstract class Processor
    {
        protected ProcessorType type;
        protected ProcessorFrequency frequency;
        protected float price;

        public abstract ProcessorType getType();
        public abstract ProcessorFrequency getFrequency();
        public abstract float getPrice();
        public abstract override string ToString();
        public abstract string getDescription();
    }
}