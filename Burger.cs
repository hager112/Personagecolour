using System;

namespace Personagecolour
{
    internal class Burger
    {
        public string BreadType { get; set; }
        public string MeatType { get; set; }
        public string Topping { get; set; }
        public string Sauce { get; set; }
        public void ReadInfo()
        {
            Console.Write("Ange brödtyp (t.ex. sesam, fullkorn): ");
            BreadType = Console.ReadLine();
            Console.Write("Ange köttryp (t.ex. nötkött, kyckling, vegansk): ");
            MeatType = Console.ReadLine();
            Console.Write("Ange topping (t.ex. sallad, tomat, ost): ");
            Topping = Console.ReadLine();
            Console.Write("Ange sås (t.ex. ketchup, majonnäs, BBQ): ");
            Sauce = Console.ReadLine();
        }
        public void DescribeBurger()
        {
            Console.WriteLine($"Din burger består av {BreadType} bröd, {MeatType} kött, toppad med {Topping} och såsen är {Sauce}.");
        }




    }





}



