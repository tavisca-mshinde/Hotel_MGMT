using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelsData.Entity;
using System.Data;
using System.Collections;

namespace HotelBooking.Data
{
    public class HotelTrans
    {
        public static ArrayList ConverterHotels(System.Data.DataSet hotelsDb)
        {
            if (hotelsDb == null)
                return null;
            if (hotelsDb.Tables.Count > 0)
            {
                ArrayList Hotellist = new ArrayList();
                foreach (DataRow row in hotelsDb.Tables[0].Rows)
                //if (hotelsDb.Tables[0].Rows.Count > 0)
                {
                    //DataRow row = hotelsDb.Tables[0].Rows[0];
                    Hotels hotel = new Hotels();
                    hotel.HotelId = Convert.ToInt32(row["HotelId"]);
                    //hotel. = Convert.ToInt32(row["HotelId"]);
                    hotel.HotelName = row["HotelName"].ToString();
                    hotel.PhoneNumber = row["PhoneNumber"].ToString();
                    hotel.City = row["City"].ToString();
                    //hotel.PhoneNumber = row["PhoneNumber"].ToString();
                    Hotellist.Add(hotel);
                    //return hotel;
                }
                return Hotellist;
            }
            return null;
        }
    }
}
