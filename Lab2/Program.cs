using System;
using Lab2.Constructions;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var construction = new Construction(103, 45, 2, 8, "Brik");
            Console.WriteLine(construction.Height);
        }
    }
}