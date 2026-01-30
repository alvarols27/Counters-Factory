using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountersFactory.bus
{
    public interface ICountable
    {
        public abstract void Reset();

        //overloaded function
        public abstract void Increment();
        public abstract void Increment(int value);

        //overloaded function
        public abstract void Decrement();
        public abstract void Decrement(int value);
    }
}
