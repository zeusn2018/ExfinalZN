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
            this.description = string.Format("Memory: {0} {1} {2}", this.type.ToString(), this.size.ToString(), this.frequency.ToString());
        }

        public string getDescription()
        {
            return description;
        }
    }
}