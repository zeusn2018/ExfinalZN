using System.Drawing;

namespace ExamenParcial
{
    public class BlackFinish : Finish
    {
        public BlackFinish()
        {
            color = Color.Black;
            price = 400;
            description = "Finish: Black";
        }
        public override Color getColor()
        {
            return color;
        }
        public override float getPrice()
        {
            return price;
        }
        public override string getDescription()
        {
            return description;
        }
        public override string ToString()
        {
            return this.description + " | " + this.price;
        }
    }
}