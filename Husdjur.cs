using System;

namespace Personagecolour
{
    internal class Husdjur 
    {
        public string Name { get; set; } 
        public string AnimalType { get; set; } 
        public string FavoriteFood { get; set; } 

        public void ReadInfo()
        {
            Console.Write("Ange djurets namn: ");
            Name = Console.ReadLine();
            Console.Write("Ange djurets typ (t.ex. hund, katt, kanin): ");
            AnimalType = Console.ReadLine();
            Console.Write("Ange djurets favoritmat: ");
            FavoriteFood = Console.ReadLine();
        }
        public void Introduce()
        {
            Console.WriteLine($"Hej! Jag heter {Name}, jag är en {AnimalType} och min favoritmat är {FavoriteFood}.");
        }




    } 











}
