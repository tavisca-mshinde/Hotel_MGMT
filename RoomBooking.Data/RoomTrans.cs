using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoomData.Entity;
using System.Data;
using System.Collections;

namespace RoomBooking.Data
{
   public class RoomTrans
    {
        public static ArrayList ConverterRooms(System.Data.DataSet roomsDb)
        {
            if (roomsDb == null)
                return null;
            if (roomsDb.Tables.Count > 0)
            {
                ArrayList Roomlist = new ArrayList();
                foreach(DataRow row in roomsDb.Tables[0].Rows)
                //for (int i = 0; i < roomsDb.Tables[0].Rows.Count; i++)
                //if (hotelsDb.Tables[0].Rows.Count > 0)
                {
                    //DataRow row = roomsDb.Tables[0].Rows[i];
                    Room room = new Room();
                    room.RoomId = Convert.ToInt32(row["RoomId"]);
                    //hotel. = Convert.ToInt32(row["HotelId"]);
                    room.HotelId = Convert.ToInt32(row["HotelId"]);
                    room.RoomType = row["RoomType"].ToString();
                    room.AvailableRooms = Convert.ToInt32(row["AvailableRooms"]);
                    room.TotalRooms = Convert.ToInt32(row["TotalRooms"]);
                    //hotel.PhoneNumber = row["PhoneNumber"].ToString();
                    Roomlist.Add(room);
                    
                }
                return Roomlist;
            }
            return null;
        }
    }
}
