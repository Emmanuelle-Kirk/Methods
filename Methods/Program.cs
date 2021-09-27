using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        //declarations
       static int score;
        static string name;
        static int exp;
        //method that shows the HUD
        static void ShowHUD()
        {
            //show hud:
            Console.WriteLine("----------");
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Exp: " + exp);
            Console.WriteLine("----------");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //Methods
            //(AKA procedures, functions, ...)


            //declarations
            name = "Arachne";

            //...

            //initialize


            //hud
            ShowHUD();

            //simulated gameplay

            score = score + 100;
            exp = exp + 50;

            //hud

            ShowHUD();

            Console.ReadKey(true);
        }
    }
}
