namespace rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rectangle program v1.0\n\n");

            Console.WriteLine("Hi! In this program you can create your own rectangle in CMD.\n\n\n");

            Console.WriteLine("What symbol would you like to use?");
            string character = Console.ReadLine();
            // I declare it in string because if the user gives multiple characters, I can store all of them.
            // But I will only use the first given one. So the program can run flawlessly and continuously
            Console.Clear();

            Console.WriteLine("How many columns should your rectangle have?");
            int column = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("How many rows should your rectangle have?");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Clear();


            Console.WriteLine("Here is your rectangle :) Bye!\n");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++) Console.Write(character[0]);

                Console.WriteLine();
            }

            Console.WriteLine("\n\nPlease press a button to exit");
            Console.ReadKey();
        }
    }
}