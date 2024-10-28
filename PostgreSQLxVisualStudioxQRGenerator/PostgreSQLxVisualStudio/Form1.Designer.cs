namespace PostgreSQLxVisualStudio
{
    partial class Form1
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
            dgvData = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtAlamat = new TextBox();
            txtNo_handphone = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnLoaddata = new Button();
            label4 = new Label();
            btn_qr = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(26, 269);
            dgvData.Margin = new Padding(4, 3, 4, 3);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(874, 187);
            dgvData.TabIndex = 0;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 113);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 1;
            label1.Text = "Nama Lengkap       :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 218);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 2;
            label2.Text = "No HP                     :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 164);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 3;
            label3.Text = "Alamat                     : ";
            label3.Click += label3_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(157, 110);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(181, 23);
            txtName.TabIndex = 4;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(157, 160);
            txtAlamat.Margin = new Padding(4, 3, 4, 3);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(181, 23);
            txtAlamat.TabIndex = 5;
            // 
            // txtNo_handphone
            // 
            txtNo_handphone.Location = new Point(157, 215);
            txtNo_handphone.Margin = new Padding(4, 3, 4, 3);
            txtNo_handphone.Name = "txtNo_handphone";
            txtNo_handphone.Size = new Size(181, 23);
            txtNo_handphone.TabIndex = 6;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(255, 192, 255);
            btnInsert.Location = new Point(355, 113);
            btnInsert.Margin = new Padding(4, 3, 4, 3);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(125, 120);
            btnInsert.TabIndex = 7;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Pink;
            btnUpdate.Location = new Point(490, 113);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 120);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Plum;
            btnDelete.Location = new Point(625, 113);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 120);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoaddata
            // 
            btnLoaddata.BackColor = Color.FromArgb(255, 192, 192);
            btnLoaddata.Location = new Point(758, 467);
            btnLoaddata.Margin = new Padding(4, 3, 4, 3);
            btnLoaddata.Name = "btnLoaddata";
            btnLoaddata.Size = new Size(125, 38);
            btnLoaddata.TabIndex = 10;
            btnLoaddata.Text = "Load Data";
            btnLoaddata.UseVisualStyleBackColor = false;
            btnLoaddata.Click += btnLoaddata_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(336, 24);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(211, 40);
            label4.TabIndex = 11;
            label4.Text = "DATA USERS";
            // 
            // btn_qr
            // 
            btn_qr.BackColor = Color.Pink;
            btn_qr.Location = new Point(760, 113);
            btn_qr.Margin = new Padding(4, 3, 4, 3);
            btn_qr.Name = "btn_qr";
            btn_qr.Size = new Size(125, 120);
            btn_qr.TabIndex = 12;
            btn_qr.Text = "Generate QR";
            btn_qr.UseVisualStyleBackColor = false;
            btn_qr.Click += btn_qr_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(933, 519);
            Controls.Add(btn_qr);
            Controls.Add(label4);
            Controls.Add(btnLoaddata);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtNo_handphone);
            Controls.Add(txtAlamat);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvData);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Dashboard Users";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvData;
        private Label label1;
        private Label label2;
        private Label label3;
        public TextBox txtName;
        public TextBox txtAlamat;
        public TextBox txtNo_handphone;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnLoaddata;
        private Label label4;
        private Button btn_qr;
    }
}