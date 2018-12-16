using System;

namespace ExamenFinal
{
    public abstract class Sandwich
    {
        public String description;

        public abstract String Make();

        public abstract String getDescription();

        public abstract double calculateCost();
    }
}
