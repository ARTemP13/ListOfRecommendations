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
        public class MyFlowLayoutPanel : FlowLayoutPanel
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
                    cp.ExStyle |= 0x02000000; // WS_CLIPCHILDREN
                    return cp;
                }
            }
        }
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

            // Загрузка изображения из файла
            pictureBox.Image = Image.FromFile("C:/Users/Артем/source/repos/TaskManager/TaskManager/picture/BMWX5.jpg");

            // Установка свойств PictureBox
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Width = 400;
            pictureBox.Height = 300;

            // Добавление PictureBox в левую часть FlowLayoutPanel
            panel1.Controls.Add(pictureBox);
            panel1.SetFlowBreak(pictureBox, true);

            // Добавление PictureBox на Panel
            panel3.Controls.Add(pictureBox);

            //panel3.BackColor = Color.White;
            panel3.Size = new Size(940, 300);
            panel3.Padding = new Padding(15);
            panel1.Controls.Add(panel3);

            Panel panel4 = new Panel();
            panel4.BackColor = Color.White;
            panel4.Size = new Size(940, 300);
            panel4.Padding = new Padding(15);
            panel1.Controls.Add(panel4);

            Panel panel5 = new Panel();
            panel5.BackColor = Color.White;
            panel5.Size = new Size(940, 300);
            panel5.Padding = new Padding(15);
            panel1.Controls.Add(panel5);

            Panel panel6 = new Panel();
            panel6.BackColor = Color.White;
            panel6.Size = new Size(940, 300);
            panel6.Padding = new Padding(15);
            panel1.Controls.Add(panel6);

            foreach (Control control in panel1.Controls)
            {
                control.Margin = new Padding(-1, 10, 10, 10);
            }

            flowLayoutPanel1.Controls.Add(panel1);
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
