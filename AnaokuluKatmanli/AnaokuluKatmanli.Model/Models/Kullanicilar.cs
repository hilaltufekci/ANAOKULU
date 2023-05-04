using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaokuluKatmanli.Model.Models
{
    public class Kullanicilar
    {
        [Key]
        public int KullaniciNo { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez!!")]
        [Display(Name = "kullanici adı")]
        public string KullaniciAdi { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez!!")]
        [Display(Name = "Sifre")]
        [DataType(DataType.Password)]
        public string Sifre { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez!!")]
        [Display(Name = "MatchSifre")]
        [DataType(DataType.Password)]
        [NotMapped]
        [Compare("Sifre", ErrorMessage = "sifreler eşleşmiyor tekrar deneyiniz!!")]

        public string MatchSifre { get; set; }

    }
}
