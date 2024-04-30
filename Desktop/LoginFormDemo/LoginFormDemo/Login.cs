using LoginFormDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFormDemo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            Users users1 = new Users();
           const string userFilePath = @"D:\LoginFormDemo\LoginFormDemo\LoginFormDemo\UserList.Txt";

            string userName=LoginTextBox1.Text;
            string userPassword = LgnTxtPassword.Text;

            List<string> userstring = new List<string>();
            List<Users> users = new List<Users>();

            userstring = File.ReadAllLines(userFilePath).ToList();

            users = FunctionClass.ReadAllLines(userstring);
            users.ForEach(u =>
            {
                if (u.role == Role.SuperAdmin.ToString() && userPassword == u.Password && u.UserName == userName)
                {
                    ChooseRole chooseRole = new ChooseRole();
                    chooseRole.Show(); this.Hide();
                }
                else
                {
                    lbErrorMessage.Text = "Error";
                    MessageBox.Show("Error");
                }             
                
            });
            users.ForEach((u) =>
            {
                if (u.role == Role.Admin.ToString() && u.UserName == userName && u.Password == userPassword)
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show(); this.Hide();
                }
            });
            users.ForEach((u) =>
            {
                if (u.role == Role.Person.ToString() && u.UserName == userName && u.Password == userPassword)
                {
                    PersonForm personForm = new PersonForm();
                    personForm.Show(); this.Hide();
                }

            });
           

        }

        private void LoginTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Loginn_Click(object sender, EventArgs e)
        {

        }

        private void Passwordd_Click(object sender, EventArgs e)
        {

        }
    }
}
