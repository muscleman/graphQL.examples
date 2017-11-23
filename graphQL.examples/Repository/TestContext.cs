using System.Data.Entity;

namespace graphQL.examples.Repository
{
    public class TestContext : DbContext
    {
        public IDbSet<User> Users { get; set; }
        public IDbSet<Account> Accounts { get; set; }
    }
}
