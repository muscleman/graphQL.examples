using graphQL.examples.IOC;
using GraphQL.Net;
using Newtonsoft.Json;
using System.Linq;

namespace graphQL.examples.Repository
{
    public class GraphQLService : IGraphQLService
    {

        private GraphQL<TestContext> graphQL;

        public GraphQLService(IContext dbContext)
        {
            GraphQLSchema<TestContext>  schema = GraphQL<TestContext>.CreateDefaultSchema(() => dbContext.Context as TestContext);



            var user = schema.AddType<User>();
            user.AddAllFields();
            user.AddField("totalUsers", (db, u) => db.Users.Count());
            user.AddField("accountPaid", (db, u) => u.Account.Paid);

            schema.AddType<Account>().AddAllFields();
            schema.AddListField("users", db => db.Users);
            schema.AddField("user", new { id = 0 }, (db, args) => db.Users.Where(u => u.Id == args.id).FirstOrDefault());
            schema.Complete();


            graphQL = new GraphQL<TestContext>(schema);
        }

        public string ExecuteQuery(string query)
        {
            return JsonConvert.SerializeObject(graphQL.ExecuteQuery(query), Formatting.Indented);

        }
    }
}