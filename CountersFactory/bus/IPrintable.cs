using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountersFactory.bus
{
    public interface IPrintable
    {
        public abstract string GetState(); //Get State has to return a string
    }
}
