using System;

namespace Personagecolour
{
    internal class Personklass
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string FavoriteColor { get; set; }

        public void ReadIfo()
        {

            Console.Write("Ange namn:");
            Name = Console.ReadLine();

            Console.Write("Ange ålder:");
            Age = int.Parse(Console.ReadLine()); 

            Console.Write("Ange favoritfärg:");
        }
        public void Introduce()
        {

            Console.WriteLine($"Hej! Jag heter {Name}, är {Age} år och min favoritfärg är {FavoriteColor}.");



        }
    }
}













            








        









    









