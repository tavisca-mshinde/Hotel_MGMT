using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;

namespace RoomBooking.Data
{
    public class RoomDBOps
    {
        public void InsertRooms(int HotelId, string RoomType, int AvailableRooms,int TotalRooms)
        {
            DatabaseProviderFactory dbfactory = new DatabaseProviderFactory();
            Database defaultDB = dbfactory.CreateDefault();
            Database database = dbfactory.Create("HotelReservationSystem");
            DbCommand dbcommand = database.GetStoredProcCommand("spInsertRooms");
            //database.AddInParameter(dbcommand, "@HotelId", System.Data.DbType.Int16, HotelId);
            database.AddInParameter(dbcommand, "@HotelId", System.Data.DbType.Int16, HotelId);
            database.AddInParameter(dbcommand, "@RoomType", System.Data.DbType.String, RoomType);
            database.AddInParameter(dbcommand, "@AvailableRooms", System.Data.DbType.Int16, AvailableRooms);
            database.AddInParameter(dbcommand, "@TotalRooms", System.Data.DbType.Int16, TotalRooms);
            database.ExecuteScalar(dbcommand);
        }
        public System.Data.DataSet SelectRoomsByHotelId(long HotelId)
        {

            DatabaseProviderFactory dbprovider = new DatabaseProviderFactory();
            Database db = dbprovider.Create("HotelReservationSystem");
            DbCommand dbcommand = db.GetStoredProcCommand("spSelectRoomsByHotelId");
            db.AddInParameter(dbcommand, "@HotelId", System.Data.DbType.Int64, HotelId);

            return db.ExecuteDataSet(dbcommand);
        }
        public void UpdateRoomsdata(int roomId)
        {

            DatabaseProviderFactory dbprovider = new DatabaseProviderFactory();
            Database db = dbprovider.Create("HotelReservationSystem");
            DbCommand dbcommand = db.GetStoredProcCommand("spUpdateRoomsdata");
            db.AddInParameter(dbcommand, "@RoomId", System.Data.DbType.Int16, roomId);

            db.ExecuteDataSet(dbcommand);
        }

    }
}
