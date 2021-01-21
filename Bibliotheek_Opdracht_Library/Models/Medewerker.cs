using System;
using System.Collections.Generic;


namespace Bibliotheek_Opdracht_Library.Models
{
    public class Medewerker : Bezoeker
    {
        public void PromoveerLidNaarMedewerker()
        {
            List<Medewerker> medewerkers = new List<Medewerker>();
            Lid lid = new Lid();
            Console.WriteLine("enter the member name to add it to the worger list...");
            lid.voornaam = Console.ReadLine();
            Console.WriteLine("enter the member last name to add it to the worger list...");
            lid.FamilieName = Console.ReadLine();

            medewerkers.Add(lid);

        }
        public void VoerItemAf()
        {
            Item item = new Item();
            CollectieBibliotheek collectie = new CollectieBibliotheek();
            Console.WriteLine("enter item id to delet it...");
            item.ItemId = int.Parse(Console.ReadLine());
            Console.WriteLine("enter item titel delet it...");
            item.Titel = Console.ReadLine();
            collectie.ItemsInCollectie.Remove(item);
        }
        public void VoegItemToe()
        {
            Item item = new Item();
            CollectieBibliotheek collectie = new CollectieBibliotheek();
            Console.WriteLine("enter item id to...");
            item.ItemId = int.Parse(Console.ReadLine());
            Console.WriteLine("enter item titel...");
            item.Titel = Console.ReadLine();
            collectie.ItemsInCollectie.Add(item);
        }
        public void GeefOVerzichtLeden()
        {
            Lid lid = new Lid();
            CollectieBibliotheek collectie = new CollectieBibliotheek();
            Console.WriteLine("press A to see the members list...");
            ConsoleKey key = Console.ReadKey().Key;
            if (key == ConsoleKey.A)
            {
                foreach (var item in collectie.Leden)
                {
                    Console.WriteLine(item.voornaam + " " + item.FamilieName);
                }
            }
        }
        public List<CollectieBibliotheek> UitleenHistoriek()
        {

        }
        public List<CollectieBibliotheek> ItemsUitgeleend()
        {

        }
        public List<Item> reservatie()
        {
            List<Item> ItemReservatie = new List<Item>();
            Item itemre = new Item();
            Console.WriteLine("");
            itemre.Titel = Console.ReadLine();
            itemre.ItemId = int.Parse(Console.ReadLine());
            ItemReservatie.Add(itemre);

        }
        public void Uitlenen(Item item, CollectieBibliotheek collectie)
        {
            Medewerker medewerker = new Medewerker();

            Console.WriteLine("choos what tou would lik to rent...");
            foreach (var item1 in collectie.ItemsInCollectie)
            {
                Console.WriteLine(item1.ItemId + " " + item1.Titel);
            }
            Console.WriteLine("enter the item titel or itemId to rent it...");
            ConsoleKey key = Console.ReadKey().Key;
            if (key == ConsoleKey.T)
            {
                string inpot;
                inpot = Console.ReadLine();
                if (collectie.ItemsInCollectie.Contains(item) && item.Titel == inpot)
                {
                    Console.WriteLine("item has been found");
                    medewerker.ItemsUitgeleend.Add(item);
                }
                else
                {
                    Console.WriteLine("item has not been found");
                }
            }
            else if (key == ConsoleKey.I)
            {
                int inpot1 = Convert.ToInt32(Console.ReadLine());
                if (collectie.ItemsInCollectie.Contains(item) && item.ItemId == inpot1)
                {
                    Console.WriteLine("item has been found");
                    medewerker.ItemsUitgeleend.Add(item);
                }
                else
                {
                    Console.WriteLine("item has not been found");
                }
            }
        }
        public void Terugbrengen(Item item)
        {
            CollectieBibliotheek collectie = new CollectieBibliotheek();
            Console.WriteLine("enter the item Id to returen it...");

            int inpot = int.Parse(Console.ReadLine());
            if (item.ItemId.Equals(inpot) && item.Uitgeleend)
            {
                collectie.ItemsInCollectie.Add(item);
                Console.WriteLine("item has been returened...");
            }

        }
        public void Reserveren(Item item)
        {

        }
    }
}
