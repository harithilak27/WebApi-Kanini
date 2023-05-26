using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kanini_Assessment.Models
{
    public class Rooms
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoomId { get; set; }

        public int HotelId { get; set; }
        public Hotels Hotels { get; set; } 

        public string RoomType { get; set; }

        public string RoomStatus { get; set; }

        public string RoomPricePerNight { get; set;}

    }
}
