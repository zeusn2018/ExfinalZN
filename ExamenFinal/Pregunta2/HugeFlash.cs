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
            this.description = string.Format("Storage: {0} {1}", this.type.ToString(), this.size.ToString());
        }

        public string getDescription()
        {
            return description;
        }
    }
}