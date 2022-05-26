using System;
using System.IO;

namespace FileManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 50;
            Console.WindowWidth = 120;
            Directory.SetCurrentDirectory(@"C:\");
            int n = 0;


            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                UsInterface.PrintRect();
                UsInterface.Print(Directory.GetCurrentDirectory(), 35, 1);
                UsInterface.PrintAllDirecCom(Directory.GetCurrentDirectory(), n);
                UsInterface.PrintAllFiles(Directory.GetCurrentDirectory());

                UsInterface.Print(" Enter Command  --->  ", 0, 36);
                string comand = Console.ReadLine();
                UsInterface.Print(" Enter NameFileOrDir --->  ", 0, 38);
                string comand1 = Console.ReadLine();
                UsInterface.DoComand(comand, comand1);

                var dirs = Directory.GetCurrentDirectory();

                if (comand == "Next" && dirs.Length >= 16)
                {
                    n++;
                    UsInterface.PrintAllDirecCom(Directory.GetCurrentDirectory(), n);
                }
                else if (comand == "Back" && n > 0)
                {
                    n--;
                    UsInterface.PrintAllDirecCom(Directory.GetCurrentDirectory(), n);
                }
            }
        }
    }
}