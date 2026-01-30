using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CountersFactory.bus
{
    [Serializable]
    [XmlInclude(typeof(ModuloNCounter))]
    [XmlInclude(typeof(StepCounter))]

    public abstract class Counter : ICountable, IPrintable //That's the Implementation
    {
        //Data member: (private fields)
        //Fields
        private int serialNumber;
        private int value;
        private EnumColor color;
        private Date madeDate;
        private EnumCounterType type;

        //Properties
        public int SerialNumber 
        {
            get { return this.serialNumber; } 
            set { this.serialNumber = value; }
        }
        public int Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
        public EnumColor Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        public Date MadeDate
        {
            get { return this.madeDate; }
            set { madeDate = value; }
        }
        public EnumCounterType Type 
        {
            get { return this.type; }
            set { this.type = value; }
        }

        //Methods
        //The following functions (Methods) are known as functions overloading
        //We have 5 overladed functions

        //This is a STATIC POLYMORPHISM known as compile-time polymorphism (each of the 5 overloaded functions has to behave according to the recieving arguments)
        public Counter() //function constructor, overloading function constructor
        {
            this.serialNumber = 0;
            this.value = 0;
            this.color = EnumColor.Undefined;
            this.madeDate = new Date();
            this.type = EnumCounterType.Undefined;
        }
        public Counter(int serialNumber, int value)
        {
            this.serialNumber = serialNumber;
            this.value = value;
            this.color = EnumColor.Undefined;
            this.madeDate = new Date();
            this.type = EnumCounterType.Undefined;
        }
        public Counter(int serialNumber, int value, EnumColor color)
        {
            this.serialNumber = serialNumber;
            this.value = value;
            this.color = color;
            this.madeDate = new Date();
            this.type = EnumCounterType.Undefined;
        }
        public Counter(int serialNumber, int value, EnumColor color, Date madeDate)
        {
            this.serialNumber = serialNumber;
            this.value = value;
            this.color = color;
            this.madeDate = madeDate;
            this.type = EnumCounterType.Undefined;
        }
        public Counter(int serialNumber, int value, EnumColor color, Date madeDate, EnumCounterType type)
        {
            this.serialNumber = serialNumber;
            this.value = value;
            this.color = color;
            this.madeDate = madeDate;
            this.type = type;
        }

        // - 2: Methods
        //The following functions (Methods) are known as functions overridden
        //We have many overridden functions

        //This is a DYNAMIC POLYMORPHISM (known as run-time polymorphism)
        //Run-time means execution time

        public virtual string GetState()
        {
            string state;
            state = this.serialNumber + " | " + this.value + " | " + this.color + " | " + this.madeDate.GetDateState() + " | " + this.type;
            return state;
        }

        public virtual void Reset()
        {
            this.value = 0;
        }

        //When a class contains at least 1 abstract methods this class MUST be abstract
        public abstract void Increment();
        public abstract void Decrement();

        public abstract void Increment(int value);
        public abstract void Decrement(int value);
    }
}
