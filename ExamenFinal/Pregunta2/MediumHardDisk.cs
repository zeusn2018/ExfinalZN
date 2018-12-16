namespace ExamenParcial
{
    public class MediumHardDisk : Storage
    {
        private string description;

        public MediumHardDisk()
        {
            this.type = StorageType.HardDisk;
            this.size = StorageSize.Medium;
            this.price = 300;
            this.description = string.Format("Storage: {0} {1}", this.type.ToString(), this.size.ToString());
        }

        public string getDescription()
        {
            return description;
        }
    }
}