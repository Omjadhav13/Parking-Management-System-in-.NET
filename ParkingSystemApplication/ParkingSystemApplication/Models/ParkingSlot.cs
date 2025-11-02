using System.ComponentModel.DataAnnotations;

namespace ParkingSystemApplication.Models
{
    public class ParkingSlot
    {
        [Key]
        public int SlotId { get; set; }
        public bool IsOccupied { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
    }
}
