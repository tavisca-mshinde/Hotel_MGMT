using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerBooking.Data;
//using CustomerData.Entity;
//using CustomerSelect.BusinessLogic;



namespace CustomerSelect.TestSuite
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void TestSelectCustomer()
        {
                               //CustomerDBOps custdbops = new CustomerDBOps();
            //SelectCustomer sc = new SelectCustomer();
            //Customer data = sc.GetCustomerById(9);
        }
        [TestMethod]
        public void TestCustomerInsert()
        {
            //CustomerDBOps custdbops = new CustomerDBOps();
            //custdbops.InsertCustomer("sagyy", "sanap","sj@tvsc.com", "23");
        }
        public void TestCustomerDelete()
        {
            CustomerDBOps custdbops = new CustomerDBOps();
            custdbops.DeleteCustomer(2);
        }
    }
}
