using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using examplemvcwindowsform.Controllers;
using examplemvcwindowsform.Models;

namespace examplemvcwindowsform.Views
{
    public partial class LoginForm : Form
    {
        private readonly LoginController _loginController;
        public LoginForm(LoginController loginController)
        {
            _loginController = loginController;
            InitializeComponent();
        }

 

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text
            };

            if (_loginController.TryLogin(user))
            {
                MessageBox.Show("Login bem-sucedido!");
            }
            else
            {
                MessageBox.Show("Credenciais inválidas. Tente novamente.");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
