using System.ComponentModel.DataAnnotations;

namespace graphQL.examples.Repository
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
}
