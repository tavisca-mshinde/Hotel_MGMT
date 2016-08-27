using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;

namespace RoomBooking.Data
{
    public class BookingDetailsDBOps
    {
        public Int64 InsertBookingDetails(long CustomerId,long HotelId)
        {
            DatabaseProviderFactory dbfactory = new DatabaseProviderFactory();
            Database defaultDB = dbfactory.CreateDefault();
            Database database = dbfactory.Create("HotelReservationSystem");
            DbCommand dbcommand = database.GetStoredProcCommand("spInsertBookingDetails");
            //database.AddInParameter(dbcommand, "@HotelId", System.Data.DbType.Int16, HotelId);
            database.AddInParameter(dbcommand, "@CustomerId", System.Data.DbType.Int64, CustomerId);
            database.AddInParameter(dbcommand, "@HotelId", System.Data.DbType.Int64, HotelId);
            //database.AddInParameter(dbcommand, "@AvailableRooms", System.Data.DbType.Int16, AvailableRooms);
            //database.AddInParameter(dbcommand, "@TotalRooms", System.Data.DbType.Int16, TotalRooms);
            return Convert.ToInt64(database.ExecuteScalar(dbcommand));
        }
        public System.Data.DataSet UpdateBookingDetails(long bookingId)
        {

            DatabaseProviderFactory dbprovider = new DatabaseProviderFactory();
            Database db = dbprovider.Create("HotelReservationSystem");
            DbCommand dbcommand = db.GetStoredProcCommand("spUpdateBookingDetails");
            db.AddInParameter(dbcommand, "@BookingId", System.Data.DbType.Int64, bookingId);

            return db.ExecuteDataSet(dbcommand);
        }
        public System.Data.DataSet SelectRoomsByHotelId(int HotelId)
        {

            DatabaseProviderFactory dbprovider = new DatabaseProviderFactory();
            Database db = dbprovider.Create("HotelReservationSystem");
            DbCommand dbcommand = db.GetStoredProcCommand("spSelectRoomsByHotelId");
            db.AddInParameter(dbcommand, "@HotelId", System.Data.DbType.Int16, HotelId);

            return db.ExecuteDataSet(dbcommand);
        }
    }
}
