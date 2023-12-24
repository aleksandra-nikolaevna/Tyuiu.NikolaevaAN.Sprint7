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
using Tyuiu.NikolaevaAN.Sprint7.Project.V7.Lib;

namespace Tyuiu.NikolaevaAN.Sprint7.Project.V7
{
    public partial class FormStatistics : Form
    {
        public FormStatistics()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

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

        private void FormStatistics_Load(object sender, EventArgs e)
        {
            string FilePath = @"C:\DataSprint7\NewPersons.csv";
            string fileData = File.ReadAllText(FilePath);
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
            arrayValues = LoadFromFileData(FilePath);

            for (int r = 0; r < rows - 1; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewMatrix_NAN.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            //статистика
            textBoxCount_NAN.Text = Convert.ToString(ds.CountPersons(FilePath));
            int sumAll, sumKids;
            sumAll = sumKids = 0;
            int[] minmax = new int[ds.CountPersons(FilePath)];
            for (int i = 0; i < rows - 1; i++)
            {
                sumAll += Convert.ToInt32(dataGridViewMatrix_NAN.Rows[i].Cells[4].Value);
                sumKids += Convert.ToInt32(dataGridViewMatrix_NAN.Rows[i].Cells[5].Value);
                minmax[i] = Convert.ToInt32(dataGridViewMatrix_NAN.Rows[i].Cells[4].Value);
            }
            textBoxSumAll_NAN.Text = Convert.ToString(sumAll);
            textBoxSumKids_NAN.Text = Convert.ToString(sumKids);
            textBoxMax_NAN.Text = Convert.ToString(minmax.Max());
            textBoxMin_NAN.Text = Convert.ToString(minmax.Min());
        }

        private void buttonFind_NAN_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewMatrix_NAN.RowCount; i++)
            {
                dataGridViewMatrix_NAN.Rows[i].Selected = false;
                for (int j = 0; j < dataGridViewMatrix_NAN.ColumnCount; j++)
                {
                    if (dataGridViewMatrix_NAN.Rows[i].Cells[j].Value != null)
                    {
                        if (dataGridViewMatrix_NAN.Rows[i].Cells[j].Value.ToString().Contains(textBoxFind_NAN.Text))
                        {
                            dataGridViewMatrix_NAN.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }
        }

        private void buttonFilter_NAN_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewMatrix_NAN.RowCount - 1; i++)
            {
                dataGridViewMatrix_NAN.Rows[i].Visible = false;
                for (int j = 0; j < dataGridViewMatrix_NAN.ColumnCount; j++)
                {
                    if (dataGridViewMatrix_NAN.Rows[i].Cells[j].Value != null)
                    {
                        if (dataGridViewMatrix_NAN.Rows[i].Cells[j].Value.ToString().Contains(textBoxFilter_NAN.Text))
                        {
                            dataGridViewMatrix_NAN.Rows[i].Visible = true;
                            break;
                        }
                    }
                }
            }
        }

        private void buttonFilterBack_NAN_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewMatrix_NAN.RowCount - 1; i++)
            {
                dataGridViewMatrix_NAN.Rows[i].Visible = true;
            }
        }

        private void buttonSort_NAN_Click(object sender, EventArgs e)
        {
            int numSort = Convert.ToInt32(textBoxSort_NAN.Text);
            dataGridViewMatrix_NAN.Sort(dataGridViewMatrix_NAN.Columns[numSort], ListSortDirection.Ascending);
        }
    }
}
