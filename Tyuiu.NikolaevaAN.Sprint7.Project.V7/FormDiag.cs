using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.NikolaevaAN.Sprint7.Project.V7
{
    public partial class FormDiag : Form
    {
        public FormDiag()
        {
            InitializeComponent();
        }

        public static string[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            string[,] arrayValues = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToString(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void FormDiag_Load(object sender, EventArgs e)
        {
            string fileData = File.ReadAllText(@"C:\DataSprint7\NewPersons.csv");
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length + 1;
            int columns = lines[0].Split(';').Length;

            dataGridViewMatrix_NAN.ColumnCount = columns;
            dataGridViewMatrix_NAN.RowCount = rows;
            dataGridViewMatrix_NAN.Columns[0].HeaderText = "Номер подъезда";
            dataGridViewMatrix_NAN.Columns[0].Width = 75;
            dataGridViewMatrix_NAN.Columns[1].HeaderText = "Номер квартиры";
            dataGridViewMatrix_NAN.Columns[1].Width = 75;
            dataGridViewMatrix_NAN.Columns[2].HeaderText = "Кол-во комнат";
            dataGridViewMatrix_NAN.Columns[2].Width = 75;
            dataGridViewMatrix_NAN.Columns[3].HeaderText = "Фамилия квартиросъёмщика";
            dataGridViewMatrix_NAN.Columns[3].Width = 125;
            dataGridViewMatrix_NAN.Columns[4].HeaderText = "Кол-во членов семьи";
            dataGridViewMatrix_NAN.Columns[4].Width = 100;
            dataGridViewMatrix_NAN.Columns[5].HeaderText = "Кол-во детей в семье";
            dataGridViewMatrix_NAN.Columns[5].Width = 100;
            dataGridViewMatrix_NAN.Columns[6].HeaderText = "Есть ли задолженность по квартплате";
            dataGridViewMatrix_NAN.Columns[6].Width = 165;

            //добавление в таблицу
            string[,] arrayValues = new string[rows, columns];
            arrayValues = LoadFromFileData(@"C:\DataSprint7\NewPersons.csv");

            for (int r = 0; r < rows - 1; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewMatrix_NAN.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
        }

        private void buttonMembers_NAN_Click(object sender, EventArgs e)
        {
            chartDiag_NAN.Series.Clear();

            //добавление в диаграмму
            int column = 4;  //номер нужного столбца
            Series s = chartDiag_NAN.Series.Add("members");
            s.ChartType = SeriesChartType.Pie;
            s.IsValueShownAsLabel = true;
            for (int i = 0; i < dataGridViewMatrix_NAN.Rows.Count; i++)
            {
                s.Points.AddXY(Convert.ToString(dataGridViewMatrix_NAN.Rows[i].Cells[3].Value), dataGridViewMatrix_NAN[column, i].Value);
            }
        }

        private void buttonKids_NAN_Click(object sender, EventArgs e)
        {
            chartDiag_NAN.Series.Clear();
            int column = 5;  //номер нужного столбца
            Series s = chartDiag_NAN.Series.Add("kids");
            s.ChartType = SeriesChartType.Pie;
            s.IsValueShownAsLabel = true;
            for (int i = 0; i < dataGridViewMatrix_NAN.Rows.Count; i++)
            {
                s.Points.AddXY(Convert.ToString(dataGridViewMatrix_NAN.Rows[i].Cells[3].Value), dataGridViewMatrix_NAN[column, i].Value);
            }
        }

        private void buttonRooms_NAN_Click(object sender, EventArgs e)
        {
            chartDiag_NAN.Series.Clear();
            int column = 2;  //номер нужного столбца
            Series s = chartDiag_NAN.Series.Add("kids");
            s.ChartType = SeriesChartType.Pie;
            s.IsValueShownAsLabel = true;
            for (int i = 0; i < dataGridViewMatrix_NAN.Rows.Count; i++)
            {
                s.Points.AddXY(Convert.ToString(dataGridViewMatrix_NAN.Rows[i].Cells[3].Value), dataGridViewMatrix_NAN[column, i].Value);
            }
        }
    }
}
