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
        public void ZoekItem(CollectieBibliotheek collectie)
        {
            Bezoeker bezoeker = new Bezoeker();
            Item item = new Item();
            //Console.WriteLine("choos the method of serach...\n-T for item titel.\n-I for item Id.");
            //ConsoleKey key = Console.ReadKey().Key;
            Console.WriteLine("om in te loggen als Lid of Medewerker of zich tijdelijk te registreren als Bezoeker");
            ConsoleKey key = Console.ReadKey().Key;

            switch (key)
            {
                case ConsoleKey.B:
                    Console.WriteLine("enter your name...");
                    bezoeker.voornaam = Console.ReadLine();
                    Console.WriteLine("enter your last name...");
                    bezoeker.FamilieName = Console.ReadLine();
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine($"welcome by our bib {bezoeker.voornaam}");
                    Console.WriteLine("________________________________________________________");
                    Console.WriteLine("typ Z to search\ntyp T to see our collection ");
                    ConsoleKey key1 = Console.ReadKey().Key;
                    if (key1 == ConsoleKey.Z)
                    {
                        Console.Clear();

                        Console.WriteLine("typ titel for titelsearch\ntyp ID for Idsearch...");
                        string inpot = Console.ReadLine();
                        if (inpot == "Titel".ToLower())
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
                            if (collectie.ItemsInCollectie.Contains(item) && item.ItemId == inpot1)
                            {
                                Console.WriteLine($"the item {inpot1} you are searching for does existed in the collection");
                            }
                            else
                            {
                                Console.WriteLine($"the item {inpot1} you are searching for does not existed in the collection");

                            }
                        }
                    }
                    else if (key1 == ConsoleKey.T)
                    {
                        Console.WriteLine("press a to see the full collection\npress d to see the droobed collection\npress v to see the avilauble itemes\n" +
                            "press n to see non aveluble itemes...");
                        ConsoleKey key2 = Console.ReadKey().Key;
                        if (key2 == ConsoleKey.A)
                        {
                            Console.Clear();
                            foreach (var itemA in collectie.ItemsInCollectie)
                            {
                                Console.WriteLine($"{itemA.ItemId}\t{itemA.Titel}\t{itemA.Uitgeleend}");
                            }

                        }
                        else if (key2 == ConsoleKey.D)
                        {
                            Console.Clear();
                            foreach (var itemA in collectie.AfgevoerdeItems)
                            {
                                Console.WriteLine($"{itemA.ItemId}\t{itemA.Titel}\t{itemA.Uitgeleend}\t{item.SoortItem}");
                            }
                        }
                        else if (key2 == ConsoleKey.V)
                        {
                            Console.Clear();
                            foreach (var itemA in collectie.ItemsInCollectie)
                            {
                                if (itemA.Uitgeleend)
                                {
                                    Console.WriteLine($"{itemA.ItemId}\t{itemA.Titel}\t{itemA.Uitgeleend}\t{item.SoortItem}");
                                }
                                continue;
                            }
                        }
                        else if (key2 == ConsoleKey.N)
                        {
                            Console.Clear();
                            foreach (var itemA in collectie.ItemsInCollectie)
                            {
                                if (!itemA.Uitgeleend)
                                {
                                    Console.WriteLine($"{itemA.ItemId}\t{itemA.Titel}\t{itemA.Uitgeleend}\t{item.SoortItem}");
                                }
                                continue;
                            }
                        }
                    }


                    break;
                default:
                    break;
            }

            //switch (key)
            //{
            //    //case ConsoleKey.T:
            //    //    Console.Clear();
            //    //    Console.WriteLine("enter item titel...");
            //    //    Item item = new Item();
            //    //    iteincollectie.ItemsInCollectie.Add(item);
            //    //    string itemTitel = Console.ReadLine();
            //    //    if (item.Titel.Contains(itemTitel))
            //    //    {
            //    //        Console.WriteLine($"the {itemTitel} is exestied");
            //    //    }
            //    //    else
            //    //    {
            //    //        Console.WriteLine($"the {itemTitel} is not exestied");
            //    //    }
            //    //    break;
            //    //case ConsoleKey.I:
            //    //    Console.Clear();
            //    //    Console.WriteLine("enter item Id...");
            //    //    Item item1 = new Item();
            //    //    iteincollectie.ItemsInCollectie.Add(item1);
            //    //    string itemId = Console.ReadLine();
            //    //    if (item1.ItemId.Equals(itemId))
            //    //    {
            //    //        Console.WriteLine($"the {itemId} is exestied");
            //    //    }
            //    //    else
            //    //    {
            //    //        Console.WriteLine($"the {itemId} is not exestied");
            //    //    }
            //    //    break;
            //    default:
            //        break;
            //}


        }
        public void ToonOverzicht()//x4
        {
            Console.WriteLine("chse the disiered list...");
            Console.WriteLine("A for the hol collection\nB for the afgevoerde\nC for the beschikbare\nD for the niet-beschikbare");

            ConsoleKey consoleKey = Console.ReadKey().Key;
            switch (consoleKey)
            {
                case ConsoleKey.A:
                    Console.Clear();
                    CollectieBibliotheek collectieBibliotheek = new CollectieBibliotheek();
                    foreach (var item in collectieBibliotheek.ItemsInCollectie)
                    {
                        Console.WriteLine($"titel : {item.Titel}\tid : {item.ItemId}\tyear : {item.Jaartal}\tsoort : {item.SoortItem}");
                    }
                    break;
                case ConsoleKey.B:
                    Console.Clear();
                    CollectieBibliotheek collectieBibliotheek1 = new CollectieBibliotheek();
                    foreach (var item in collectieBibliotheek1.AfgevoerdeItems)
                    {
                        Console.WriteLine($"titel : {item.Titel}\tid : {item.ItemId}\tyear : {item.Jaartal}\tsoort : {item.SoortItem}");
                    }
                    break;
                case ConsoleKey.C:
                    Console.Clear();
                    CollectieBibliotheek collectieBibliotheek2 = new CollectieBibliotheek();
                    foreach (var item in collectieBibliotheek2.ItemsInCollectie)
                    {
                        if (item.Uitgeleend || item.Afgevoerd)
                        {
                            Console.WriteLine($"titel : {item.Titel}\tid : {item.ItemId}\tyear : {item.Jaartal}\tsoort : {item.SoortItem}");
                        }
                        continue;
                    }
                    break;
                case ConsoleKey.D:
                    Console.Clear();
                    CollectieBibliotheek collectieBibliotheek3 = new CollectieBibliotheek();
                    foreach (var item in collectieBibliotheek3.ItemsInCollectie)
                    {
                        if (!item.Uitgeleend || !item.Afgevoerd)
                        {
                            Console.WriteLine($"titel : {item.Titel}\tid : {item.ItemId}\tyear : {item.Jaartal}\tsoort : {item.SoortItem}");
                        }
                        continue;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
