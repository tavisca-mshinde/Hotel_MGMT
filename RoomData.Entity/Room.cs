using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomData.Entity
{
    public class Room
    {
        public int RoomId { set; get; }
        public int HotelId { set; get; }
        public string RoomType { set; get; }
        public int AvailableRooms { set; get; }
        public int TotalRooms { set; get; }
    }
}
