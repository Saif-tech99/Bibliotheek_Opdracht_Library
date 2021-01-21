using Bibliotheek_Opdracht_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek_Opdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            SoortItem soortItem = new SoortItem();

            CollectieBibliotheek collectie = new CollectieBibliotheek();
            Item item = new Item()
            {
                Titel = "jojo",
                ItemId = 1,
                SoortItem = soortItem,
                Uitgeleend = true
            };
            Item item1 = new Item()
            {
                Titel = "dio",
                ItemId = 2,
                SoortItem = soortItem,
                Uitgeleend = false
            };
            Item item2 = new Item()
            {
                Titel = "kuma",
                ItemId = 3,
                SoortItem = soortItem,
                Uitgeleend = false
            };
            Item item3 = new Item()
            {
                Titel = "dedo",
                ItemId = 4,
                SoortItem = soortItem,
                Uitgeleend = false
            };
            Item item4 = new Item()
            {
                Titel = "dada",
                ItemId = 5,
                SoortItem = soortItem,
                Uitgeleend = false
            };
            collectie.ItemsInCollectie.Add(item);
            collectie.ItemsInCollectie.Add(item1);
            collectie.ItemsInCollectie.Add(item2);
            collectie.ItemsInCollectie.Add(item3);
            collectie.ItemsInCollectie.Add(item4);
            collectie.AfgevoerdeItems.Add(item4);
            collectie.AfgevoerdeItems.Add(item3);

            Bezoeker bezoeker = new Bezoeker();
            Lid lid = new Lid();
           

            Console.WriteLine(" PRESS L TO LOGIN AS A MEMBER\n PRESS B TO LOGIN AS GUEST\n PRESS M TO LIGIN AS WORKER...");
            ConsoleKey key = Console.ReadKey().Key;
            if (key==ConsoleKey.L)
            {
                lid.ZoekItem(collectie);
                lid.ToonOverzicht(collectie);
                lid.Terugbrengen(item);
                lid.Uitlenen(item, collectie);
            }
            else if (key == ConsoleKey.B)
            {
                bezoeker.ZoekItem(collectie);
                bezoeker.ToonOverzicht(collectie);
                bezoeker.RegistreeralsLid();
            }
            else if (key == ConsoleKey.M)
            {
            }




        }
    }
}
