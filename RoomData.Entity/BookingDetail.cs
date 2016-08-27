using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomData.Entity
{
    public class BookingDetail
    {
        public int BookingId { set; get; }
        public int CustomerId { set; get; }
        public int HotelId { set; get; }
        public string CheckInDate { set; get; }
        public string CheckoutDate { set; get; }
    }
}
