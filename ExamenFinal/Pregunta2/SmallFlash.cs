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
            this.description = string.Format("Storage: {0} {1}", this.type.ToString(), this.size.ToString());
        }

        public string getDescription()
        {
            return description;
        }
    }
}