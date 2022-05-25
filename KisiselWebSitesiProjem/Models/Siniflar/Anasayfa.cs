using System.ComponentModel.DataAnnotations;

namespace KisiselWebSitesiProjem.Models.Siniflar
{
    public class Anasayfa
    {
        [Key]
        public int İd { get; set; }
        public string profil { get; set; }
        public string isim { get; set; }
        public string unvan { get; set; }
        public string aciklama { get; set; }
        public string iletisim { get; set; }


    }
}