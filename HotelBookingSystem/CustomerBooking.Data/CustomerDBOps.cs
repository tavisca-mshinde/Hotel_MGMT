using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;

namespace CustomerBooking.Data
{
    public class CustomerDBOps
    {

        public System.Data.DataSet SelectCusotmer(int Id)
        {

            DatabaseProviderFactory dbprovider = new DatabaseProviderFactory();
            Database db = dbprovider.Create("HotelReservationSystem");
            DbCommand dbcommand = db.GetStoredProcCommand("spSelectCustomer");
            db.AddInParameter(dbcommand, "@CustomerId", System.Data.DbType.Int16, Id);
            
            return db.ExecuteDataSet(dbcommand);
        }
        public void InsertCustomer(string FirstName, string LastName, string EmailId, string PhoneNumber)
        {
            DatabaseProviderFactory dbfactory = new DatabaseProviderFactory();
            Database defaultDB = dbfactory.CreateDefault();
            Database database = dbfactory.Create("HotelReservationSystem");
            DbCommand dbcommand = database.GetStoredProcCommand("spInsertCustomer");
            database.AddInParameter(dbcommand, "@FirstName", System.Data.DbType.String, FirstName);
            database.AddInParameter(dbcommand, "@LastName", System.Data.DbType.String, LastName);
            database.AddInParameter(dbcommand, "@EmailId", System.Data.DbType.String, EmailId);
            database.AddInParameter(dbcommand, "@PhoneNumber", System.Data.DbType.String, PhoneNumber);
            database.ExecuteScalar(dbcommand);
        }
        public void DeleteCustomer(int Id)
        {
            DatabaseProviderFactory dbprovider = new DatabaseProviderFactory();
            Database db = dbprovider.Create("HotelReservationSystem");
            DbCommand dbcommand = db.GetStoredProcCommand("spDeleteCustomer");
            db.AddInParameter(dbcommand, "@CustomerId", System.Data.DbType.Int16, Id);
        }
    }
}
