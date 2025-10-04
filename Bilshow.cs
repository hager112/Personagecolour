using System;

namespace Personagecolour
{
    internal class Bilshow
    {
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public void ReadInfo()
        {
            Console.Write("Ange bilens märke (t.ex. Toyota, Ford): ");
            CarMake = Console.ReadLine();
            Console.Write("Ange bilens modell (t.ex. Corolla, Mustang): ");
            CarModel = Console.ReadLine();
            Console.Write("Ange bilens årsmodell (t.ex. 2020): ");
            Year = int.Parse(Console.ReadLine());
            Console.Write("Ange bilens färg (t.ex. röd, blå, svart): ");
            Color = Console.ReadLine();
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Bilinfo: {Year} {Color} {CarMake} {CarModel}");
        }




    }




}

