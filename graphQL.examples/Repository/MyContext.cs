using System.Data.Entity;

namespace graphQL.examples.Repository
{
    public class MyContext : IContext
    {
        public DbContext Context { get; set; }

        public MyContext(string connectionString = null)
        {
            Context = new TestContext();
        }

    }
}