using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TaskManager.MainApplicationList;

namespace TaskManager
{
    public partial class MainApplicationList : Form

    {
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
        PictureBox pictureBox2 = new PictureBox();
        public MainApplicationList()
        {
            InitializeComponent();
            DoubleBuffered = true;
            SetRoundedShape(FavoritesButton, 40);
            SetRoundedShape(selectionsButton, 40);
            SetRoundedShape(FeaturesButton, 40);
            SetRoundedShape(PlusCar, 40);
            CustomFlowLayoutPanel panel1 = new CustomFlowLayoutPanel();
            panel1.FlowDirection = FlowDirection.LeftToRight;
            panel1.AutoSize = true;

            Panel panel3 = new Panel();

            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile("C:/Users/Артем/source/repos/TaskManager/TaskManager/picture/BMWX5.jpg");
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Width = 400;
            pictureBox.Height = 300;
            panel3.Controls.Add(pictureBox);

            panel3.BackColor = Color.White;
            panel3.Size = new Size(950, 300);
            //panel3.Padding = new Padding(0,15,15,15);
            panel1.Controls.Add(panel3);

            Label label = new Label();
            label.Text = "BMW X5";
            label.Location = new Point(420, 10);
            label.AutoSize = true;
            label.Font = new Font("Segoe UI Variable Display Semib", 20, FontStyle.Bold);
            panel3.Controls.Add(label);

            Label label1 = new Label();
            label1.Text = "Цена:  10.000.000₽";
            label1.Location = new Point(410, 80);
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display Semib", 16);
            panel3.Controls.Add(label1);

            Label label2 = new Label();
            label2.Text = "Максимальная скорость: 210 км/ч";
            label2.Location = new Point(410, 120);
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display Semib", 16);
            panel3.Controls.Add(label2);

            Label label3 = new Label();
            label3.Text = "Мощность: 300 л.c";
            label3.Location = new Point(410, 160);
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display Semib", 16);
            panel3.Controls.Add(label3);

            SetRoundedShape(panel3, 40);

            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Image = Image.FromFile("C:/Users/Артем/source/repos/TaskManager/TaskManager/picture/Plus1.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Width = 50;
            pictureBox1.Height = 50;
            pictureBox1.Location = new Point(650,240);
            panel3.Controls.Add(pictureBox1);

            
            pictureBox2.Image = Image.FromFile("C:/Users/Артем/source/repos/TaskManager/TaskManager/picture/LikeEmpty.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.Enabled = true;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Width = 40;
            pictureBox2.Height = 30;
            pictureBox2.Location = new Point(700, 250);
            pictureBox2.Click += pictureBox2_Click;
            panel3.Controls.Add(pictureBox2);

            PictureBox[] stars = new PictureBox[5];
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i] = new PictureBox();
                stars[i].Location = new Point(i*30 + 750, 250);
                stars[i].Size = new Size(30, 30);
                stars[i].SizeMode = PictureBoxSizeMode.StretchImage;
                stars[i].Image = Image.FromFile("C:/Users/Артем/source/repos/TaskManager/TaskManager/picture/StarEmpty.png");
                panel3.Controls.Add(stars[i]);
            }





            Panel panel4 = new Panel();
            panel4.BackColor = Color.White;
            panel4.Size = new Size(940, 300);
            panel4.Padding = new Padding(0, 15, 15, 15);
            panel1.Controls.Add(panel4);

            Panel panel5 = new Panel();
            panel5.BackColor = Color.White;
            panel5.Size = new Size(940, 300);
            panel5.Padding = new Padding(0, 15, 15, 15);
            panel1.Controls.Add(panel5);

            Panel panel6 = new Panel();
            panel6.BackColor = Color.White;
            panel6.Size = new Size(940, 300);
            panel6.Padding = new Padding(0, 15, 15, 15);
            panel1.Controls.Add(panel6);

            foreach (Control control in panel1.Controls)
            {
                control.Margin = new Padding(-1, 10, 10, 10);
            }

            flowLayoutPanel1.Controls.Add(panel1);
        }
        public void pictureBox2_Click(object sender, EventArgs e)
        {
            if(pictureBox2.Image == Image.FromFile("C:/Users/Артем/source/repos/TaskManager/TaskManager/picture/LikeEmpty.png"))
            {
                pictureBox2.Image = Image.FromFile("C:/Users/Артем/source/repos/TaskManager/TaskManager/picture/LikeFill.png");
            }
            else if(pictureBox2.Image == Image.FromFile("C:/Users/Артем/source/repos/TaskManager/TaskManager/picture/LikeFill.png"))
            {
                pictureBox2.Image = Image.FromFile("C:/Users/Артем/source/repos/TaskManager/TaskManager/picture/LikeEmpty.png");
            }
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

        private void flowLayoutPanel1_Scroll(object sender, ScrollEventArgs e)
        {
            Application.DoEvents();
        }
    }
}
