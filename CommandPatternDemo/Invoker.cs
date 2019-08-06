using System;
using System.Collections.Generic;
using System.Text;
using CommandPatternDemo.Abstract;

namespace CommandPatternDemo
{
    class Invoker
    {
        private readonly ICommand _on;
        private readonly ICommand _off;
        private readonly ICommand _dim;
        private readonly ICommand _brighten;

        public Invoker(ICommand on, ICommand off, ICommand dim, ICommand brighten)
        {
            _on = on;
            _off = off;
            _dim = dim;
            _brighten = brighten;
        }

        public void ClickOn()
        {
            
        }

    }
}
