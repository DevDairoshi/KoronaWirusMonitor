using System.ComponentModel.DataAnnotations;

namespace KoronaWirusMonitor.Models
{
    public class Region
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
    }
}