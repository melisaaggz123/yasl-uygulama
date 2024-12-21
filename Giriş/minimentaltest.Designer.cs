namespace OYUN.Giriş
{
    partial class minimentaltest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(minimentaltest));
            this.yıillbl = new System.Windows.Forms.Label();
            this.cmbyil = new System.Windows.Forms.ComboBox();
            this.cmbayinkaci = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbay = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbmevsim = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnbitir = new System.Windows.Forms.Button();
            this.lblmasa = new System.Windows.Forms.Label();
            this.lblkalem = new System.Windows.Forms.Label();
            this.lblbayrak = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnbasla = new System.Windows.Forms.Button();
            this.tmrhatirla = new System.Windows.Forms.Timer(this.components);
            this.listsecenek = new System.Windows.Forms.CheckedListBox();
            this.tmrsec = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // yıillbl
            // 
            this.yıillbl.AutoSize = true;
            this.yıillbl.BackColor = System.Drawing.Color.White;
            this.yıillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yıillbl.Location = new System.Drawing.Point(35, 13);
            this.yıillbl.Name = "yıillbl";
            this.yıillbl.Size = new System.Drawing.Size(212, 31);
            this.yıillbl.TabIndex = 0;
            this.yıillbl.Text = "Hangi yıldayız?";
            // 
            // cmbyil
            // 
            this.cmbyil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.cmbyil.FormattingEnabled = true;
            this.cmbyil.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cmbyil.Location = new System.Drawing.Point(19, 80);
            this.cmbyil.Name = "cmbyil";
            this.cmbyil.Size = new System.Drawing.Size(250, 39);
            this.cmbyil.TabIndex = 1;
            // 
            // cmbayinkaci
            // 
            this.cmbayinkaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.cmbayinkaci.FormattingEnabled = true;
            this.cmbayinkaci.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbayinkaci.Location = new System.Drawing.Point(21, 80);
            this.cmbayinkaci.Name = "cmbayinkaci";
            this.cmbayinkaci.Size = new System.Drawing.Size(250, 39);
            this.cmbayinkaci.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(28, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bugün ayın kaçı?";
            // 
            // cmbay
            // 
            this.cmbay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.cmbay.FormattingEnabled = true;
            this.cmbay.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.cmbay.Location = new System.Drawing.Point(20, 80);
            this.cmbay.Name = "cmbay";
            this.cmbay.Size = new System.Drawing.Size(250, 39);
            this.cmbay.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(33, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hangi aydayız?";
            // 
            // cmbmevsim
            // 
            this.cmbmevsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.cmbmevsim.FormattingEnabled = true;
            this.cmbmevsim.Items.AddRange(new object[] {
            "İlkbahar",
            "Yaz",
            "Sonbahar",
            "Kış"});
            this.cmbmevsim.Location = new System.Drawing.Point(22, 80);
            this.cmbmevsim.Name = "cmbmevsim";
            this.cmbmevsim.Size = new System.Drawing.Size(250, 39);
            this.cmbmevsim.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hangi mevsimdeyiz?";
            // 
            // btnbitir
            // 
            this.btnbitir.BackColor = System.Drawing.Color.Black;
            this.btnbitir.Font = new System.Drawing.Font("Franklin Gothic Book", 36F, System.Drawing.FontStyle.Bold);
            this.btnbitir.ForeColor = System.Drawing.Color.White;
            this.btnbitir.Location = new System.Drawing.Point(1269, 808);
            this.btnbitir.Name = "btnbitir";
            this.btnbitir.Size = new System.Drawing.Size(298, 75);
            this.btnbitir.TabIndex = 8;
            this.btnbitir.Text = "BİTİR";
            this.btnbitir.UseVisualStyleBackColor = false;
            this.btnbitir.Click += new System.EventHandler(this.btnbitir_Click);
            // 
            // lblmasa
            // 
            this.lblmasa.AutoSize = true;
            this.lblmasa.BackColor = System.Drawing.Color.White;
            this.lblmasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblmasa.ForeColor = System.Drawing.Color.Black;
            this.lblmasa.Location = new System.Drawing.Point(43, 90);
            this.lblmasa.Name = "lblmasa";
            this.lblmasa.Size = new System.Drawing.Size(84, 31);
            this.lblmasa.TabIndex = 9;
            this.lblmasa.Text = "Masa";
            this.lblmasa.Visible = false;
            // 
            // lblkalem
            // 
            this.lblkalem.AutoSize = true;
            this.lblkalem.BackColor = System.Drawing.Color.White;
            this.lblkalem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblkalem.ForeColor = System.Drawing.Color.Black;
            this.lblkalem.Location = new System.Drawing.Point(424, 90);
            this.lblkalem.Name = "lblkalem";
            this.lblkalem.Size = new System.Drawing.Size(95, 31);
            this.lblkalem.TabIndex = 12;
            this.lblkalem.Text = "Kalem";
            this.lblkalem.Visible = false;
            // 
            // lblbayrak
            // 
            this.lblbayrak.AutoSize = true;
            this.lblbayrak.BackColor = System.Drawing.Color.White;
            this.lblbayrak.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblbayrak.ForeColor = System.Drawing.Color.Black;
            this.lblbayrak.Location = new System.Drawing.Point(210, 90);
            this.lblbayrak.Name = "lblbayrak";
            this.lblbayrak.Size = new System.Drawing.Size(105, 31);
            this.lblbayrak.TabIndex = 13;
            this.lblbayrak.Text = "Bayrak";
            this.lblbayrak.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Book", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1295, 43);
            this.label4.TabIndex = 14;
            this.label4.Text = "Başla butonuna tıkladıktan sonra görünen kelimleri aklınızda tutmaya çalışın.";
            // 
            // btnbasla
            // 
            this.btnbasla.Font = new System.Drawing.Font("Franklin Gothic Book", 27.75F, System.Drawing.FontStyle.Bold);
            this.btnbasla.Location = new System.Drawing.Point(1068, 68);
            this.btnbasla.Name = "btnbasla";
            this.btnbasla.Size = new System.Drawing.Size(230, 53);
            this.btnbasla.TabIndex = 15;
            this.btnbasla.Text = "Başla";
            this.btnbasla.UseVisualStyleBackColor = true;
            this.btnbasla.Click += new System.EventHandler(this.btnbasla_Click);
            // 
            // tmrhatirla
            // 
            this.tmrhatirla.Interval = 3000;
            this.tmrhatirla.Tick += new System.EventHandler(this.tmrhatirla_Tick);
            // 
            // listsecenek
            // 
            this.listsecenek.BackColor = System.Drawing.Color.White;
            this.listsecenek.Font = new System.Drawing.Font("Franklin Gothic Book", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listsecenek.FormattingEnabled = true;
            this.listsecenek.Items.AddRange(new object[] {
            "Okul",
            "Kağıt",
            "Kalem",
            "Sandalye",
            "Masa",
            "Kahve",
            "Araba",
            "Bayrak",
            "Tablo"});
            this.listsecenek.Location = new System.Drawing.Point(41, 171);
            this.listsecenek.Name = "listsecenek";
            this.listsecenek.Size = new System.Drawing.Size(476, 202);
            this.listsecenek.TabIndex = 16;
            this.listsecenek.Visible = false;
            // 
            // tmrsec
            // 
            this.tmrsec.Interval = 20000;
            this.tmrsec.Tick += new System.EventHandler(this.tmrsec_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.yıillbl);
            this.panel1.Controls.Add(this.cmbyil);
            this.panel1.Font = new System.Drawing.Font("Franklin Gothic Book", 36F, System.Drawing.FontStyle.Bold);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(84, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 216);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbayinkaci);
            this.panel2.Font = new System.Drawing.Font("Franklin Gothic Book", 36F, System.Drawing.FontStyle.Bold);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(1162, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 216);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cmbay);
            this.panel3.Font = new System.Drawing.Font("Franklin Gothic Book", 36F, System.Drawing.FontStyle.Bold);
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(813, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 216);
            this.panel3.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.cmbmevsim);
            this.panel4.Font = new System.Drawing.Font("Franklin Gothic Book", 36F, System.Drawing.FontStyle.Bold);
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(438, 76);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(297, 216);
            this.panel4.TabIndex = 18;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.btnbasla);
            this.panel5.Controls.Add(this.lblmasa);
            this.panel5.Controls.Add(this.lblkalem);
            this.panel5.Controls.Add(this.lblbayrak);
            this.panel5.Controls.Add(this.listsecenek);
            this.panel5.Font = new System.Drawing.Font("Franklin Gothic Book", 36F, System.Drawing.FontStyle.Bold);
            this.panel5.Location = new System.Drawing.Point(84, 358);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1365, 422);
            this.panel5.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1524, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // minimentaltest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1595, 934);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnbitir);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "minimentaltest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label yıillbl;
        private System.Windows.Forms.ComboBox cmbyil;
        private System.Windows.Forms.ComboBox cmbayinkaci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbmevsim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnbitir;
        private System.Windows.Forms.Label lblmasa;
        private System.Windows.Forms.Label lblkalem;
        private System.Windows.Forms.Label lblbayrak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnbasla;
        private System.Windows.Forms.Timer tmrhatirla;
        private System.Windows.Forms.CheckedListBox listsecenek;
        private System.Windows.Forms.Timer tmrsec;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}