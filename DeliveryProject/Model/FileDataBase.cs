using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Security.Principal;
using System.Text;
using Microsoft.VisualBasic.Logging;

namespace DeliveryProject
{
    public sealed class FileDataBase : IAccountManager, IProductStorage
    {
        // Хранение данных
        /* products.txt — файл, который содержит список продуктов, где данные расположены следующим образом:
        НАЗВАНИЕ
        ЦЕНА
        КОЛИЧЕСТВО
        */
        /* accounts.txt — файл, солержащий список аккаунтов, где данные расположены следующим образом:
        ЛОГИН
        ПАРОЛЬ
        РОЛЬ
        */

        public string Folder { get; }

        private IList<Product> products;

        public IList<Product> Products
        {
            get
            {
                return products;
            }
        }

        private List<Account> accounts;

        public IEnumerable<Account> Accounts => accounts;

        private string ProductsFile => Path.Combine(Folder, "products.txt");

        private string AccountsFile => Path.Combine(Folder, "accounts.txt");

        public FileDataBase(string folder)
        {
            if (Directory.Exists(Folder))
                throw new ArgumentException(null, nameof(folder));

            Folder = folder;
            products = LoadProducts();
            accounts = LoadAccounts();
        }

        public List<Product> LoadProducts()
        {
            List<Product> products = new List<Product>();

            string file = ProductsFile;

            if (File.Exists(file))
            {
                string[] lines = File.ReadAllLines(file);

                for (int i = 0; i < lines.Length; i += 3)
                {
                    Product product = DeserializeProduct(lines, i);

                    products.Add(product);
                }
            }

            return products;
        }

        private static Product DeserializeProduct(string[] lines, int start)
        {
            string name = lines[start];
            int count = int.Parse(lines[start + 1]);
            double price = double.Parse(lines[start + 2]);

            return new Product(name, price, count);
        }

        public bool TryAddAccount(string login, string password, Role role, [MaybeNullWhen(false)] out Account account)
        {
            if (TryGetAccount(login, out account))
            {
                return false;
            }

            account = new Account(login, password, role);
            accounts.Add(account);

            return true;
        }

        public bool TryGetAccount(string login, [MaybeNullWhen(false)] out Account account)
        {
            foreach(var item in accounts)
            {
                if(item.Login == login)
                {
                    account = item;
                    return true;
                }
            }

            account = null;
            return false;
        }

        private List<Account> LoadAccounts()
        {
            List<Account> accounts = new List<Account>();

            if (File.Exists(AccountsFile))
            {
                string[] lines = File.ReadAllLines(AccountsFile);

                for (int i = 0; i < lines.Length; i += 3)
                {
                    string login = lines[i];
                    string password = lines[i + 1];
                    Role role = Enum.Parse<Role>(lines[i + 2]);

                    Account account = new Account(login, password, role);
                    accounts.Add(account);
                }
            }

            return accounts;
        }

        public void SaveAccountData()
        {
            using (var stream = new FileStream(AccountsFile, FileMode.Create))
            {
                using (var writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    foreach (var account in accounts)
                    {
                        writer.WriteLine(account.Login);
                        writer.WriteLine(account.Password);
                        writer.WriteLine(account.Role.ToString());
                    }
                }
            }
        }

        public void SaveProductData()
        {
            using (var stream = new FileStream(ProductsFile, FileMode.Create))
            {
                using (var writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    foreach (var product in products)
                    {
                        writer.WriteLine(product.Name);
                        writer.WriteLine(product.Price);
                        writer.WriteLine(product.Count);
                    }
                }
            }
        }
    }
}
