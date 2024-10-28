namespace PostgreSQLxVisualStudio
{
    partial class Form2
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
            pb_qr = new PictureBox();
            lb_qr = new Label();
            ((System.ComponentModel.ISupportInitialize)pb_qr).BeginInit();
            SuspendLayout();
            // 
            // pb_qr
            // 
            pb_qr.BackgroundImageLayout = ImageLayout.Stretch;
            pb_qr.Location = new Point(21, 12);
            pb_qr.Name = "pb_qr";
            pb_qr.Size = new Size(389, 327);
            pb_qr.TabIndex = 0;
            pb_qr.TabStop = false;
            // 
            // lb_qr
            // 
            lb_qr.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lb_qr.AutoSize = true;
            lb_qr.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lb_qr.Location = new Point(21, 362);
            lb_qr.Name = "lb_qr";
            lb_qr.Size = new Size(50, 19);
            lb_qr.TabIndex = 1;
            lb_qr.Text = "label1";
            lb_qr.Click += lb_qr_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(433, 450);
            Controls.Add(lb_qr);
            Controls.Add(pb_qr);
            Name = "Form2";
            Text = "QR Generator";
            Load += Form2_Load_1;
            ((System.ComponentModel.ISupportInitialize)pb_qr).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pb_qr;
        private Label lb_qr;
    }
}