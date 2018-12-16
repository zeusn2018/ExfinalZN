using System.Drawing;

namespace ExamenParcial
{
    public class WhiteFinish : Finish
    {

        public WhiteFinish()
        {
            this.color = Color.White;
            this.price = 300;
            this.description = "Finish: White";
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