using System.ComponentModel.DataAnnotations;

namespace KoronaWirusMonitor.Models
{
    public class Country
    {
        [Key]
        public int Id{ get; set; }
        public string Name { get; set; }
        public Country(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
