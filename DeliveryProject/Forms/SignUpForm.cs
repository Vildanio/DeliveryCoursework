using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryProject
{
    public partial class SignUpForm : Form
    {
        private readonly IAccountManager accountManager;

        public SignUpForm(IAccountManager dataBase)
        {
            InitializeComponent();

            this.accountManager = dataBase;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string login = loginBox.Text;
            string password = passwordBox.Text;

            if (TryGetRole(roleBox.Text, out Role role))
            {
                if (accountManager.TryAddAccount(login, password, role, out _))
                {
                    MessageBox.Show("Аккаунт успешно зарегестрирован");
                }
                else
                {
                    MessageBox.Show("Аккаунт с таким логином уже существует");
                }
            }
            else
            {
                MessageBox.Show("Некорректное название роли");
            }

            this.Close();
        }

        private static bool TryGetRole(string name, out Role role)
        {
            switch (name)
            {
                case "Админстратор":
                    role = Role.Administrator;
                    return true;
                case "Кладовщик":
                    role = Role.Storekeeper;
                    return true;
                case "Диспетчер":
                    role = Role.Dispatcher;
                    return true;
                case "Курьер":
                    role = Role.Courier;
                    return true;
                default:
                    role = default;
                    return false;
            }
        }
    }
}
