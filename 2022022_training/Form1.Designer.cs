namespace _2022022_training
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBÜrün = new System.Windows.Forms.ComboBox();
            this.lBUrun = new System.Windows.Forms.ListBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.txtNo);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kargo Ekleme";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(104, 122);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(177, 20);
            this.txtNo.TabIndex = 3;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(104, 54);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(177, 20);
            this.txtAd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şirket No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şirket Adı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cBÜrün);
            this.groupBox2.Controls.Add(this.lBUrun);
            this.groupBox2.Controls.Add(this.btnAra);
            this.groupBox2.Controls.Add(this.txtArama);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(330, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 265);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Arama";
            // 
            // cBÜrün
            // 
            this.cBÜrün.FormattingEnabled = true;
            this.cBÜrün.Location = new System.Drawing.Point(142, 55);
            this.cBÜrün.Name = "cBÜrün";
            this.cBÜrün.Size = new System.Drawing.Size(121, 21);
            this.cBÜrün.TabIndex = 5;
            // 
            // lBUrun
            // 
            this.lBUrun.FormattingEnabled = true;
            this.lBUrun.Location = new System.Drawing.Point(10, 146);
            this.lBUrun.Name = "lBUrun";
            this.lBUrun.Size = new System.Drawing.Size(286, 95);
            this.lBUrun.TabIndex = 4;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(68, 84);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(156, 23);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(68, 57);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(58, 20);
            this.txtArama.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ürün Listesi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Arama";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(63, 161);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(156, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 303);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cBÜrün;
        private System.Windows.Forms.ListBox lBUrun;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEkle;
    }
}

