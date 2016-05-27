using System.ComponentModel.DataAnnotations;

namespace Konoha.Classes
{
    public class Shinobi
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsKonohaShinobi { get; set; }
        public Clan Clan { get; set; }
        public int ClanId { get; set; }
    }
}
