using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek_Opdracht_Library.Models
{
    public class Item
    {
        public SoortItem SoortItem { get; set; }
        public int ItemId { get; set; }
        public string Titel { get; set; }
        public string Auteur { get; set; }
        public string Regisseur { get; set; }
        public string Uitvoerder { get; set; }
        public int Jaartal { get; set; }
        public bool Uitgeleend { get; set; }
        public bool Afgevoerd { get; set; }


    }
}
