using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Model
{
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid id { get; set; }
        public String username { get; set; }
        public String password { get; set; }

        public Guid customerId { get; set; }
        public Customer customer { get; set; }
        public Guid employeeId { get; set; }
        public Employee employee { get; set; }

        public ICollection<Account_Role> account_Roles { get; set; }
        public Account()
        {
            account_Roles = new List<Account_Role>();
        }
    }
}
