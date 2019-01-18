namespace WeatherApp
{
	partial class Form1
	{
		/// <summary>
		/// Wymagana zmienna projektanta.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Wyczyść wszystkie używane zasoby.
		/// </summary>
		/// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Kod generowany przez Projektanta formularzy systemu Windows

		/// <summary>
		/// Metoda wymagana do obsługi projektanta — nie należy modyfikować
		/// jej zawartości w edytorze kodu.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.actualWeatherCity = new System.Windows.Forms.Label();
			this.country = new System.Windows.Forms.Label();
			this.timeLabel = new System.Windows.Forms.Label();
			this.dateLabel = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.actualWeatherTemp = new System.Windows.Forms.Label();
			this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.actualWeatherHum = new System.Windows.Forms.Label();
			this.forecast1CityLabel = new System.Windows.Forms.Label();
			this.forecast1DateLabel = new System.Windows.Forms.Label();
			this.forecast1TempLabel = new System.Windows.Forms.Label();
			this.forecast2TempLabel = new System.Windows.Forms.Label();
			this.forecast2DateLabel = new System.Windows.Forms.Label();
			this.forecast2CityLabel = new System.Windows.Forms.Label();
			this.forecast3TempLabel = new System.Windows.Forms.Label();
			this.forecast3DateLabel = new System.Windows.Forms.Label();
			this.forecast3CityLabel = new System.Windows.Forms.Label();
			this.forecast4TempLabel = new System.Windows.Forms.Label();
			this.forecast4DateLabel = new System.Windows.Forms.Label();
			this.forecast4CityLabel = new System.Windows.Forms.Label();
			this.forecast1PictureBox = new System.Windows.Forms.PictureBox();
			this.forecast4PictureBox = new System.Windows.Forms.PictureBox();
			this.forecast3PictureBox = new System.Windows.Forms.PictureBox();
			this.forecast2PictureBox = new System.Windows.Forms.PictureBox();
			this.actualWeatherPictureBox = new System.Windows.Forms.PictureBox();
			this.refreshDateTime = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.forecast1PictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.forecast4PictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.forecast3PictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.forecast2PictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.actualWeatherPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// actualWeatherCity
			// 
			this.actualWeatherCity.AutoSize = true;
			this.actualWeatherCity.BackColor = System.Drawing.Color.Transparent;
			this.actualWeatherCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.actualWeatherCity.ForeColor = System.Drawing.Color.MidnightBlue;
			this.actualWeatherCity.Location = new System.Drawing.Point(254, 350);
			this.actualWeatherCity.Name = "actualWeatherCity";
			this.actualWeatherCity.Size = new System.Drawing.Size(186, 54);
			this.actualWeatherCity.TabIndex = 0;
			this.actualWeatherCity.Text = "Kraków";
			// 
			// country
			// 
			this.country.AutoSize = true;
			this.country.BackColor = System.Drawing.Color.Transparent;
			this.country.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.country.ForeColor = System.Drawing.Color.MidnightBlue;
			this.country.Location = new System.Drawing.Point(300, 404);
			this.country.Name = "country";
			this.country.Size = new System.Drawing.Size(102, 31);
			this.country.TabIndex = 1;
			this.country.Text = "Polska";
			// 
			// timeLabel
			// 
			this.timeLabel.AutoSize = true;
			this.timeLabel.BackColor = System.Drawing.Color.Transparent;
			this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timeLabel.ForeColor = System.Drawing.Color.MidnightBlue;
			this.timeLabel.Location = new System.Drawing.Point(1091, 43);
			this.timeLabel.Name = "timeLabel";
			this.timeLabel.Size = new System.Drawing.Size(145, 54);
			this.timeLabel.TabIndex = 8;
			this.timeLabel.Text = "16:22";
			// 
			// dateLabel
			// 
			this.dateLabel.AutoSize = true;
			this.dateLabel.BackColor = System.Drawing.Color.Transparent;
			this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateLabel.ForeColor = System.Drawing.Color.MidnightBlue;
			this.dateLabel.Location = new System.Drawing.Point(1083, 11);
			this.dateLabel.Name = "dateLabel";
			this.dateLabel.Size = new System.Drawing.Size(160, 31);
			this.dateLabel.TabIndex = 9;
			this.dateLabel.Text = "06.01.2019";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button1.Location = new System.Drawing.Point(12, 9);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(107, 44);
			this.button1.TabIndex = 10;
			this.button1.Text = "Odśwież";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.refreshButton_Click);
			// 
			// actualWeatherTemp
			// 
			this.actualWeatherTemp.AutoSize = true;
			this.actualWeatherTemp.BackColor = System.Drawing.Color.Transparent;
			this.actualWeatherTemp.Font = new System.Drawing.Font("Calibri", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.actualWeatherTemp.ForeColor = System.Drawing.Color.MidnightBlue;
			this.actualWeatherTemp.Location = new System.Drawing.Point(670, 128);
			this.actualWeatherTemp.Name = "actualWeatherTemp";
			this.actualWeatherTemp.Size = new System.Drawing.Size(190, 131);
			this.actualWeatherTemp.TabIndex = 11;
			this.actualWeatherTemp.Text = "2 C";
			// 
			// directorySearcher1
			// 
			this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
			this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
			this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
			// 
			// actualWeatherHum
			// 
			this.actualWeatherHum.AutoSize = true;
			this.actualWeatherHum.BackColor = System.Drawing.Color.Transparent;
			this.actualWeatherHum.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.actualWeatherHum.ForeColor = System.Drawing.Color.MidnightBlue;
			this.actualWeatherHum.Location = new System.Drawing.Point(686, 268);
			this.actualWeatherHum.Name = "actualWeatherHum";
			this.actualWeatherHum.Size = new System.Drawing.Size(202, 33);
			this.actualWeatherHum.TabIndex = 12;
			this.actualWeatherHum.Text = "Wilgotność: 80%";
			// 
			// forecast1CityLabel
			// 
			this.forecast1CityLabel.AutoSize = true;
			this.forecast1CityLabel.BackColor = System.Drawing.Color.Transparent;
			this.forecast1CityLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.forecast1CityLabel.ForeColor = System.Drawing.Color.DodgerBlue;
			this.forecast1CityLabel.Location = new System.Drawing.Point(185, 644);
			this.forecast1CityLabel.Name = "forecast1CityLabel";
			this.forecast1CityLabel.Size = new System.Drawing.Size(88, 29);
			this.forecast1CityLabel.TabIndex = 13;
			this.forecast1CityLabel.Text = "Kraków";
			// 
			// forecast1DateLabel
			// 
			this.forecast1DateLabel.AutoSize = true;
			this.forecast1DateLabel.BackColor = System.Drawing.Color.Transparent;
			this.forecast1DateLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.forecast1DateLabel.ForeColor = System.Drawing.Color.DodgerBlue;
			this.forecast1DateLabel.Location = new System.Drawing.Point(168, 615);
			this.forecast1DateLabel.Name = "forecast1DateLabel";
			this.forecast1DateLabel.Size = new System.Drawing.Size(121, 29);
			this.forecast1DateLabel.TabIndex = 14;
			this.forecast1DateLabel.Text = "07.01.2019";
			// 
			// forecast1TempLabel
			// 
			this.forecast1TempLabel.AutoSize = true;
			this.forecast1TempLabel.BackColor = System.Drawing.Color.Transparent;
			this.forecast1TempLabel.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.forecast1TempLabel.ForeColor = System.Drawing.Color.DodgerBlue;
			this.forecast1TempLabel.Location = new System.Drawing.Point(192, 673);
			this.forecast1TempLabel.Name = "forecast1TempLabel";
			this.forecast1TempLabel.Size = new System.Drawing.Size(72, 49);
			this.forecast1TempLabel.TabIndex = 15;
			this.forecast1TempLabel.Text = "5 C";
			// 
			// forecast2TempLabel
			// 
			this.forecast2TempLabel.AutoSize = true;
			this.forecast2TempLabel.BackColor = System.Drawing.Color.Transparent;
			this.forecast2TempLabel.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.forecast2TempLabel.ForeColor = System.Drawing.Color.DodgerBlue;
			this.forecast2TempLabel.Location = new System.Drawing.Point(467, 675);
			this.forecast2TempLabel.Name = "forecast2TempLabel";
			this.forecast2TempLabel.Size = new System.Drawing.Size(72, 49);
			this.forecast2TempLabel.TabIndex = 18;
			this.forecast2TempLabel.Text = "5 C";
			// 
			// forecast2DateLabel
			// 
			this.forecast2DateLabel.AutoSize = true;
			this.forecast2DateLabel.BackColor = System.Drawing.Color.Transparent;
			this.forecast2DateLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.forecast2DateLabel.ForeColor = System.Drawing.Color.DodgerBlue;
			this.forecast2DateLabel.Location = new System.Drawing.Point(443, 617);
			this.forecast2DateLabel.Name = "forecast2DateLabel";
			this.forecast2DateLabel.Size = new System.Drawing.Size(121, 29);
			this.forecast2DateLabel.TabIndex = 17;
			this.forecast2DateLabel.Text = "07.01.2019";
			// 
			// forecast2CityLabel
			// 
			this.forecast2CityLabel.AutoSize = true;
			this.forecast2CityLabel.BackColor = System.Drawing.Color.Transparent;
			this.forecast2CityLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.forecast2CityLabel.ForeColor = System.Drawing.Color.DodgerBlue;
			this.forecast2CityLabel.Location = new System.Drawing.Point(460, 646);
			this.forecast2CityLabel.Name = "forecast2CityLabel";
			this.forecast2CityLabel.Size = new System.Drawing.Size(88, 29);
			this.forecast2CityLabel.TabIndex = 16;
			this.forecast2CityLabel.Text = "Kraków";
			// 
			// forecast3TempLabel
			// 
			this.forecast3TempLabel.AutoSize = true;
			this.forecast3TempLabel.BackColor = System.Drawing.Color.Transparent;
			this.forecast3TempLabel.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.forecast3TempLabel.ForeColor = System.Drawing.Color.DodgerBlue;
			this.forecast3TempLabel.Location = new System.Drawing.Point(737, 675);
			this.forecast3TempLabel.Name = "forecast3TempLabel";
			this.forecast3TempLabel.Size = new System.Drawing.Size(72, 49);
			this.forecast3TempLabel.TabIndex = 21;
			this.forecast3TempLabel.Text = "5 C";
			// 
			// forecast3DateLabel
			// 
			this.forecast3DateLabel.AutoSize = true;
			this.forecast3DateLabel.BackColor = System.Drawing.Color.Transparent;
			this.forecast3DateLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.forecast3DateLabel.ForeColor = System.Drawing.Color.DodgerBlue;
			this.forecast3DateLabel.Location = new System.Drawing.Point(713, 617);
			this.forecast3DateLabel.Name = "forecast3DateLabel";
			this.forecast3DateLabel.Size = new System.Drawing.Size(121, 29);
			this.forecast3DateLabel.TabIndex = 20;
			this.forecast3DateLabel.Text = "07.01.2019";
			// 
			// forecast3CityLabel
			// 
			this.forecast3CityLabel.AutoSize = true;
			this.forecast3CityLabel.BackColor = System.Drawing.Color.Transparent;
			this.forecast3CityLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.forecast3CityLabel.ForeColor = System.Drawing.Color.DodgerBlue;
			this.forecast3CityLabel.Location = new System.Drawing.Point(730, 646);
			this.forecast3CityLabel.Name = "forecast3CityLabel";
			this.forecast3CityLabel.Size = new System.Drawing.Size(88, 29);
			this.forecast3CityLabel.TabIndex = 19;
			this.forecast3CityLabel.Text = "Kraków";
			// 
			// forecast4TempLabel
			// 
			this.forecast4TempLabel.AutoSize = true;
			this.forecast4TempLabel.BackColor = System.Drawing.Color.Transparent;
			this.forecast4TempLabel.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.forecast4TempLabel.ForeColor = System.Drawing.Color.DodgerBlue;
			this.forecast4TempLabel.Location = new System.Drawing.Point(1002, 675);
			this.forecast4TempLabel.Name = "forecast4TempLabel";
			this.forecast4TempLabel.Size = new System.Drawing.Size(72, 49);
			this.forecast4TempLabel.TabIndex = 24;
			this.forecast4TempLabel.Text = "5 C";
			// 
			// forecast4DateLabel
			// 
			this.forecast4DateLabel.AutoSize = true;
			this.forecast4DateLabel.BackColor = System.Drawing.Color.Transparent;
			this.forecast4DateLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.forecast4DateLabel.ForeColor = System.Drawing.Color.DodgerBlue;
			this.forecast4DateLabel.Location = new System.Drawing.Point(978, 617);
			this.forecast4DateLabel.Name = "forecast4DateLabel";
			this.forecast4DateLabel.Size = new System.Drawing.Size(121, 29);
			this.forecast4DateLabel.TabIndex = 23;
			this.forecast4DateLabel.Text = "07.01.2019";
			// 
			// forecast4CityLabel
			// 
			this.forecast4CityLabel.AutoSize = true;
			this.forecast4CityLabel.BackColor = System.Drawing.Color.Transparent;
			this.forecast4CityLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.forecast4CityLabel.ForeColor = System.Drawing.Color.DodgerBlue;
			this.forecast4CityLabel.Location = new System.Drawing.Point(995, 646);
			this.forecast4CityLabel.Name = "forecast4CityLabel";
			this.forecast4CityLabel.Size = new System.Drawing.Size(88, 29);
			this.forecast4CityLabel.TabIndex = 22;
			this.forecast4CityLabel.Text = "Kraków";
			// 
			// forecast1PictureBox
			// 
			this.forecast1PictureBox.BackColor = System.Drawing.Color.Transparent;
			this.forecast1PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.forecast1PictureBox.Image = global::WeatherApp.Properties.Resources.sunny;
			this.forecast1PictureBox.Location = new System.Drawing.Point(163, 479);
			this.forecast1PictureBox.Name = "forecast1PictureBox";
			this.forecast1PictureBox.Size = new System.Drawing.Size(131, 131);
			this.forecast1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.forecast1PictureBox.TabIndex = 7;
			this.forecast1PictureBox.TabStop = false;
			// 
			// forecast4PictureBox
			// 
			this.forecast4PictureBox.BackColor = System.Drawing.Color.Transparent;
			this.forecast4PictureBox.Image = global::WeatherApp.Properties.Resources.wave;
			this.forecast4PictureBox.Location = new System.Drawing.Point(971, 479);
			this.forecast4PictureBox.Name = "forecast4PictureBox";
			this.forecast4PictureBox.Size = new System.Drawing.Size(131, 133);
			this.forecast4PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.forecast4PictureBox.TabIndex = 6;
			this.forecast4PictureBox.TabStop = false;
			// 
			// forecast3PictureBox
			// 
			this.forecast3PictureBox.BackColor = System.Drawing.Color.Transparent;
			this.forecast3PictureBox.Image = global::WeatherApp.Properties.Resources.fewclouds;
			this.forecast3PictureBox.Location = new System.Drawing.Point(706, 479);
			this.forecast3PictureBox.Name = "forecast3PictureBox";
			this.forecast3PictureBox.Size = new System.Drawing.Size(131, 133);
			this.forecast3PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.forecast3PictureBox.TabIndex = 5;
			this.forecast3PictureBox.TabStop = false;
			// 
			// forecast2PictureBox
			// 
			this.forecast2PictureBox.BackColor = System.Drawing.Color.Transparent;
			this.forecast2PictureBox.Image = global::WeatherApp.Properties.Resources.snow;
			this.forecast2PictureBox.Location = new System.Drawing.Point(437, 479);
			this.forecast2PictureBox.Name = "forecast2PictureBox";
			this.forecast2PictureBox.Size = new System.Drawing.Size(131, 133);
			this.forecast2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.forecast2PictureBox.TabIndex = 4;
			this.forecast2PictureBox.TabStop = false;
			// 
			// actualWeatherPictureBox
			// 
			this.actualWeatherPictureBox.BackColor = System.Drawing.Color.Transparent;
			this.actualWeatherPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("actualWeatherPictureBox.Image")));
			this.actualWeatherPictureBox.Location = new System.Drawing.Point(221, 90);
			this.actualWeatherPictureBox.Name = "actualWeatherPictureBox";
			this.actualWeatherPictureBox.Size = new System.Drawing.Size(260, 257);
			this.actualWeatherPictureBox.TabIndex = 2;
			this.actualWeatherPictureBox.TabStop = false;
			// 
			// timer1
			// 
			this.refreshDateTime.Enabled = true;
			this.refreshDateTime.Interval = 1000;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::WeatherApp.Properties.Resources.background;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1255, 733);
			this.Controls.Add(this.forecast4TempLabel);
			this.Controls.Add(this.forecast4DateLabel);
			this.Controls.Add(this.forecast4CityLabel);
			this.Controls.Add(this.forecast3TempLabel);
			this.Controls.Add(this.forecast3DateLabel);
			this.Controls.Add(this.forecast3CityLabel);
			this.Controls.Add(this.forecast2TempLabel);
			this.Controls.Add(this.forecast2DateLabel);
			this.Controls.Add(this.forecast2CityLabel);
			this.Controls.Add(this.forecast1TempLabel);
			this.Controls.Add(this.forecast1DateLabel);
			this.Controls.Add(this.forecast1CityLabel);
			this.Controls.Add(this.actualWeatherHum);
			this.Controls.Add(this.actualWeatherTemp);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dateLabel);
			this.Controls.Add(this.timeLabel);
			this.Controls.Add(this.forecast1PictureBox);
			this.Controls.Add(this.forecast4PictureBox);
			this.Controls.Add(this.forecast3PictureBox);
			this.Controls.Add(this.forecast2PictureBox);
			this.Controls.Add(this.actualWeatherPictureBox);
			this.Controls.Add(this.country);
			this.Controls.Add(this.actualWeatherCity);
			this.DoubleBuffered = true;
			this.Name = "Form1";
			this.Text = "WeatherApp";
			((System.ComponentModel.ISupportInitialize)(this.forecast1PictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.forecast4PictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.forecast3PictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.forecast2PictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.actualWeatherPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label actualWeatherCity;
		private System.Windows.Forms.Label country;
		private System.Windows.Forms.PictureBox actualWeatherPictureBox;
		private System.Windows.Forms.PictureBox forecast2PictureBox;
		private System.Windows.Forms.PictureBox forecast3PictureBox;
		private System.Windows.Forms.PictureBox forecast4PictureBox;
		private System.Windows.Forms.PictureBox forecast1PictureBox;
		private System.Windows.Forms.Label timeLabel;
		private System.Windows.Forms.Label dateLabel;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label actualWeatherTemp;
		private System.DirectoryServices.DirectorySearcher directorySearcher1;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Label actualWeatherHum;
		private System.Windows.Forms.Label forecast1CityLabel;
		private System.Windows.Forms.Label forecast1DateLabel;
		private System.Windows.Forms.Label forecast1TempLabel;
		private System.Windows.Forms.Label forecast2TempLabel;
		private System.Windows.Forms.Label forecast2DateLabel;
		private System.Windows.Forms.Label forecast2CityLabel;
		private System.Windows.Forms.Label forecast3TempLabel;
		private System.Windows.Forms.Label forecast3DateLabel;
		private System.Windows.Forms.Label forecast3CityLabel;
		private System.Windows.Forms.Label forecast4TempLabel;
		private System.Windows.Forms.Label forecast4DateLabel;
		private System.Windows.Forms.Label forecast4CityLabel;
		private System.Windows.Forms.Timer refreshDateTime;
	}
}

