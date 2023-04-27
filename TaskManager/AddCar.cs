using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaskManager
{
    public partial class AddCar : Form
    {
        DataBase dataBase = new DataBase();
        string NameTable;
        string SurnameTable;

        public AddCar(string name, string surname)
        {
            InitializeComponent();
            SetRoundedShape(AddButton, 40);
            SetRoundedShape(InsertePicture, 40);
            //SetRoundedShape(Selectcar, 30);
            //SetRoundedShape(comboBoxCountry, 30);
            //SetRoundedShape(textBoxModel, 30);
            //SetRoundedShape(textBoxPower, 30);
            //SetRoundedShape(textBoxPrice, 30);
            //SetRoundedShape(textBoxSpeed, 30);
            StartPosition = FormStartPosition.CenterScreen;
            NameTable = name;
            SurnameTable = surname;
        }

        private void AddCar_Load(object sender, EventArgs e)
        {
            Selectcar.Items.Add("KIA");
            Selectcar.Items.Add("Audi");
            Selectcar.Items.Add("Nissan");
            Selectcar.Items.Add("LADA");
            Selectcar.Items.Add("Lexus");
            Selectcar.Items.Add("Hyundai");
            Selectcar.Items.Add("Suzuki");
            Selectcar.Items.Add("BMW");
            Selectcar.Items.Add("Volkswagen");
            Selectcar.Items.Add("Toyota");
            Selectcar.Items.Add("Mitsubishi");
            Selectcar.Items.Add("Ford");
            comboBoxCountry.Items.Add("Russia");
            comboBoxCountry.Items.Add("USA");
            comboBoxCountry.Items.Add("Korea");
            comboBoxCountry.Items.Add("Germany");
            comboBoxCountry.Items.Add("Czech Republic");
            comboBoxCountry.Items.Add("Japan");

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

        private void AddButton_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
            string query1 = $"SELECT MinPrice, MaxPrice, MinSpeed, MxSpeed, mPower, MxPower, CountrySelect FROM {NameTable}{SurnameTable}Table WHERE brand = '{Selectcar.Text}'";
            SqlCommand command1 = new SqlCommand(query1, dataBase.getConnection());
            SqlDataReader reader = command1.ExecuteReader();
            int minPrice1 = 0, maxPrice1 = 0, minSpeed1 = 0, maxSpeed1 = 0, minPower1 = 0, maxPower1 = 0, selectCountry1 = 0;
            if (reader.Read())
            {
                minPrice1 = reader.GetInt32(0);
                maxPrice1 = reader.GetInt32(1);
                minSpeed1 = reader.GetInt32(2);
                maxSpeed1 = reader.GetInt32(3);
                minPower1 = reader.GetInt32(4);
                maxPower1 = reader.GetInt32(5);
                selectCountry1 = reader.GetInt32(6);
            }
            reader.Close();
            string Country = "";
            if (comboBoxCountry.Text == "Russia") Country = "Россия";
            if (comboBoxCountry.Text == "USA") Country = "США";
            if (comboBoxCountry.Text == "Germany") Country = "Германия";
            if (comboBoxCountry.Text == "Japan") Country = "Япония";
            if (comboBoxCountry.Text == "Czech Republic") Country = "Чехия";
            if (comboBoxCountry.Text == "Korea") Country = "Корея";
            if(comboBoxCountry.Text == "" || Selectcar.Text == "" || textBoxModel.Text == "" || textBoxPower.Text == "" || textBoxPrice.Text == "" || textBoxSpeed.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");
            } else
            {
                string query2 = $"INSERT INTO {NameTable}{SurnameTable}Table (brand, model, priceRUB, maxspeed, horsepower, country, Score, Favorites, CarsSelect, PlayList, MinPrice, MaxPrice, MinSpeed, MxSpeed, mPower, MxPower, CountrySelect) VALUES ('{Selectcar.Text}', '{textBoxModel.Text}', {textBoxPrice.Text}, {textBoxSpeed.Text}, {textBoxPower.Text}, '{Country}', 0, 0, 1, NULL, {minPrice1}, {maxPrice1}, {minSpeed1}, {maxSpeed1}, {minPower1}, {maxPower1}, {selectCountry1})";
                SqlCommand command2 = new SqlCommand(query2, dataBase.getConnection());
                command2.ExecuteNonQuery();
                dataBase.closedConnection();
                this.Close();
            }
            
        }

        private void InsertePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файлы изображений (*.jpg)|*.jpg";
            openFileDialog.Title = "Выберите изображение";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string newFilePath = $"C:/Users/Артем/source/repos/TaskManager/TaskManager/Cars/";
                string fileName = Path.GetFileName(filePath);
                string targetFilePath = Path.Combine(newFilePath, fileName);
                File.Copy(filePath, targetFilePath);
                string newPath = Path.Combine(newFilePath, $"{Selectcar.Text}{textBoxModel.Text}.jpg");
                File.Move(targetFilePath, newPath);
            }
        }
    }
}
