
namespace Veri_Tabanlı_Parti_Secim
{
    partial class FrmGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtilce = new System.Windows.Forms.TextBox();
            this.txta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txte = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnoy = new System.Windows.Forms.Button();
            this.btngrafik = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlce Ad:";
            // 
            // txtilce
            // 
            this.txtilce.Location = new System.Drawing.Point(305, 105);
            this.txtilce.Name = "txtilce";
            this.txtilce.Size = new System.Drawing.Size(350, 39);
            this.txtilce.TabIndex = 1;
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(305, 198);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(350, 39);
            this.txta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "A Parti:";
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(305, 243);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(350, 39);
            this.txtb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "B Parti:";
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(305, 288);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(350, 39);
            this.txtc.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "C Parti:";
            // 
            // txtd
            // 
            this.txtd.Location = new System.Drawing.Point(305, 333);
            this.txtd.Name = "txtd";
            this.txtd.Size = new System.Drawing.Size(350, 39);
            this.txtd.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "D Parti:";
            // 
            // txte
            // 
            this.txte.Location = new System.Drawing.Point(305, 378);
            this.txte.Name = "txte";
            this.txte.Size = new System.Drawing.Size(350, 39);
            this.txte.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "E Parti:";
            // 
            // btnoy
            // 
            this.btnoy.Location = new System.Drawing.Point(305, 432);
            this.btnoy.Name = "btnoy";
            this.btnoy.Size = new System.Drawing.Size(350, 63);
            this.btnoy.TabIndex = 12;
            this.btnoy.Text = "OY GİRİSİ YAP";
            this.btnoy.UseVisualStyleBackColor = true;
            this.btnoy.Click += new System.EventHandler(this.btnoy_Click);
            // 
            // btngrafik
            // 
            this.btngrafik.Location = new System.Drawing.Point(305, 501);
            this.btngrafik.Name = "btngrafik";
            this.btngrafik.Size = new System.Drawing.Size(172, 63);
            this.btngrafik.TabIndex = 14;
            this.btngrafik.Text = "GRAFİKLER";
            this.btngrafik.UseVisualStyleBackColor = true;
            this.btngrafik.Click += new System.EventHandler(this.btngrafik_Click);
            // 
            // btncikis
            // 
            this.btncikis.Location = new System.Drawing.Point(483, 501);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(172, 63);
            this.btncikis.TabIndex = 15;
            this.btncikis.Text = "CIKIS";
            this.btncikis.UseVisualStyleBackColor = true;
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(903, 649);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btngrafik);
            this.Controls.Add(this.btnoy);
            this.Controls.Add(this.txte);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtilce);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmGiris";
            this.Text = "Secim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtilce;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnoy;
        private System.Windows.Forms.Button btngrafik;
        private System.Windows.Forms.Button btncikis;
    }
}

