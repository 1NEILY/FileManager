using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileManager
{
    class UsInterface
    {
        string gpath { get; set; }
        int currentlist { get; set; }

        public void SetDir(string St)
        {
            gpath = St;
            Directory.SetCurrentDirectory(St);
        }

        public static void Print(string s, int x, int y, ConsoleColor fg = ConsoleColor.White, ConsoleColor bg = ConsoleColor.Black)
        {
            Console.ForegroundColor = fg;
            Console.BackgroundColor = bg;
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }


        public static void PrintAllDirecCom(string path, int c)
        {
            var dirs = Directory.GetDirectories(path);
            if (dirs.Length <= 30 + c)
                for (int i = 0 + c; i < dirs.Length + c; i++)
                    UsInterface.Print(dirs[i], 3, i - c + 2);

            else
            {
                for (int i = 0 + c; i < 30 + c; i++)
                    UsInterface.Print(dirs[i], 3, i - c + 2);
            }

        }

        public static void PrintAllFiles(string path)
        {
            var dirs = Directory.GetFiles(path);
            if (dirs.Length <= 30)
                for (int i = 0; i < dirs.Length; i++)
                    UsInterface.Print(dirs[i], 65, i + 2);

            else
                for (int i = 0; i < 30; i++)
                    UsInterface.Print(dirs[i], 65, i + 2);
        }

        public static void PrintRect()
        {
            for (int i = 0; i < 120; i++)
            {
                Print("-", i, 0, ConsoleColor.DarkMagenta);
                Print("-", i, 35, ConsoleColor.DarkMagenta);
                Print("-", i, 37, ConsoleColor.DarkMagenta);
                Print("-", i, 39, ConsoleColor.DarkMagenta);
            }
            for (int i = 1; i < 38; i++)
            {
                Print("|", 0, i, ConsoleColor.DarkMagenta);
                Print("|", 119, i, ConsoleColor.DarkMagenta);
            }
            for (int i = 1; i < 35; i++)
            {
                Print("|", 60, i, ConsoleColor.DarkMagenta);
            }
        }

        public static void DoComand(string com, string com1)
        {
            if (com == "NewDir" && com1 != "...")
            {
                Directory.CreateDirectory(com1);
            }
            else if (com == "DelDir" && com1 != " ")
            {
                Directory.Delete(com1);
            }
            else if (com == "NewFile" && com1 != "...")
            {
                File.Create(com1); 
            }
            else if (com == "DelFile" && com1 != " ")
            {
                File.Delete(com1);
            }
        }
    }
}