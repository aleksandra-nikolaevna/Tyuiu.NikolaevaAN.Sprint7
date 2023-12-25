
namespace Tyuiu.NikolaevaAN.Sprint7.Project.V7
{
    partial class FormDiag
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelLeft_NAN = new System.Windows.Forms.Panel();
            this.chartDiag_NAN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxDiag_NAN = new System.Windows.Forms.GroupBox();
            this.labelRooms_NAN = new System.Windows.Forms.Label();
            this.buttonRooms_NAN = new System.Windows.Forms.Button();
            this.labelKids_NAN = new System.Windows.Forms.Label();
            this.labelMembers_NAN = new System.Windows.Forms.Label();
            this.buttonKids_NAN = new System.Windows.Forms.Button();
            this.buttonMembers_NAN = new System.Windows.Forms.Button();
            this.splitter_NAN = new System.Windows.Forms.Splitter();
            this.panelRight_NAN = new System.Windows.Forms.Panel();
            this.dataGridViewMatrix_NAN = new System.Windows.Forms.DataGridView();
            this.toolTip_NAN = new System.Windows.Forms.ToolTip(this.components);
            this.panelLeft_NAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_NAN)).BeginInit();
            this.groupBoxDiag_NAN.SuspendLayout();
            this.panelRight_NAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_NAN)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft_NAN
            // 
            this.panelLeft_NAN.Controls.Add(this.chartDiag_NAN);
            this.panelLeft_NAN.Controls.Add(this.groupBoxDiag_NAN);
            this.panelLeft_NAN.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_NAN.Location = new System.Drawing.Point(0, 0);
            this.panelLeft_NAN.Name = "panelLeft_NAN";
            this.panelLeft_NAN.Padding = new System.Windows.Forms.Padding(5);
            this.panelLeft_NAN.Size = new System.Drawing.Size(657, 503);
            this.panelLeft_NAN.TabIndex = 0;
            // 
            // chartDiag_NAN
            // 
            this.chartDiag_NAN.BackColor = System.Drawing.Color.LightCyan;
            chartArea3.Name = "ChartArea1";
            this.chartDiag_NAN.ChartAreas.Add(chartArea3);
            this.chartDiag_NAN.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartDiag_NAN.Legends.Add(legend3);
            this.chartDiag_NAN.Location = new System.Drawing.Point(5, 162);
            this.chartDiag_NAN.Name = "chartDiag_NAN";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartDiag_NAN.Series.Add(series3);
            this.chartDiag_NAN.Size = new System.Drawing.Size(647, 336);
            this.chartDiag_NAN.TabIndex = 1;
            this.chartDiag_NAN.Text = "chart1";
            // 
            // groupBoxDiag_NAN
            // 
            this.groupBoxDiag_NAN.BackColor = System.Drawing.Color.LightCyan;
            this.groupBoxDiag_NAN.Controls.Add(this.labelRooms_NAN);
            this.groupBoxDiag_NAN.Controls.Add(this.buttonRooms_NAN);
            this.groupBoxDiag_NAN.Controls.Add(this.labelKids_NAN);
            this.groupBoxDiag_NAN.Controls.Add(this.labelMembers_NAN);
            this.groupBoxDiag_NAN.Controls.Add(this.buttonKids_NAN);
            this.groupBoxDiag_NAN.Controls.Add(this.buttonMembers_NAN);
            this.groupBoxDiag_NAN.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDiag_NAN.Location = new System.Drawing.Point(5, 5);
            this.groupBoxDiag_NAN.Name = "groupBoxDiag_NAN";
            this.groupBoxDiag_NAN.Size = new System.Drawing.Size(647, 157);
            this.groupBoxDiag_NAN.TabIndex = 0;
            this.groupBoxDiag_NAN.TabStop = false;
            this.groupBoxDiag_NAN.Text = "Выбор диаграммы:";
            // 
            // labelRooms_NAN
            // 
            this.labelRooms_NAN.AutoSize = true;
            this.labelRooms_NAN.Location = new System.Drawing.Point(106, 36);
            this.labelRooms_NAN.Name = "labelRooms_NAN";
            this.labelRooms_NAN.Size = new System.Drawing.Size(299, 19);
            this.labelRooms_NAN.TabIndex = 6;
            this.labelRooms_NAN.Text = "Диаграмма по количеству комнат в квартире";
            // 
            // buttonRooms_NAN
            // 
            this.buttonRooms_NAN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(204)))), ((int)(((byte)(252)))));
            this.buttonRooms_NAN.Location = new System.Drawing.Point(8, 26);
            this.buttonRooms_NAN.Name = "buttonRooms_NAN";
            this.buttonRooms_NAN.Size = new System.Drawing.Size(91, 37);
            this.buttonRooms_NAN.TabIndex = 5;
            this.buttonRooms_NAN.Text = "Показать";
            this.toolTip_NAN.SetToolTip(this.buttonRooms_NAN, "Вывести на экран диаграмму по количеству\r\nкомнат в квартире");
            this.buttonRooms_NAN.UseVisualStyleBackColor = false;
            this.buttonRooms_NAN.Click += new System.EventHandler(this.buttonRooms_NAN_Click);
            // 
            // labelKids_NAN
            // 
            this.labelKids_NAN.AutoSize = true;
            this.labelKids_NAN.Location = new System.Drawing.Point(105, 121);
            this.labelKids_NAN.Name = "labelKids_NAN";
            this.labelKids_NAN.Size = new System.Drawing.Size(268, 19);
            this.labelKids_NAN.TabIndex = 4;
            this.labelKids_NAN.Text = "Диаграмма по количеству детей в семье";
            // 
            // labelMembers_NAN
            // 
            this.labelMembers_NAN.AutoSize = true;
            this.labelMembers_NAN.Location = new System.Drawing.Point(105, 79);
            this.labelMembers_NAN.Name = "labelMembers_NAN";
            this.labelMembers_NAN.Size = new System.Drawing.Size(267, 19);
            this.labelMembers_NAN.TabIndex = 3;
            this.labelMembers_NAN.Text = "Диаграмма по количеству членов семьи";
            // 
            // buttonKids_NAN
            // 
            this.buttonKids_NAN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(204)))), ((int)(((byte)(252)))));
            this.buttonKids_NAN.Location = new System.Drawing.Point(8, 112);
            this.buttonKids_NAN.Name = "buttonKids_NAN";
            this.buttonKids_NAN.Size = new System.Drawing.Size(91, 35);
            this.buttonKids_NAN.TabIndex = 1;
            this.buttonKids_NAN.Text = "Показать";
            this.toolTip_NAN.SetToolTip(this.buttonKids_NAN, "Вывести на экран диаграмму по количеству\r\nдетей в семье\r\n");
            this.buttonKids_NAN.UseVisualStyleBackColor = false;
            this.buttonKids_NAN.Click += new System.EventHandler(this.buttonKids_NAN_Click);
            // 
            // buttonMembers_NAN
            // 
            this.buttonMembers_NAN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(204)))), ((int)(((byte)(252)))));
            this.buttonMembers_NAN.Location = new System.Drawing.Point(8, 69);
            this.buttonMembers_NAN.Name = "buttonMembers_NAN";
            this.buttonMembers_NAN.Size = new System.Drawing.Size(91, 37);
            this.buttonMembers_NAN.TabIndex = 0;
            this.buttonMembers_NAN.Text = "Показать";
            this.toolTip_NAN.SetToolTip(this.buttonMembers_NAN, "Вывести на экран диаграмму по количеству\r\nчленов семьи\r\n");
            this.buttonMembers_NAN.UseVisualStyleBackColor = false;
            this.buttonMembers_NAN.Click += new System.EventHandler(this.buttonMembers_NAN_Click);
            // 
            // splitter_NAN
            // 
            this.splitter_NAN.Location = new System.Drawing.Point(657, 0);
            this.splitter_NAN.Name = "splitter_NAN";
            this.splitter_NAN.Size = new System.Drawing.Size(3, 503);
            this.splitter_NAN.TabIndex = 1;
            this.splitter_NAN.TabStop = false;
            // 
            // panelRight_NAN
            // 
            this.panelRight_NAN.Controls.Add(this.dataGridViewMatrix_NAN);
            this.panelRight_NAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_NAN.Location = new System.Drawing.Point(660, 0);
            this.panelRight_NAN.Name = "panelRight_NAN";
            this.panelRight_NAN.Padding = new System.Windows.Forms.Padding(5);
            this.panelRight_NAN.Size = new System.Drawing.Size(422, 503);
            this.panelRight_NAN.TabIndex = 2;
            // 
            // dataGridViewMatrix_NAN
            // 
            this.dataGridViewMatrix_NAN.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewMatrix_NAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_NAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMatrix_NAN.Location = new System.Drawing.Point(5, 5);
            this.dataGridViewMatrix_NAN.Name = "dataGridViewMatrix_NAN";
            this.dataGridViewMatrix_NAN.RowHeadersVisible = false;
            this.dataGridViewMatrix_NAN.RowHeadersWidth = 51;
            this.dataGridViewMatrix_NAN.RowTemplate.Height = 24;
            this.dataGridViewMatrix_NAN.Size = new System.Drawing.Size(412, 493);
            this.dataGridViewMatrix_NAN.TabIndex = 0;
            // 
            // toolTip_NAN
            // 
            this.toolTip_NAN.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_NAN.ToolTipTitle = "Подсказка";
            // 
            // FormDiag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1082, 503);
            this.Controls.Add(this.panelRight_NAN);
            this.Controls.Add(this.splitter_NAN);
            this.Controls.Add(this.panelLeft_NAN);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(1100, 550);
            this.Name = "FormDiag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Диаграммы";
            this.Load += new System.EventHandler(this.FormDiag_Load);
            this.panelLeft_NAN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_NAN)).EndInit();
            this.groupBoxDiag_NAN.ResumeLayout(false);
            this.groupBoxDiag_NAN.PerformLayout();
            this.panelRight_NAN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_NAN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft_NAN;
        private System.Windows.Forms.Splitter splitter_NAN;
        private System.Windows.Forms.Panel panelRight_NAN;
        private System.Windows.Forms.GroupBox groupBoxDiag_NAN;
        private System.Windows.Forms.Button buttonMembers_NAN;
        private System.Windows.Forms.Button buttonKids_NAN;
        private System.Windows.Forms.Label labelMembers_NAN;
        private System.Windows.Forms.Label labelKids_NAN;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_NAN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_NAN;
        private System.Windows.Forms.Button buttonRooms_NAN;
        private System.Windows.Forms.Label labelRooms_NAN;
        private System.Windows.Forms.ToolTip toolTip_NAN;
    }
}