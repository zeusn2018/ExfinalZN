namespace ExamenParcial
{
    public abstract class Storage
    {
        protected StorageType type;
        protected StorageSize size;
        protected float price;

        public abstract StorageType getType();
        public abstract StorageSize getSize();
        public abstract float getPrice();
        public abstract override string ToString();
        public abstract string getDescription();
    }
}