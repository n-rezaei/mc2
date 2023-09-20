using Mc2.CrudTest.AcceptanceTests.Bases;
using Mc2.CrudTest.Presentation.Infrustructure.Repositories;
using Mc2.CrudTest.Presentation.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mc2.CrudTest.AcceptanceTests.CRUD
{
    [TestClass]
    public class CustomerTests : BaseTest
    {
        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("First Name 1")]
        public void TestEmptyName(string firstName)
        {
            var customer = new Customer { FirstName = firstName};
            Assert.IsNull(customer.FirstName);
            Assert.IsTrue(customer.FirstName.Length > 0);
        }

        [TestMethod]
        public void Add()
        {
            var customer = new Customer()
            {
                BankAccountNumber = "123",
                DateOfBirth = DateTime.Now,
                Email = "email1@mail.com",
                FirstName = "FirstName 1",
                LastName = "LastName 1",
                PhoneNumber = "1234567890",
            };

            customer = new CustomersRespository(context).Add(customer);

            Assert.Equals(1, context.Customers.Count());
        }
    }
}
