using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;

namespace HotelBooking.Data
{
    public class HotelDBOps
    {
        public void InsertHotels(string HotelName, string PhoneNumber,string City)
        {
            DatabaseProviderFactory dbfactory = new DatabaseProviderFactory();
            Database defaultDB = dbfactory.CreateDefault();
            Database database = dbfactory.Create("HotelReservationSystem");
            DbCommand dbcommand = database.GetStoredProcCommand("spInsertHotels");
            //database.AddInParameter(dbcommand, "@HotelId", System.Data.DbType.Int16, HotelId);
            database.AddInParameter(dbcommand, "@HotelName", System.Data.DbType.String, HotelName);
            database.AddInParameter(dbcommand, "@PhoneNumber", System.Data.DbType.String, PhoneNumber);
            database.AddInParameter(dbcommand, "@City", System.Data.DbType.String, City);
            database.ExecuteScalar(dbcommand);
        }
        public System.Data.DataSet SelectHotelsById(int Id)
        {

            DatabaseProviderFactory dbprovider = new DatabaseProviderFactory();
            Database db = dbprovider.Create("HotelReservationSystem");
            DbCommand dbcommand = db.GetStoredProcCommand("spSelectHotels");
            db.AddInParameter(dbcommand, "@HotelId", System.Data.DbType.Int16, Id);

            return db.ExecuteDataSet(dbcommand);
        }
        public System.Data.DataSet SelectHotelsByCity(string city)
        {

            DatabaseProviderFactory dbprovider = new DatabaseProviderFactory();
            Database db = dbprovider.Create("HotelReservationSystem");
            DbCommand dbcommand = db.GetStoredProcCommand("spSelectHotelsByCity");
            db.AddInParameter(dbcommand, "@City", System.Data.DbType.String, city);

            return db.ExecuteDataSet(dbcommand);
        }
    }
}
