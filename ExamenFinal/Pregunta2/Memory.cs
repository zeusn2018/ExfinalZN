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

        //public MemoryType getType()
        //{
        //    return type;
        //}

        //public MemorySize getSize()
        //{
        //    return size;
        //}

        //public MemorySpeed getFrequency()
        //{
        //    return frequency;
        //}

        //public float getPrice()
        //{
        //    return price;
        //}

        //public override string ToString()
        //{
        //    return this.type.ToString() + " | " + EnumExtensions.GetMemorySize(this.size) + " | " + EnumExtensions.GetMemorySpeed(this.frequency) + " | " + this.price;
        //}
    }
}