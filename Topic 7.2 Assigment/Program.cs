namespace Topic_7._2_Assigment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment 1

            Console.WriteLine("Assignment 1");
            Console.WriteLine("");
            Console.WriteLine("I shall count down from ten before blasting the rocket to the sky.");
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();
            for (int i = 10; i >= 1; i = i - 1)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
                if (i == 1)
                {
                    Console.WriteLine("BLAST OFF!");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Press enter for next part");
            Console.ReadLine();
            Console.Clear();

            //Assigment 2

            Console.WriteLine("I can count the variable ‘x’ go from -10 to 10, counting by 2’s and the variable 'y' make the current value of the x, squared.");
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();

            Console.WriteLine("\t X \t Y");
            for (int i = -10; i <= 10; i = i + 2)
            {
                Console.WriteLine("\t" + i + "\t" + Math.Pow(i, 2));
                Thread.Sleep(500);
            }
            Console.WriteLine();
            Console.WriteLine("Press enter for next part");
            Console.ReadLine();
            Console.Clear();

            //Assignment 3

            string name;

            Console.WriteLine("I will write your name 10 times one you insert in the prompt it but I will write Aldworth 5 times.");
            Console.Write("Name:");
            name = Console.ReadLine();

            if (name != "Aldworth" && name != "Mr. Aldworth" && name != "aldworth" && name != "mr aldworth" && name != "Mr Aldoworth" && name != "mr Aldworth")
            {
                for (int i = 0; i <= 9; i = i + 1)
                {
                    Console.WriteLine(name);
                }

            }
            else
            {
                for (int i = 0; i <= 4; i = i + 1)
                {
                    Console.WriteLine("AldWorth");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press to end execution console.");
            Console.ReadLine();
        }
    }
}
