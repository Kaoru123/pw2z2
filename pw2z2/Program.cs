using System;

namespace pw2z2
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberHandler handler = new NumberHandler();

            while (true)
            {
                Console.WriteLine("Введите число:");
                int number = int.Parse(Console.ReadLine());

                bool result = handler.SetNumber(number);

                if (result)
                {
                    Console.WriteLine($"Значение n: {handler.GetExpectedNumber()}");
                }
                else
                {
                    Console.WriteLine("Неверное значение! Начните сначала.");
                }
            }
        }
    }

    public class NumberHandler
    {
        private int n;

        public bool SetNumber(int number)
        {
            if (number == n + 1)
            {
                n += 1;
                return true;
            }
            else
            {
                n = 0;
                return false;
            }
        }

        public int GetExpectedNumber()
        {
            return n + 1;
        }
    }
}