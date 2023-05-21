namespace SAMÜDEK
{
    partial class EmelSoylu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmelSoylu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonexit = new System.Windows.Forms.Button();
            this.comboders = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.combodonem = new System.Windows.Forms.ComboBox();
            this.combotur = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonkaydet = new System.Windows.Forms.Button();
            this.buttonsec = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(273, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Emel Soylu";
            // 
            // buttonexit
            // 
            this.buttonexit.BackColor = System.Drawing.Color.Red;
            this.buttonexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonexit.Location = new System.Drawing.Point(600, 59);
            this.buttonexit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(110, 41);
            this.buttonexit.TabIndex = 2;
            this.buttonexit.Text = "Çıkış Yap";
            this.buttonexit.UseVisualStyleBackColor = false;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // comboders
            // 
            this.comboders.FormattingEnabled = true;
            this.comboders.Items.AddRange(new object[] {
            "Bilgisayar Bilimlerine Giriş",
            "Yazılım Tasarımı ve Mimarisi",
            "Mikroişlemciler ve Programlama"});
            this.comboders.Location = new System.Drawing.Point(303, 140);
            this.comboders.Margin = new System.Windows.Forms.Padding(2);
            this.comboders.Name = "comboders";
            this.comboders.Size = new System.Drawing.Size(171, 21);
            this.comboders.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(221, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ders:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(207, 241);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Döndem:";
            // 
            // combodonem
            // 
            this.combodonem.FormattingEnabled = true;
            this.combodonem.Items.AddRange(new object[] {
            "2020-2021",
            "2021-2022",
            "2022-2023"});
            this.combodonem.Location = new System.Drawing.Point(303, 241);
            this.combodonem.Margin = new System.Windows.Forms.Padding(2);
            this.combodonem.Name = "combodonem";
            this.combodonem.Size = new System.Drawing.Size(171, 21);
            this.combodonem.TabIndex = 6;
            // 
            // combotur
            // 
            this.combotur.FormattingEnabled = true;
            this.combotur.Items.AddRange(new object[] {
            "Vize",
            "Final",
            "Ödev"});
            this.combotur.Location = new System.Drawing.Point(303, 337);
            this.combotur.Margin = new System.Windows.Forms.Padding(2);
            this.combotur.Name = "combotur";
            this.combotur.Size = new System.Drawing.Size(171, 21);
            this.combotur.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(207, 334);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tür:";
            // 
            // buttonkaydet
            // 
            this.buttonkaydet.BackColor = System.Drawing.Color.Lime;
            this.buttonkaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonkaydet.Location = new System.Drawing.Point(613, 429);
            this.buttonkaydet.Margin = new System.Windows.Forms.Padding(2);
            this.buttonkaydet.Name = "buttonkaydet";
            this.buttonkaydet.Size = new System.Drawing.Size(98, 41);
            this.buttonkaydet.TabIndex = 19;
            this.buttonkaydet.Text = "Kaydet";
            this.buttonkaydet.UseVisualStyleBackColor = false;
            // 
            // buttonsec
            // 
            this.buttonsec.BackColor = System.Drawing.Color.Lime;
            this.buttonsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonsec.Location = new System.Drawing.Point(478, 429);
            this.buttonsec.Margin = new System.Windows.Forms.Padding(2);
            this.buttonsec.Name = "buttonsec";
            this.buttonsec.Size = new System.Drawing.Size(98, 41);
            this.buttonsec.TabIndex = 18;
            this.buttonsec.Text = "Seç";
            this.buttonsec.UseVisualStyleBackColor = false;
            this.buttonsec.Click += new System.EventHandler(this.buttonsec_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "En Başarılı",
            "En Başarısız",
            "Ortalama"});
            this.comboBox1.Location = new System.Drawing.Point(303, 429);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(155, 427);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Başarı Durumu:";
            // 
            // EmelSoylu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(748, 499);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonkaydet);
            this.Controls.Add(this.buttonsec);
            this.Controls.Add(this.combotur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combodonem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboders);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmelSoylu";
            this.Text = "EmelSoylu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.ComboBox comboders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combodonem;
        private System.Windows.Forms.ComboBox combotur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonkaydet;
        private System.Windows.Forms.Button buttonsec;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
    }
}