using System.ComponentModel.DataAnnotations;

namespace TurkiyeBolgelerSehirler.Data
{
    public class Sehir
    {
        public int Id { get; set; }
        public int BolgeId { get; set; }

        [MaxLength(100)]
        public string Slug { get; set; } = string.Empty;

        [MaxLength(100)]
        public string SehirAd { get; set; } = string.Empty;

        public int Nufus { get; set; }


        public Bolge Bolge { get; set; } = null!;
    }
}
