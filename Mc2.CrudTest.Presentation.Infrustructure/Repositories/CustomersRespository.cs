using Mc2.CrudTest.Presentation.Domain;

namespace Mc2.CrudTest.Presentation.Infrustructure.Repositories
{
    public interface ICustomersRespository
    {
        IQueryable<Customer> GetAll();
        Customer Add(Customer item);
    }

    public class CustomersRespository : ICustomersRespository
    {
        private readonly Mc2Context context;
        public CustomersRespository(Mc2Context context)
        {
            this.context = context;
        }

        public IQueryable<Customer> GetAll()
        {
            return context.Customers;
        }
        public Customer Add(Customer item)
        {
            context.Customers.Add(item);
            context.SaveChanges();
            return item;
        }
    }
}
