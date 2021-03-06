﻿namespace ExamenParcial
{
    public abstract class Computer
    {        
        public abstract Processor processor();
        public abstract Memory memory();       
        public abstract Storage storage();
        public abstract Finish finish();

        //public Computer(Finish finish, Storage storage, Processor processor, Memory memory)
        //{
        //    this.finish = finish;
        //    this.storage = storage;
        //    this.processor = processor;
        //    this.memory = memory;
        //}

        //public float getTotalPrice()
        //{
        //    return this.finish.getPrice() + this.storage.getPrice() + this.processor.getPrice() + this.memory.getPrice();
        //}

        //public string getDescription()
        //{
        //    return string.Format("Your configuration => \n{0} \n{1} \n{2} \n{3} \nTotal: {4:C2}", this.finish.ToString(), this.storage.ToString(), this.processor.ToString(), this.memory.ToString(), this.getTotalPrice());
        //}
    }
}