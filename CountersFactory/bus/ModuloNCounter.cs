using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountersFactory.bus
{
    [Serializable]
    public class ModuloNCounter : Counter
    {
        //Data member: (private fields)
        //Fields
        private int maxLimit;

        //Public Property
        public int MaxLimit
        {
            get { return this.maxLimit; }
            set { this.maxLimit = value; }
        }
        public ModuloNCounter() : base()
        {
            this.maxLimit = 0;
        }
        public ModuloNCounter(int serialNumber, int value) : base(serialNumber, value)
        {
            this.maxLimit = 0;
        }
        public ModuloNCounter(int serialNumber, int value, EnumColor color) : base(serialNumber, value, color)
        {
            this.maxLimit = 0;
        }
        public ModuloNCounter(int serialNumber, int value, EnumColor color, Date madeDate) : base(serialNumber, value, color, madeDate)
        {
            this.maxLimit = 0;
        }
        public ModuloNCounter(int serialNumber, int value, EnumColor color, Date madeDate, EnumCounterType type) : base(serialNumber, value, color, madeDate, type)
        {
            this.maxLimit = 0;
        }
        public ModuloNCounter(int serialNumber, int value, EnumColor color, Date madeDate, EnumCounterType type, int maxLimit) : base(serialNumber, value, color, madeDate, type)
        {
            this.maxLimit = maxLimit;
        }

        // - 2: Methods
        //The following functions (Methods) are known as functions overridden
        //We have many overridden functions

        //This is a DYNAMIC POLYMORPHISM (known as run-time polymorphism)
        //Run-time means execution time

        public override string GetState()
        {
            string state;
            state = base.GetState() + " | " + this.maxLimit;
            return state;
        }

        //1- the ModuloNCounter class CAN to override the virtual method Reset() of the base class counter.
        //the value must be reset to 1

        //2- the ModuloNCounter class MUST override the abstract method of the base class Counter

        public override void Reset()
        {
            this.Value = 1;
        }

        //Overloaded functions (same name)
        public override void Increment()
        {
            this.Value = this.Value + 2;
        }
        public override void Increment(int value)
        {
            this.Value = this.Value + value;
        }

        //Overloaded functions (same name)
        public override void Decrement()
        {
            this.Value = this.Value - 2;
        }
        public override void Decrement(int value)
        {
            this.Value = this.Value - value;
        }
    }
}
