using System;
using System;

namespace Personagecolour
{
    internal class Konsertbiljett
    {
        public string EventName { get; set; }
        public string Place { get; set; } 
        public string SeatNumber { get; set; }
        public void ReadInfo()
        {
            Console.WriteLine("Ange eventnamn:");
            EventName = Console.ReadLine();
            Console.WriteLine("Ange plats:");
            Place = Console.ReadLine();
            Console.WriteLine("Ange sittplats:");
            SeatNumber = Console.ReadLine();
        }
             public void PrintTicket()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("----- KONCERTBILJETT -----");
                Console.WriteLine($"Event: {EventName}");
                Console.WriteLine($"Plats: {Place}");
                Console.WriteLine($"Sittplats: {SeatNumber}");
                Console.ResetColor();
            }


        }





    } 

