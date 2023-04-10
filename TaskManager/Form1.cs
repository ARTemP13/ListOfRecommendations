using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaskManager
{

    
    public partial class Form1 : Form
    {
        //string defaultPassword = "dsd";
        DataBase dataBase = new DataBase();
        int key = 1;
        public Form1()
        {
            InitializeComponent();
            SetRoundedShape(panel1, 30);
            SetRoundedShape(button2, 20);
            SetRoundedShape(textBox1, 20);
            SetRoundedShape(textBox2, 20);
            textBox1.Text = "example@gmail.com";
            textBox1.ForeColor = Color.Silver;
            textBox2.Text = "************";
            textBox2.ForeColor = Color.Silver;
            button3.BackgroundImage = Properties.Resources.closedeye;
            StartPosition = FormStartPosition.CenterScreen;
            panel2.Visible = false;
            textBox4.Text = "E-mail";
            textBox4.ForeColor = Color.Silver;
        }
        static void SetRoundedShape(Control control, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddLine(radius, 0, control.Width - radius, 0);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddLine(control.Width, radius, control.Width, control.Height - radius);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddLine(control.Width - radius, control.Height, radius, control.Height);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.AddLine(0, control.Height - radius, 0, radius);
            path.AddArc(0, 0, radius, radius, 180, 90);
            control.Region = new Region(path);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "example@gmail.com")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "example@gmail.com";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "************")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }
        private void textBox2_Leave_1(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "************";
                textBox2.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox2.PasswordChar == '\0')
            {
                textBox2.PasswordChar = '*';
                button3.BackgroundImage = Properties.Resources.closedeye;
            } else
            {
                textBox2.PasswordChar = '\0';
                button3.BackgroundImage = Properties.Resources.eye;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string CheckEmail = textBox1.Text;
            string CheckPassword = Hashing.PasswordHashing(textBox2.Text);
            int dogs = 0;
            int dots = 0;
            for(int i = 0; i < CheckEmail.Length; i++)
            {
                if('@' == CheckEmail[i]) dogs++;
                if('.' == CheckEmail[i]) dots++;
            }
            if(dogs == 1 && dots == 1)
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                DataTable dt = new DataTable();

                string querystring = $"select id, names, surnames, emails, passwords from accounts_db where emails = '{CheckEmail}' and passwords = '{CheckPassword}'";

                SqlCommand sqlCommand = new SqlCommand(querystring, dataBase.getConnection());

                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dt);

                if(dt.Rows.Count == 1)
                {
                    this.Hide();
                    MainApplicationList mainApplicationList = new MainApplicationList();
                    mainApplicationList.Show();
                } else
                {
                    MessageBox.Show("Неправильный логин или пароль");
                    textBox1.Text = "example@gmail.com";
                    textBox1.ForeColor = Color.Silver;
                    textBox2.Text = "************";
                    textBox2.ForeColor = Color.Silver;
                }



            } else
            {
                textBox1.Text = "example@gmail.com";
                textBox1.ForeColor = Color.Silver;
                textBox2.Text = "************";
                textBox2.ForeColor = Color.Silver;
                MessageBox.Show("Непарвильный формат ввода почты");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                MailAddress from = new MailAddress("testerov9911@mail.ru", "Администрация приложения Avto");
                MailAddress to = new MailAddress(textBox4.Text);
                MailMessage m = new MailMessage(from, to);
                m.Subject = "Восстановление пароля";
                string str21 = newPasswordAccount();
                m.Body = $"Ваш новый пароль: {str21}";
                m.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);
                smtp.Credentials = new NetworkCredential("testerov9911@mail.ru", "XLFqLGzHAHf4PVF3anWE");
                smtp.EnableSsl = true;
                panel2.Visible = false;
                try
                {
                    smtp.Send(m);
                    MessageBox.Show("Сообщение отпралено");
                    ChangePassword(str21);
                }
                catch
                {
                    MessageBox.Show("Сообщение не отпралено");
                }
                Console.Read();
                textBox4.Text = "";
            } catch
            {
                MessageBox.Show("Ошибка в вводе почты!");
            }
        }

        private void textBox4_Enter_1(object sender, EventArgs e)
        {
            if (textBox4.Text == "E-mail")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave_1(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "E-mail";
                textBox4.ForeColor = Color.Silver;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
        private string newPasswordAccount()
        {
            Random rnd = new Random();

            string value = rnd.Next(100000,1000000).ToString();
            int key = rnd.Next(1,127);
            dataBase.openConnection();
            SqlCommand sqlCom = new SqlCommand($"SELECT names FROM accounts_db WHERE emails = '{textBox4.Text}'", dataBase.getConnection());
            string str = sqlCom.ExecuteScalar().ToString();
            str = str + value;
            char[] chars = str.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                int c = str[i];
                c = (c + key) % 128;
                chars[i] = (char)c;
            }
            string str1 = new string(chars);
            dataBase.closedConnection();
            return str1;

        }
        private void ChangePassword(string newPassword)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string querystring = $"UPDATE accounts_db SET passwords = '{Hashing.PasswordHashing(newPassword)}' WHERE emails = '{textBox4.Text}'";

            SqlCommand sqlCommand = new SqlCommand(querystring, dataBase.getConnection());

            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dt);
        }
    }
}
