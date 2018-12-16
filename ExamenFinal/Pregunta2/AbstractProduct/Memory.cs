namespace ExamenParcial
{
    public abstract class Memory
    {
        protected MemoryType type;
        protected MemorySize size;
        protected MemorySpeed frequency;
        protected float price;

        public abstract MemoryType getType();
        public abstract MemorySize getSize();
        public abstract MemorySpeed getFrequency();
        public abstract float getPrice();
        public override abstract string ToString();
        public abstract string getDescription();
    }
}