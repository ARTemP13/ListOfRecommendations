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
                        string querystring1 = $"SELECT * INTO {createName}{createSurname}Table FROM cars_db";
                        SqlCommand sqlCommand1 = new SqlCommand(querystring1, dataBase.getConnection());
                        sqlCommand1.ExecuteNonQuery();
                        string querystring2 = $"ALTER TABLE [{createName}{createSurname}Table] ADD Score INT DEFAULT 0;";
                        SqlCommand sqlCommand2 = new SqlCommand(querystring2, dataBase.getConnection());
                        sqlCommand2.ExecuteNonQuery();
                        string querystring3 = $"ALTER TABLE [{createName}{createSurname}Table] ADD Favorites INT DEFAULT 0;";
                        SqlCommand sqlCommand3 = new SqlCommand(querystring3, dataBase.getConnection());
                        sqlCommand3.ExecuteNonQuery();
                        string querystring4 = $"UPDATE [{createName}{createSurname}Table] SET Score = 0 WHERE Score IS NULL;";
                        SqlCommand sqlCommand4 = new SqlCommand(querystring4, dataBase.getConnection());
                        sqlCommand4.ExecuteNonQuery();
                        string querystring5 = $"UPDATE [{createName}{createSurname}Table] SET Favorites = 0 WHERE Favorites IS NULL;";
                        SqlCommand sqlCommand5 = new SqlCommand(querystring5, dataBase.getConnection());
                        sqlCommand5.ExecuteNonQuery();
                        string querystring6 = $"ALTER TABLE [{createName}{createSurname}Table] ADD CarsSelect INT DEFAULT 1;";
                        SqlCommand sqlCommand6 = new SqlCommand(querystring6, dataBase.getConnection());
                        sqlCommand6.ExecuteNonQuery();
                        string querystring7 = $"UPDATE [{createName}{createSurname}Table] SET CarsSelect = 1 WHERE CarsSelect IS NULL;";
                        SqlCommand sqlCommand7 = new SqlCommand(querystring7, dataBase.getConnection());
                        sqlCommand7.ExecuteNonQuery();
                        string querystring8 = $"ALTER TABLE [{createName}{createSurname}Table] ADD PlayList VARCHAR(50);";
                        SqlCommand sqlCommand8 = new SqlCommand(querystring8, dataBase.getConnection());
                        sqlCommand8.ExecuteNonQuery();

                        string querystring9 = $"ALTER TABLE [{createName}{createSurname}Table] ADD MinPrice INT DEFAULT 1;";
                        SqlCommand sqlCommand9 = new SqlCommand(querystring9, dataBase.getConnection());
                        sqlCommand9.ExecuteNonQuery();
                        string querystring10 = $"UPDATE [{createName}{createSurname}Table] SET MinPrice = 1 WHERE MinPrice IS NULL;";
                        SqlCommand sqlCommand10 = new SqlCommand(querystring10, dataBase.getConnection());
                        sqlCommand10.ExecuteNonQuery();

                        string querystring11 = $"ALTER TABLE [{createName}{createSurname}Table] ADD MaxPrice INT DEFAULT 1;";
                        SqlCommand sqlCommand11 = new SqlCommand(querystring11, dataBase.getConnection());
                        sqlCommand11.ExecuteNonQuery();
                        string querystring12 = $"UPDATE [{createName}{createSurname}Table] SET MaxPrice = 100000000 WHERE MaxPrice IS NULL;";
                        SqlCommand sqlCommand12 = new SqlCommand(querystring12, dataBase.getConnection());
                        sqlCommand12.ExecuteNonQuery();

                        string querystring13 = $"ALTER TABLE [{createName}{createSurname}Table] ADD MinSpeed INT DEFAULT 1;";
                        SqlCommand sqlCommand13 = new SqlCommand(querystring13, dataBase.getConnection());
                        sqlCommand13.ExecuteNonQuery();
                        string querystring14 = $"UPDATE [{createName}{createSurname}Table] SET MinSpeed = 1 WHERE MinSpeed IS NULL;";
                        SqlCommand sqlCommand14 = new SqlCommand(querystring14, dataBase.getConnection());
                        sqlCommand14.ExecuteNonQuery();

                        string querystring15 = $"ALTER TABLE [{createName}{createSurname}Table] ADD MxSpeed INT DEFAULT 1;";
                        SqlCommand sqlCommand15 = new SqlCommand(querystring15, dataBase.getConnection());
                        sqlCommand15.ExecuteNonQuery();
                        string querystring16 = $"UPDATE [{createName}{createSurname}Table] SET MxSpeed = 450 WHERE MxSpeed IS NULL;";
                        SqlCommand sqlCommand16 = new SqlCommand(querystring16, dataBase.getConnection());
                        sqlCommand16.ExecuteNonQuery();

                        string querystring17 = $"ALTER TABLE [{createName}{createSurname}Table] ADD mPower INT DEFAULT 1;";
                        SqlCommand sqlCommand17 = new SqlCommand(querystring17, dataBase.getConnection());
                        sqlCommand17.ExecuteNonQuery();
                        string querystring18 = $"UPDATE [{createName}{createSurname}Table] SET mPower = 1 WHERE mPower IS NULL;";
                        SqlCommand sqlCommand18 = new SqlCommand(querystring18, dataBase.getConnection());
                        sqlCommand18.ExecuteNonQuery();

                        string querystring19 = $"ALTER TABLE [{createName}{createSurname}Table] ADD MxPower INT DEFAULT 1;";
                        SqlCommand sqlCommand19 = new SqlCommand(querystring19, dataBase.getConnection());
                        sqlCommand19.ExecuteNonQuery();
                        string querystring20 = $"UPDATE [{createName}{createSurname}Table] SET MxPower = 5000 WHERE MxPower IS NULL;";
                        SqlCommand sqlCommand20 = new SqlCommand(querystring20, dataBase.getConnection());
                        sqlCommand20.ExecuteNonQuery();

                        string querystring21 = $"ALTER TABLE [{createName}{createSurname}Table] ADD CountrySelect INT DEFAULT 1;";
                        SqlCommand sqlCommand21 = new SqlCommand(querystring21, dataBase.getConnection());
                        sqlCommand21.ExecuteNonQuery();
                        string querystring22 = $"UPDATE [{createName}{createSurname}Table] SET CountrySelect = 1 WHERE CountrySelect IS NULL;";
                        SqlCommand sqlCommand22 = new SqlCommand(querystring22, dataBase.getConnection());
                        sqlCommand22.ExecuteNonQuery();

                        string querystring23 = $"ALTER TABLE [{createName}{createSurname}Table] ADD AllPlayList VARCHAR(50) DEFAULT 1;";
                        SqlCommand sqlCommand23 = new SqlCommand(querystring23, dataBase.getConnection());
                        sqlCommand23.ExecuteNonQuery();
                        string querystring24 = $"UPDATE [{createName}{createSurname}Table] SET AllPlayList = 'Empty' WHERE AllPlayList IS NULL;";
                        SqlCommand sqlCommand24 = new SqlCommand(querystring24, dataBase.getConnection());
                        sqlCommand24.ExecuteNonQuery();


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
