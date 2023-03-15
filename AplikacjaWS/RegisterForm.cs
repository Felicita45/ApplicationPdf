using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaWS
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            if (!String.IsNullOrEmpty(Properties.Settings.Default.language))
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.language);
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.language);
            }
            InitializeComponent();
        }
        public bool IsUserExists()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `logpass` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = textBoxLogin.Text;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show(MyStrings.Registered);
                return true;
            }
            else
                return false;
        }
        private void textBoxLogin_Enter(object sender, EventArgs e)
        {

            if (textBoxLogin.Text == "Wpisz Login" || textBoxLogin.Text == "Введіть Логін" || textBoxLogin.Text == "Введите логин")
                textBoxLogin.Text = "";
            textBoxLogin.ForeColor = Color.Black;
        }

        private void textBoxLogin_Leave(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "")
            {
                textBoxLogin.Text = MyStrings.Login;
                textBoxLogin.ForeColor = Color.Gray;
            }
        }
        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Wpisz Hasło" || textBoxPassword.Text == "Введіть Пароль" || textBoxPassword.Text == "Введите пароль")
                textBoxPassword.Text = "";
            textBoxPassword.ForeColor = Color.Black;
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = MyStrings.Password;
                textBoxPassword.ForeColor = Color.Gray;
            }
        }

        private void ButttonEnter_Click(object sender, EventArgs e)
        {
            
            if (textBoxLogin.Text == "Wpisz Hasło"  || textBoxLogin.Text == "Введіть Пароль" || textBoxLogin.Text == "Введите пароль" || textBoxLogin.Text == "")
            {
                MessageBox.Show(MyStrings.Login);
                return;
            }
            
            if (textBoxPassword.Text == "Wpisz Hasło" || textBoxPassword.Text == "Введіть Пароль" || textBoxPassword.Text == "Введите пароль" || textBoxPassword.Text == "")
            {
                MessageBox.Show(MyStrings.Password);
                return;
            }

            if (IsUserExists())
            {
                return;
            }

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `logpass` (`login`, `password`) VALUES (@login, @password)", db.getConnection());
            
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = textBoxLogin.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = textBoxPassword.Text;
            db.OpenConnetcion();

            if (command.ExecuteNonQuery() == 1)                
                MessageBox.Show(MyStrings.AccCreation,MyStrings.Create, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else                
                MessageBox.Show(MyStrings.NotCreated, MyStrings.ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            db.CloseConnection();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
           this.Hide();
            Login login = new Login();
            login.Show();
        }
        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Exit();
        }


    }
}
