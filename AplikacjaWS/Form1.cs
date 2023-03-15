using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaWS
{
    public partial class Form1 : Form
    {
        public string LogInfo;
        private byte[] pdfData;
        private string FileName;
        public Form1()
        {
            MaximizeBox = false;
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

        public void loadData()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.OpenConnetcion();

            MySqlCommand command = new MySqlCommand("SELECT id, Login, FileName FROM `users` WHERE `Login` = @login", db.getConnection());
            
            command.Parameters.AddWithValue("@login", LogInfo);

                    
                    adapter.SelectCommand= command;
                    
                    adapter.Fill(table);                        
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = table;
                    dataGridView1.DataSource = bindingSource;     
                   
                
                db.CloseConnection();
            


        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                string filePath = openFileDialog1.FileName.ToString();
                FileName = Path.GetFileName(filePath);
                label1.Text = FileName;
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        
                         fileStream.CopyTo(memoryStream);

                         pdfData = memoryStream.ToArray();
                    }
                }
            }
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            if (pdfData==null || FileName ==null)
            {
                return;
            }

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`Login`, `File`, `FileName`) VALUES (@login, @file, @filename)", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = LogInfo;
            command.Parameters.Add("@filename", MySqlDbType.VarChar).Value = FileName;
            command.Parameters.Add("@file", MySqlDbType.MediumBlob).Value = pdfData;
            

            db.OpenConnetcion();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Сохранено в базе");
            else
                MessageBox.Show("Ошибка в отправке");

            db.CloseConnection();


        }
        public void GetPdf()
        {
            DB db = new DB();
            db.OpenConnetcion();
            MySqlCommand command = new MySqlCommand("SELECT `File` FROM users WHERE Filename=@FileName", db.getConnection());
            
            command.Parameters.AddWithValue("@FileName", FileName);                 
            
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string value = reader.GetString(0);
            }
            reader.Close();
            db.CloseConnection();
        }        

        private void button2_Click(object sender, EventArgs e)
        {
            GetPdf();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            loadData();
            
        }

       
    }
}
