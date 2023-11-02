using LAB2.Constructions;
using System;
using LAB2.Models;

namespace LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            var constr = new Construction(32, 23, 3, 6, BuildMaterialType.Brik);
            var constr2 = new Construction();
            var dto = new CreateConstuctionsDTO()
            {
                BuildMaterial = BuildMaterialType.Brik,
                Width = 23,
                Height = 32,
                HumanCapacity = 1,
                Entrances = 2
            };
            Console.WriteLine(dto.Width);
            Console.WriteLine(dto.Entrances);
            Console.WriteLine(dto.HumanCapacity);
            
         
        }
    }
}