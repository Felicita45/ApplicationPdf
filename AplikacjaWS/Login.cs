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
    public partial class Login : Form
    {
        public string LogInfo;
        public Login()
        {
            if (!String.IsNullOrEmpty(Properties.Settings.Default.language))
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.language);
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.language);
            }
                InitializeComponent();
        }
        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Exit();   
        }
        private void ButttonEnter_Click(object sender, EventArgs e)
        {
            string LoginUser = textBoxLogin.Text;

            string PassUser = textBoxPassword.Text;

            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            
            try
            {
                
                MySqlCommand command = new MySqlCommand("SELECT * FROM `logpass` WHERE `login` = @uL AND `password` = @uP", db.getConnection());
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginUser;
                command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = PassUser;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                adapter.Fill(table);
                LogInfo = LoginUser;
                if (table.Rows.Count > 0)
                {
                    this.Hide();
                    Form1 Form = new Form1();
                    Form.LogInfo = this.LogInfo;
                    Form.Show();


                }
                else
                    MessageBox.Show(MyStrings.Warning, MyStrings.ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show(MyStrings.NoConnection, MyStrings.ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
            
                       
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

        private void label2_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                RegisterForm registerForm = new RegisterForm();
                registerForm.Show();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = new System.Globalization.CultureInfo[]
            {
                System.Globalization.CultureInfo.GetCultureInfo("pl-PL"),
                System.Globalization.CultureInfo.GetCultureInfo("uk-UA"),
                System.Globalization.CultureInfo.GetCultureInfo("ru-Ru")
            };
            comboBox1.DisplayMember = "NativeName";
            comboBox1.ValueMember = "Name";
            if (!String.IsNullOrEmpty(Properties.Settings.Default.language))
            {
                comboBox1.SelectedValue = Properties.Settings.Default.language;                
            }
            
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.language = comboBox1.SelectedValue.ToString();
            Properties.Settings.Default.Save();
        }


    }
}
