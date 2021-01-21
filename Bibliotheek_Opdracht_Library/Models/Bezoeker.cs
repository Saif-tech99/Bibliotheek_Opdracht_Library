using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek_Opdracht_Library.Models
{
    public class Bezoeker
    {
        public string FamilieName { get; set; }
        public string voornaam { get; set; }

        public void RegistreeralsLid()
        {
            Console.WriteLine("please enter your birthdate...");
            Lid newlid = new Lid();
            newlid.Geboortedatum = int.Parse(Console.ReadLine());
            CollectieBibliotheek nlid = new CollectieBibliotheek();
            nlid.Leden.Add(newlid);
            Console.WriteLine("you are now a memmber...");
            Console.Clear();
            Console.WriteLine(newlid.voornaam);
            Console.WriteLine("keis wat well u doen...");
            Console.WriteLine("press A for Items uitlenen\npress B for Items terugbrengen\npress C for Items reserveren");
            ConsoleKey keyinstrotie = Console.ReadKey().Key;
            if (keyinstrotie == ConsoleKey.A)
            {
                Console.Clear();
                CollectieBibliotheek collectie = new CollectieBibliotheek();
                foreach (var item in collectie.ItemsInCollectie)
                {
                    Console.WriteLine(item.Titel + "\t" + item.SoortItem);
                }
            }
            else if (keyinstrotie == ConsoleKey.B)
            {
                Console.Clear();
                List<Item> itemsterug = new List<Item>();
                Item terugitem = new Item();
                Console.WriteLine("pleas enter item titel...");
                terugitem.Titel = Console.ReadLine();
                Console.WriteLine("pleas enter item Id...");
                terugitem.ItemId = int.Parse(Console.ReadLine());
                itemsterug.Add(terugitem);
            }
            else if (keyinstrotie == ConsoleKey.C)
            {
                List<Item> ItemReservatie = new List<Item>();
                Item itemre = new Item();
                itemre.Titel = Console.ReadLine();
                ItemReservatie.Add(itemre);
            }

        }
        public virtual void ZoekItem(CollectieBibliotheek collectie)
        {
            Bezoeker bezoeker = new Bezoeker();
            Item item = new Item();
            Console.Clear();
            Console.WriteLine("Enter your name...");
            bezoeker.voornaam = Console.ReadLine();
            Console.WriteLine("Enter your last name...");
            bezoeker.FamilieName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Welcome by our bib {bezoeker.voornaam}");
            Console.WriteLine("________________________________________________________");
            Console.WriteLine("Typ Z to search\ntyp T to see our collection ");
            ConsoleKey key1 = Console.ReadKey().Key;
            Console.WriteLine();
            if (key1 == ConsoleKey.Z)
            {
                Console.Clear();
                Console.WriteLine("Typ titel for titelsearch\ntyp ID for Idsearch...");
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
        public void ToonOverzicht(CollectieBibliotheek collectie)//x4
        {

            Console.WriteLine("chose out of the list...");
            Console.WriteLine("press a to see the full collection\npress d to see the droobed collection\npress v to see the avilauble itemes\n" +
                           "press n to see non aveluble itemes\ns for item soort...");
            ConsoleKey key2 = Console.ReadKey().Key;
            switch (key2)
            {
                case ConsoleKey.A:

                    Console.Clear();
                    foreach (var itemA in collectie.ItemsInCollectie)
                    {
                        Console.WriteLine($"{itemA.ItemId}\t{itemA.Titel}\t{itemA.Uitgeleend}");
                    }


                    break;
                case ConsoleKey.D:
                    Console.Clear();
                    foreach (var itemA in collectie.AfgevoerdeItems)
                    {
                        Console.WriteLine($"{itemA.ItemId}\t{itemA.Titel}\t{itemA.Uitgeleend}\t{itemA.SoortItem}");
                    }

                    break;
                case ConsoleKey.V:
                    Console.Clear();
                    foreach (var itemA in collectie.ItemsInCollectie)
                    {
                        if (!itemA.Uitgeleend)
                        {
                            Console.WriteLine($"{itemA.ItemId}\t{itemA.Titel}\t{itemA.Uitgeleend}\t{itemA.SoortItem}");
                        }
                        continue;
                    }
                    break;
                case ConsoleKey.N:
                    Console.Clear();
                    foreach (var itemA in collectie.ItemsInCollectie)
                    {
                        if (!itemA.Uitgeleend)
                        {
                            Console.WriteLine($"{itemA.ItemId}\t{itemA.Titel}\t{itemA.Uitgeleend}\t{itemA.SoortItem}");
                        }
                        continue;
                    }
                    break;
                case ConsoleKey.S:

                    if (key2 == ConsoleKey.S)
                    {
                        Console.Clear();
                        string value = Console.ReadLine();
                        SoortItem soortItem = (SoortItem)Enum.Parse(typeof(SoortItem), value);

                        foreach (var itemA in collectie.ItemsInCollectie)
                        {
                            Console.WriteLine($"{itemA.ItemId}\t{itemA.Titel}\t{itemA.Uitgeleend}\t{itemA.SoortItem}");
                        }

                    }
                    break;
                default:
                    break;
            }
        }
    }
}
