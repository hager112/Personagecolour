using System;

namespace Personagecolour
{
    internal class Spelkaraktar
    {   public string CharacterName { get; set; }
        public string Class { get; set; }
        public int Level { get; set; }
        public string SpecialAbility { get; set; }
        public void ReadInfo()
        {
            Console.Write("Ange karaktärens namn: ");
            CharacterName = Console.ReadLine();
            Console.Write("Ange karaktärens klass (t.ex. krigare, magiker, tjuv): ");
            Class = Console.ReadLine();
            Console.Write("Ange karaktärens nivå (t.ex. 1, 5, 10): ");
            Level = int.Parse(Console.ReadLine());
            Console.Write("Ange karaktärens specialförmåga: ");
            SpecialAbility = Console.ReadLine();
        }
        public void Introduce()
        {
            Console.WriteLine($"Hej! Jag är {CharacterName}, en nivå {Level} {Class} med förmågan: {SpecialAbility}.");
        }
    }
}
