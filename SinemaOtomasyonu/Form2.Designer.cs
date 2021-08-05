
namespace SinemaOtomasyonu
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
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbKadin = new System.Windows.Forms.RadioButton();
            this.mtxtKimlikNo = new System.Windows.Forms.MaskedTextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(404, 146);
            this.rbErkek.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(53, 17);
            this.rbErkek.TabIndex = 26;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(321, 226);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(179, 47);
            this.btnIptal.TabIndex = 25;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(117, 226);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(179, 47);
            this.btnOnayla.TabIndex = 24;
            this.btnOnayla.Text = "Onayla ";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(530, 70);
            this.label3.TabIndex = 23;
            this.label3.Text = "Rezervasyon Ekranı ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "TC. Kimlik No :";
            // 
            // rbKadin
            // 
            this.rbKadin.AutoSize = true;
            this.rbKadin.Checked = true;
            this.rbKadin.Location = new System.Drawing.Point(404, 92);
            this.rbKadin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbKadin.Name = "rbKadin";
            this.rbKadin.Size = new System.Drawing.Size(55, 17);
            this.rbKadin.TabIndex = 21;
            this.rbKadin.TabStop = true;
            this.rbKadin.Text = "Kadın ";
            this.rbKadin.UseVisualStyleBackColor = true;
            // 
            // mtxtKimlikNo
            // 
            this.mtxtKimlikNo.Location = new System.Drawing.Point(161, 143);
            this.mtxtKimlikNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtxtKimlikNo.Mask = "00000000000";
            this.mtxtKimlikNo.Name = "mtxtKimlikNo";
            this.mtxtKimlikNo.PromptChar = ' ';
            this.mtxtKimlikNo.Size = new System.Drawing.Size(190, 20);
            this.mtxtKimlikNo.TabIndex = 20;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(161, 95);
            this.txtAdSoyad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(190, 20);
            this.txtAdSoyad.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ad Soyad :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 294);
            this.Controls.Add(this.rbErkek);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbKadin);
            this.Controls.Add(this.mtxtKimlikNo);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbKadin;
        private System.Windows.Forms.MaskedTextBox mtxtKimlikNo;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label1;
    }
}