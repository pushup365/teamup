namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        // asp.net identity
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

    }
}