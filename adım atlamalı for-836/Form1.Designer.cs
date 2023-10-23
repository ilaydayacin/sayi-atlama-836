namespace adım_atlamalı_for_836
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
            this.txtBitir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHesap = new System.Windows.Forms.Button();
            this.lbSayilar = new System.Windows.Forms.ListBox();
            this.txtBasla = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAtlama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBitir
            // 
            this.txtBitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBitir.Location = new System.Drawing.Point(11, 99);
            this.txtBitir.Name = "txtBitir";
            this.txtBitir.Size = new System.Drawing.Size(176, 26);
            this.txtBitir.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Bitiş sayısı";
            // 
            // btnHesap
            // 
            this.btnHesap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesap.Location = new System.Drawing.Point(12, 234);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Size = new System.Drawing.Size(119, 60);
            this.btnHesap.TabIndex = 13;
            this.btnHesap.Text = "Hesapla";
            this.btnHesap.UseVisualStyleBackColor = true;
            this.btnHesap.Click += new System.EventHandler(this.btnHesap_Click);
            // 
            // lbSayilar
            // 
            this.lbSayilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSayilar.FormattingEnabled = true;
            this.lbSayilar.ItemHeight = 20;
            this.lbSayilar.Location = new System.Drawing.Point(213, 12);
            this.lbSayilar.Name = "lbSayilar";
            this.lbSayilar.Size = new System.Drawing.Size(167, 324);
            this.lbSayilar.TabIndex = 12;
            // 
            // txtBasla
            // 
            this.txtBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBasla.Location = new System.Drawing.Point(11, 29);
            this.txtBasla.Name = "txtBasla";
            this.txtBasla.Size = new System.Drawing.Size(176, 26);
            this.txtBasla.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Başlangıç sayısı";
            // 
            // txtAtlama
            // 
            this.txtAtlama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAtlama.Location = new System.Drawing.Point(11, 167);
            this.txtAtlama.Name = "txtAtlama";
            this.txtAtlama.Size = new System.Drawing.Size(176, 26);
            this.txtAtlama.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(8, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Atlama";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAtlama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBitir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHesap);
            this.Controls.Add(this.lbSayilar);
            this.Controls.Add(this.txtBasla);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBitir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHesap;
        private System.Windows.Forms.ListBox lbSayilar;
        private System.Windows.Forms.TextBox txtBasla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAtlama;
        private System.Windows.Forms.Label label3;
    }
}

