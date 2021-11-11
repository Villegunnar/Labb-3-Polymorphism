using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3___Polymorphism
{
    class Cirkel : Teckning
    {
        public double pi = 3.14;
        public double Radius { get; set; }

        public Cirkel()
        {
            Radius = 6;
        }
        public override double Area()
        {

           return (Radius * Radius * pi);
        }

    }


}

