namespace ExamenParcial
{
    public class AdvancedMemory : Memory
    {
        private string description;

        public AdvancedMemory()
        {
            this.type = MemoryType.LPDDR3;
            this.size = MemorySize.Medium;
            this.frequency = MemorySpeed.Fast;
            this.price = 400;
            this.description = string.Format("Memory: {0} {1} {2}", this.type.ToString(), this.size.ToString(), this.frequency.ToString());
        }

        public string getDescription()
        {
            return description;
        }
    }
}