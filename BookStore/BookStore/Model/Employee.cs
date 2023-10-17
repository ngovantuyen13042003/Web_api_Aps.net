using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Model
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public  int id { get; set; }
        public String name { get; set; }
        public ICollection<Account> account { get; set; }
        public Employee()
        {
            account = new List<Account>();
        }

    }
}
