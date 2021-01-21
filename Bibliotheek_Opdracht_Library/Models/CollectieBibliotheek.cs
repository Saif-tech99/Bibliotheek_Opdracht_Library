
using System.Collections.Generic;


namespace Bibliotheek_Opdracht_Library.Models
{
    public class CollectieBibliotheek
    {
        public List<Item> ItemsInCollectie = new List<Item>();
        public List<Item> AfgevoerdeItems = new List<Item>();
        public List<Lid> Leden = new List<Lid>();
    }
}
