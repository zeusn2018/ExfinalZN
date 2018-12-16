namespace ExamenParcial
{
    public class HugeFlash : Storage
    {
        private string description;

        public HugeFlash()
        {
            this.type = StorageType.Flash;
            this.size = StorageSize.Huge;
            this.price = 900;
            this.description = string.Format("Storage: {0} ", this.type.ToString());
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