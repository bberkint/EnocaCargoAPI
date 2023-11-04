using System.ComponentModel.DataAnnotations;

namespace EnocaCargoAPI.Models
{
    public class Orders : BaseEntity
    {
        [Key]
        public int OrderId { get; set; }
        public int OrderDesi { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal OrderCarrierCost { get; set; }
    }
}
