namespace cekilis
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
            this.rtxt_Oynayacaklar = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtg_Kadro1 = new System.Windows.Forms.DataGridView();
            this.dtg_Kadro2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Kadro = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.n_Miktar = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Katılımcı_Sayısı = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Kadro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Kadro2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_Miktar)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxt_Oynayacaklar
            // 
            this.rtxt_Oynayacaklar.Location = new System.Drawing.Point(550, 112);
            this.rtxt_Oynayacaklar.Name = "rtxt_Oynayacaklar";
            this.rtxt_Oynayacaklar.Size = new System.Drawing.Size(121, 290);
            this.rtxt_Oynayacaklar.TabIndex = 2;
            this.rtxt_Oynayacaklar.Text = "";
            this.rtxt_Oynayacaklar.TextChanged += new System.EventHandler(this.rtxt_Oynayacaklar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(547, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Oynayacaklar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(547, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "*Her satıra bir isim yazınız";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtg_Kadro1
            // 
            this.dtg_Kadro1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Kadro1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Kadro1.Location = new System.Drawing.Point(12, 112);
            this.dtg_Kadro1.Name = "dtg_Kadro1";
            this.dtg_Kadro1.Size = new System.Drawing.Size(240, 308);
            this.dtg_Kadro1.TabIndex = 5;
            this.dtg_Kadro1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Kadro1_CellContentClick);
            // 
            // dtg_Kadro2
            // 
            this.dtg_Kadro2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Kadro2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Kadro2.Location = new System.Drawing.Point(278, 112);
            this.dtg_Kadro2.Name = "dtg_Kadro2";
            this.dtg_Kadro2.Size = new System.Drawing.Size(240, 308);
            this.dtg_Kadro2.TabIndex = 6;
            this.dtg_Kadro2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Kadro2_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(104, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kadro 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlText;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(381, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kadro 2";
            // 
            // btn_Kadro
            // 
            this.btn_Kadro.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Kadro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Kadro.Location = new System.Drawing.Point(160, 47);
            this.btn_Kadro.Name = "btn_Kadro";
            this.btn_Kadro.Size = new System.Drawing.Size(92, 23);
            this.btn_Kadro.TabIndex = 9;
            this.btn_Kadro.Text = "Kadro Oluştur";
            this.btn_Kadro.UseVisualStyleBackColor = false;
            this.btn_Kadro.Click += new System.EventHandler(this.btn_Kadro_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Reset.Location = new System.Drawing.Point(278, 47);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(92, 23);
            this.btn_Reset.TabIndex = 10;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // n_Miktar
            // 
            this.n_Miktar.Location = new System.Drawing.Point(28, 50);
            this.n_Miktar.Name = "n_Miktar";
            this.n_Miktar.Size = new System.Drawing.Size(120, 20);
            this.n_Miktar.TabIndex = 11;
            this.n_Miktar.ValueChanged += new System.EventHandler(this.n_Miktar_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(413, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Oynayan Sayısı";
            // 
            // lbl_Katılımcı_Sayısı
            // 
            this.lbl_Katılımcı_Sayısı.AutoSize = true;
            this.lbl_Katılımcı_Sayısı.BackColor = System.Drawing.Color.DarkRed;
            this.lbl_Katılımcı_Sayısı.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Katılımcı_Sayısı.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Katılımcı_Sayısı.Location = new System.Drawing.Point(498, 44);
            this.lbl_Katılımcı_Sayısı.Name = "lbl_Katılımcı_Sayısı";
            this.lbl_Katılımcı_Sayısı.Size = new System.Drawing.Size(20, 24);
            this.lbl_Katılımcı_Sayısı.TabIndex = 13;
            this.lbl_Katılımcı_Sayısı.Text = "0";
            this.lbl_Katılımcı_Sayısı.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.lbl_Katılımcı_Sayısı);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.n_Miktar);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Kadro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtg_Kadro2);
            this.Controls.Add(this.dtg_Kadro1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtxt_Oynayacaklar);
            this.Name = "Form1";
            this.Text = "Rastgele Kadro Kurucu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Kadro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Kadro2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_Miktar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtxt_Oynayacaklar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtg_Kadro1;
        private System.Windows.Forms.DataGridView dtg_Kadro2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Kadro;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.NumericUpDown n_Miktar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Katılımcı_Sayısı;
    }
}

