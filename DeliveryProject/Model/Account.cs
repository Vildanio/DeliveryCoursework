using System.Diagnostics.CodeAnalysis;

namespace DeliveryProject
{
    public class Account
    {
        public Role Role { get; }

        public string Login { get; }

        public string Password { get; }

        internal Account(string login, string password, Role role)
        {
            Role = role;
            Login = login;
            Password = password;
        }
    }
}
