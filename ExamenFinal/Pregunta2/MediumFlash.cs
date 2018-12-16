namespace ExamenParcial
{
    public class MediumFlash : Storage
    {
        private string description;

        public MediumFlash()
        {
            this.type = StorageType.Flash;
            this.size = StorageSize.Medium;
            this.price = 650;
            this.description = string.Format("Storage: {0} {1}", this.type.ToString(), this.size.ToString());
        }

        public string getDescription()
        {
            return description;
        }
    }
}