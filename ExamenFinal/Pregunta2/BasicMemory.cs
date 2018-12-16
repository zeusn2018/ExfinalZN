namespace ExamenParcial
{
    public class BasicMemory : Memory
    {
        private string description;

        public BasicMemory()
        {
            this.type = MemoryType.DDR3;
            this.size = MemorySize.Basic;
            this.frequency = MemorySpeed.Fast;
            this.price = 200;
            this.description = string.Format("Memory: {0} {1} {2}", this.type.ToString(), this.size.ToString(), this.frequency.ToString());
        }

        public string getDescription()
        {
            return description;
        }
    }
}