using System.ComponentModel.DataAnnotations;

namespace TurkiyeBolgelerSehirler.Data
{
    public class Bolge
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string BolgeAd { get; set; } = string.Empty;

        [MaxLength(100)]
        public string Slug { get; set; } = string.Empty;


        public List<Sehir> Sehirler { get; set; } = new();
    }
}
