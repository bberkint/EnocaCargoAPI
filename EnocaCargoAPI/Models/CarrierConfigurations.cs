using System.ComponentModel.DataAnnotations;

namespace EnocaCargoAPI.Models
{
    public class CarrierConfigurations : BaseEntity
    {
        [Key]
        public int CarrierConfigurationId { get; set; }
        public int CarrierMaxDesi { get; set; }
        public int CarrierMinDesi { get; set; }
        public decimal CarrierCost { get; set; }
    }
}
