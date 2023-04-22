using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaskManager
{
    public partial class brandview : Form
    {
        string NameTable;
        string SurnameTable;
        string ThisEmail;
        DataBase dataBase = new DataBase();
        public brandview(string Name, string Surname, string Email)
        {
            InitializeComponent();
            NameTable = Name;
            SurnameTable = Surname;
            ThisEmail = Email;
            SetRoundedShape(SaveRec, 20);
            InsertData();
            //priceTo.Text = "100.000.000";
            //priceTo.ForeColor = Color.Silver;
            //prieceFrom.Text = "1";
            //prieceFrom.ForeColor = Color.Silver;
            //speedFrom.Text = "1";
            //speedFrom.ForeColor = Color.Silver;
            //speedTo.Text = "450";
            //speedTo.ForeColor = Color.Silver;
            //PowerFrom.Text = "1";
            //PowerFrom.ForeColor = Color.Silver;
            //PowerTo.Text = "5000";
            //PowerTo.ForeColor = Color.Silver;

        }
        public void InsertData()
        {
            dataBase.openConnection();
            string query1 = $"SELECT CarsSelect FROM {NameTable}{SurnameTable}Table WHERE brand = 'Audi'";
            SqlCommand command1 = new SqlCommand(query1, dataBase.getConnection());
            if((int)command1.ExecuteScalar() == 1)
            {
                Audi.Checked = true;
            }

            string query2 = $"SELECT CarsSelect FROM {NameTable}{SurnameTable}Table WHERE brand = 'KIA'";
            SqlCommand command2 = new SqlCommand(query2, dataBase.getConnection());
            if ((int)command2.ExecuteScalar() == 1)
            {
                KIA.Checked = true;
            }

            string query3 = $"SELECT CarsSelect FROM {NameTable}{SurnameTable}Table WHERE brand = 'Nissan'";
            SqlCommand command3 = new SqlCommand(query3, dataBase.getConnection());
            if ((int)command3.ExecuteScalar() == 1)
            {
                Nissan.Checked = true;
            }

            string query4 = $"SELECT CarsSelect FROM {NameTable}{SurnameTable}Table WHERE brand = 'LADA'";
            SqlCommand command4 = new SqlCommand(query4, dataBase.getConnection());
            if ((int)command4.ExecuteScalar() == 1)
            {
                LADA.Checked = true;
            }

            string query5 = $"SELECT CarsSelect FROM {NameTable}{SurnameTable}Table WHERE brand = 'Lexus'";
            SqlCommand command5 = new SqlCommand(query5, dataBase.getConnection());
            if ((int)command5.ExecuteScalar() == 1)
            {
                Lexus.Checked = true;
            }

            string query6 = $"SELECT CarsSelect FROM {NameTable}{SurnameTable}Table WHERE brand = 'Hyundai'";
            SqlCommand command6 = new SqlCommand(query6, dataBase.getConnection());
            if ((int)command6.ExecuteScalar() == 1)
            {
                Hyundai.Checked = true;
            }

            string query7 = $"SELECT CarsSelect FROM {NameTable}{SurnameTable}Table WHERE brand = 'Suzuki'";
            SqlCommand command7 = new SqlCommand(query7, dataBase.getConnection());
            if ((int)command7.ExecuteScalar() == 1)
            {
                Suzuki.Checked = true;
            }

            string query8 = $"SELECT CarsSelect FROM {NameTable}{SurnameTable}Table WHERE brand = 'BMW'";
            SqlCommand command8 = new SqlCommand(query8, dataBase.getConnection());
            if ((int)command8.ExecuteScalar() == 1)
            {
                BMW.Checked = true;
            }

            string query9 = $"SELECT CarsSelect FROM {NameTable}{SurnameTable}Table WHERE brand = 'Volkswagen'";
            SqlCommand command9 = new SqlCommand(query9, dataBase.getConnection());
            if ((int)command9.ExecuteScalar() == 1)
            {
                Volkswagen.Checked = true;
            }

            string query10 = $"SELECT CarsSelect FROM {NameTable}{SurnameTable}Table WHERE brand = 'Toyota'";
            SqlCommand command10 = new SqlCommand(query10, dataBase.getConnection());
            if ((int)command10.ExecuteScalar() == 1)
            {
                Toyota.Checked = true;
            }

            string query11 = $"SELECT CarsSelect FROM {NameTable}{SurnameTable}Table WHERE brand = 'Skoda'";
            SqlCommand command11 = new SqlCommand(query11, dataBase.getConnection());
            if ((int)command11.ExecuteScalar() == 1)
            {
                Skoda.Checked = true;
            }

            string query12 = $"SELECT CarsSelect FROM {NameTable}{SurnameTable}Table WHERE brand = 'Mitsubishi'";
            SqlCommand command12 = new SqlCommand(query12, dataBase.getConnection());
            if ((int)command12.ExecuteScalar() == 1)
            {
                Mitsubishi.Checked = true;
            }

            string query13 = $"SELECT CarsSelect FROM {NameTable}{SurnameTable}Table WHERE brand = 'Ford'";
            SqlCommand command13 = new SqlCommand(query13, dataBase.getConnection());
            if ((int)command13.ExecuteScalar() == 1)
            {
                Ford.Checked = true;
            }

            string query14 = $"SELECT CountrySelect FROM {NameTable}{SurnameTable}Table WHERE country = 'Россия'";
            SqlCommand command14 = new SqlCommand(query14, dataBase.getConnection());
            if ((int)command14.ExecuteScalar() == 1)
            {
                checkBoxRussia.Checked = true;
            }

            string query15 = $"SELECT CountrySelect FROM {NameTable}{SurnameTable}Table WHERE country = 'США'";
            SqlCommand command15 = new SqlCommand(query15, dataBase.getConnection());
            if ((int)command15.ExecuteScalar() == 1)
            {
                checkBoxUSA.Checked = true;
            }

            string query16 = $"SELECT CountrySelect FROM {NameTable}{SurnameTable}Table WHERE country = 'Корея'";
            SqlCommand command16 = new SqlCommand(query16, dataBase.getConnection());
            if ((int)command16.ExecuteScalar() == 1)
            {
                checkBoxKorey.Checked = true;
            }

            string query17 = $"SELECT CountrySelect FROM {NameTable}{SurnameTable}Table WHERE country = 'Япония'";
            SqlCommand command17 = new SqlCommand(query17, dataBase.getConnection());
            if ((int)command17.ExecuteScalar() == 1)
            {
                checkBoxJapany.Checked = true;
            }

            string query18 = $"SELECT CountrySelect FROM {NameTable}{SurnameTable}Table WHERE country = 'Германия'";
            SqlCommand command18 = new SqlCommand(query18, dataBase.getConnection());
            if ((int)command18.ExecuteScalar() == 1)
            {
                checkBoxGermany.Checked = true;
            }

            string query19 = $"SELECT CountrySelect FROM {NameTable}{SurnameTable}Table WHERE country = 'Чехия'";
            SqlCommand command19 = new SqlCommand(query19, dataBase.getConnection());
            if ((int)command19.ExecuteScalar() == 1)
            {
                checkBoxCzechRepublic.Checked = true;
            }

            string query20 = $"SELECT MinPrice FROM {NameTable}{SurnameTable}Table";
            SqlCommand command20 = new SqlCommand(query20, dataBase.getConnection());
            prieceFrom.Text = (command20.ExecuteScalar()).ToString();

            string query21 = $"SELECT MaxPrice FROM {NameTable}{SurnameTable}Table";
            SqlCommand command21 = new SqlCommand(query21, dataBase.getConnection());
            priceTo.Text = (command21.ExecuteScalar()).ToString();

            string query22 = $"SELECT MinSpeed FROM {NameTable}{SurnameTable}Table";
            SqlCommand command22 = new SqlCommand(query22, dataBase.getConnection());
            speedFrom.Text = (command22.ExecuteScalar()).ToString();

            string query23 = $"SELECT MxSpeed FROM {NameTable}{SurnameTable}Table";
            SqlCommand command23 = new SqlCommand(query23, dataBase.getConnection());
            speedTo.Text = (command23.ExecuteScalar()).ToString();

            string query24 = $"SELECT mPower FROM {NameTable}{SurnameTable}Table";
            SqlCommand command24 = new SqlCommand(query24, dataBase.getConnection());
            PowerFrom.Text = (command24.ExecuteScalar()).ToString();

            string query25 = $"SELECT MxPower FROM {NameTable}{SurnameTable}Table";
            SqlCommand command25 = new SqlCommand(query25, dataBase.getConnection());
            PowerTo.Text = (command25.ExecuteScalar()).ToString();


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
        //private void prieceFrom_Enter(object sender, EventArgs e)
        //{
        //    if(prieceFrom.Text == "1")
        //    {
        //        prieceFrom.Text = "";
        //        prieceFrom.ForeColor = Color.Black;
        //    }
        //}

        //private void prieceFrom_Leave(object sender, EventArgs e)
        //{
        //    if (prieceFrom.Text == "")
        //    {
        //        prieceFrom.Text = "1";
        //        prieceFrom.ForeColor = Color.Silver;
        //    }
        //}

        //private void priceTo_Enter(object sender, EventArgs e)
        //{
        //    if (priceTo.Text == "100.000.000")
        //    {
        //        priceTo.Text = "";
        //        priceTo.ForeColor = Color.Black;
        //    }
        //}

        //private void priceTo_Leave(object sender, EventArgs e)
        //{
        //    if (priceTo.Text == "")
        //    {
        //        priceTo.Text = "100.000.000";
        //        priceTo.ForeColor = Color.Silver;
        //    }
        //}

        //private void speedFrom_Enter(object sender, EventArgs e)
        //{
        //    if (speedFrom.Text == "1")
        //    {
        //        speedFrom.Text = "";
        //        speedFrom.ForeColor = Color.Black;
        //    }
        //}

        //private void speedFrom_Leave(object sender, EventArgs e)
        //{
        //    if (speedFrom.Text == "")
        //    {
        //        speedFrom.Text = "1";
        //        speedFrom.ForeColor = Color.Silver;
        //    }
        //}

        //private void speedTo_Enter(object sender, EventArgs e)
        //{
        //    if (speedTo.Text == "450")
        //    {
        //        speedTo.Text = "";
        //        speedTo.ForeColor = Color.Black;
        //    }
        //}

        //private void PowerFrom_Leave(object sender, EventArgs e)
        //{
        //    if (PowerFrom.Text == "")
        //    {
        //        PowerFrom.Text = "1";
        //        PowerFrom.ForeColor = Color.Silver;
        //    }
        //}

        //private void PowerFrom_Enter(object sender, EventArgs e)
        //{
        //    if (PowerFrom.Text == "1")
        //    {
        //        PowerFrom.Text = "";
        //        PowerFrom.ForeColor = Color.Black;
        //    }
        //}

        //private void PowerTo_Leave(object sender, EventArgs e)
        //{
        //    if (PowerTo.Text == "")
        //    {
        //        PowerTo.Text = "5000";
        //        PowerTo.ForeColor = Color.Silver;
        //    }
        //}

        //private void PowerTo_Enter(object sender, EventArgs e)
        //{
        //    if (PowerTo.Text == "5000")
        //    {
        //        PowerTo.Text = "";
        //        PowerTo.ForeColor = Color.Black;
        //    }
        //}

        //private void speedTo_Leave(object sender, EventArgs e)
        //{
        //    if (speedTo.Text == "")
        //    {
        //        speedTo.Text = "450";
        //        speedTo.ForeColor = Color.Silver;
        //    }
        //}

        private void SaveRec_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
            int PriceFrom = int.Parse(prieceFrom.Text);
            int PriceTo = int.Parse(priceTo.Text);
            int SpeedFrom = int.Parse(speedFrom.Text);
            int SpeedTo = int.Parse(speedTo.Text);
            int PowerFrom1 = int.Parse(PowerFrom.Text);
            int PowerTo1 = int.Parse(PowerTo.Text);
            List<string> brandCars = new List<string>() {"Audi", "KIA", "Nissan", "LADA", "Lexus", "Hyundai", "Suzuki", "BMW", "Volkswagen", "Toyota", "Skoda", "Mitsubishi", "Ford" };
            string sql = $"UPDATE {NameTable}{SurnameTable}Table SET MinPrice = {PriceFrom}";
            SqlCommand com1 = new SqlCommand(sql, dataBase.getConnection());
            com1.ExecuteScalar();
            
                string sql1 = $"UPDATE {NameTable}{SurnameTable}Table SET MaxPrice = {PriceTo}";
                SqlCommand com2 = new SqlCommand(sql1, dataBase.getConnection());
                com2.ExecuteScalar();
            
            
                string sql2 = $"UPDATE {NameTable}{SurnameTable}Table SET MinSpeed = {SpeedFrom}";
                SqlCommand com3 = new SqlCommand(sql2, dataBase.getConnection());
                com3.ExecuteScalar();
            
            
                string sql3 = $"UPDATE {NameTable}{SurnameTable}Table SET MxSpeed = {SpeedTo}";
                SqlCommand com4 = new SqlCommand(sql3, dataBase.getConnection());
                com4.ExecuteScalar();
            
                string sql5 = $"UPDATE {NameTable}{SurnameTable}Table SET mPower = {PowerFrom1}";
                SqlCommand com5 = new SqlCommand(sql5, dataBase.getConnection());
                com5.ExecuteScalar();
            
                string sql6 = $"UPDATE {NameTable}{SurnameTable}Table SET MxPower = {PowerTo1}";
                SqlCommand com6 = new SqlCommand(sql6, dataBase.getConnection());
                com6.ExecuteScalar();
            
            int k = 0;
            if (Audi.Checked) k = 1;
            string sqlQuery1 = $"UPDATE {NameTable}{SurnameTable}Table SET CarsSelect = {k} WHERE brand = 'Audi'";
            SqlCommand command2 = new SqlCommand(sqlQuery1, dataBase.getConnection());
            command2.ExecuteScalar();

            k = 0;
            if (KIA.Checked) k = 1;
            string query1 = $"UPDATE {NameTable}{SurnameTable}Table SET CarsSelect = {k} WHERE brand = 'KIA'";
            SqlCommand command3 = new SqlCommand(query1, dataBase.getConnection());
            command3.ExecuteScalar();

            k = 0;
            if (Nissan.Checked) k = 1;
            string query2 = $"UPDATE {NameTable}{SurnameTable}Table SET CarsSelect = {k} WHERE brand = 'Nissan'";
            SqlCommand command4 = new SqlCommand(query2, dataBase.getConnection());
            command4.ExecuteScalar();

            k = 0;
            if (LADA.Checked) k = 1;
            string query3 = $"UPDATE {NameTable}{SurnameTable}Table SET CarsSelect = {k} WHERE brand = 'LADA'";
            SqlCommand command5 = new SqlCommand(query3, dataBase.getConnection());
            command5.ExecuteScalar();

            k = 0;
            if (Lexus.Checked) k = 1;
            string query4 = $"UPDATE {NameTable}{SurnameTable}Table SET CarsSelect = {k} WHERE brand = 'Lexus'";
            SqlCommand command6 = new SqlCommand(query4, dataBase.getConnection());
            command6.ExecuteScalar();

            k = 0;
            if (Hyundai.Checked) k = 1;
            string query5 = $"UPDATE {NameTable}{SurnameTable}Table SET CarsSelect = {k} WHERE brand = 'Hyundai'";
            SqlCommand command7 = new SqlCommand(query5, dataBase.getConnection());
            command7.ExecuteScalar();

            k = 0;
            if (Suzuki.Checked) k = 1;
            string query6 = $"UPDATE {NameTable}{SurnameTable}Table SET CarsSelect = {k} WHERE brand = 'Suzuki'";
            SqlCommand command8 = new SqlCommand(query6, dataBase.getConnection());
            command8.ExecuteScalar();

            k = 0;
            if (BMW.Checked) k = 1;
            string query7 = $"UPDATE {NameTable}{SurnameTable}Table SET CarsSelect = {k} WHERE brand = 'BMW'";
            SqlCommand command9 = new SqlCommand(query7, dataBase.getConnection());
            command9.ExecuteScalar();

            k = 0;
            if (Volkswagen.Checked) k = 1;
            string query8 = $"UPDATE {NameTable}{SurnameTable}Table SET CarsSelect = {k} WHERE brand = 'Volkswagen'";
            SqlCommand command10 = new SqlCommand(query8, dataBase.getConnection());
            command10.ExecuteScalar();

            k = 0;
            if (Toyota.Checked) k = 1;
            string query9 = $"UPDATE {NameTable}{SurnameTable}Table SET CarsSelect = {k} WHERE brand = 'Toyota'";
            SqlCommand command11 = new SqlCommand(query9, dataBase.getConnection());
            command11.ExecuteScalar();

            k = 0;
            if (Skoda.Checked) k = 1;
            string query10 = $"UPDATE {NameTable}{SurnameTable}Table SET CarsSelect = {k} WHERE brand = 'Skoda'";
            SqlCommand command12 = new SqlCommand(query10, dataBase.getConnection());
            command12.ExecuteScalar();

            k = 0;
            if (Mitsubishi.Checked) k = 1;
            string query11 = $"UPDATE {NameTable}{SurnameTable}Table SET CarsSelect = {k} WHERE brand = 'Mitsubishi'";
            SqlCommand command13 = new SqlCommand(query11, dataBase.getConnection());
            command13.ExecuteScalar();

            k = 0;
            if (Ford.Checked) k = 1;
            string query12 = $"UPDATE {NameTable}{SurnameTable}Table SET CarsSelect = {k} WHERE brand = 'Ford'";
            SqlCommand command14 = new SqlCommand(query12, dataBase.getConnection());
            command14.ExecuteScalar();

            k = 0;
            if (checkBoxCzechRepublic.Checked) k = 1;
            string query13 = $"UPDATE {NameTable}{SurnameTable}Table SET CountrySelect = {k} WHERE country = 'Чехия'";
            SqlCommand command15 = new SqlCommand(query13, dataBase.getConnection());
            command15.ExecuteScalar();

            k = 0;
            if (checkBoxGermany.Checked) k = 1;
            string query14 = $"UPDATE {NameTable}{SurnameTable}Table SET CountrySelect = {k} WHERE country = 'Германия'";
            SqlCommand command16 = new SqlCommand(query14, dataBase.getConnection());
            command16.ExecuteScalar();

            k = 0;
            if (checkBoxJapany.Checked) k = 1;
            string query15 = $"UPDATE {NameTable}{SurnameTable}Table SET CountrySelect = {k} WHERE country = 'Япония'";
            SqlCommand command17 = new SqlCommand(query15, dataBase.getConnection());
            command17.ExecuteScalar();

            k = 0;
            if (checkBoxKorey.Checked) k = 1;
            string query16 = $"UPDATE {NameTable}{SurnameTable}Table SET CountrySelect = {k} WHERE country = 'Корея'";
            SqlCommand command18 = new SqlCommand(query16, dataBase.getConnection());
            command18.ExecuteScalar();

            k = 0;
            if (checkBoxRussia.Checked) k = 1;
            string query17 = $"UPDATE {NameTable}{SurnameTable}Table SET CountrySelect = {k} WHERE country = 'Россия'";
            SqlCommand command19 = new SqlCommand(query17, dataBase.getConnection());
            command19.ExecuteScalar();

            k = 0;
            if (checkBoxUSA.Checked) k = 1;
            string query18 = $"UPDATE {NameTable}{SurnameTable}Table SET CountrySelect = {k} WHERE country = 'США'";
            SqlCommand command20 = new SqlCommand(query18, dataBase.getConnection());
            command20.ExecuteScalar();

            dataBase.closedConnection();
            this.Hide();
            MainApplicationList mainApplicationList = new MainApplicationList(ThisEmail);
            mainApplicationList.Show();
        }
    }
}
