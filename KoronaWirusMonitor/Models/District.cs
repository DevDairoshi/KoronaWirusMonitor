using System.ComponentModel.DataAnnotations;

namespace KoronaWirusMonitor.Models
{
    public class District
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Region Region { get; set; }
    }
}