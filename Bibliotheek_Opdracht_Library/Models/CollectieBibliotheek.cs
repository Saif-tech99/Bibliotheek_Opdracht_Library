using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek_Opdracht_Library.Models
{
    public class CollectieBibliotheek
    {
        public List<Item> ItemsInCollectie = new List<Item>();
        public List<Item> AfgevoerdeItems = new List<Item>();
        public List<Lid> Leden = new List<Lid>();
    }
}
