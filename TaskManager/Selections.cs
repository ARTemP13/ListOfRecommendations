using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace TaskManager
{
    public partial class Selections : Form
    {
        string NameTable, SurnameTable, ThisEmail;
        DataBase dataBase = new DataBase();
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
            public string NameCollection { get; set; }
        }
        public class CustomEventArgs1 : EventArgs
        {
            public string NameCollection { get; set; }
        }
        public Selections(string name, string surname, string email)
        {
            InitializeComponent();
            SetRoundedShape(FavoritesButton, 40);
            SetRoundedShape(AddPlayList, 40);
            NameTable = name;
            SurnameTable = surname;
            ThisEmail = email;
            CreateSelections();
            textBox1.Text = "Название";
            textBox1.ForeColor = Color.Silver;
            panel2.Visible = false;
            label2.Cursor = Cursors.Hand;
        }
        public void CreateSelections ()
        {
            
            dataBase.openConnection();
            List<string> PlayList = new List<string>();
            List<string> ActuallyPlayList = new List<string>();
            string query2 = $"SELECT AllPlayList FROM {NameTable}{SurnameTable}Table WHERE AllPlayList != 'Empty'";
            SqlCommand command2 = new SqlCommand(query2, dataBase.getConnection());
            using (SqlDataReader reader3 = command2.ExecuteReader())
            {
                while (reader3.Read())
                {
                    PlayList.Add(reader3.GetString(0));
                    
                }
            }
            int Count = 0;
            try
            {
                ActuallyPlayList.Add(PlayList[0]);
                Count++;
                for (int i = 1; i < PlayList.Count; i++)
                {
                    int y = 0;
                    for (int j = 0; j < ActuallyPlayList.Count; j++)
                    {
                        if (PlayList[i] == ActuallyPlayList[j]) y++;
                    }
                    if (y == 0)
                    {
                        ActuallyPlayList.Add(PlayList[i]);
                        Count++;
                    }
                }
                } catch
            {
                Count = 0;
            }
            
            MyFlowLayoutPanel panel1 = new MyFlowLayoutPanel();
            panel1.FlowDirection = FlowDirection.LeftToRight;
            panel1.AutoSize = true;

            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Image = Image.FromFile("../../picture/AvaCollection.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Enabled = true;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Width = 290;
            pictureBox1.Height = 400;
            panel1.Controls.Add(pictureBox1);

            Label label4 = new Label();
            label4.Text = $"Плейлист\nдня";
            label4.ForeColor = Color.White;
            label4.Location = new Point(10, 10);
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display Semib", 20);
            pictureBox1.Controls.Add(label4);
            pictureBox1.Click += new EventHandler(pictureBox1_Click);

            for (int i = 0; i < Count; i++)
            {
                PictureBox pictureBox2 = new PictureBox();
                pictureBox2.Image = Image.FromFile("../../picture/AvaCollection1.jpg");
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.Enabled = true;
                pictureBox2.Cursor = Cursors.Hand;
                pictureBox2.Width = 290;
                pictureBox2.Height = 400;
                panel1.Controls.Add(pictureBox2);

                

                Label label = new Label();
                label.Text = $"{ActuallyPlayList[i]}";
                label.ForeColor = Color.White;
                label.Location = new Point(10, 10);
                label.AutoSize = true;
                label.Font = new Font("Segoe UI Variable Display Semib", 20);
                pictureBox2.Controls.Add(label);

                Label label1 = new Label();
                label1.Text = $"X";
                label1.ForeColor = Color.White;
                label1.Location = new Point(273, -3);
                label1.Font = new Font("", 10);
                pictureBox2.Controls.Add(label1);

                CustomEventArgs customEventArgs = new CustomEventArgs();
                customEventArgs.NameCollection = label.Text;
                label1.Click += (sender, e) => label1_Click(sender, customEventArgs);

                //label1.Click += new EventHandler(label1_Click);


                CustomEventArgs1 customEventArgs1 = new CustomEventArgs1();
                customEventArgs1.NameCollection = label.Text;
                pictureBox2.Click += (sender, e) => pictureBox2_Click(sender, customEventArgs1);


                //pictureBox2.Click += new EventHandler(pictureBox2_Click);

            }

            foreach (Control control in panel1.Controls)
            {
                control.Margin = new Padding(10, 10, 10, 10);
            }





            flowLayoutPanel1.Controls.Add(panel1);

            dataBase.closedConnection();
        }
        public void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayListaDay playListaDay = new PlayListaDay(NameTable, SurnameTable, ThisEmail);
            playListaDay.Show();
        }
        
            public void label1_Click(object sender, CustomEventArgs e)
        {
            
            dataBase.openConnection();
            string label = e.NameCollection;
            MessageBox.Show("----" + label);
            string query1 = $"UPDATE {NameTable}{SurnameTable}Table SET AllPlayList = 'Empty' WHERE AllPlayList = '{label}'";
            SqlCommand command1 = new SqlCommand(query1, dataBase.getConnection());
            command1.ExecuteNonQuery();
            dataBase.closedConnection();
            flowLayoutPanel1.Controls.Clear();
            CreateSelections();
        }
        public void pictureBox2_Click(object sender, CustomEventArgs1 e)
        {
            this.Hide();
            Collection collection = new Collection(NameTable, SurnameTable, e.NameCollection, ThisEmail);
            collection.Show();
        }
        private void AddPlayList_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Название")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Название";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
            string query1 = $"UPDATE TOP (1) {NameTable}{SurnameTable}Table SET AllPlayList = '{textBox1.Text}' WHERE AllPlayList = 'Empty'";
            SqlCommand command1 = new SqlCommand(query1, dataBase.getConnection());
            command1.ExecuteNonQuery();
            dataBase.closedConnection();
            panel2.Visible = false;
            flowLayoutPanel1.Controls.Clear();
            CreateSelections();
        }

        private void FavoritesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainApplicationList mainApplicationList = new MainApplicationList(ThisEmail);
            mainApplicationList.Show();
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
