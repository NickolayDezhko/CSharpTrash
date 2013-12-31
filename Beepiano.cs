
      
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beepiano
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;                 //Немного
            Console.WriteLine("Welcome to SqueZ`s Beepiano");             //    Интересного
            Console.WriteLine("                           ");             //         И красивого
            Console.ForegroundColor = ConsoleColor.Yellow;                //             Оформления
            while (true)
            {
            
                 ConsoleKeyInfo cki; //Клавиша
                 int CHC = 180;        //Начальная длительность ноты



            Console.TreatControlCAsInput = true;
            cki = Console.ReadKey();
            if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) CHC = 100;  //При нажатии на Shift длительность ноты уменьшается 
            //Основные ноты
            if (cki.Key == ConsoleKey.D1) Console.Beep(100, CHC);  
            if (cki.Key == ConsoleKey.D2) Console.Beep(200, CHC);
            if (cki.Key == ConsoleKey.D3) Console.Beep(300, CHC);
            if (cki.Key == ConsoleKey.D4) Console.Beep(400, CHC);
            if (cki.Key == ConsoleKey.D5) Console.Beep(500, CHC);
            if (cki.Key == ConsoleKey.D6) Console.Beep(600, CHC);
            if (cki.Key == ConsoleKey.D7) Console.Beep(700, CHC);
            if (cki.Key == ConsoleKey.D8) Console.Beep(800, CHC);
            if (cki.Key == ConsoleKey.D9) Console.Beep(900, CHC);
            if (cki.Key == ConsoleKey.D0) Console.Beep(1000, CHC);
            
            //#(диез) ноты
            if (cki.Key == ConsoleKey.Q) Console.Beep(150, CHC);
            if (cki.Key == ConsoleKey.W) Console.Beep(250, CHC);
            if (cki.Key == ConsoleKey.E) Console.Beep(350, CHC);
            if (cki.Key == ConsoleKey.R) Console.Beep(450, CHC);
            if (cki.Key == ConsoleKey.T) Console.Beep(550, CHC);
            if (cki.Key == ConsoleKey.Y) Console.Beep(650, CHC);
            if (cki.Key == ConsoleKey.U) Console.Beep(750, CHC);
            if (cki.Key == ConsoleKey.I) Console.Beep(850, CHC);
            if (cki.Key == ConsoleKey.O) Console.Beep(950, CHC);
            if (cki.Key == ConsoleKey.P) Console.Beep(1050, CHC);

                       
        }
    }
    }
}
