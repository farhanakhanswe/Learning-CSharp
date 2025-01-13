using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            explicitTypeCasting();
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

        static void implicitTypeCasting()
        {
            /*
             This happens automatically when converting a smaller data type to a larger data type because
             there's no risk of data loss.
                char -> int -> long -> float -> double
            */

            int myInt = 9;
            double myDouble = myInt; //Automatic casting int to double

            Console.WriteLine("Integer: " + myInt);
            Console.WriteLine("Double: " + myDouble);

        }

        static void explicitTypeCasting()
        {
            /* 
               This must be done manually. 
               Explicit Casting converts a larger type to a smaller type
            */

            double myDouble = 7.5;
            int myInt = (int)myDouble;

            Console.WriteLine("Double: " + myDouble);
            Console.WriteLine("myInt: " + myInt);
        }
    }

}