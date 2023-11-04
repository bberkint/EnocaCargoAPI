using System.ComponentModel.DataAnnotations;

namespace EnocaCargoAPI.Models
{
    public class Carriers
    {
        [Key]
        public int CarrierId { get; set; }
        public string CarrierName { get; set; }
        public bool CarrierIsActive { get; set; }
        public int CarrierPlusDesiCost { get; set; }
        public int CarrierConfigurationId { get; set; }
    }
}
