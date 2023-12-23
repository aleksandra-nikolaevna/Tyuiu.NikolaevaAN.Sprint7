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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_NAN.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog_NAN.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        DataService ds = new DataService();
        static int rows = 4;
        static int columns = 7;
        static string openFilePath = @"C:\DataSprint7\InPutFileProjectV7.csv";

        public static string[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath, Encoding.Default);
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

        private void buttonAddPerson_NAN_Click(object sender, EventArgs e)
        {
            try
            {
                string entrance = Convert.ToString(textBoxEntrance_NAN.Text);
                string flat = Convert.ToString(textBoxFlat_NAN.Text);
                string rooms = Convert.ToString(textBoxRooms_NAN.Text);
                string surname = Convert.ToString(textBoxSurname_NAN.Text);
                string members = Convert.ToString(textBoxMembers_NAN.Text);
                string kids = Convert.ToString(textBoxKids_NAN.Text);
                string arrears = Convert.ToString(textBoxArrears_NAN.Text);

                //вывод в таблицу
                this.dataGridViewMatrix_NAN.Rows.Add(entrance, flat, rooms, surname, members, kids, arrears);
                rows += 1;

                //сохранение в файл
                saveFileDialog_NAN.FileName = @"C:\DataSprint7\NewPersons.csv";
                string path = saveFileDialog_NAN.FileName;
                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;
                if (fileExists)
                {
                    File.Delete(path);
                }

                int row = dataGridViewMatrix_NAN.RowCount;
                int column = dataGridViewMatrix_NAN.ColumnCount;
                string str = "";
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        if (j != columns - 1)
                        {
                            str = str + dataGridViewMatrix_NAN.Rows[i].Cells[j].Value + ";";
                        }
                        else
                        {
                            str = str + dataGridViewMatrix_NAN.Rows[i].Cells[j].Value;
                        }
                    }
                    File.AppendAllText(path, str + Environment.NewLine);
                    str = "";
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewMatrix_NAN.ColumnCount = columns;
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
            dataGridViewMatrix_NAN.RowCount = rows;

            //добавление в таблицу
            string[,] arrayValues = new string[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);

            for (int r = 0; r < rows-1; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewMatrix_NAN.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
        }

        private void buttonSort_NAN_Click(object sender, EventArgs e)
        {
            int numSort = Convert.ToInt32(textBoxSort_NAN.Text);
            dataGridViewMatrix_NAN.Sort(dataGridViewMatrix_NAN.Columns[numSort], ListSortDirection.Ascending);
        }

        private void buttonHelp_NAN_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDiag_NAN_Click(object sender, EventArgs e)
        {
            FormDiag formDiag = new FormDiag();
            formDiag.ShowDialog();
        }
    }
}
