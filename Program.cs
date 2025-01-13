using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            printTextWithConsoleWriteOnly();
        }

        static void printTextWithConsoleWriteLine()
        {
            Console.WriteLine("Printing some Text!");
        }

        static void printTextWithConsoleWriteOnly()
        {
            Console.Write("Write will not insert a new line at the end of the output like Write Line");
            Console.Write("**");
        }
    }

}