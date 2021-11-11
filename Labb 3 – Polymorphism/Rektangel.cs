using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3___Polymorphism
{
    class Rektangel : Teckning
    {
        public double lenght { get; set; }
        public double width { get; set; }
        public Rektangel()
        {
            lenght = 5;
            width = 3;
        }
        public override double Area()
        {

            return (lenght * width);
        }
        public override void PrintInformation()
        {
            
        }
    }
}
