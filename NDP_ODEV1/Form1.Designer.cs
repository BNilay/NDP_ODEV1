namespace NDP_ODEV1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dOSYAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniDosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bİÇİMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aYARLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıÇeşitleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.biçimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.görünümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arkaPlanRengiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıTipiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arkaPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beyazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pembeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeşilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LavenderBlush;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dOSYAToolStripMenuItem,
            this.bİÇİMToolStripMenuItem,
            this.aYARLARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1249, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dOSYAToolStripMenuItem
            // 
            this.dOSYAToolStripMenuItem.BackColor = System.Drawing.Color.Pink;
            this.dOSYAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniDosyaToolStripMenuItem,
            this.dosyaAçToolStripMenuItem,
            this.dosyaKaydetToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.dOSYAToolStripMenuItem.Name = "dOSYAToolStripMenuItem";
            this.dOSYAToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.dOSYAToolStripMenuItem.Text = "DOSYA";
            // 
            // yeniDosyaToolStripMenuItem
            // 
            this.yeniDosyaToolStripMenuItem.Name = "yeniDosyaToolStripMenuItem";
            this.yeniDosyaToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.yeniDosyaToolStripMenuItem.Text = "Yeni ";
            this.yeniDosyaToolStripMenuItem.Click += new System.EventHandler(this.yeniDosyaToolStripMenuItem_Click);
            // 
            // dosyaAçToolStripMenuItem
            // 
            this.dosyaAçToolStripMenuItem.Name = "dosyaAçToolStripMenuItem";
            this.dosyaAçToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.dosyaAçToolStripMenuItem.Text = "Dosya Aç";
            this.dosyaAçToolStripMenuItem.Click += new System.EventHandler(this.dosyaAçToolStripMenuItem_Click);
            // 
            // dosyaKaydetToolStripMenuItem
            // 
            this.dosyaKaydetToolStripMenuItem.Name = "dosyaKaydetToolStripMenuItem";
            this.dosyaKaydetToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.dosyaKaydetToolStripMenuItem.Text = "Dosya Kaydet";
            this.dosyaKaydetToolStripMenuItem.Click += new System.EventHandler(this.dosyaKaydetToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // bİÇİMToolStripMenuItem
            // 
            this.bİÇİMToolStripMenuItem.BackColor = System.Drawing.Color.Pink;
            this.bİÇİMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapıştırToolStripMenuItem});
            this.bİÇİMToolStripMenuItem.Name = "bİÇİMToolStripMenuItem";
            this.bİÇİMToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.bİÇİMToolStripMenuItem.Text = "BİÇİM";
            // 
            // lToolStripMenuItem
            // 
            this.lToolStripMenuItem.Name = "lToolStripMenuItem";
            this.lToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.lToolStripMenuItem.Text = "Kes";
            this.lToolStripMenuItem.Click += new System.EventHandler(this.lToolStripMenuItem_Click);
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            this.kopyalaToolStripMenuItem.Click += new System.EventHandler(this.kopyalaToolStripMenuItem_Click);
            // 
            // yapıştırToolStripMenuItem
            // 
            this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.yapıştırToolStripMenuItem.Text = "Yapıştır";
            this.yapıştırToolStripMenuItem.Click += new System.EventHandler(this.yapıştırToolStripMenuItem_Click);
            // 
            // aYARLARToolStripMenuItem
            // 
            this.aYARLARToolStripMenuItem.BackColor = System.Drawing.Color.Pink;
            this.aYARLARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renkToolStripMenuItem,
            this.yazıÇeşitleriToolStripMenuItem});
            this.aYARLARToolStripMenuItem.Name = "aYARLARToolStripMenuItem";
            this.aYARLARToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.aYARLARToolStripMenuItem.Text = "AYARLAR";
            // 
            // renkToolStripMenuItem
            // 
            this.renkToolStripMenuItem.Name = "renkToolStripMenuItem";
            this.renkToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.renkToolStripMenuItem.Text = "Renk";
            this.renkToolStripMenuItem.Click += new System.EventHandler(this.renkToolStripMenuItem_Click);
            // 
            // yazıÇeşitleriToolStripMenuItem
            // 
            this.yazıÇeşitleriToolStripMenuItem.Name = "yazıÇeşitleriToolStripMenuItem";
            this.yazıÇeşitleriToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.yazıÇeşitleriToolStripMenuItem.Text = "Yazı Çeşitleri";
            this.yazıÇeşitleriToolStripMenuItem.Click += new System.EventHandler(this.yazıÇeşitleriToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.richTextBox1.Location = new System.Drawing.Point(208, 85);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(833, 442);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(593, 533);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 30);
            this.textBox1.TabIndex = 3;
            this.textBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(397, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dosya adı girin:";
            this.label1.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biçimToolStripMenuItem,
            this.görünümToolStripMenuItem,
            this.arkaPlanToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(150, 76);
            // 
            // biçimToolStripMenuItem
            // 
            this.biçimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem1,
            this.yapıştırToolStripMenuItem1});
            this.biçimToolStripMenuItem.Name = "biçimToolStripMenuItem";
            this.biçimToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.biçimToolStripMenuItem.Text = "biçim";
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.kesToolStripMenuItem.Text = "kes";
            this.kesToolStripMenuItem.Click += new System.EventHandler(this.kesToolStripMenuItem_Click);
            // 
            // kopyalaToolStripMenuItem1
            // 
            this.kopyalaToolStripMenuItem1.Name = "kopyalaToolStripMenuItem1";
            this.kopyalaToolStripMenuItem1.Size = new System.Drawing.Size(144, 26);
            this.kopyalaToolStripMenuItem1.Text = "kopyala";
            this.kopyalaToolStripMenuItem1.Click += new System.EventHandler(this.kopyalaToolStripMenuItem1_Click);
            // 
            // yapıştırToolStripMenuItem1
            // 
            this.yapıştırToolStripMenuItem1.Name = "yapıştırToolStripMenuItem1";
            this.yapıştırToolStripMenuItem1.Size = new System.Drawing.Size(144, 26);
            this.yapıştırToolStripMenuItem1.Text = "yapıştır";
            this.yapıştırToolStripMenuItem1.Click += new System.EventHandler(this.yapıştırToolStripMenuItem1_Click);
            // 
            // görünümToolStripMenuItem
            // 
            this.görünümToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkaPlanRengiToolStripMenuItem,
            this.yazıTipiToolStripMenuItem});
            this.görünümToolStripMenuItem.Name = "görünümToolStripMenuItem";
            this.görünümToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.görünümToolStripMenuItem.Text = "görünüm";
            // 
            // arkaPlanRengiToolStripMenuItem
            // 
            this.arkaPlanRengiToolStripMenuItem.Name = "arkaPlanRengiToolStripMenuItem";
            this.arkaPlanRengiToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.arkaPlanRengiToolStripMenuItem.Text = "renk";
            this.arkaPlanRengiToolStripMenuItem.Click += new System.EventHandler(this.arkaPlanRengiToolStripMenuItem_Click);
            // 
            // yazıTipiToolStripMenuItem
            // 
            this.yazıTipiToolStripMenuItem.Name = "yazıTipiToolStripMenuItem";
            this.yazıTipiToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.yazıTipiToolStripMenuItem.Text = "yazı tipi";
            this.yazıTipiToolStripMenuItem.Click += new System.EventHandler(this.yazıTipiToolStripMenuItem_Click);
            // 
            // arkaPlanToolStripMenuItem
            // 
            this.arkaPlanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maviToolStripMenuItem,
            this.beyazToolStripMenuItem,
            this.pembeToolStripMenuItem,
            this.yeşilToolStripMenuItem});
            this.arkaPlanToolStripMenuItem.Name = "arkaPlanToolStripMenuItem";
            this.arkaPlanToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.arkaPlanToolStripMenuItem.Text = "Arka  plan ";
            // 
            // maviToolStripMenuItem
            // 
            this.maviToolStripMenuItem.Name = "maviToolStripMenuItem";
            this.maviToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.maviToolStripMenuItem.Text = "mavi";
            this.maviToolStripMenuItem.Click += new System.EventHandler(this.maviToolStripMenuItem_Click);
            // 
            // beyazToolStripMenuItem
            // 
            this.beyazToolStripMenuItem.Name = "beyazToolStripMenuItem";
            this.beyazToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.beyazToolStripMenuItem.Text = "beyaz";
            this.beyazToolStripMenuItem.Click += new System.EventHandler(this.beyazToolStripMenuItem_Click);
            // 
            // pembeToolStripMenuItem
            // 
            this.pembeToolStripMenuItem.Name = "pembeToolStripMenuItem";
            this.pembeToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.pembeToolStripMenuItem.Text = "pembe";
            this.pembeToolStripMenuItem.Click += new System.EventHandler(this.pembeToolStripMenuItem_Click);
            // 
            // yeşilToolStripMenuItem
            // 
            this.yeşilToolStripMenuItem.Name = "yeşilToolStripMenuItem";
            this.yeşilToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.yeşilToolStripMenuItem.Text = "yeşil";
            this.yeşilToolStripMenuItem.Click += new System.EventHandler(this.yeşilToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LavenderBlush;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1249, 27);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(537, 579);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1071, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.richTextBox2.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(797, 0);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(277, 55);
            this.richTextBox2.TabIndex = 10;
            this.richTextBox2.Text = "Not Defteri";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(909, 534);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 37);
            this.button2.TabIndex = 11;
            this.button2.Text = "sayfayı temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1249, 696);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dOSYAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bİÇİMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aYARLARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazıÇeşitleriToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem yeniDosyaToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem biçimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem görünümToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arkaPlanRengiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazıTipiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arkaPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beyazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pembeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeşilToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button2;
    }
}

