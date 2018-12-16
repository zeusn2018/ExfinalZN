namespace ExamenParcial
{
    public class SmallFlash : Storage
    {
        private string description;

        public SmallFlash()
        {
            this.type = StorageType.Flash;
            this.size = StorageSize.Small;
            this.price = 500;
            this.description = string.Format("Storage: {0} {1}", this.ToString());
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