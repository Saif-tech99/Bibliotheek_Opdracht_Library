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
            SoortItem soortItem1 = new SoortItem();
            SoortItem soortItem2 = new SoortItem();
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
                SoortItem = soortItem1,
                Uitgeleend = false
            };
            Item item2 = new Item()
            {
                Titel = "kuma",
                ItemId = 3,
                SoortItem = soortItem1,
                Uitgeleend = false
            };
            Item item3 = new Item()
            {
                Titel = "dedo",
                ItemId = 4,
                SoortItem = soortItem1,
                Uitgeleend = false
            };
            Item item4 = new Item()
            {
                Titel = "dada",
                ItemId = 4,
                SoortItem = soortItem2,
                Uitgeleend = false
            };
            collectie.ItemsInCollectie.Add(item);
            collectie.ItemsInCollectie.Add(item1);
            collectie.ItemsInCollectie.Add(item2);
            collectie.ItemsInCollectie.Add(item3);
            collectie.ItemsInCollectie.Add(item4);
            collectie.AfgevoerdeItems.Add(item4);
            collectie.AfgevoerdeItems.Add(item3);
            soortItem.Equals(1);
            soortItem1.Equals(2);
            soortItem2.Equals(3);
            Bezoeker bezoeker = new Bezoeker();
            Lid lid = new Lid();
            bezoeker.ToonOverzicht(collectie);
            //bezoeker.ZoekItem(collectie);
           
        }
    }
}
