using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelBooking.Data;
namespace HotelInsert.TestSuite
{
    [TestClass]
    public class HotelTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            HotelDBOps hotelDBOps = new HotelDBOps();
            hotelDBOps.InsertHotels("NOVOTEL", "1234567890", "Mumbai");
        }
    }
}
