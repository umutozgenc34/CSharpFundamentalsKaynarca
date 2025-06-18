namespace HesapMakinasıYeni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtSayiBox1 = new TextBox();
            txtSayiBox2 = new TextBox();
            btnTopla = new Button();
            btnCikar = new Button();
            btnCarp = new Button();
            btnBol = new Button();
            lblSonuc = new Label();
            btnFix = new Button();
            btnPow = new Button();
            btnSqrt = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(125, 36);
            label1.Name = "label1";
            label1.Size = new Size(828, 114);
            label1.TabIndex = 0;
            label1.Text = "HESAP MAKINESI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(112, 206);
            label2.Name = "label2";
            label2.Size = new Size(144, 60);
            label2.TabIndex = 1;
            label2.Text = "1. Sayı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(112, 331);
            label3.Name = "label3";
            label3.Size = new Size(150, 60);
            label3.TabIndex = 2;
            label3.Text = "2. Sayı";
            // 
            // txtSayiBox1
            // 
            txtSayiBox1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSayiBox1.Location = new Point(319, 206);
            txtSayiBox1.Name = "txtSayiBox1";
            txtSayiBox1.Size = new Size(382, 71);
            txtSayiBox1.TabIndex = 3;
            // 
            // txtSayiBox2
            // 
            txtSayiBox2.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSayiBox2.Location = new Point(319, 320);
            txtSayiBox2.Name = "txtSayiBox2";
            txtSayiBox2.Size = new Size(382, 71);
            txtSayiBox2.TabIndex = 4;
            // 
            // btnTopla
            // 
            btnTopla.Anchor = AnchorStyles.None;
            btnTopla.BackColor = Color.FromArgb(255, 224, 192);
            btnTopla.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnTopla.ForeColor = Color.Black;
            btnTopla.ImageAlign = ContentAlignment.BottomLeft;
            btnTopla.Location = new Point(759, 187);
            btnTopla.Name = "btnTopla";
            btnTopla.Size = new Size(133, 123);
            btnTopla.TabIndex = 5;
            btnTopla.Text = "+";
            btnTopla.UseVisualStyleBackColor = false;
            btnTopla.Click += btnTopla_Click;
            // 
            // btnCikar
            // 
            btnCikar.Anchor = AnchorStyles.None;
            btnCikar.BackColor = Color.FromArgb(255, 224, 192);
            btnCikar.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnCikar.ForeColor = Color.Black;
            btnCikar.ImageAlign = ContentAlignment.BottomLeft;
            btnCikar.Location = new Point(932, 187);
            btnCikar.Name = "btnCikar";
            btnCikar.Size = new Size(133, 123);
            btnCikar.TabIndex = 6;
            btnCikar.Text = "-";
            btnCikar.UseVisualStyleBackColor = false;
            btnCikar.Click += btnCikar_Click;
            // 
            // btnCarp
            // 
            btnCarp.Anchor = AnchorStyles.None;
            btnCarp.BackColor = Color.FromArgb(255, 224, 192);
            btnCarp.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnCarp.ForeColor = Color.Black;
            btnCarp.ImageAlign = ContentAlignment.BottomLeft;
            btnCarp.Location = new Point(759, 331);
            btnCarp.Name = "btnCarp";
            btnCarp.Size = new Size(133, 123);
            btnCarp.TabIndex = 7;
            btnCarp.Text = "*";
            btnCarp.UseVisualStyleBackColor = false;
            btnCarp.Click += btnCarp_Click;
            // 
            // btnBol
            // 
            btnBol.Anchor = AnchorStyles.None;
            btnBol.BackColor = Color.FromArgb(255, 224, 192);
            btnBol.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnBol.ForeColor = Color.Black;
            btnBol.ImageAlign = ContentAlignment.BottomLeft;
            btnBol.Location = new Point(932, 331);
            btnBol.Name = "btnBol";
            btnBol.Size = new Size(133, 123);
            btnBol.TabIndex = 8;
            btnBol.Text = "/";
            btnBol.UseVisualStyleBackColor = false;
            btnBol.Click += btnBol_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.BackColor = Color.Lime;
            lblSonuc.Font = new Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSonuc.Location = new Point(319, 459);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(232, 76);
            lblSonuc.TabIndex = 9;
            lblSonuc.Text = "Sonuç";
            lblSonuc.Visible = false;
            // 
            // btnFix
            // 
            btnFix.Anchor = AnchorStyles.None;
            btnFix.BackColor = Color.FromArgb(192, 0, 0);
            btnFix.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnFix.ForeColor = Color.Black;
            btnFix.ImageAlign = ContentAlignment.BottomLeft;
            btnFix.Location = new Point(759, 479);
            btnFix.Name = "btnFix";
            btnFix.Size = new Size(133, 56);
            btnFix.TabIndex = 10;
            btnFix.Text = "Fix";
            btnFix.UseVisualStyleBackColor = false;
            btnFix.Click += btnFix_Click;
            // 
            // btnPow
            // 
            btnPow.Anchor = AnchorStyles.None;
            btnPow.BackColor = Color.FromArgb(255, 224, 192);
            btnPow.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnPow.ForeColor = Color.Black;
            btnPow.Location = new Point(908, 482);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(97, 51);
            btnPow.TabIndex = 11;
            btnPow.Text = "^";
            btnPow.UseVisualStyleBackColor = false;
            btnPow.Click += btnPow_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.Anchor = AnchorStyles.None;
            btnSqrt.BackColor = Color.FromArgb(255, 224, 192);
            btnSqrt.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnSqrt.ForeColor = Color.Black;
            btnSqrt.Location = new Point(1022, 482);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(97, 51);
            btnSqrt.TabIndex = 12;
            btnSqrt.Text = "√";
            btnSqrt.UseVisualStyleBackColor = false;
            btnSqrt.Click += btnSqrt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1140, 575);
            Controls.Add(btnSqrt);
            Controls.Add(btnPow);
            Controls.Add(btnFix);
            Controls.Add(lblSonuc);
            Controls.Add(btnBol);
            Controls.Add(btnCarp);
            Controls.Add(btnCikar);
            Controls.Add(btnTopla);
            Controls.Add(txtSayiBox2);
            Controls.Add(txtSayiBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Hesap Makinesi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSayiBox1;
        private TextBox txtSayiBox2;
        private Button btnTopla;
        private Button btnCikar;
        private Button btnCarp;
        private Button btnBol;
        private Label lblSonuc;
        private Button btnFix;
        private Button btnPow;
        private Button btnSqrt;
    }
}
