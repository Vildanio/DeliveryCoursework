using System.Diagnostics.CodeAnalysis;
using DeliveryProject;

namespace DeliveryProject
{
    public interface IAccountManager
    {
        public bool TryGetAccount(string login, [MaybeNullWhen(false)] out Account account);

        public bool TryAddAccount(string login, string password, Role role, [MaybeNullWhen(false)] out Account account);

        public void SaveAccountData();
    }
}
