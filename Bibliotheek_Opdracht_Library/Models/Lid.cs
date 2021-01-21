using System;
using System.Collections.Generic;


namespace Bibliotheek_Opdracht_Library.Models
{
    public class Lid : Bezoeker
    {
        public int Geboortedatum { get; set; }
        public List<Item> UitleenHistoriek { get; set; }
        private List<Item> _itemsUitgeleend;
        public List<Item> ItemsUitgeleend
        {
            get { return _itemsUitgeleend; }
            set
            {
                if (value.Capacity <= 5)
                {
                    _itemsUitgeleend = value;
                }
            }
        }
        private List<Item> _Reservatie;
        public List<Item> Reservatie
        {
            get { return _Reservatie; }
            set
            {
                if (value.Capacity <= 5)
                {
                    _Reservatie = value;
                }
            }
        }

        public override void ZoekItem(CollectieBibliotheek collectie)
        {
            Lid lid = new Lid();
            Item item = new Item();
            Console.Clear();
            Console.WriteLine("Enter your name...");
            lid.voornaam = Console.ReadLine();
            Console.WriteLine("Enter your last name...");
            lid.FamilieName = Console.ReadLine();
            Console.WriteLine("enter your berthdate...");
            Geboortedatum = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Welcome by our bib {lid.voornaam}");
            Console.WriteLine("________________________________________________________");
            Console.WriteLine("Typ Z to search\ntyp T to see our collection ");
            ConsoleKey key1 = Console.ReadKey().Key;
            Console.WriteLine();
            if (key1 == ConsoleKey.Z)
            {
                Console.Clear();
                Console.WriteLine("enter titel for titelsearch\nenter ID for Idsearch...");
                string inpot = Console.ReadLine();
                if (inpot == "titel".ToLower())
                {
                    Console.Clear();
                    Console.WriteLine("enter the item Titel please...");
                    inpot = Console.ReadLine();
                    if (collectie.ItemsInCollectie.Contains(item) && item.Titel == inpot)
                    {
                        Console.WriteLine($"the item {inpot} you are searching for does existed in the collection");
                    }
                    else
                    {
                        Console.WriteLine($"the item {inpot} you are searching for does not existed in the collection");

                    }
                }
                else if (inpot == "id".ToLower())
                {
                    Console.Clear();
                    Console.WriteLine("enter the item Id please...");
                    int inpot1 = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        if (collectie.ItemsInCollectie.Contains(item) && item.ItemId == inpot1)
                        {
                            Console.WriteLine($"the item {inpot1} you are searching for does existed in the collection");

                        }
                        else
                        {
                            Console.WriteLine($"the item {inpot1} you are searching for does not existed in the collection");

                        }
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e);
                    }


                }


            }
        }

        public void Uitlenen(Item item, CollectieBibliotheek collectie)
        {
            Lid lid = new Lid();

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
                    lid.ItemsUitgeleend.Add(item);
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
                    lid.ItemsUitgeleend.Add(item);
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
    }
}
