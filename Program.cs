using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            stringInterpolation();
            Console.ReadLine();
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
               Explicit Casting converts a larger type to a smaller type.
               double -> float -> long -> int -> char
            */

            double myDouble = 7.5;
            int myInt = (int)myDouble;

            Console.WriteLine("Double: " + myDouble);
            Console.WriteLine("myInt: " + myInt);
        }

        static void typeConversionMethods()
        {
            /* It is possible to convert data types explicitly by uisng built-in methods */

            /* 
              List of conversion methods:
                (1) Convert.ToBoolean()
                (2) Convert.ToDouble()
                (3) Convert.ToString()
                (4) Convert.ToInt32() -> Converts to int
                (5) Convert.ToInt64()(long) -> Converts to long
             */

            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt)); // convert int to string
            Console.WriteLine(Convert.ToString(myInt).GetType());// We can check datatype using GetType()

            Console.WriteLine(Convert.ToDouble(myInt)); // convert int to double
            Console.WriteLine(Convert.ToDouble(myInt).GetType());

            Console.WriteLine(Convert.ToInt32(myDouble)); // convert double to int
            Console.WriteLine(Convert.ToInt32(myDouble).GetType());

            Console.WriteLine(Convert.ToString(myBool)); // convert bool to string
            Console.Write(Convert.ToString(myBool).GetType());

        }

        static void getStringUserInput()
        {
            Console.WriteLine("Enter username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Username is: " + userName);
        }

        static void getIntUserInput()
        {
            Console.WriteLine("Enter a number:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number is: " + age);
        }

        static void stringInterpolation()
        {
            string text = "Hello World!";
            int date = 2;
            string line = $"{ text } Number is { date} !"; // Use $ at the beginning to indicate an interpolated string
            Console.WriteLine(line);
        }
    }

}