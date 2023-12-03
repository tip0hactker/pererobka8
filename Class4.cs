using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pererobka8
{
    public abstract class AbstractFactory
    {
        public abstract IScreen CreateScreen();
        public abstract IProcessor CreateProcessor();
    }
}