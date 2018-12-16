using System.Drawing;

namespace ExamenParcial
{
    public abstract class Finish
    {
        protected Color color;
        protected float price;
        protected string description;

        public abstract Color getColor();
        public abstract float getPrice();
        public abstract string getDescription();
        public override abstract string ToString();
    }
}