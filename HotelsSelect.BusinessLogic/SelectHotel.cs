using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelsData.Entity;
using HotelBooking.Data;
using System.Collections;

namespace HotelsSelect.BusinessLogic
{
    public class SelectHotel
    {
        public ArrayList GetHotelsById(int Id)
        {
            HotelDBOps hotelDBOps = new HotelDBOps();
            
            return HotelTrans.ConverterHotels(hotelDBOps.SelectHotelsById(Id));
        }
        public ArrayList GetHotelsByCity(String city)
        {
            HotelDBOps hotelDBOps = new HotelDBOps();

            return HotelTrans.ConverterHotels(hotelDBOps.SelectHotelsByCity(city));
        }
        public void InsertHotelData(string hotelName,string phoneNumber,string city)
        {
            HotelDBOps hotelDBOps = new HotelDBOps();
            hotelDBOps.InsertHotels(hotelName,phoneNumber,city);
        }
    }
}
