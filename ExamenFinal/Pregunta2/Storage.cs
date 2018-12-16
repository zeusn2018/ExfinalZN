namespace ExamenParcial
{
    public class Storage
    {
        protected StorageType type;
        protected StorageSize size;
        protected float price;

        public StorageType getType()
        {
            return type;
        }

        public StorageSize getSize()
        {
            return size;
        }

        public float getPrice()
        {
            return price;
        }

        public override string ToString()
        {
            return this.type.ToString() + " | " + EnumExtensions.GetStorageSize(this.size) + " | " + this.price;
        }
    }
}