using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountersFactory.bus
{
    [Serializable]
    public class StepCounter : Counter
    {
        //Data member (private fields)
        //Fields
        private int steps;

        //Public property
        public int Steps 
        {
            get { return this.steps; }
            set { steps = value; }
        }

        //Methods
        //The following functions (Methods) are known as functions overloading

        //This is a STATIC POLYMORPHISM known as compile-time polymorphism (each overloaded function has to behave according to the recieving arguments)

        //Public Default Constructor (with parameters)
        public StepCounter() : base()
        {
            this.steps = 0;
        }
        public StepCounter(int serialNumber, int value) : base(serialNumber, value)
        {
            this.steps = 0;
        }
        public StepCounter(int serialNumber, int value, EnumColor color) : base(serialNumber, value, color)
        {
            this.steps = 0;
        }
        public StepCounter(int serialNumber, int value, EnumColor color, Date madeDate) : base(serialNumber, value, color, madeDate)
        {
            this.steps = 0;
        }
        public StepCounter(int serialNumber, int value, EnumColor color, Date madeDate, EnumCounterType type) : base(serialNumber, value, color, madeDate, type)
        {
            this.steps = 0;
        }
        public StepCounter(int serialNumber, int value, EnumColor color, Date madeDate, EnumCounterType type, int steps) : base(serialNumber, value, color, madeDate, type)
        {
            this.steps = steps;
        }

        // - 2: Methods
        //The following functions (Methods) are known as functions overridden
        //We have many overridden functions

        //This is a DYNAMIC POLYMORPHISM (known as run-time polymorphism)
        //Run-time means execution time

        public override string GetState()
        {
            string state;
            state = base.GetState() + " | " + this.steps;
            return state;
        }

        //the StepCounter class does not need to override the virtual method Reset() of the base class counter.
        //because the StepCounter will reset the value to 0 (it has the same behavior as the base class.

        //Overloaded functions (same name)
        public override void Increment()
        {
            this.Value = this.Value + 1;
        }
        public override void Increment(int value)
        {
            this.Value = this.Value + value;
        }

        //Overloaded functions (same name)
        public override void Decrement(int value)
        {
            this.Value = this.Value - value;
        }
        public override void Decrement()
        {
            this.Value = this.Value - 1;
        }
    }
}
