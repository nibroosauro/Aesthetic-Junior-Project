namespace RestAPI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbAsal = new TextBox();
            tbTujuan = new TextBox();
            tbBerat = new TextBox();
            btnCekHarga = new Button();
            rbPos = new RadioButton();
            rbJne = new RadioButton();
            rbTiki = new RadioButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 56);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(156, 19);
            label1.TabIndex = 0;
            label1.Text = "Kota / Kabupaten Asal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 161);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(175, 19);
            label2.TabIndex = 1;
            label2.Text = "Kota / Kabupaten Tujuan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 272);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 19);
            label3.TabIndex = 2;
            label3.Text = "Berat (gram)";
            // 
            // tbAsal
            // 
            tbAsal.Location = new Point(53, 79);
            tbAsal.Margin = new Padding(4, 4, 4, 4);
            tbAsal.Name = "tbAsal";
            tbAsal.Size = new Size(332, 24);
            tbAsal.TabIndex = 3;
            // 
            // tbTujuan
            // 
            tbTujuan.Location = new Point(53, 184);
            tbTujuan.Margin = new Padding(4, 4, 4, 4);
            tbTujuan.Name = "tbTujuan";
            tbTujuan.Size = new Size(332, 24);
            tbTujuan.TabIndex = 4;
            // 
            // tbBerat
            // 
            tbBerat.Location = new Point(53, 295);
            tbBerat.Margin = new Padding(4, 4, 4, 4);
            tbBerat.Name = "tbBerat";
            tbBerat.Size = new Size(332, 24);
            tbBerat.TabIndex = 5;
            // 
            // btnCekHarga
            // 
            btnCekHarga.Location = new Point(53, 437);
            btnCekHarga.Margin = new Padding(4, 4, 4, 4);
            btnCekHarga.Name = "btnCekHarga";
            btnCekHarga.Size = new Size(333, 29);
            btnCekHarga.TabIndex = 6;
            btnCekHarga.Text = "Check Harga Layanan";
            btnCekHarga.UseVisualStyleBackColor = true;
            btnCekHarga.Click += btnCekHarga_Click;
            // 
            // rbPos
            // 
            rbPos.AutoSize = true;
            rbPos.Location = new Point(73, 372);
            rbPos.Margin = new Padding(4, 4, 4, 4);
            rbPos.Name = "rbPos";
            rbPos.Size = new Size(57, 23);
            rbPos.TabIndex = 7;
            rbPos.TabStop = true;
            rbPos.Text = "POS";
            rbPos.UseVisualStyleBackColor = true;
            // 
            // rbJne
            // 
            rbJne.AutoSize = true;
            rbJne.Location = new Point(197, 372);
            rbJne.Margin = new Padding(4, 4, 4, 4);
            rbJne.Name = "rbJne";
            rbJne.Size = new Size(55, 23);
            rbJne.TabIndex = 8;
            rbJne.TabStop = true;
            rbJne.Text = "JNE";
            rbJne.UseVisualStyleBackColor = true;
            rbJne.CheckedChanged += rbJne_CheckedChanged;
            // 
            // rbTiki
            // 
            rbTiki.AutoSize = true;
            rbTiki.Location = new Point(312, 372);
            rbTiki.Margin = new Padding(4, 4, 4, 4);
            rbTiki.Name = "rbTiki";
            rbTiki.Size = new Size(60, 23);
            rbTiki.TabIndex = 9;
            rbTiki.TabStop = true;
            rbTiki.Text = "TIKI";
            rbTiki.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(456, 56);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(342, 410);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detail Layanan";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(845, 570);
            Controls.Add(groupBox1);
            Controls.Add(rbTiki);
            Controls.Add(rbJne);
            Controls.Add(rbPos);
            Controls.Add(btnCekHarga);
            Controls.Add(tbBerat);
            Controls.Add(tbTujuan);
            Controls.Add(tbAsal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Bell MT", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Using API Bruh";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbAsal;
        private TextBox tbTujuan;
        private TextBox tbBerat;
        private Button btnCekHarga;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public GroupBox groupBox1;
        public RadioButton rbPos;
        public RadioButton rbJne;
        public RadioButton rbTiki;
    }
}