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
            this.description = string.Format("Storage: {0} ", this.ToString());
        }

        public override StorageType getType()
        {
            return type;
        }

        public override StorageSize getSize()
        {
            return size;
        }

        public override float getPrice()
        {
            return price;
        }

        public override string ToString()
        {
            return this.type.ToString() + " | " + EnumExtensions.GetStorageSize(this.size) + " | " + this.price;
        }

        public override string getDescription()
        {
            return description;
        }
    }
}