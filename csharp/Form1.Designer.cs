namespace csharp
{
    partial class ohmaj_indicator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ohmaj_indicator));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.baglan = new System.Windows.Forms.Button();
            this.baglantiyikes = new System.Windows.Forms.Button();
            this.liste = new System.Windows.Forms.ComboBox();
            this.comport = new System.Windows.Forms.Label();
            this.okunandeger = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // baglan
            // 
            this.baglan.Location = new System.Drawing.Point(155, 185);
            this.baglan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.baglan.Name = "baglan";
            this.baglan.Size = new System.Drawing.Size(88, 23);
            this.baglan.TabIndex = 0;
            this.baglan.Text = "baglan";
            this.baglan.UseVisualStyleBackColor = true;
            this.baglan.Click += new System.EventHandler(this.baglan_Click);
            // 
            // baglantiyikes
            // 
            this.baglantiyikes.Location = new System.Drawing.Point(549, 187);
            this.baglantiyikes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.baglantiyikes.Name = "baglantiyikes";
            this.baglantiyikes.Size = new System.Drawing.Size(108, 23);
            this.baglantiyikes.TabIndex = 1;
            this.baglantiyikes.Text = "bağlantıyı kes";
            this.baglantiyikes.UseVisualStyleBackColor = true;
            this.baglantiyikes.Click += new System.EventHandler(this.baglantiyikes_Click);
            // 
            // liste
            // 
            this.liste.FormattingEnabled = true;
            this.liste.Items.AddRange(new object[] {
            "com3",
            "com4",
            "com5",
            "com6",
            "com7"});
            this.liste.Location = new System.Drawing.Point(329, 187);
            this.liste.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(140, 21);
            this.liste.TabIndex = 2;
            // 
            // comport
            // 
            this.comport.AutoSize = true;
            this.comport.Location = new System.Drawing.Point(372, 157);
            this.comport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.comport.Name = "comport";
            this.comport.Size = new System.Drawing.Size(52, 13);
            this.comport.TabIndex = 3;
            this.comport.Text = "comport";
            // 
            // okunandeger
            // 
            this.okunandeger.AutoSize = true;
            this.okunandeger.Location = new System.Drawing.Point(23, 224);
            this.okunandeger.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.okunandeger.Name = "okunandeger";
            this.okunandeger.Size = new System.Drawing.Size(97, 13);
            this.okunandeger.TabIndex = 4;
            this.okunandeger.Text = "okunan değer : ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 240);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(715, 58);
            this.progressBar1.TabIndex = 5;
            // 
            // ohmaj_indicator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(743, 310);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.okunandeger);
            this.Controls.Add(this.comport);
            this.Controls.Add(this.liste);
            this.Controls.Add(this.baglantiyikes);
            this.Controls.Add(this.baglan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ohmaj_indicator";
            this.Text = "ohmaj indicator";
            this.Load += new System.EventHandler(this.ohmaj_indicator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button baglan;
        private System.Windows.Forms.Button baglantiyikes;
        private System.Windows.Forms.ComboBox liste;
        private System.Windows.Forms.Label comport;
        private System.Windows.Forms.Label okunandeger;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

