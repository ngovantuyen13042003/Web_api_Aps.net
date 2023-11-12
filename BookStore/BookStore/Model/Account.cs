using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Model
{
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public String username { get; set; }
        public String password { get; set; }

        public int customerId { get; set; }
        public Customer customer { get; set; }

        public int roleId { get; set; }
        public String role { get; set; }
       
    }
}
