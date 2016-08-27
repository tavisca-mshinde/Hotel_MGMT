using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoomBooking.Data;
using RoomData.Entity;
using System.Collections;

namespace RoomSelect.BusinessLogic
{
    public class SelectRooms
    {
        public ArrayList GetRoomByHotelId(long HotelId)
        {
            RoomDBOps roomDBOps = new RoomDBOps();

            return RoomTrans.ConverterRooms(roomDBOps.SelectRoomsByHotelId(HotelId));
        }
        public void InsertRoomsData(int hotelId,string roomType,int availbleRooms,int totalRooms)
        {
            RoomDBOps roomDBOps = new RoomDBOps();
            roomDBOps.InsertRooms(hotelId, roomType,availbleRooms,totalRooms);
        }
        public void UpdateRoomsData(int roomId)
        {
            RoomDBOps roomDBOps = new RoomDBOps();
            roomDBOps.UpdateRoomsdata(roomId);
            
        }
    }
}
