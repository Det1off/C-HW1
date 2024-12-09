namespace C_HW1
{
    class Program
    {
        static void PrintLadder(int steps)
        {
            int indent = 0;

            for (int i = 0; i < steps; i++)
            {
                Console.WriteLine(new string(' ', indent) + "***");

                indent += 2;
                Console.WriteLine(new string(' ', indent) + "*");

            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите количество ступенек: ");

            if (int.TryParse(Console.ReadLine(), out int steps) && steps > 0)
            {
                PrintLadder(steps);
            }
            else
            {
                Console.WriteLine("Введите положительное число!");
            }
        }
    }

}
