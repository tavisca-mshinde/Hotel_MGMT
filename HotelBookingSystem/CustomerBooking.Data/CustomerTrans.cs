using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerData.Entity;
using System.Data;

namespace CustomerBooking.Data
{
    public class CustomerTrans
    {
       
             public static Customer ConverterCustomer(System.Data.DataSet customerDb)
                {
                    if (customerDb == null)
                        return null;
                    if (customerDb.Tables.Count > 0)
                    {
                        if (customerDb.Tables[0].Rows.Count > 0)
                        {
                            DataRow row = customerDb.Tables[0].Rows[0];
                            Customer cust = new Customer();
                            cust.Id = Convert.ToInt32(row["CustomerId"]);
                            cust.FirstName = row["FirstName"].ToString();
                            cust.LastName = row["LastName"].ToString();
                            cust.Email = row["EmailId"].ToString();
                            cust.PhoneNumber = row["PhoneNumber"].ToString();
                            return cust;
                        }
                    }
                    return null;
                }
        
    }
}
