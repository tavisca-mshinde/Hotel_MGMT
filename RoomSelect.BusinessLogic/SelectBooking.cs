using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoomBooking.Data;

namespace RoomSelect.BusinessLogic
{
    public class SelectBooking
    {
        public Int64 InsertBookingData(long CustomerId, long HotelId)
        {
            BookingDetailsDBOps bookingDetailsDBOps = new BookingDetailsDBOps();
            return bookingDetailsDBOps.InsertBookingDetails(CustomerId, HotelId);
            //RoomDBOps roomDBOps = new RoomDBOps();
            //roomDBOps.InsertRooms(roomId, roomType, availbleRooms, totalRooms);
        }
        public void UpdateBookingData(long bookingId)
        {
            BookingDetailsDBOps bookingDetailsDBOps = new BookingDetailsDBOps();
            bookingDetailsDBOps.UpdateBookingDetails(bookingId);
            //RoomDBOps roomDBOps = new RoomDBOps();
            //roomDBOps.InsertRooms(roomId, roomType, availbleRooms, totalRooms);
        }
    }
}
