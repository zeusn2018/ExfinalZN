namespace ExamenParcial
{
    public class ProMemory : Memory
    {
        private string description;

        public ProMemory()
        {
            this.type = MemoryType.LPDDR3;
            this.size = MemorySize.Pro;
            this.frequency = MemorySpeed.Fast;
            this.price = 600;
            this.description = string.Format("Memory: {0}", this.ToString());
        }

        public override MemoryType getType()
        {
            return type;
        }

        public override MemorySize getSize()
        {
            return size;
        }

        public override MemorySpeed getFrequency()
        {
            return frequency;
        }

        public override float getPrice()
        {
            return price;
        }

        public override string ToString()
        {
            return this.type.ToString() + " | " + EnumExtensions.GetMemorySize(this.size) + " | " + EnumExtensions.GetMemorySpeed(this.frequency) + " | " + this.price;
        }

        public override string getDescription()
        {
            return description;
        }
    }
}