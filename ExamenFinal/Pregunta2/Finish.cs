﻿using System.Drawing;

namespace ExamenParcial
{
    public class Finish
    {
        protected Color color;
        protected float price;
        protected string description;

        public Color getColor()
        {
            return color;
        }

        public float getPrice()
        {
            return price;
        }

        public string getDescription()
        {
            return description;
        }

        public override string ToString()
        {
            return this.description + " | " + this.price;
        }
    }
}