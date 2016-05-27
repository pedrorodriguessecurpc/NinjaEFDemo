using System.ComponentModel.DataAnnotations;

namespace Konoha.Classes
{
    public class Justu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public Shinobi Shinobi { get; set; }
        public ElementType ElementType { get; set; }
    }
}
