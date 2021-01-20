using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public void Uitlenen(Item item)
        {
            CollectieBibliotheek collectie = new CollectieBibliotheek();
            Console.WriteLine("choos what tou would lik to rent...");
            foreach (var item1 in collectie.ItemsInCollectie)
            {
                Console.WriteLine(item1.ItemId + " " + item1.Titel);
            }
            Console.WriteLine("enter th item titel or itemId to rent it...");
            ConsoleKey key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.T:
                    string inpot = Console.ReadLine();
                    if (item.Titel.Contains(inpot))
                    {
                        Console.WriteLine("item has been found");
                        Lid lid = new Lid();
                        lid.ItemsUitgeleend.Add(item);
                    }
                    else
                    {
                        Console.WriteLine("item has not been found");
                    }
                    break;
                case ConsoleKey.I:
                    int inpot1 = Convert.ToInt32(Console.ReadLine());
                    if (item.ItemId.Equals(inpot1))
                    {
                        Console.WriteLine("item has been found");
                        Lid lid = new Lid();
                        lid.ItemsUitgeleend.Add(item);
                    }
                    else
                    {
                        Console.WriteLine("item has not been found");
                    }
                    break;

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
