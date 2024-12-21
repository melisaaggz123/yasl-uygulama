namespace OYUN
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnStart = new System.Windows.Forms.Button();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.cmbMissing = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Black;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.Font = new System.Drawing.Font("Franklin Gothic Book", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(537, 622);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(627, 128);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Başla";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // numSize
            // 
            this.numSize.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.numSize.Location = new System.Drawing.Point(777, 439);
            this.numSize.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(387, 47);
            this.numSize.TabIndex = 3;
            this.numSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // cmbMissing
            // 
            this.cmbMissing.AllowDrop = true;
            this.cmbMissing.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbMissing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMissing.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMissing.FormattingEnabled = true;
            this.cmbMissing.Items.AddRange(new object[] {
            "Oppe til venstre",
            "Oppe til høyre",
            "Nede til venstre",
            "Nede til høyre",
            "Senter"});
            this.cmbMissing.Location = new System.Drawing.Point(12, 889);
            this.cmbMissing.Name = "cmbMissing";
            this.cmbMissing.Size = new System.Drawing.Size(346, 33);
            this.cmbMissing.TabIndex = 4;
            this.cmbMissing.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(530, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "Parça Sayısı:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pic1
            // 
            this.pic1.Image = global::OYUN.Properties.Resources.tree_square1;
            this.pic1.InitialImage = global::OYUN.Properties.Resources.tree_square1;
            this.pic1.Location = new System.Drawing.Point(675, 85);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(322, 285);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 9;
            this.pic1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1532, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 47);
            this.button2.TabIndex = 30;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1595, 934);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMissing);
            this.Controls.Add(this.numSize);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yapboz Menü";
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.ComboBox cmbMissing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Button button2;
    }
}