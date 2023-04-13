using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaskManager
{
    public partial class brandview : Form
    {
        public brandview()
        {
            InitializeComponent();
            SetRoundedShape(SaveRec, 20);
            priceTo.Text = "100.000.000";
            priceTo.ForeColor = Color.Silver;
            //priceTo.Font = new Font(priceTo.Font.FontFamily, 12);
            prieceFrom.Text = "1.0";
            prieceFrom.ForeColor = Color.Silver;
            speedFrom.Text = "1";
            speedFrom.ForeColor = Color.Silver;
            speedTo.Text = "450";
            speedTo.ForeColor = Color.Silver;
            PowerFrom.Text = "1";
            PowerFrom.ForeColor = Color.Silver;
            PowerTo.Text = "5000";
            PowerTo.ForeColor = Color.Silver;
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
        private void brandview_Load(object sender, EventArgs e)
        {

        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void prieceFrom_Enter(object sender, EventArgs e)
        {
            if(prieceFrom.Text == "1.0")
            {
                prieceFrom.Text = "";
                prieceFrom.ForeColor = Color.Black;
            }
        }

        private void prieceFrom_Leave(object sender, EventArgs e)
        {
            if (prieceFrom.Text == "")
            {
                prieceFrom.Text = "1.0";
                prieceFrom.ForeColor = Color.Silver;
            }
        }

        private void priceTo_Enter(object sender, EventArgs e)
        {
            if (priceTo.Text == "100.000.000")
            {
                priceTo.Text = "";
                priceTo.ForeColor = Color.Black;
            }
        }

        private void priceTo_Leave(object sender, EventArgs e)
        {
            if (priceTo.Text == "")
            {
                priceTo.Text = "100.000.000";
                priceTo.ForeColor = Color.Silver;
            }
        }

        private void speedFrom_Enter(object sender, EventArgs e)
        {
            if (speedFrom.Text == "1")
            {
                speedFrom.Text = "";
                speedFrom.ForeColor = Color.Black;
            }
        }

        private void speedFrom_Leave(object sender, EventArgs e)
        {
            if (speedFrom.Text == "")
            {
                speedFrom.Text = "1";
                speedFrom.ForeColor = Color.Silver;
            }
        }

        private void speedTo_Enter(object sender, EventArgs e)
        {
            if (speedTo.Text == "450")
            {
                speedTo.Text = "";
                speedTo.ForeColor = Color.Black;
            }
        }

        private void PowerFrom_Leave(object sender, EventArgs e)
        {
            if (PowerFrom.Text == "")
            {
                PowerFrom.Text = "1";
                PowerFrom.ForeColor = Color.Silver;
            }
        }

        private void PowerFrom_Enter(object sender, EventArgs e)
        {
            if (PowerFrom.Text == "1")
            {
                PowerFrom.Text = "";
                PowerFrom.ForeColor = Color.Black;
            }
        }

        private void PowerTo_Leave(object sender, EventArgs e)
        {
            if (PowerTo.Text == "")
            {
                PowerTo.Text = "5000";
                PowerTo.ForeColor = Color.Silver;
            }
        }

        private void PowerTo_Enter(object sender, EventArgs e)
        {
            if (PowerTo.Text == "5000")
            {
                PowerTo.Text = "";
                PowerTo.ForeColor = Color.Black;
            }
        }

        private void speedTo_Leave(object sender, EventArgs e)
        {
            if (speedTo.Text == "")
            {
                speedTo.Text = "450";
                speedTo.ForeColor = Color.Silver;
            }
        }
    }
}
