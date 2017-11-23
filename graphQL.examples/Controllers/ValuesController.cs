using graphQL.examples.IOC;
using System.Web.Http;

namespace graphQL.examples.Controllers
{
    //http://localhost:61688/api/values?query={user(id:1){userId:id userName:name totalUsers}}
    //http://localhost:61688/api/values?query={user(id:1){userId:id userName:name account {id paid}totalUsers}}
    public class ValuesController : ApiController
    {
        private readonly IGraphQLService graphQLService;

        public ValuesController(IGraphQLService graphQLService)
        {
            this.graphQLService = graphQLService;         
        }


        [HttpGet()]
        public string Get(string query)
        {
            return graphQLService.ExecuteQuery(query);

        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
