using graphQL.examples.Repository;
using System.Collections.Generic;

namespace graphQL.examples.IOC
{
    public interface IGraphQLService
    {
        //IContext Context { get; set; }

        string ExecuteQuery(string query);
    }
}
