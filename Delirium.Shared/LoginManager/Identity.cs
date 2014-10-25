namespace Delirium.Shared
{
    public class Identity
    {
        public Identity(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }

        public string Email { get; private set; }

        public string Password { get; private set; }
    }
}
