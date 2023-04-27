using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Status;
using static TaskManager.MainApplicationList;

namespace TaskManager
{
    
    public partial class MainApplicationList : Form

    {
        DataBase dataBase = new DataBase();
        int FavoriteNow = 0;
        class MyFlowLayoutPanel : FlowLayoutPanel
        {
            public MyFlowLayoutPanel()
            {
                this.DoubleBuffered = true;
            }
            protected override void OnScroll(ScrollEventArgs se)
            {
                this.Invalidate();
                base.OnScroll(se);
            }

        }
        public class CustomEventArgs : EventArgs
        {
            public int FavoriteNow { get; set; }
        }
        

        public class CustomFlowLayoutPanel : FlowLayoutPanel
        {
            public CustomFlowLayoutPanel()
                : base()
            {
                this.SetStyle(ControlStyles.UserPaint, true);
                this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
                this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            }

            protected override void OnScroll(ScrollEventArgs se)
            {
                this.Invalidate();

                base.OnScroll(se);
            }
            protected override CreateParams CreateParams
            {
                get
                {
                    CreateParams cp = base.CreateParams;
                    cp.ExStyle |= 0x02000000;
                    return cp;
                }
            }
        }
        string ThisEmail;
        public MainApplicationList(string email)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            DoubleBuffered = true;
            SetRoundedShape(FavoritesButton, 40);
            SetRoundedShape(selectionsButton, 40);
            SetRoundedShape(FeaturesButton, 40);
            SetRoundedShape(PlusCar, 40);
            SetRoundedShape(AddPlayList, 20);
            ThisEmail = email;
            Setting.Visible = false;
            panel4.Visible = false;
            SetRoundedShape(Setting, 40);
            CreateCards();
            setting();
            AddPlayList.Visible = false;
            label8.Cursor = Cursors.Hand;
            
        }
        string name = "", surname = "";
        string cars = "", models = "";
        int idcar = 0;
        public void CreateCards()
        {
            MyFlowLayoutPanel panel1 = new MyFlowLayoutPanel();
            panel1.FlowDirection = FlowDirection.LeftToRight;
            panel1.AutoSize = true;
            dataBase.openConnection();
            string queryTable = $"SELECT names, surnames FROM accounts_db WHERE emails = '{ThisEmail}';";
            SqlCommand command = new SqlCommand(queryTable, dataBase.getConnection());
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                name = reader.GetString(0);
                surname = reader.GetString(1);
            }
            reader.Close();

            string query1 = $"SELECT COUNT(*) FROM {name}{surname}Table WHERE priceRUB >= MinPrice AND priceRUB <= MaxPrice AND maxspeed >= MinSpeed AND maxspeed <= MxSpeed AND horsepower >= mPower AND horsepower <= MxPower AND CarsSelect = 1 AND CountrySelect = 1";
            SqlCommand command1 = new SqlCommand(query1, dataBase.getConnection());
            int rowCount = 0;
            rowCount = (int)command1.ExecuteScalar();
            List<int> id = new List<int>();
            List<string> car = new List<string>();
            List<string> model = new List<string>();
            List<int> price = new List<int>();
            List<int> speed = new List<int>();
            List<int> power = new List<int>();
            List<string> country = new List<string>();
            List<int> score = new List<int>();
            List<int> favorite = new List<int>();
            string query2 = $"SELECT id, brand, model, priceRUB, maxspeed, horsepower, country, Score, Favorites FROM {name}{surname}Table WHERE priceRUB >= MinPrice AND priceRUB <= MaxPrice AND maxspeed >= MinSpeed AND maxspeed <= MxSpeed AND horsepower >= mPower AND horsepower <= MxPower AND CarsSelect = 1 AND CountrySelect = 1";
            SqlCommand command2 = new SqlCommand(query2, dataBase.getConnection());
            using (SqlDataReader reader3 = command2.ExecuteReader())
            {
                while (reader3.Read())
                {
                    id.Add(reader3.GetInt32(0));
                    car.Add(reader3.GetString(1));
                    model.Add(reader3.GetString(2));
                    price.Add(reader3.GetInt32(3));
                    speed.Add(reader3.GetInt32(4));
                    power.Add(reader3.GetInt32(5));
                    country.Add(reader3.GetString(6));
                    score.Add(reader3.GetInt32(7));
                    favorite.Add(reader3.GetInt32(8));
                }
            }
            if (rowCount >= 50) rowCount = 50;
            for (int i = 0; i < rowCount; i++)
            {
                cars = car[i];
                models = model[i];
                idcar = id[i];
                Panel panel3 = new Panel();

                PictureBox pictureBox = new PictureBox();
                try
                {
                    pictureBox.Image = Image.FromFile($"../../Cars/{car[i]}{model[i]}.jpg");
                }
                catch
                {
                }
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Width = 400;
                pictureBox.Height = 300;
                panel3.Controls.Add(pictureBox);

                panel3.BackColor = Color.White;
                panel3.Size = new Size(950, 300);
                panel1.Controls.Add(panel3);

                Label label = new Label();
                label.Text = $"{car[i]} {model[i]}";
                label.Location = new Point(420, 10);
                label.AutoSize = true;
                label.Font = new Font("Segoe UI Variable Display Semib", 20, FontStyle.Bold);
                panel3.Controls.Add(label);

                Label label1 = new Label();
                label1.Text = $"Цена:  {price[i]}₽";
                label1.Location = new Point(410, 80);
                label1.AutoSize = true;
                label1.Font = new Font("Segoe UI Variable Display Semib", 16);
                panel3.Controls.Add(label1);

                Label label2 = new Label();
                label2.Text = $"Максимальная скорость: {speed[i]} км/ч";
                label2.Location = new Point(410, 120);
                label2.AutoSize = true;
                label2.Font = new Font("Segoe UI Variable Display Semib", 16);
                panel3.Controls.Add(label2);

                Label label3 = new Label();
                label3.Text = $"Мощность: {power[i]} л.c";
                label3.Location = new Point(410, 160);
                label3.AutoSize = true;
                label3.Font = new Font("Segoe UI Variable Display Semib", 16);
                panel3.Controls.Add(label3);

                Label label4 = new Label();
                label4.Text = $"Страна: {country[i].ToString()}";
                label4.Location = new Point(410, 200);
                label4.AutoSize = true;
                label4.Font = new Font("Segoe UI Variable Display Semib", 16);
                panel3.Controls.Add(label4);

                SetRoundedShape(panel3, 40);

                Label label5 = new Label();
                label5.Text = "Оценка: ";
                label5.Location = new Point(700, 250);
                label5.AutoSize = true;
                label5.Font = new Font("Segoe UI Variable Display Semib", 12);
                panel3.Controls.Add(label5);

                NumericUpDown numericUpDown1 = new NumericUpDown();
                numericUpDown1.Width = 40;
                numericUpDown1.Height = 50;
                numericUpDown1.Location = new Point(795, 255);
                numericUpDown1.Maximum = 9;
                numericUpDown1.Minimum = 0;
                numericUpDown1.Value = score[i];
                numericUpDown1.Cursor = Cursors.Hand;
                numericUpDown1.Tag = idcar;
                panel3.Controls.Add(numericUpDown1);
                numericUpDown1.ValueChanged += new EventHandler(numericUpDown1_ValueChanged);

                PictureBox pictureBox1 = new PictureBox();
                pictureBox1.Image = Image.FromFile("../../picture/Plus1.png");
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Width = 50;
                pictureBox1.Cursor = Cursors.Hand;
                pictureBox1.Height = 50;
                pictureBox1.Tag = idcar;
                pictureBox1.Location = new Point(880, 240);
                panel3.Controls.Add(pictureBox1);
                pictureBox1.Click += new EventHandler(pictureBox1_Click);

                PictureBox pictureBox2 = new PictureBox();
                if (favorite[i] == 1)
                {
                    pictureBox2.Image = Image.FromFile("../../picture/LikeFill.png");
                    FavoriteNow = 1;
                }
                else
                {
                    pictureBox2.Image = Image.FromFile("../../picture/LikeEmpty.png");
                    FavoriteNow = 0;
                }
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox2.Enabled = true;
                pictureBox2.Cursor = Cursors.Hand;
                pictureBox2.Width = 40;
                pictureBox2.Height = 30;
                pictureBox2.Location = new Point(843, 250);
                pictureBox2.Tag = idcar;
                panel3.Controls.Add(pictureBox2);


                foreach (Control control in panel1.Controls)
                {
                    control.Margin = new Padding(-1, 10, 10, 10);
                }

                flowLayoutPanel1.Controls.Add(panel1);
                CustomEventArgs customEventArgs = new CustomEventArgs();
                customEventArgs.FavoriteNow = favorite[i];
                pictureBox2.Click += (sender, e) => pictureBox2_Click(sender, customEventArgs);
            }
            dataBase.closedConnection();
        }
        int count = 0;
        int[] WasCard = new int[130];
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            idcar = (int)pictureBox.Tag;
            AddPlayList.Visible = true;
            dataBase.openConnection();
            string query1 = $"SELECT COUNT(*) FROM {name}{surname}Table WHERE AllPlayList != 'Empty'";
            SqlCommand command1 = new SqlCommand(query1, dataBase.getConnection());
            int rowCount = 0;
            rowCount = (int)command1.ExecuteScalar();
            List<string> CountPlayList = new List<string>();
            string query2 = $"SELECT AllPlayList FROM {name}{surname}Table WHERE AllPlayList != 'Empty'";
            SqlCommand command2 = new SqlCommand(query2, dataBase.getConnection());
            using (SqlDataReader reader3 = command2.ExecuteReader())
            {
                while (reader3.Read())
                {
                    CountPlayList.Add(reader3.GetString(0));
                }
            }
            MyFlowLayoutPanel AddPlayListFlowLayoutPanel = new MyFlowLayoutPanel();
            AddPlayListFlowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
            AddPlayListFlowLayoutPanel.AutoSize = true;
            for (int i = 0; i < rowCount; i++)
            {
                Panel cardPlayList = new Panel();
                cardPlayList.BackColor = Color.Transparent;
                cardPlayList.Size = new Size(440, 50);
                AddPlayListFlowLayoutPanel.Controls.Add(cardPlayList);

                Label NameCard = new Label();
                NameCard.Text = $"{CountPlayList[i]}";
                NameCard.Location = new Point(10, 10);
                NameCard.AutoSize = true;
                NameCard.Cursor = Cursors.Hand;
                NameCard.Font = new Font("Segoe UI Variable Display Semib", 16);
                NameCard.ForeColor = Color.White;
                NameCard.Tag = idcar;
                cardPlayList.Controls.Add(NameCard);
                NameCard.Click += new EventHandler(NameCard_Click);





                flowLayoutPanel2.Controls.Add(cardPlayList);
            }
            
            dataBase.closedConnection();

        }
        private void NameCard_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            idcar = (int)label.Tag;
            dataBase.openConnection();
            string query1 = $"UPDATE {name}{surname}Table SET PlayList = '{label.Text}' WHERE id = @id";
            SqlCommand command1 = new SqlCommand(query1, dataBase.getConnection());
            command1.Parameters.AddWithValue("@id", idcar);
            command1.ExecuteNonQuery();
            dataBase.closedConnection();
            MessageBox.Show($"Карточка добавлена в плейлист: {label.Text}");
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            decimal value = numericUpDown.Value;
            idcar = (int)numericUpDown.Tag;
            //MessageBox.Show("----" + value + name + surname + idcar);
            dataBase.openConnection();
            string query1 = $"UPDATE {name}{surname}Table SET Score = {value} WHERE id = @id";
            SqlCommand command1 = new SqlCommand(query1, dataBase.getConnection());
            command1.Parameters.AddWithValue("@id", idcar);
            command1.ExecuteNonQuery();
            dataBase.closedConnection();
        }
        private void FavoritesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Favorites favorites = new Favorites(name, surname, ThisEmail);
            favorites.Show();
        }

        private void FeaturesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            brandview brandview = new brandview(name, surname, ThisEmail);
            brandview.Show();
        }

        private void PlusCar_Click(object sender, EventArgs e)
        {
            AddCar addCar = new AddCar(name, surname);
            addCar.Show();
        }

        private void User_Click(object sender, EventArgs e)
        {
            if(Setting.Visible == false)
            {
                Setting.Visible = true;
            } else
            {
                Setting.Visible = false;
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            Setting.Visible = false;
        }
        public void setting()
        {
            label1.Text = surname + " " + name;
            label4.Text = ThisEmail;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(textBox4.Text != "")
            {
                try
                {
                    dataBase.openConnection();

                    string query1 = $"UPDATE accounts_db SET passwords = '{Hashing.PasswordHashing(textBox4.Text)}' WHERE emails = '{ThisEmail}'";
                    SqlCommand command1 = new SqlCommand(query1, dataBase.getConnection());
                    command1.ExecuteNonQuery();
                    dataBase.closedConnection();
                    MessageBox.Show("Пароль успешно изменен");
                    panel4.Visible = false;
                } catch (Exception ex)
                {
                    MessageBox.Show("Ошибка изменеие пароля, поробуйте еще раз!\n" + ex);
                }
                
            } else
            {
                MessageBox.Show("Строка пуста");
            }
            
        }

        private void selectionsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Selections selections = new Selections(name, surname, ThisEmail);
            selections.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            AddPlayList.Visible = false;
            flowLayoutPanel2.Controls.Clear();
        }

        public void pictureBox2_Click(object sender, CustomEventArgs e)
        {
            PictureBox pictureBox2 = (PictureBox)sender;
            idcar = (int)pictureBox2.Tag;
            int j = 0;
            for (int i = 0; i < WasCard.Length; i++)
            {
                if (idcar == WasCard[i])
                {
                    j++;
                }
            }
            if (j == 0) FavoriteNow = e.FavoriteNow;
            if (j == 0) WasCard[count] = idcar;
            count++;
            dataBase.openConnection();
            pictureBox2.Focus();
            if (FavoriteNow == 0)
            {
                dataBase.openConnection();
                pictureBox2.Image = Image.FromFile("../../picture/LikeFill.png");
                FavoriteNow = 1;

                string query1 = $"UPDATE [{name}{surname}Table] SET Favorites = 1 WHERE id = @id";
                SqlCommand command1 = new SqlCommand(query1, dataBase.getConnection());
                command1.Parameters.AddWithValue("@id", idcar);

                command1.ExecuteNonQuery();
                dataBase.closedConnection();

            }
            else
            {
                pictureBox2.Image = Image.FromFile("../../picture/LikeEmpty.png");
                FavoriteNow = 0;
                string query1 = $"UPDATE {name}{surname}Table SET Favorites = 0 WHERE id = @id";
                SqlCommand command1 = new SqlCommand(query1, dataBase.getConnection());
                command1.Parameters.AddWithValue("@id", idcar);
                command1.ExecuteNonQuery();

            }
            dataBase.closedConnection();
        }
        public static void SetRoundedShape(Control control, int radius)
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
    }
}
