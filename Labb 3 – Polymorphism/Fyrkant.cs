using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3___Polymorphism
{
    class Fyrkant : Teckning
    {
        public double lenght { get; set; }


        public Fyrkant()
        {
            lenght = 4;

        }
        public override double Area()
        {

            return (lenght * lenght);
        }
        public override void PrintInformation()
        {
            Console.WriteLine("");
        }

    }
}
