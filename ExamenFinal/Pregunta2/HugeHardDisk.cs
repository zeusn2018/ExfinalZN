namespace ExamenParcial
{
    public class HugeHardDisk : Storage
    {
        private string description;

        public HugeHardDisk()
        {
            this.type = StorageType.HardDisk;
            this.size = StorageSize.Huge;
            this.price = 450;
            this.description = string.Format("Storage: {0} {1}", this.type.ToString(), this.size.ToString());
        }

        public string getDescription()
        {
            return description;
        }
    }
}