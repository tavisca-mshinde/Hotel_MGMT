using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelBooking.Data;
using HotelsSelect.BusinessLogic;
using HotelsData.Entity;
using System.Collections;

namespace HotelInsert.TestSuite
    
{
    [TestClass]
    public class HotelTest
    {
        //[TestMethod]
        //public void TestMethod1()
        //{
        //    HotelDBOps hotelDBOps = new HotelDBOps();
        //    hotelDBOps.InsertHotels("Hyatt", "1234567890", "Mumbai");
        //}
        //[TestMethod]
        //public void TestSelectHotelsById()
        //{
        //    SelectHotel selectHotel = new SelectHotel();
        //    ArrayList hotel = selectHotel.GetHotelsById(1);
        //}
        [TestMethod]
        public void TestSelectHotelsByCity()
        {
            SelectHotel selectHotel = new SelectHotel();
            ArrayList hotel = selectHotel.GetHotelsByCity("Mumbai");
        }
    }
}
