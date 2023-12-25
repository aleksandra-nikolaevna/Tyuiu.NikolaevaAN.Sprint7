
namespace Tyuiu.NikolaevaAN.Sprint7.Project.V7
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelTop_NAN = new System.Windows.Forms.Panel();
            this.buttonStat_NAN = new System.Windows.Forms.Button();
            this.groupBoxSort_NAN = new System.Windows.Forms.GroupBox();
            this.buttonSort_NAN = new System.Windows.Forms.Button();
            this.labelSort_NAN = new System.Windows.Forms.Label();
            this.textBoxSort_NAN = new System.Windows.Forms.TextBox();
            this.buttonDiag_NAN = new System.Windows.Forms.Button();
            this.buttonHelp_NAN = new System.Windows.Forms.Button();
            this.panelLeft_NAN = new System.Windows.Forms.Panel();
            this.groupBoxAddPerson_NAN = new System.Windows.Forms.GroupBox();
            this.buttonAddPerson_NAN = new System.Windows.Forms.Button();
            this.textBoxArrears_NAN = new System.Windows.Forms.TextBox();
            this.labelArrears_NAN = new System.Windows.Forms.Label();
            this.textBoxKids_NAN = new System.Windows.Forms.TextBox();
            this.labelKids_NAN = new System.Windows.Forms.Label();
            this.textBoxMembers_NAN = new System.Windows.Forms.TextBox();
            this.labelMembers_NAN = new System.Windows.Forms.Label();
            this.textBoxSurname_NAN = new System.Windows.Forms.TextBox();
            this.labelSurname_NAN = new System.Windows.Forms.Label();
            this.textBoxRooms_NAN = new System.Windows.Forms.TextBox();
            this.labelRooms_NAN = new System.Windows.Forms.Label();
            this.textBoxFlat_NAN = new System.Windows.Forms.TextBox();
            this.labelFlat_NAN = new System.Windows.Forms.Label();
            this.textBoxEntrance_NAN = new System.Windows.Forms.TextBox();
            this.labelEntrance_NAN = new System.Windows.Forms.Label();
            this.panelRight_NAN = new System.Windows.Forms.Panel();
            this.dataGridViewMatrix_NAN = new System.Windows.Forms.DataGridView();
            this.openFileDialog_NAN = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_NAN = new System.Windows.Forms.SaveFileDialog();
            this.toolTip_NAN = new System.Windows.Forms.ToolTip(this.components);
            this.panelTop_NAN.SuspendLayout();
            this.groupBoxSort_NAN.SuspendLayout();
            this.panelLeft_NAN.SuspendLayout();
            this.groupBoxAddPerson_NAN.SuspendLayout();
            this.panelRight_NAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_NAN)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_NAN
            // 
            this.panelTop_NAN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.panelTop_NAN.Controls.Add(this.buttonStat_NAN);
            this.panelTop_NAN.Controls.Add(this.groupBoxSort_NAN);
            this.panelTop_NAN.Controls.Add(this.buttonDiag_NAN);
            this.panelTop_NAN.Controls.Add(this.buttonHelp_NAN);
            this.panelTop_NAN.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_NAN.Location = new System.Drawing.Point(0, 0);
            this.panelTop_NAN.Name = "panelTop_NAN";
            this.panelTop_NAN.Padding = new System.Windows.Forms.Padding(5);
            this.panelTop_NAN.Size = new System.Drawing.Size(1382, 78);
            this.panelTop_NAN.TabIndex = 0;
            // 
            // buttonStat_NAN
            // 
            this.buttonStat_NAN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(204)))), ((int)(((byte)(252)))));
            this.buttonStat_NAN.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStat_NAN.Location = new System.Drawing.Point(150, 10);
            this.buttonStat_NAN.Name = "buttonStat_NAN";
            this.buttonStat_NAN.Size = new System.Drawing.Size(109, 57);
            this.buttonStat_NAN.TabIndex = 3;
            this.buttonStat_NAN.Text = "Статистика";
            this.toolTip_NAN.SetToolTip(this.buttonStat_NAN, "Посмотреть статистику жильцов и выполнить поиск,\r\nфильтрацию и сортировку");
            this.buttonStat_NAN.UseVisualStyleBackColor = false;
            this.buttonStat_NAN.Click += new System.EventHandler(this.buttonStat_NAN_Click);
            // 
            // groupBoxSort_NAN
            // 
            this.groupBoxSort_NAN.BackColor = System.Drawing.Color.LightCyan;
            this.groupBoxSort_NAN.Controls.Add(this.buttonSort_NAN);
            this.groupBoxSort_NAN.Controls.Add(this.labelSort_NAN);
            this.groupBoxSort_NAN.Controls.Add(this.textBoxSort_NAN);
            this.groupBoxSort_NAN.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxSort_NAN.Location = new System.Drawing.Point(437, 7);
            this.groupBoxSort_NAN.Name = "groupBoxSort_NAN";
            this.groupBoxSort_NAN.Size = new System.Drawing.Size(568, 60);
            this.groupBoxSort_NAN.TabIndex = 2;
            this.groupBoxSort_NAN.TabStop = false;
            this.groupBoxSort_NAN.Text = "Сортировка:";
            // 
            // buttonSort_NAN
            // 
            this.buttonSort_NAN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSort_NAN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(204)))), ((int)(((byte)(252)))));
            this.buttonSort_NAN.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSort_NAN.Location = new System.Drawing.Point(432, 14);
            this.buttonSort_NAN.Name = "buttonSort_NAN";
            this.buttonSort_NAN.Size = new System.Drawing.Size(130, 38);
            this.buttonSort_NAN.TabIndex = 2;
            this.buttonSort_NAN.Text = "Сортировать";
            this.toolTip_NAN.SetToolTip(this.buttonSort_NAN, "Выполнить сортировку по выбранному столбцу");
            this.buttonSort_NAN.UseVisualStyleBackColor = false;
            this.buttonSort_NAN.Click += new System.EventHandler(this.buttonSort_NAN_Click);
            // 
            // labelSort_NAN
            // 
            this.labelSort_NAN.AutoSize = true;
            this.labelSort_NAN.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSort_NAN.Location = new System.Drawing.Point(6, 24);
            this.labelSort_NAN.Name = "labelSort_NAN";
            this.labelSort_NAN.Size = new System.Drawing.Size(295, 19);
            this.labelSort_NAN.TabIndex = 0;
            this.labelSort_NAN.Text = "Сортировать по номеру столбца (отсчёт с 0):";
            // 
            // textBoxSort_NAN
            // 
            this.textBoxSort_NAN.Location = new System.Drawing.Point(335, 21);
            this.textBoxSort_NAN.Multiline = true;
            this.textBoxSort_NAN.Name = "textBoxSort_NAN";
            this.textBoxSort_NAN.Size = new System.Drawing.Size(50, 25);
            this.textBoxSort_NAN.TabIndex = 1;
            // 
            // buttonDiag_NAN
            // 
            this.buttonDiag_NAN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(204)))), ((int)(((byte)(252)))));
            this.buttonDiag_NAN.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDiag_NAN.Location = new System.Drawing.Point(9, 10);
            this.buttonDiag_NAN.Name = "buttonDiag_NAN";
            this.buttonDiag_NAN.Size = new System.Drawing.Size(134, 57);
            this.buttonDiag_NAN.TabIndex = 1;
            this.buttonDiag_NAN.Text = "Посмотреть диаграмму";
            this.toolTip_NAN.SetToolTip(this.buttonDiag_NAN, "Посмотреть диаграммы по таблице с данными жильцов");
            this.buttonDiag_NAN.UseVisualStyleBackColor = false;
            this.buttonDiag_NAN.Click += new System.EventHandler(this.buttonDiag_NAN_Click);
            // 
            // buttonHelp_NAN
            // 
            this.buttonHelp_NAN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_NAN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(204)))), ((int)(((byte)(252)))));
            this.buttonHelp_NAN.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_NAN.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_NAN.Image")));
            this.buttonHelp_NAN.Location = new System.Drawing.Point(1312, 7);
            this.buttonHelp_NAN.Name = "buttonHelp_NAN";
            this.buttonHelp_NAN.Size = new System.Drawing.Size(64, 64);
            this.buttonHelp_NAN.TabIndex = 0;
            this.toolTip_NAN.SetToolTip(this.buttonHelp_NAN, "Сведения о программе");
            this.buttonHelp_NAN.UseVisualStyleBackColor = false;
            this.buttonHelp_NAN.Click += new System.EventHandler(this.buttonHelp_NAN_Click);
            // 
            // panelLeft_NAN
            // 
            this.panelLeft_NAN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.panelLeft_NAN.Controls.Add(this.groupBoxAddPerson_NAN);
            this.panelLeft_NAN.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_NAN.Location = new System.Drawing.Point(0, 78);
            this.panelLeft_NAN.Name = "panelLeft_NAN";
            this.panelLeft_NAN.Padding = new System.Windows.Forms.Padding(5);
            this.panelLeft_NAN.Size = new System.Drawing.Size(437, 475);
            this.panelLeft_NAN.TabIndex = 1;
            // 
            // groupBoxAddPerson_NAN
            // 
            this.groupBoxAddPerson_NAN.BackColor = System.Drawing.Color.LightCyan;
            this.groupBoxAddPerson_NAN.Controls.Add(this.buttonAddPerson_NAN);
            this.groupBoxAddPerson_NAN.Controls.Add(this.textBoxArrears_NAN);
            this.groupBoxAddPerson_NAN.Controls.Add(this.labelArrears_NAN);
            this.groupBoxAddPerson_NAN.Controls.Add(this.textBoxKids_NAN);
            this.groupBoxAddPerson_NAN.Controls.Add(this.labelKids_NAN);
            this.groupBoxAddPerson_NAN.Controls.Add(this.textBoxMembers_NAN);
            this.groupBoxAddPerson_NAN.Controls.Add(this.labelMembers_NAN);
            this.groupBoxAddPerson_NAN.Controls.Add(this.textBoxSurname_NAN);
            this.groupBoxAddPerson_NAN.Controls.Add(this.labelSurname_NAN);
            this.groupBoxAddPerson_NAN.Controls.Add(this.textBoxRooms_NAN);
            this.groupBoxAddPerson_NAN.Controls.Add(this.labelRooms_NAN);
            this.groupBoxAddPerson_NAN.Controls.Add(this.textBoxFlat_NAN);
            this.groupBoxAddPerson_NAN.Controls.Add(this.labelFlat_NAN);
            this.groupBoxAddPerson_NAN.Controls.Add(this.textBoxEntrance_NAN);
            this.groupBoxAddPerson_NAN.Controls.Add(this.labelEntrance_NAN);
            this.groupBoxAddPerson_NAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAddPerson_NAN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxAddPerson_NAN.Location = new System.Drawing.Point(5, 5);
            this.groupBoxAddPerson_NAN.Name = "groupBoxAddPerson_NAN";
            this.groupBoxAddPerson_NAN.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxAddPerson_NAN.Size = new System.Drawing.Size(427, 465);
            this.groupBoxAddPerson_NAN.TabIndex = 0;
            this.groupBoxAddPerson_NAN.TabStop = false;
            this.groupBoxAddPerson_NAN.Text = "Добавить нового пользователя:";
            // 
            // buttonAddPerson_NAN
            // 
            this.buttonAddPerson_NAN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddPerson_NAN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(204)))), ((int)(((byte)(252)))));
            this.buttonAddPerson_NAN.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddPerson_NAN.Location = new System.Drawing.Point(285, 411);
            this.buttonAddPerson_NAN.Name = "buttonAddPerson_NAN";
            this.buttonAddPerson_NAN.Size = new System.Drawing.Size(138, 50);
            this.buttonAddPerson_NAN.TabIndex = 14;
            this.buttonAddPerson_NAN.Text = "Добавить пользователя";
            this.toolTip_NAN.SetToolTip(this.buttonAddPerson_NAN, "Добавляет в таблицу данные о новом жильце");
            this.buttonAddPerson_NAN.UseVisualStyleBackColor = false;
            this.buttonAddPerson_NAN.Click += new System.EventHandler(this.buttonAddPerson_NAN_Click);
            // 
            // textBoxArrears_NAN
            // 
            this.textBoxArrears_NAN.Location = new System.Drawing.Point(302, 362);
            this.textBoxArrears_NAN.Multiline = true;
            this.textBoxArrears_NAN.Name = "textBoxArrears_NAN";
            this.textBoxArrears_NAN.Size = new System.Drawing.Size(73, 32);
            this.textBoxArrears_NAN.TabIndex = 13;
            // 
            // labelArrears_NAN
            // 
            this.labelArrears_NAN.AutoSize = true;
            this.labelArrears_NAN.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArrears_NAN.Location = new System.Drawing.Point(6, 361);
            this.labelArrears_NAN.Name = "labelArrears_NAN";
            this.labelArrears_NAN.Size = new System.Drawing.Size(254, 38);
            this.labelArrears_NAN.TabIndex = 12;
            this.labelArrears_NAN.Text = "Есть ли задолженность по квартплате?\r\n(да/нет)";
            // 
            // textBoxKids_NAN
            // 
            this.textBoxKids_NAN.Location = new System.Drawing.Point(181, 305);
            this.textBoxKids_NAN.Multiline = true;
            this.textBoxKids_NAN.Name = "textBoxKids_NAN";
            this.textBoxKids_NAN.Size = new System.Drawing.Size(73, 32);
            this.textBoxKids_NAN.TabIndex = 11;
            // 
            // labelKids_NAN
            // 
            this.labelKids_NAN.AutoSize = true;
            this.labelKids_NAN.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKids_NAN.Location = new System.Drawing.Point(6, 310);
            this.labelKids_NAN.Name = "labelKids_NAN";
            this.labelKids_NAN.Size = new System.Drawing.Size(148, 19);
            this.labelKids_NAN.TabIndex = 10;
            this.labelKids_NAN.Text = "Кол-во детей в семье:";
            // 
            // textBoxMembers_NAN
            // 
            this.textBoxMembers_NAN.Location = new System.Drawing.Point(178, 246);
            this.textBoxMembers_NAN.Multiline = true;
            this.textBoxMembers_NAN.Name = "textBoxMembers_NAN";
            this.textBoxMembers_NAN.Size = new System.Drawing.Size(73, 32);
            this.textBoxMembers_NAN.TabIndex = 9;
            // 
            // labelMembers_NAN
            // 
            this.labelMembers_NAN.AutoSize = true;
            this.labelMembers_NAN.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMembers_NAN.Location = new System.Drawing.Point(6, 251);
            this.labelMembers_NAN.Name = "labelMembers_NAN";
            this.labelMembers_NAN.Size = new System.Drawing.Size(147, 19);
            this.labelMembers_NAN.TabIndex = 8;
            this.labelMembers_NAN.Text = "Кол-во членов семьи:";
            // 
            // textBoxSurname_NAN
            // 
            this.textBoxSurname_NAN.Location = new System.Drawing.Point(231, 190);
            this.textBoxSurname_NAN.Multiline = true;
            this.textBoxSurname_NAN.Name = "textBoxSurname_NAN";
            this.textBoxSurname_NAN.Size = new System.Drawing.Size(151, 32);
            this.textBoxSurname_NAN.TabIndex = 7;
            // 
            // labelSurname_NAN
            // 
            this.labelSurname_NAN.AutoSize = true;
            this.labelSurname_NAN.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname_NAN.Location = new System.Drawing.Point(6, 195);
            this.labelSurname_NAN.Name = "labelSurname_NAN";
            this.labelSurname_NAN.Size = new System.Drawing.Size(197, 19);
            this.labelSurname_NAN.TabIndex = 6;
            this.labelSurname_NAN.Text = "Фамилия квартиросъёмщика:";
            // 
            // textBoxRooms_NAN
            // 
            this.textBoxRooms_NAN.Location = new System.Drawing.Point(131, 139);
            this.textBoxRooms_NAN.Multiline = true;
            this.textBoxRooms_NAN.Name = "textBoxRooms_NAN";
            this.textBoxRooms_NAN.Size = new System.Drawing.Size(73, 32);
            this.textBoxRooms_NAN.TabIndex = 5;
            // 
            // labelRooms_NAN
            // 
            this.labelRooms_NAN.AutoSize = true;
            this.labelRooms_NAN.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRooms_NAN.Location = new System.Drawing.Point(6, 144);
            this.labelRooms_NAN.Name = "labelRooms_NAN";
            this.labelRooms_NAN.Size = new System.Drawing.Size(106, 19);
            this.labelRooms_NAN.TabIndex = 4;
            this.labelRooms_NAN.Text = "Кол-во комнат:";
            // 
            // textBoxFlat_NAN
            // 
            this.textBoxFlat_NAN.Location = new System.Drawing.Point(144, 87);
            this.textBoxFlat_NAN.Multiline = true;
            this.textBoxFlat_NAN.Name = "textBoxFlat_NAN";
            this.textBoxFlat_NAN.Size = new System.Drawing.Size(73, 32);
            this.textBoxFlat_NAN.TabIndex = 3;
            // 
            // labelFlat_NAN
            // 
            this.labelFlat_NAN.AutoSize = true;
            this.labelFlat_NAN.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFlat_NAN.Location = new System.Drawing.Point(6, 92);
            this.labelFlat_NAN.Name = "labelFlat_NAN";
            this.labelFlat_NAN.Size = new System.Drawing.Size(120, 19);
            this.labelFlat_NAN.TabIndex = 2;
            this.labelFlat_NAN.Text = "Номер квартиры:";
            // 
            // textBoxEntrance_NAN
            // 
            this.textBoxEntrance_NAN.Location = new System.Drawing.Point(145, 36);
            this.textBoxEntrance_NAN.Multiline = true;
            this.textBoxEntrance_NAN.Name = "textBoxEntrance_NAN";
            this.textBoxEntrance_NAN.Size = new System.Drawing.Size(73, 32);
            this.textBoxEntrance_NAN.TabIndex = 1;
            // 
            // labelEntrance_NAN
            // 
            this.labelEntrance_NAN.AutoSize = true;
            this.labelEntrance_NAN.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEntrance_NAN.Location = new System.Drawing.Point(6, 41);
            this.labelEntrance_NAN.Name = "labelEntrance_NAN";
            this.labelEntrance_NAN.Size = new System.Drawing.Size(119, 19);
            this.labelEntrance_NAN.TabIndex = 0;
            this.labelEntrance_NAN.Text = "Номер подъезда:";
            // 
            // panelRight_NAN
            // 
            this.panelRight_NAN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.panelRight_NAN.Controls.Add(this.dataGridViewMatrix_NAN);
            this.panelRight_NAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_NAN.Location = new System.Drawing.Point(437, 78);
            this.panelRight_NAN.Name = "panelRight_NAN";
            this.panelRight_NAN.Padding = new System.Windows.Forms.Padding(5);
            this.panelRight_NAN.Size = new System.Drawing.Size(945, 475);
            this.panelRight_NAN.TabIndex = 2;
            // 
            // dataGridViewMatrix_NAN
            // 
            this.dataGridViewMatrix_NAN.AllowUserToOrderColumns = true;
            this.dataGridViewMatrix_NAN.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewMatrix_NAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_NAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMatrix_NAN.Location = new System.Drawing.Point(5, 5);
            this.dataGridViewMatrix_NAN.Name = "dataGridViewMatrix_NAN";
            this.dataGridViewMatrix_NAN.RowHeadersVisible = false;
            this.dataGridViewMatrix_NAN.RowHeadersWidth = 51;
            this.dataGridViewMatrix_NAN.RowTemplate.Height = 24;
            this.dataGridViewMatrix_NAN.Size = new System.Drawing.Size(935, 465);
            this.dataGridViewMatrix_NAN.TabIndex = 0;
            // 
            // openFileDialog_NAN
            // 
            this.openFileDialog_NAN.FileName = "openFileDialog1";
            // 
            // toolTip_NAN
            // 
            this.toolTip_NAN.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_NAN.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1382, 553);
            this.Controls.Add(this.panelRight_NAN);
            this.Controls.Add(this.panelLeft_NAN);
            this.Controls.Add(this.panelTop_NAN);
            this.MinimumSize = new System.Drawing.Size(1400, 600);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 7 | Project Task | Вариант 7 | Николаева А. Н.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelTop_NAN.ResumeLayout(false);
            this.groupBoxSort_NAN.ResumeLayout(false);
            this.groupBoxSort_NAN.PerformLayout();
            this.panelLeft_NAN.ResumeLayout(false);
            this.groupBoxAddPerson_NAN.ResumeLayout(false);
            this.groupBoxAddPerson_NAN.PerformLayout();
            this.panelRight_NAN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_NAN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_NAN;
        private System.Windows.Forms.Button buttonHelp_NAN;
        private System.Windows.Forms.Button buttonDiag_NAN;
        private System.Windows.Forms.Panel panelLeft_NAN;
        private System.Windows.Forms.GroupBox groupBoxAddPerson_NAN;
        private System.Windows.Forms.Label labelEntrance_NAN;
        private System.Windows.Forms.TextBox textBoxEntrance_NAN;
        private System.Windows.Forms.Label labelFlat_NAN;
        private System.Windows.Forms.TextBox textBoxFlat_NAN;
        private System.Windows.Forms.Label labelRooms_NAN;
        private System.Windows.Forms.TextBox textBoxRooms_NAN;
        private System.Windows.Forms.Label labelSurname_NAN;
        private System.Windows.Forms.TextBox textBoxSurname_NAN;
        private System.Windows.Forms.Label labelMembers_NAN;
        private System.Windows.Forms.TextBox textBoxMembers_NAN;
        private System.Windows.Forms.Label labelKids_NAN;
        private System.Windows.Forms.TextBox textBoxKids_NAN;
        private System.Windows.Forms.Label labelArrears_NAN;
        private System.Windows.Forms.TextBox textBoxArrears_NAN;
        private System.Windows.Forms.Button buttonAddPerson_NAN;
        private System.Windows.Forms.Panel panelRight_NAN;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_NAN;
        private System.Windows.Forms.OpenFileDialog openFileDialog_NAN;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_NAN;
        private System.Windows.Forms.ToolTip toolTip_NAN;
        private System.Windows.Forms.TextBox textBoxSort_NAN;
        private System.Windows.Forms.Label labelSort_NAN;
        private System.Windows.Forms.Button buttonSort_NAN;
        private System.Windows.Forms.GroupBox groupBoxSort_NAN;
        private System.Windows.Forms.Button buttonStat_NAN;
    }
}

