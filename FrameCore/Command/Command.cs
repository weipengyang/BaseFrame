using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseFrame.Core
{
    public abstract class Command : ICommand
    {
        public abstract void Run();
        public abstract bool Enable();
    }
}
