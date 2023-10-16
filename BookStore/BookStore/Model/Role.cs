using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Model
{
    public class Role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid id { get; set; }
        public String name { get; set; }
        public ICollection<Account_Role> account_Roles { get; set; }
        public Role()
        {
            account_Roles = new List<Account_Role>();
        }

    }
}
