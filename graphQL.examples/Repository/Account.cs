using System.ComponentModel.DataAnnotations;

namespace graphQL.examples.Repository
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Paid { get; set; }
    }
}
