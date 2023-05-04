using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaokuluKatmanli.Model.Models
{
    public class Ogretmenler
    {
        [Key]
        public int OgretmenID { get; set; }
        
        public string OgretmenAdi { get; set; }
       
        public string OgretmenSoyadi { get; set; }
        public string Brans { get; set; }

        public virtual List<Ogrenciler> Ogrenciler{ get; set; } = new List<Ogrenciler>();
        public virtual List<Dersler> Dersler{ get; set; } = new List<Dersler>();
        //bir ogrencinin  birden fazla ogretmeni 
        //bir dersin birden fazla ogretmeni 
    }
}
