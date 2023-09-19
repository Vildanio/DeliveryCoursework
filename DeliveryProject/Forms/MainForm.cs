using DeliveryProject;
using DeliveryProject.Pages;
using DeliveryProject.RolePages;

namespace DeliveryProject
{
    internal partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            var dataBase = new FileDataBase(Environment.CurrentDirectory);

            Session.ProductStorage = dataBase;
            Session.AccountManager = dataBase;
        }

        private void SubmitButton_Click_1(object sender, EventArgs e)
        {
            string login = loginBox.Text;
            string password = passwordBox.Text;

            if(login == string.Empty || password == string.Empty)
            {
                return;
            }

            if (Session.AccountManager.TryGetAccount(login, out Account? account))
            {
                if (account.Password == password)
                {
                    Form page;

                    if (account.Role == Role.Courier)
                    {
                        CourierPage courierPage = new CourierPage();
                        courierPage.FormClosed += (sender, e) => Session.Courier = null;

                        Session.Courier = courierPage;
                        page = courierPage;
                    }
                    else if (account.Role == Role.Storekeeper)
                    {
                        StorekeeperPage storekeeperPage = new StorekeeperPage();
                        storekeeperPage.FormClosed += (sender, e) => Session.Storekeeper = null;

                        Session.Storekeeper = storekeeperPage;
                        page = storekeeperPage;
                    }
                    else if (account.Role == Role.Dispatcher)
                    {
                        DispatcherPage dispatcherPage = new DispatcherPage();
                        dispatcherPage.FormClosed += (sender, e) => Session.Dispatcher = null;

                        Session.Dispatcher = dispatcherPage;
                        page = dispatcherPage;
                    }
                    else if (account.Role == Role.Administrator)
                    {
                        page = new AdministratorPage();
                    }
                    else
                    {
                        throw new NotSupportedException();
                    }

                    NavigateTo(page);
                }
                else
                {
                    MessageBox.Show("Неверный пароль");
                }
            }
            else
            {
                MessageBox.Show("Аккаунт не найден");
            }
        }

        private void NavigateTo(Form form)
        {
            form.Show();
            loginBox.Text = string.Empty;
            passwordBox.Text = string.Empty;
        }

        private void ContinueAsClientButton_Click(object sender, EventArgs e)
        {
            NavigateTo(new ClientPage());
        }

        protected override void OnClosed(EventArgs e)
        {
            Session.AccountManager.SaveAccountData();

            base.OnClosed(e);
        }
    }
}