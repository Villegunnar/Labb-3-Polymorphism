using System;
using System.Threading;
using System.Threading.Tasks;


namespace Labb_3___Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleSettings(10,70);
            do
            {

            TextPriter("Polymorphism", 50, 43);
            Teckning myCircle = new Cirkel();
            TextPriter("Area Cirkel:       "+ myCircle.Area() + " cm^2",50, 0);

            Teckning myFyrkant = new Fyrkant();
            TextPriter("Area Fyrkant:      " + myFyrkant.Area() + " cm^2", 50, 0);

            Teckning myRektangel = new Rektangel();
            TextPriter("Area Rektangel:    " + myRektangel.Area()+ " cm^2", 50, 0);
                TextPriter("Tryck enter för att köra programmet igen.");
                Console.ReadLine();
                Console.Clear();
            } while (true);
            
        }
        public static void TextPriter(string tempText = "", int temptextSpeed = 0 ,int tempCenterText = 0)
        {
            string text = tempText;
            int textSpeed = temptextSpeed;
            int centerText = tempCenterText;
            {
                Console.Write(String.Format("{0," + (Console.WindowWidth - centerText) + "}", ""));
            }
            
            for (int i = 0; i < text.Length; i++)
            {
                
                if (i == 0 || i == 9 || i == 18 || i == 27 || i == 34 || i == 43)
                {
                    
                    Console.ForegroundColor = ConsoleColor.Cyan;                 
                }
                if (i == 1 || i == 10 || i == 19 || i == 28 || i == 35 || i == 44)
                {
                    Console.ForegroundColor = ConsoleColor.Green;                
                }
                if (i == 2 || i == 11 || i == 20 || i == 29 || i == 36 || i == 45)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == 3 || i == 12 || i == 21 || i == 30 || i == 37 || i == 46)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                if (i == 4 || i == 13 || i == 22 || i == 31 || i == 38 || i == 47)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (i == 5 || i == 14 || i == 23 || i == 32 || i == 39 || i == 48)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                if (i == 6 || i == 15 || i == 24 || i == 33 || i == 40 || i == 49)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                if (i == 7 || i == 16 || i == 25 || i == 34 || i == 41 || i == 50)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                if (i == 8 || i == 17 || i == 26 || i == 35 || i == 42 || i == 51)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                }

                
                Thread.Sleep(textSpeed);
                Console.Write(text[i]);

            }
            
            Console.WriteLine();
        } // Skriver ut texten i olika färger
        static void ConsoleSettings(int tempWindowHeight = 25, int tempWindowWidth = 70)
        {
            Console.WindowHeight = tempWindowHeight;
            Console.WindowWidth = tempWindowWidth;
        }


    }
}
