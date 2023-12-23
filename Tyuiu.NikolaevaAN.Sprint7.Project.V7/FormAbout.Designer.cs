
namespace Tyuiu.NikolaevaAN.Sprint7.Project.V7
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBox_NAN = new System.Windows.Forms.PictureBox();
            this.buttonOk_NAN = new System.Windows.Forms.Button();
            this.labelInfo_NAN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_NAN)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_NAN
            // 
            this.pictureBox_NAN.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_NAN.Image")));
            this.pictureBox_NAN.Location = new System.Drawing.Point(13, 13);
            this.pictureBox_NAN.Name = "pictureBox_NAN";
            this.pictureBox_NAN.Size = new System.Drawing.Size(209, 211);
            this.pictureBox_NAN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_NAN.TabIndex = 0;
            this.pictureBox_NAN.TabStop = false;
            // 
            // buttonOk_NAN
            // 
            this.buttonOk_NAN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk_NAN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk_NAN.Location = new System.Drawing.Point(495, 205);
            this.buttonOk_NAN.Name = "buttonOk_NAN";
            this.buttonOk_NAN.Size = new System.Drawing.Size(124, 34);
            this.buttonOk_NAN.TabIndex = 1;
            this.buttonOk_NAN.Text = "ОК";
            this.buttonOk_NAN.UseVisualStyleBackColor = true;
            this.buttonOk_NAN.Click += new System.EventHandler(this.buttonOk_NAN_Click);
            // 
            // labelInfo_NAN
            // 
            this.labelInfo_NAN.AutoSize = true;
            this.labelInfo_NAN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo_NAN.Location = new System.Drawing.Point(241, 13);
            this.labelInfo_NAN.Name = "labelInfo_NAN";
            this.labelInfo_NAN.Size = new System.Drawing.Size(387, 180);
            this.labelInfo_NAN.TabIndex = 2;
            this.labelInfo_NAN.Text = resources.GetString("labelInfo_NAN.Text");
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 251);
            this.Controls.Add(this.labelInfo_NAN);
            this.Controls.Add(this.buttonOk_NAN);
            this.Controls.Add(this.pictureBox_NAN);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_NAN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_NAN;
        private System.Windows.Forms.Button buttonOk_NAN;
        private System.Windows.Forms.Label labelInfo_NAN;
    }
}