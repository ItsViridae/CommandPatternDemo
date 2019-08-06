using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternDemo.Abstract
{
    public interface ICommand
    {
        void Execute();
        void Unexecute();
    }
}
