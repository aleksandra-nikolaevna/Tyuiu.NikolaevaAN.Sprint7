
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelLeft_NAN = new System.Windows.Forms.Panel();
            this.splitter_NAN = new System.Windows.Forms.Splitter();
            this.panelRight_NAN = new System.Windows.Forms.Panel();
            this.groupBoxDiag_NAN = new System.Windows.Forms.GroupBox();
            this.buttonMembers_NAN = new System.Windows.Forms.Button();
            this.buttonKids_NAN = new System.Windows.Forms.Button();
            this.buttonArrears_NAN = new System.Windows.Forms.Button();
            this.labelMembers_NAN = new System.Windows.Forms.Label();
            this.labelKids_NAN = new System.Windows.Forms.Label();
            this.labelArrears_NAN = new System.Windows.Forms.Label();
            this.dataGridViewMatrix_NAN = new System.Windows.Forms.DataGridView();
            this.chartDiag_NAN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelLeft_NAN.SuspendLayout();
            this.panelRight_NAN.SuspendLayout();
            this.groupBoxDiag_NAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_NAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_NAN)).BeginInit();
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
            // groupBoxDiag_NAN
            // 
            this.groupBoxDiag_NAN.Controls.Add(this.labelArrears_NAN);
            this.groupBoxDiag_NAN.Controls.Add(this.labelKids_NAN);
            this.groupBoxDiag_NAN.Controls.Add(this.labelMembers_NAN);
            this.groupBoxDiag_NAN.Controls.Add(this.buttonArrears_NAN);
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
            // buttonMembers_NAN
            // 
            this.buttonMembers_NAN.Location = new System.Drawing.Point(8, 25);
            this.buttonMembers_NAN.Name = "buttonMembers_NAN";
            this.buttonMembers_NAN.Size = new System.Drawing.Size(91, 37);
            this.buttonMembers_NAN.TabIndex = 0;
            this.buttonMembers_NAN.Text = "Показать";
            this.buttonMembers_NAN.UseVisualStyleBackColor = true;
            this.buttonMembers_NAN.Click += new System.EventHandler(this.buttonMembers_NAN_Click);
            // 
            // buttonKids_NAN
            // 
            this.buttonKids_NAN.Location = new System.Drawing.Point(8, 68);
            this.buttonKids_NAN.Name = "buttonKids_NAN";
            this.buttonKids_NAN.Size = new System.Drawing.Size(91, 35);
            this.buttonKids_NAN.TabIndex = 1;
            this.buttonKids_NAN.Text = "Показать";
            this.buttonKids_NAN.UseVisualStyleBackColor = true;
            // 
            // buttonArrears_NAN
            // 
            this.buttonArrears_NAN.Location = new System.Drawing.Point(8, 109);
            this.buttonArrears_NAN.Name = "buttonArrears_NAN";
            this.buttonArrears_NAN.Size = new System.Drawing.Size(91, 35);
            this.buttonArrears_NAN.TabIndex = 2;
            this.buttonArrears_NAN.Text = "Показать";
            this.buttonArrears_NAN.UseVisualStyleBackColor = true;
            // 
            // labelMembers_NAN
            // 
            this.labelMembers_NAN.AutoSize = true;
            this.labelMembers_NAN.Location = new System.Drawing.Point(105, 35);
            this.labelMembers_NAN.Name = "labelMembers_NAN";
            this.labelMembers_NAN.Size = new System.Drawing.Size(267, 19);
            this.labelMembers_NAN.TabIndex = 3;
            this.labelMembers_NAN.Text = "Диаграмма по количеству членов семьи";
            // 
            // labelKids_NAN
            // 
            this.labelKids_NAN.AutoSize = true;
            this.labelKids_NAN.Location = new System.Drawing.Point(105, 77);
            this.labelKids_NAN.Name = "labelKids_NAN";
            this.labelKids_NAN.Size = new System.Drawing.Size(268, 19);
            this.labelKids_NAN.TabIndex = 4;
            this.labelKids_NAN.Text = "Диаграмма по количеству детей в семье";
            // 
            // labelArrears_NAN
            // 
            this.labelArrears_NAN.AutoSize = true;
            this.labelArrears_NAN.Location = new System.Drawing.Point(105, 118);
            this.labelArrears_NAN.Name = "labelArrears_NAN";
            this.labelArrears_NAN.Size = new System.Drawing.Size(305, 19);
            this.labelArrears_NAN.TabIndex = 5;
            this.labelArrears_NAN.Text = "Диаграмма по задолженностям по квартплате";
            // 
            // dataGridViewMatrix_NAN
            // 
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
            // chartDiag_NAN
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDiag_NAN.ChartAreas.Add(chartArea1);
            this.chartDiag_NAN.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartDiag_NAN.Legends.Add(legend1);
            this.chartDiag_NAN.Location = new System.Drawing.Point(5, 162);
            this.chartDiag_NAN.Name = "chartDiag_NAN";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDiag_NAN.Series.Add(series1);
            this.chartDiag_NAN.Size = new System.Drawing.Size(647, 336);
            this.chartDiag_NAN.TabIndex = 1;
            this.chartDiag_NAN.Text = "chart1";
            // 
            // FormDiag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.panelRight_NAN.ResumeLayout(false);
            this.groupBoxDiag_NAN.ResumeLayout(false);
            this.groupBoxDiag_NAN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_NAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_NAN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft_NAN;
        private System.Windows.Forms.Splitter splitter_NAN;
        private System.Windows.Forms.Panel panelRight_NAN;
        private System.Windows.Forms.GroupBox groupBoxDiag_NAN;
        private System.Windows.Forms.Button buttonMembers_NAN;
        private System.Windows.Forms.Button buttonKids_NAN;
        private System.Windows.Forms.Button buttonArrears_NAN;
        private System.Windows.Forms.Label labelMembers_NAN;
        private System.Windows.Forms.Label labelKids_NAN;
        private System.Windows.Forms.Label labelArrears_NAN;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_NAN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_NAN;
    }
}