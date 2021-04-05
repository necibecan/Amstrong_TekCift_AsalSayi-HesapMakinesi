namespace NecibeCanBIL201Odev1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ileri = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bitisTxt = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.baslangicTxt = new System.Windows.Forms.MaskedTextBox();
            this.hesapla = new System.Windows.Forms.Button();
            this.islemler = new System.Windows.Forms.TabControl();
            this.tekTab = new System.Windows.Forms.TabPage();
            this.tekSayiListe = new System.Windows.Forms.ListView();
            this.ciftTab = new System.Windows.Forms.TabPage();
            this.ciftSayiListe = new System.Windows.Forms.ListView();
            this.asalTab = new System.Windows.Forms.TabPage();
            this.asalSayiListe = new System.Windows.Forms.ListView();
            this.armstrongTab = new System.Windows.Forms.TabPage();
            this.armstrongListe = new System.Windows.Forms.ListView();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.islemler.SuspendLayout();
            this.tekTab.SuspendLayout();
            this.ciftTab.SuspendLayout();
            this.asalTab.SuspendLayout();
            this.armstrongTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ileri);
            this.groupBox1.Controls.Add(this.geri);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bitisTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.baslangicTxt);
            this.groupBox1.Controls.Add(this.hesapla);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Bilgileri";
            // 
            // ileri
            // 
            this.ileri.Location = new System.Drawing.Point(679, 56);
            this.ileri.Name = "ileri";
            this.ileri.Size = new System.Drawing.Size(75, 23);
            this.ileri.TabIndex = 6;
            this.ileri.Text = "İleri>>";
            this.ileri.UseVisualStyleBackColor = true;
            this.ileri.Click += new System.EventHandler(this.ileri_Click);
            // 
            // geri
            // 
            this.geri.Location = new System.Drawing.Point(574, 56);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(75, 23);
            this.geri.TabIndex = 5;
            this.geri.Text = "<<Geri";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bitiş";
            // 
            // bitisTxt
            // 
            this.bitisTxt.Location = new System.Drawing.Point(265, 59);
            this.bitisTxt.Mask = "00000";
            this.bitisTxt.Name = "bitisTxt";
            this.bitisTxt.Size = new System.Drawing.Size(100, 22);
            this.bitisTxt.TabIndex = 3;
            this.bitisTxt.Text = "10000";
            this.bitisTxt.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Başlangıç";
            // 
            // baslangicTxt
            // 
            this.baslangicTxt.Location = new System.Drawing.Point(100, 59);
            this.baslangicTxt.Mask = "00000";
            this.baslangicTxt.Name = "baslangicTxt";
            this.baslangicTxt.Size = new System.Drawing.Size(100, 22);
            this.baslangicTxt.TabIndex = 1;
            this.baslangicTxt.Text = "1";
            this.baslangicTxt.ValidatingType = typeof(int);
            // 
            // hesapla
            // 
            this.hesapla.Location = new System.Drawing.Point(398, 56);
            this.hesapla.Name = "hesapla";
            this.hesapla.Size = new System.Drawing.Size(75, 23);
            this.hesapla.TabIndex = 0;
            this.hesapla.Text = "Hesapla";
            this.hesapla.UseVisualStyleBackColor = true;
            this.hesapla.Click += new System.EventHandler(this.hesapla_Click);
            // 
            // islemler
            // 
            this.islemler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.islemler.Controls.Add(this.tekTab);
            this.islemler.Controls.Add(this.ciftTab);
            this.islemler.Controls.Add(this.asalTab);
            this.islemler.Controls.Add(this.armstrongTab);
            this.islemler.Location = new System.Drawing.Point(12, 164);
            this.islemler.Name = "islemler";
            this.islemler.SelectedIndex = 0;
            this.islemler.Size = new System.Drawing.Size(776, 274);
            this.islemler.TabIndex = 1;
            // 
            // tekTab
            // 
            this.tekTab.Controls.Add(this.tekSayiListe);
            this.tekTab.Location = new System.Drawing.Point(4, 25);
            this.tekTab.Name = "tekTab";
            this.tekTab.Padding = new System.Windows.Forms.Padding(3);
            this.tekTab.Size = new System.Drawing.Size(768, 245);
            this.tekTab.TabIndex = 0;
            this.tekTab.Text = "Tek Sayılar";
            this.tekTab.UseVisualStyleBackColor = true;
            // 
            // tekSayiListe
            // 
            this.tekSayiListe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tekSayiListe.HideSelection = false;
            this.tekSayiListe.Location = new System.Drawing.Point(0, 0);
            this.tekSayiListe.Name = "tekSayiListe";
            this.tekSayiListe.Size = new System.Drawing.Size(768, 245);
            this.tekSayiListe.TabIndex = 0;
            this.tekSayiListe.UseCompatibleStateImageBehavior = false;
            // 
            // ciftTab
            // 
            this.ciftTab.Controls.Add(this.ciftSayiListe);
            this.ciftTab.Location = new System.Drawing.Point(4, 25);
            this.ciftTab.Name = "ciftTab";
            this.ciftTab.Padding = new System.Windows.Forms.Padding(3);
            this.ciftTab.Size = new System.Drawing.Size(768, 245);
            this.ciftTab.TabIndex = 1;
            this.ciftTab.Text = "Çift Sayılar";
            this.ciftTab.UseVisualStyleBackColor = true;
            // 
            // ciftSayiListe
            // 
            this.ciftSayiListe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ciftSayiListe.HideSelection = false;
            this.ciftSayiListe.Location = new System.Drawing.Point(8, 8);
            this.ciftSayiListe.Name = "ciftSayiListe";
            this.ciftSayiListe.Size = new System.Drawing.Size(768, 245);
            this.ciftSayiListe.TabIndex = 1;
            this.ciftSayiListe.UseCompatibleStateImageBehavior = false;
            // 
            // asalTab
            // 
            this.asalTab.Controls.Add(this.asalSayiListe);
            this.asalTab.Location = new System.Drawing.Point(4, 25);
            this.asalTab.Name = "asalTab";
            this.asalTab.Size = new System.Drawing.Size(768, 245);
            this.asalTab.TabIndex = 2;
            this.asalTab.Text = "Asal Sayılar";
            this.asalTab.UseVisualStyleBackColor = true;
            // 
            // asalSayiListe
            // 
            this.asalSayiListe.HideSelection = false;
            this.asalSayiListe.Location = new System.Drawing.Point(8, 8);
            this.asalSayiListe.Name = "asalSayiListe";
            this.asalSayiListe.Size = new System.Drawing.Size(768, 245);
            this.asalSayiListe.TabIndex = 1;
            this.asalSayiListe.UseCompatibleStateImageBehavior = false;
            // 
            // armstrongTab
            // 
            this.armstrongTab.Controls.Add(this.armstrongListe);
            this.armstrongTab.Location = new System.Drawing.Point(4, 25);
            this.armstrongTab.Name = "armstrongTab";
            this.armstrongTab.Size = new System.Drawing.Size(768, 245);
            this.armstrongTab.TabIndex = 3;
            this.armstrongTab.Text = "Armstrong Sayılar";
            this.armstrongTab.UseVisualStyleBackColor = true;
            // 
            // armstrongListe
            // 
            this.armstrongListe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.armstrongListe.HideSelection = false;
            this.armstrongListe.Location = new System.Drawing.Point(8, 8);
            this.armstrongListe.Name = "armstrongListe";
            this.armstrongListe.Size = new System.Drawing.Size(768, 245);
            this.armstrongListe.TabIndex = 1;
            this.armstrongListe.UseCompatibleStateImageBehavior = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Nesne Yönelimli Programlama Odev 1";
            this.notifyIcon1.BalloonTipTitle = "Programa Hoşgeldiniz!";
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.islemler);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.islemler.ResumeLayout(false);
            this.tekTab.ResumeLayout(false);
            this.ciftTab.ResumeLayout(false);
            this.asalTab.ResumeLayout(false);
            this.armstrongTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ileri;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox bitisTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox baslangicTxt;
        private System.Windows.Forms.Button hesapla;
        private System.Windows.Forms.TabControl islemler;
        private System.Windows.Forms.TabPage tekTab;
        private System.Windows.Forms.TabPage ciftTab;
        private System.Windows.Forms.TabPage asalTab;
        private System.Windows.Forms.TabPage armstrongTab;
        private System.Windows.Forms.ListView tekSayiListe;
        private System.Windows.Forms.ListView ciftSayiListe;
        private System.Windows.Forms.ListView asalSayiListe;
        private System.Windows.Forms.ListView armstrongListe;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

