
namespace Tyuiu.NikolaevaAN.Sprint7.Project.V7
{
    partial class FormStatistics
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
            this.panelTop_NAN = new System.Windows.Forms.Panel();
            this.panelLeft_NAN = new System.Windows.Forms.Panel();
            this.splitter_NAN = new System.Windows.Forms.Splitter();
            this.panelRight_NAN = new System.Windows.Forms.Panel();
            this.dataGridViewMatrix_NAN = new System.Windows.Forms.DataGridView();
            this.groupBoxStat_NAN = new System.Windows.Forms.GroupBox();
            this.labelCount_NAN = new System.Windows.Forms.Label();
            this.labelSumAll_NAN = new System.Windows.Forms.Label();
            this.labelSumKids_NAN = new System.Windows.Forms.Label();
            this.labelMax_NAN = new System.Windows.Forms.Label();
            this.labelMin_NAN = new System.Windows.Forms.Label();
            this.textBoxCount_NAN = new System.Windows.Forms.TextBox();
            this.textBoxSumAll_NAN = new System.Windows.Forms.TextBox();
            this.textBoxSumKids_NAN = new System.Windows.Forms.TextBox();
            this.textBoxMax_NAN = new System.Windows.Forms.TextBox();
            this.textBoxMin_NAN = new System.Windows.Forms.TextBox();
            this.panelLeft_NAN.SuspendLayout();
            this.panelRight_NAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_NAN)).BeginInit();
            this.groupBoxStat_NAN.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_NAN
            // 
            this.panelTop_NAN.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_NAN.Location = new System.Drawing.Point(0, 0);
            this.panelTop_NAN.Name = "panelTop_NAN";
            this.panelTop_NAN.Padding = new System.Windows.Forms.Padding(5);
            this.panelTop_NAN.Size = new System.Drawing.Size(1072, 103);
            this.panelTop_NAN.TabIndex = 0;
            // 
            // panelLeft_NAN
            // 
            this.panelLeft_NAN.Controls.Add(this.groupBoxStat_NAN);
            this.panelLeft_NAN.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_NAN.Location = new System.Drawing.Point(0, 103);
            this.panelLeft_NAN.Name = "panelLeft_NAN";
            this.panelLeft_NAN.Padding = new System.Windows.Forms.Padding(5);
            this.panelLeft_NAN.Size = new System.Drawing.Size(293, 430);
            this.panelLeft_NAN.TabIndex = 1;
            // 
            // splitter_NAN
            // 
            this.splitter_NAN.Location = new System.Drawing.Point(293, 103);
            this.splitter_NAN.Name = "splitter_NAN";
            this.splitter_NAN.Size = new System.Drawing.Size(3, 430);
            this.splitter_NAN.TabIndex = 2;
            this.splitter_NAN.TabStop = false;
            // 
            // panelRight_NAN
            // 
            this.panelRight_NAN.Controls.Add(this.dataGridViewMatrix_NAN);
            this.panelRight_NAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_NAN.Location = new System.Drawing.Point(296, 103);
            this.panelRight_NAN.Name = "panelRight_NAN";
            this.panelRight_NAN.Padding = new System.Windows.Forms.Padding(5);
            this.panelRight_NAN.Size = new System.Drawing.Size(776, 430);
            this.panelRight_NAN.TabIndex = 3;
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
            this.dataGridViewMatrix_NAN.Size = new System.Drawing.Size(766, 420);
            this.dataGridViewMatrix_NAN.TabIndex = 0;
            // 
            // groupBoxStat_NAN
            // 
            this.groupBoxStat_NAN.Controls.Add(this.textBoxMin_NAN);
            this.groupBoxStat_NAN.Controls.Add(this.textBoxMax_NAN);
            this.groupBoxStat_NAN.Controls.Add(this.textBoxSumKids_NAN);
            this.groupBoxStat_NAN.Controls.Add(this.textBoxSumAll_NAN);
            this.groupBoxStat_NAN.Controls.Add(this.textBoxCount_NAN);
            this.groupBoxStat_NAN.Controls.Add(this.labelMin_NAN);
            this.groupBoxStat_NAN.Controls.Add(this.labelMax_NAN);
            this.groupBoxStat_NAN.Controls.Add(this.labelSumKids_NAN);
            this.groupBoxStat_NAN.Controls.Add(this.labelSumAll_NAN);
            this.groupBoxStat_NAN.Controls.Add(this.labelCount_NAN);
            this.groupBoxStat_NAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxStat_NAN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxStat_NAN.Location = new System.Drawing.Point(5, 5);
            this.groupBoxStat_NAN.Name = "groupBoxStat_NAN";
            this.groupBoxStat_NAN.Size = new System.Drawing.Size(283, 420);
            this.groupBoxStat_NAN.TabIndex = 0;
            this.groupBoxStat_NAN.TabStop = false;
            this.groupBoxStat_NAN.Text = "Статистика:";
            // 
            // labelCount_NAN
            // 
            this.labelCount_NAN.AutoSize = true;
            this.labelCount_NAN.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount_NAN.Location = new System.Drawing.Point(7, 29);
            this.labelCount_NAN.Name = "labelCount_NAN";
            this.labelCount_NAN.Size = new System.Drawing.Size(140, 19);
            this.labelCount_NAN.TabIndex = 0;
            this.labelCount_NAN.Text = "Количество квартир:";
            // 
            // labelSumAll_NAN
            // 
            this.labelSumAll_NAN.AutoSize = true;
            this.labelSumAll_NAN.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSumAll_NAN.Location = new System.Drawing.Point(7, 72);
            this.labelSumAll_NAN.Name = "labelSumAll_NAN";
            this.labelSumAll_NAN.Size = new System.Drawing.Size(144, 19);
            this.labelSumAll_NAN.TabIndex = 1;
            this.labelSumAll_NAN.Text = "Количество жильцов:";
            // 
            // labelSumKids_NAN
            // 
            this.labelSumKids_NAN.AutoSize = true;
            this.labelSumKids_NAN.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSumKids_NAN.Location = new System.Drawing.Point(6, 115);
            this.labelSumKids_NAN.Name = "labelSumKids_NAN";
            this.labelSumKids_NAN.Size = new System.Drawing.Size(118, 19);
            this.labelSumKids_NAN.TabIndex = 2;
            this.labelSumKids_NAN.Text = "Среди них детей:";
            // 
            // labelMax_NAN
            // 
            this.labelMax_NAN.AutoSize = true;
            this.labelMax_NAN.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMax_NAN.Location = new System.Drawing.Point(7, 169);
            this.labelMax_NAN.Name = "labelMax_NAN";
            this.labelMax_NAN.Size = new System.Drawing.Size(195, 38);
            this.labelMax_NAN.TabIndex = 3;
            this.labelMax_NAN.Text = "Наибольшее кол-во жильцов\r\nв квартире:";
            // 
            // labelMin_NAN
            // 
            this.labelMin_NAN.AutoSize = true;
            this.labelMin_NAN.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMin_NAN.Location = new System.Drawing.Point(7, 233);
            this.labelMin_NAN.Name = "labelMin_NAN";
            this.labelMin_NAN.Size = new System.Drawing.Size(197, 38);
            this.labelMin_NAN.TabIndex = 4;
            this.labelMin_NAN.Text = "Наименьшее кол-во жильцов\r\nв квартире:";
            // 
            // textBoxCount_NAN
            // 
            this.textBoxCount_NAN.Location = new System.Drawing.Point(132, 24);
            this.textBoxCount_NAN.Multiline = true;
            this.textBoxCount_NAN.Name = "textBoxCount_NAN";
            this.textBoxCount_NAN.ReadOnly = true;
            this.textBoxCount_NAN.Size = new System.Drawing.Size(55, 25);
            this.textBoxCount_NAN.TabIndex = 5;
            // 
            // textBoxSumAll_NAN
            // 
            this.textBoxSumAll_NAN.Location = new System.Drawing.Point(135, 64);
            this.textBoxSumAll_NAN.Multiline = true;
            this.textBoxSumAll_NAN.Name = "textBoxSumAll_NAN";
            this.textBoxSumAll_NAN.ReadOnly = true;
            this.textBoxSumAll_NAN.Size = new System.Drawing.Size(55, 25);
            this.textBoxSumAll_NAN.TabIndex = 6;
            // 
            // textBoxSumKids_NAN
            // 
            this.textBoxSumKids_NAN.Location = new System.Drawing.Point(109, 109);
            this.textBoxSumKids_NAN.Multiline = true;
            this.textBoxSumKids_NAN.Name = "textBoxSumKids_NAN";
            this.textBoxSumKids_NAN.ReadOnly = true;
            this.textBoxSumKids_NAN.Size = new System.Drawing.Size(55, 25);
            this.textBoxSumKids_NAN.TabIndex = 7;
            // 
            // textBoxMax_NAN
            // 
            this.textBoxMax_NAN.Location = new System.Drawing.Point(74, 183);
            this.textBoxMax_NAN.Multiline = true;
            this.textBoxMax_NAN.Name = "textBoxMax_NAN";
            this.textBoxMax_NAN.ReadOnly = true;
            this.textBoxMax_NAN.Size = new System.Drawing.Size(55, 25);
            this.textBoxMax_NAN.TabIndex = 8;
            // 
            // textBoxMin_NAN
            // 
            this.textBoxMin_NAN.Location = new System.Drawing.Point(74, 247);
            this.textBoxMin_NAN.Multiline = true;
            this.textBoxMin_NAN.Name = "textBoxMin_NAN";
            this.textBoxMin_NAN.ReadOnly = true;
            this.textBoxMin_NAN.Size = new System.Drawing.Size(55, 25);
            this.textBoxMin_NAN.TabIndex = 9;
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 533);
            this.Controls.Add(this.panelRight_NAN);
            this.Controls.Add(this.splitter_NAN);
            this.Controls.Add(this.panelLeft_NAN);
            this.Controls.Add(this.panelTop_NAN);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(1090, 580);
            this.Name = "FormStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика жильцов";
            this.Load += new System.EventHandler(this.FormStatistics_Load);
            this.panelLeft_NAN.ResumeLayout(false);
            this.panelRight_NAN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_NAN)).EndInit();
            this.groupBoxStat_NAN.ResumeLayout(false);
            this.groupBoxStat_NAN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_NAN;
        private System.Windows.Forms.Panel panelLeft_NAN;
        private System.Windows.Forms.Splitter splitter_NAN;
        private System.Windows.Forms.Panel panelRight_NAN;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_NAN;
        private System.Windows.Forms.GroupBox groupBoxStat_NAN;
        private System.Windows.Forms.Label labelCount_NAN;
        private System.Windows.Forms.Label labelSumAll_NAN;
        private System.Windows.Forms.Label labelSumKids_NAN;
        private System.Windows.Forms.Label labelMax_NAN;
        private System.Windows.Forms.Label labelMin_NAN;
        private System.Windows.Forms.TextBox textBoxCount_NAN;
        private System.Windows.Forms.TextBox textBoxSumAll_NAN;
        private System.Windows.Forms.TextBox textBoxSumKids_NAN;
        private System.Windows.Forms.TextBox textBoxMax_NAN;
        private System.Windows.Forms.TextBox textBoxMin_NAN;
    }
}