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
        }

        DataService ds = new DataService();
        private void buttonAddPerson_NAN_Click(object sender, EventArgs e)
        {
            try
            {
                int entrance = Convert.ToInt32(textBoxEntrance_NAN.Text);
                int flat = Convert.ToInt32(textBoxFlat_NAN.Text);
                int rooms = Convert.ToInt32(textBoxRooms_NAN.Text);
                string surname = Convert.ToString(textBoxSurname_NAN.Text);
                int members = Convert.ToInt32(textBoxMembers_NAN.Text);
                int kids = Convert.ToInt32(textBoxKids_NAN.Text);
                string arrears = Convert.ToString(textBoxArrears_NAN.Text);

                dataGridViewMatrix_NAN.ColumnCount = 7;
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
                /*dataGridViewMatrix_NAN.RowCount = rows;
                for (int i = 0; i < columns; i++)
                {
                    dataGridViewMatrix_NAN.Columns[i].Width = 30;
                }
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewMatrix_NAN.Rows[i].Cells[j].Value = Convert.ToString(array[i, j]);
                    }
                }*/
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
