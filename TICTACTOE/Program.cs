using System;

namespace TICTACTOE
{
    class Program
    {
        static void Main(string[] args)
        {
            SetField();
            Console.ReadKey();
        }
        public static void SetField()
        {
            Console.WriteLine("     |     |     ");
            //Todo replace with vars
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", 1, 2, 3);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");

            //Todo replace with vars
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", 1, 2, 3);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");

            //Todo replace with vars
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", 1, 2, 3);
            Console.WriteLine("     |     |     ");

        }
    }
}
