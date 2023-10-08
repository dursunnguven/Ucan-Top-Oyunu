
namespace UçanTopOyunuYapımı
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblsolkenar = new System.Windows.Forms.Label();
            this.lblustkenar = new System.Windows.Forms.Label();
            this.lblsagkenar = new System.Windows.Forms.Label();
            this.lblcan = new System.Windows.Forms.Label();
            this.btntahta = new System.Windows.Forms.Button();
            this.btntop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblsolkenar
            // 
            this.lblsolkenar.BackColor = System.Drawing.Color.Green;
            this.lblsolkenar.Location = new System.Drawing.Point(0, -31);
            this.lblsolkenar.Name = "lblsolkenar";
            this.lblsolkenar.Size = new System.Drawing.Size(51, 658);
            this.lblsolkenar.TabIndex = 0;
            // 
            // lblustkenar
            // 
            this.lblustkenar.BackColor = System.Drawing.Color.Green;
            this.lblustkenar.Location = new System.Drawing.Point(-1, 0);
            this.lblustkenar.Name = "lblustkenar";
            this.lblustkenar.Size = new System.Drawing.Size(970, 43);
            this.lblustkenar.TabIndex = 0;
            // 
            // lblsagkenar
            // 
            this.lblsagkenar.BackColor = System.Drawing.Color.Green;
            this.lblsagkenar.Location = new System.Drawing.Point(919, 1);
            this.lblsagkenar.Name = "lblsagkenar";
            this.lblsagkenar.Size = new System.Drawing.Size(51, 626);
            this.lblsagkenar.TabIndex = 0;
            // 
            // lblcan
            // 
            this.lblcan.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.lblcan.Location = new System.Drawing.Point(1064, 95);
            this.lblcan.Name = "lblcan";
            this.lblcan.Size = new System.Drawing.Size(56, 55);
            this.lblcan.TabIndex = 1;
            this.lblcan.Text = "3";
            this.lblcan.Click += new System.EventHandler(this.lblcan_Click);
            // 
            // btntahta
            // 
            this.btntahta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btntahta.Location = new System.Drawing.Point(397, 597);
            this.btntahta.Name = "btntahta";
            this.btntahta.Size = new System.Drawing.Size(130, 30);
            this.btntahta.TabIndex = 2;
            this.btntahta.UseVisualStyleBackColor = false;
            this.btntahta.Click += new System.EventHandler(this.btntahta_Click);
            this.btntahta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btntahta_MouseMove);
            // 
            // btntop
            // 
            this.btntop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btntop.Location = new System.Drawing.Point(446, 456);
            this.btntop.Name = "btntop";
            this.btntop.Size = new System.Drawing.Size(25, 29);
            this.btntop.TabIndex = 3;
            this.btntop.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(1012, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 29);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 732);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btntop);
            this.Controls.Add(this.btntahta);
            this.Controls.Add(this.lblcan);
            this.Controls.Add(this.lblsagkenar);
            this.Controls.Add(this.lblustkenar);
            this.Controls.Add(this.lblsolkenar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblsolkenar;
        private System.Windows.Forms.Label lblustkenar;
        private System.Windows.Forms.Label lblsagkenar;
        private System.Windows.Forms.Label lblcan;
        private System.Windows.Forms.Button btntahta;
        private System.Windows.Forms.Button btntop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}

