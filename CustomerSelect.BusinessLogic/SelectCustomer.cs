using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerData.Entity;
using CustomerBooking.Data;

namespace CustomerSelect.BusinessLogic
{
    public class SelectCustomer
    {
        public Customer GetCustomerById(int Id)
        {
            CustomerDBOps customerdbops = new CustomerDBOps();
               //customerdbops.SelectCusotmer(Id);
            return CustomerTrans.ConverterCustomer(customerdbops.SelectCusotmer(Id));
        }
        public Int64 InsertCustomerData(string FirstName, string LastName, string EmailId, string PhoneNumber)
        {
            CustomerDBOps customerDBOps = new CustomerDBOps();
            Int64 a= customerDBOps.InsertCustomer(FirstName, LastName, EmailId, PhoneNumber);
            return a;
        }

    }
}
