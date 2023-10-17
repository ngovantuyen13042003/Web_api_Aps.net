namespace BookStore.Model
{
    public class Account_Role
    {
        public int roleId { get; set; }
        public Role role { get; set; }
        public int accountId { get; set; }
        public Account account { get; set; }

    }
}
