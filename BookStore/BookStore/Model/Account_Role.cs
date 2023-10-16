namespace BookStore.Model
{
    public class Account_Role
    {
        public Guid roleId { get; set; }
        public Role role { get; set; }
        public Guid accountId { get; set; }
        public Account account { get; set; }

    }
}
