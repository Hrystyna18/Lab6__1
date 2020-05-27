using System;

namespace Lab6_1
{
    class Program
    {
        public static Student[] group = new Student[int.Parse(Console.ReadLine())];

        private static void Main(string[] args)
        {
            Input input = new Input();

            input.Read();

            Output output = new Output();

            output.Write();

        }
    }
}

