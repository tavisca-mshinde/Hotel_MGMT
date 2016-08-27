using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using HotelBooking.Data;
//using RoomBooking.Data;
using HotelsSelect.BusinessLogic;
using System.Collections;
using HotelsData.Entity;
using RoomSelect.BusinessLogic; 
using RoomData.Entity;
using CustomerSelect.BusinessLogic;

using CustomerData.Entity;

namespace HotelBookingSystem
{
    class HotelMgmt
    {
        static long hotelId = 0;
        static long custId = 0, bookingId=0;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter Your Role");
                Console.WriteLine("1 . Customer");
                Console.WriteLine("2 . Agent");
                string yourRole = (Console.ReadLine());
                switch (yourRole)
                {
                    case "1":
                        CuctomerRole();
                        break;
                    case "2":
                        AgentRole();
                        break;
                    default:
                        break;

                }
            }
        }
        public static void CuctomerRole()
        {

            Console.WriteLine("Choose");
            Console.WriteLine("1. Check in");
            Console.WriteLine("2. Check Out");
            string choice= Console.ReadLine();
            SelectRooms selectRooms = new SelectRooms();
            SelectBooking selectBooking = new SelectBooking();
            switch (choice)
            {
                case "1":
                    hotelId = SelectByCity();
                    
                    ArrayList rooms = selectRooms.GetRoomByHotelId(hotelId);
                    Console.WriteLine("Rooms status");
                    Console.WriteLine(" RoomId  HotelId  RoomType  AvailableRooms  TotalRooms");
                    foreach (Room room in rooms)
                    {
                        Console.WriteLine(" {0}   {1}   {2}   {3}   {4}", room.RoomId, room.HotelId, room.RoomType, room.AvailableRooms, room.TotalRooms);
                    }

                    Console.WriteLine("Enter Room Id");
                    int roomId = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter your Details bellow");
                    Console.WriteLine("Enter FirstName");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Enter LastName");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Enter EmailId");
                    string emailId = Console.ReadLine();
                    Console.WriteLine("Enter Phone Numer");
                    string phoneNumber = Console.ReadLine();


                    SelectCustomer selectCustomer = new SelectCustomer();
                    custId = selectCustomer.InsertCustomerData(firstName, lastName, emailId, phoneNumber);
                    Console.WriteLine("Adding Booking Details");
                    
                    long bookingId = selectBooking.InsertBookingData(custId, hotelId);
                    Console.WriteLine("Booking Details are Added Id is {0}", bookingId);
                    selectRooms.UpdateRoomsData(roomId);
                    break;

                case "2":
                    hotelId = SelectByCity();
                    //ArrayList roomtocheckout = selectRooms.GetRoomByHotelId(hotelId);
                    //foreach (Room room in roomtocheckout)
                    //{
                    //    Console.WriteLine(" {0}   {1} ", room.RoomId, room.HotelId);
                    //}
                    Console.WriteLine("Enter your Booking Id for check out");
                    long bookingId1 = Convert.ToInt64(Console.ReadLine());
                    selectBooking.UpdateBookingData(bookingId1);
                    break;
            }


            

        }

        private static int SelectByCity()
        {
            Console.WriteLine("Enter Your City");
            string city = Console.ReadLine();
            SelectHotel selectHotel = new SelectHotel();
            ArrayList hotels = selectHotel.GetHotelsByCity(city);
            Console.WriteLine("hotels in {0}", city);
            foreach (Hotels hotel in hotels)
            {
                Console.WriteLine(hotel.HotelId + " . " + hotel.HotelName);
            }
            //int hotelId=
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void AgentRole()
        {
            string detailsByAgent;
           
                Console.WriteLine("1.To Enter Hotel Detail");
                Console.WriteLine("2.To Enter Room Detail");
                detailsByAgent = (Console.ReadLine());
                switch (detailsByAgent)
                {
                    case "1":
                        //SelectByCity();
                        Console.WriteLine("Enter Name of Hotel");
                        string hotelName = Console.ReadLine();
                        Console.WriteLine("Enter Phone Numer");
                        string phoneNumber = Console.ReadLine();
                        Console.WriteLine("Enter City");
                        string city = Console.ReadLine();
                        SelectHotel selectHotel = new SelectHotel();
                        //HotelDBOps hotelDBOps = new HotelDBOps();
                        //hotelDBOps.InsertHotels(hotelName, phoneNumber, city);
                        selectHotel.InsertHotelData(hotelName, phoneNumber, city);
                        break;
                    case "2":
                        int hotelId = SelectByCity();


                        //Console.WriteLine("Enter Id of Hotel");
                        //int hotelId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Room Type");
                        string roomType = Console.ReadLine();
                        Console.WriteLine("Enter Total Rooms");
                        int totalRooms = Convert.ToInt32(Console.ReadLine());
                        SelectRooms selectRooms = new SelectRooms();
                        //RoomDBOps roomDBOps = new RoomDBOps();
                        //roomDBOps.InsertRooms(hotelId, roomType, totalRooms, totalRooms);
                        selectRooms.InsertRoomsData(hotelId, roomType, totalRooms, totalRooms);

                        //AgentRole();
                        break;
                    default:
                        break;

                }
            
        }
        
}
}
