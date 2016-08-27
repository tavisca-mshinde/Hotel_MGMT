using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoomBooking.Data;
using RoomSelect.BusinessLogic;
using RoomData.Entity;
using System.Collections;

namespace RoomInsert.TestSuite
{
    [TestClass]
    public class RoomTest
    {
        //[TestMethod]
        //public void TestMethod1()
        //{
        //    RoomDBOps roomDBOps = new RoomDBOps();
        //    roomDBOps.InsertRooms(1, "Non-AC", 5, 5);
        //}
        [TestMethod]
        public void TestMethod2()
        {
            //RoomDBOps roomDBOps = new RoomDBOps();
            SelectRooms selectRooms = new SelectRooms();
            ArrayList arr = selectRooms.GetRoomByHotelId(1);

        }
    }
}
