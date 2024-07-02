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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetWeather
            // 
            this.btnGetWeather.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetWeather.Location = new System.Drawing.Point(59, 325);
            this.btnGetWeather.Name = "btnGetWeather";
            this.btnGetWeather.Size = new System.Drawing.Size(201, 82);
            this.btnGetWeather.TabIndex = 0;
            this.btnGetWeather.Text = "GetWeather";
            this.btnGetWeather.UseVisualStyleBackColor = true;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(55, 60);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(100, 20);
            this.lblTemp.TabIndex = 1;
            this.lblTemp.Text = "Temperature";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(55, 128);
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
            this.txtCityName.Location = new System.Drawing.Point(59, 178);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(201, 26);
            this.txtCityName.TabIndex = 4;
            // 
            // From1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCityName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.btnGetWeather);
            this.Name = "From1";
            this.Text = "GetWeather";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetWeather;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCityName;
    }
}

