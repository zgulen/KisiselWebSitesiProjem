using System.ComponentModel.DataAnnotations;

namespace KisiselWebSitesiProjem.Models.Siniflar
{
    public class admin
    {
        [Key]
        public int id { get; set; }
        public string kullaniciadi { get; set; }
        public string sifre { get; set; }

    }
}