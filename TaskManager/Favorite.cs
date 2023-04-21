using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TaskManager.MainApplicationList;
using System.Xml.Linq;

namespace TaskManager
{
    public partial class Favorite : Form
    {
        DataBase dataBase = new DataBase();
        string NameTable, SurnameTable, ThisEmail;
        public Favorite(string name, string surname, string email)
        {
            InitializeComponent();
            NameTable = name;
            SurnameTable = surname;
            ThisEmail = email;
            SetRoundedShape(BackButton, 40);
            CreateCardFavorite();

        }
        string cars = "", models = "";
        int idcar = 0;
        int FavoriteNow = 0;
        int count = 0;
        int[] WasCard = new int[130];
        public void CreateCardFavorite()
        {
            MyFlowLayoutPanel panel1 = new MyFlowLayoutPanel();
            panel1.FlowDirection = FlowDirection.LeftToRight;
            panel1.AutoSize = true;
            dataBase.openConnection();
            string query1 = $"SELECT COUNT(*) FROM {NameTable}{SurnameTable}Table WHERE Favorites = 1";
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
            string query2 = $"SELECT id, brand, model, priceRUB, maxspeed, horsepower, country, Score, Favorites FROM {NameTable}{SurnameTable}Table WHERE Favorites = 1";
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
            if (rowCount >= 100) rowCount = 100;
            for (int i = 0; i < rowCount; i++)
            {
                cars = car[i];
                models = model[i];
                idcar = id[i];
                Panel panel3 = new Panel();

                PictureBox pictureBox = new PictureBox();
                try
                {
                    pictureBox.Image = Image.FromFile($"C:/Users/Артем/source/repos/TaskManager/TaskManager/Cars/{car[i]}{model[i]}.jpg");
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
                panel3.Invalidate();
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
                panel3.Controls.Add(numericUpDown1);

                PictureBox pictureBox1 = new PictureBox();
                pictureBox1.Image = Image.FromFile("C:/Users/Артем/source/repos/TaskManager/TaskManager/picture/Plus1.png");
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Width = 50;
                pictureBox1.Cursor = Cursors.Hand;
                pictureBox1.Height = 50;
                pictureBox1.Location = new Point(880, 240);
                panel3.Controls.Add(pictureBox1);

                PictureBox pictureBox2 = new PictureBox();
                if (favorite[i] == 1)
                {
                    pictureBox2.Image = Image.FromFile("C:/Users/Артем/source/repos/TaskManager/TaskManager/picture/LikeFill.png");
                    FavoriteNow = 1;
                }
                else
                {
                    pictureBox2.Image = Image.FromFile("C:/Users/Артем/source/repos/TaskManager/TaskManager/picture/LikeEmpty.png");
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

                flowLayoutPanelFavorite.Controls.Add(panel1);
                CustomEventArgs customEventArgs = new CustomEventArgs();
                customEventArgs.FavoriteNow = favorite[i];
                pictureBox2.Click += (sender, e) => pictureBox2_Click(sender, customEventArgs);
            }
            dataBase.closedConnection();

        }

        private void Favorite_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainApplicationList mainApplicationList = new MainApplicationList(ThisEmail);
            mainApplicationList.Show();
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
                pictureBox2.Image = Image.FromFile("C:/Users/Артем/source/repos/TaskManager/TaskManager/picture/LikeFill.png");
                FavoriteNow = 1;

                string query1 = $"UPDATE [{NameTable}{SurnameTable}Table] SET Favorites = 1 WHERE id = @id";
                SqlCommand command1 = new SqlCommand(query1, dataBase.getConnection());
                command1.Parameters.AddWithValue("@id", idcar);

                command1.ExecuteNonQuery();

            }
            else
            {
                pictureBox2.Image = Image.FromFile("C:/Users/Артем/source/repos/TaskManager/TaskManager/picture/LikeEmpty.png");
                FavoriteNow = 0;
                string query1 = $"UPDATE {NameTable}{SurnameTable}Table SET Favorites = 0 WHERE id = @id";
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
