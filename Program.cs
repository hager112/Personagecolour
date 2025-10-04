namespace Personagecolour
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Välkommen till Personprogramet!");
           Console.WriteLine("------------------------------");
            Console.Write("Vad heter du? ");
            String name= Console.ReadLine ();
            Console.Write("Hur gammal är du? ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Vilken är din favoritfärg? ");
            String färg= Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hej " + name + "!");
            Console.WriteLine("Du är " + age + " år gammal och din favoritfärg är " + färg + ".");
            if(age<18)             {
                Console.WriteLine("Du är fortfarande ung och har hela livet framför dig!");
            }
            else if (age >= 18 && age < 65)
            {
                Console.WriteLine("Du är i din bästa ålder och kan uppnå stora saker!");
            }
            else
            {
                Console.WriteLine("Du har mycket livserfarenhet och visdom att dela med dig av!");
                Console.WriteLine("Tack för att du använde Personprogramet.Tryck på valfri tagnet för att stänga" +
                " Ha en underbar dag!");
            }
        }
    }
}
