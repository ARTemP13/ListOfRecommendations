using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace TaskManager
{
    public partial class SignUp : Form
    {
        DataBase dataBase = new DataBase();
        public SignUp()
        {
            InitializeComponent();
            SetRoundedShape(panel1,35);
            SetRoundedShape(textBox1, 20);
            SetRoundedShape(textBox2, 20);
            SetRoundedShape(textBox3, 20);
            SetRoundedShape(textBox4, 20);
            SetRoundedShape(button1, 30);
            textBox1.Text = "имя";
            textBox2.Text = "фамилия";
            textBox3.Text = "example@gmail.com";
            textBox4.Text = "************";
            textBox1.ForeColor = Color.Silver;
            textBox2.ForeColor = Color.Silver;
            textBox3.ForeColor = Color.Silver;
            textBox4.ForeColor = Color.Silver;
            StartPosition = FormStartPosition.CenterScreen;
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





        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "имя")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "имя";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "фамилия")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "фамилия";
                textBox2.ForeColor = Color.Silver;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "example@gmail.com")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "example@gmail.com";
                textBox3.ForeColor = Color.Silver;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "************")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "************";
                textBox4.ForeColor = Color.Silver;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.PasswordChar == '\0')
            {
                textBox4.PasswordChar = '*';
                button3.BackgroundImage = Properties.Resources.closedeye;
            }
            else
            {
                textBox4.PasswordChar = '\0';
                button3.BackgroundImage = Properties.Resources.eye;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            string createName = textBox1.Text;
            string createSurname = textBox2.Text;
            string createEmail = textBox3.Text;
            string createPassword = Hashing.PasswordHashing(textBox4.Text);

            int dogs = 0;
            int dots = 0;
            for (int i = 0; i < createEmail.Length; i++)
            {
                if ('@' == createEmail[i]) dogs++;
                if ('.' == createEmail[i]) dots++;
            }
            if(dots == 1 && dogs == 1 && (createName != "имя" && createSurname != "фамилия" && createEmail != "example@gmail.com" && createPassword != "************"))
            {
                if (!checkUser())
                {
                    string querystring = $"insert into accounts_db (names, surnames, emails, passwords) values ('{createName}', '{createSurname}', '{createEmail}', '{createPassword}')";

                    SqlCommand sqlCommand = new SqlCommand(querystring, dataBase.getConnection());

                    dataBase.openConnection();

                    if (sqlCommand.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Аккаунт успешно создан!");
                        this.Hide();
                        Form1 form = new Form1();
                        form.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка!!!");
                    }
                    dataBase.closedConnection();
                }
            } else
            {
                MessageBox.Show("Некорректный ввод данных!");
            }
        }
        private bool checkUser()
        {
            var checkEmail = textBox3.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            string querystring = $"select id, emails from accounts_db where emails = '{checkEmail}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            if(dataTable.Rows.Count > 0 )
            {
                MessageBox.Show("Пользователь с такой почтой уже существует");
                return true;
            } else 
            { 
                return false; 
            }
        } 
    }
}
