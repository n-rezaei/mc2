using Mc2.CrudTest.Presentation.Infrustructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace Mc2.CrudTest.AcceptanceTests.Bases
{
    public class BaseTest
    {
        protected Mc2Context context;
        public BaseTest(Mc2Context context = null)
        {
            this.context = context ?? GetDBContext();
        }
        protected Mc2Context GetDBContext()
        {
            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkInMemoryDatabase()
                .BuildServiceProvider();

            var builder = new DbContextOptionsBuilder<Mc2Context>();
            var options = builder.UseSqlServer("Mc2InMemoryDB").UseInternalServiceProvider(serviceProvider).Options;

            Mc2Context dbContext = new Mc2Context(options);
            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();
            return dbContext;
        }
    }
}
