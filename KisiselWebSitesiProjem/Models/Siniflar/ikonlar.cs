using System.ComponentModel.DataAnnotations;

namespace KisiselWebSitesiProjem.Models.Siniflar
{
    public class ikonlar
    {
        [Key]
        public int id { get; set; }
        public string ikon { get; set; }
        public string Link { get; set; }

    }
}