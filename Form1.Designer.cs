namespace WeattherApp2
{
    partial class From1
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
            this.btnGetWeather = new System.Windows.Forms.Button();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox_CityName = new System.Windows.Forms.TextBox();
            this.label_WeatherDescription = new System.Windows.Forms.Label();
            this.label_TempF = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Sunrise = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetWeather
            // 
            this.btnGetWeather.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetWeather.Location = new System.Drawing.Point(59, 325);
            this.btnGetWeather.Name = "btnGetWeather";
            this.btnGetWeather.Size = new System.Drawing.Size(201, 47);
            this.btnGetWeather.TabIndex = 0;
            this.btnGetWeather.Text = "GetWeather";
            this.btnGetWeather.UseVisualStyleBackColor = true;
            this.btnGetWeather.Click += new System.EventHandler(this.btnGetWeather_Click);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(0, 80);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(60, 20);
            this.lblTemp.TabIndex = 1;
            this.lblTemp.Text = "Celsius";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(68, 186);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(101, 20);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "The Weather";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(366, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(422, 426);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(59, 255);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(201, 26);
            this.txtCityName.TabIndex = 4;
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.Location = new System.Drawing.Point(0, 0);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(100, 23);
            this.lblFahrenheit.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(306, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(447, 427);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // textBox_CityName
            // 
            this.textBox_CityName.Location = new System.Drawing.Point(72, 240);
            this.textBox_CityName.Name = "textBox_CityName";
            this.textBox_CityName.Size = new System.Drawing.Size(100, 26);
            this.textBox_CityName.TabIndex = 3;
            // 
            // label_WeatherDescription
            // 
            this.label_WeatherDescription.AutoSize = true;
            this.label_WeatherDescription.Location = new System.Drawing.Point(0, 11);
            this.label_WeatherDescription.Name = "label_WeatherDescription";
            this.label_WeatherDescription.Size = new System.Drawing.Size(89, 20);
            this.label_WeatherDescription.TabIndex = 4;
            this.label_WeatherDescription.Text = "Description";
            // 
            // label_TempF
            // 
            this.label_TempF.AutoSize = true;
            this.label_TempF.Location = new System.Drawing.Point(0, 46);
            this.label_TempF.Name = "label_TempF";
            this.label_TempF.Size = new System.Drawing.Size(42, 20);
            this.label_TempF.TabIndex = 5;
            this.label_TempF.Text = "Fahr";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_Sunrise);
            this.panel1.Controls.Add(this.label_WeatherDescription);
            this.panel1.Controls.Add(this.label_TempF);
            this.panel1.Controls.Add(this.lblTemp);
            this.panel1.Location = new System.Drawing.Point(27, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 146);
            this.panel1.TabIndex = 6;
            // 
            // label_Sunrise
            // 
            this.label_Sunrise.AutoSize = true;
            this.label_Sunrise.Location = new System.Drawing.Point(3, 110);
            this.label_Sunrise.Name = "label_Sunrise";
            this.label_Sunrise.Size = new System.Drawing.Size(63, 20);
            this.label_Sunrise.TabIndex = 6;
            this.label_Sunrise.Text = "Sunrise";
            // 
            // From1
            // 
            this.ClientSize = new System.Drawing.Size(765, 510);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_CityName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnGetWeather);
            this.Name = "From1";
            this.Text = "GetWeather";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetWeather;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox_CityName;
        private System.Windows.Forms.Label label_WeatherDescription;
        private System.Windows.Forms.Label label_TempF;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Sunrise;
    }
}

