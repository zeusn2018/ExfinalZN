namespace ExamenParcial
{
    public class Memory
    {
        protected MemoryType type;
        protected MemorySize size;
        protected MemorySpeed frequency;
        protected float price;

        public MemoryType getType()
        {
            return type;
        }

        public MemorySize getSize()
        {
            return size;
        }

        public MemorySpeed getFrequency()
        {
            return frequency;
        }

        public float getPrice()
        {
            return price;
        }

        public override string ToString()
        {
            return this.type.ToString() + " | " + EnumExtensions.GetMemorySize(this.size) + " | " + EnumExtensions.GetMemorySpeed(this.frequency) + " | " + this.price;
        }
    }
}