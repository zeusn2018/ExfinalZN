namespace ExamenParcial
{
    public class SmallHardDisk : Storage
    {
        private string description;

        public SmallHardDisk()
        {
            this.type = StorageType.HardDisk;
            this.size = StorageSize.Small;
            this.price = 100;
            this.description = string.Format("Storage: {0} {1}", this.type.ToString(), this.size.ToString());
        }

        public string getDescription()
        {
            return description;
        }
    }
}