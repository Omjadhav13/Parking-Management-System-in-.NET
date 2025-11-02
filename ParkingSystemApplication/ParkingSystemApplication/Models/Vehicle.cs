using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingSystemApplication.Models
{
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string PlateNumber { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public DateTime EntryTime { get; set; }
        public DateTime? ExitTime { get; set; }

        [ForeignKey("ParkingSlot")]
        public int SlotId { get; set; }

        public ParkingSlot ParkingSlot { get; set; }
    }

}
