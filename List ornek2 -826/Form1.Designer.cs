namespace List_ornek2__826
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtKisi = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnSira = new System.Windows.Forms.Button();
            this.btnRemoveAt = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnArtan = new System.Windows.Forms.Button();
            this.btnazaltan = new System.Windows.Forms.Button();
            this.btnOgrenciSayisi = new System.Windows.Forms.Button();
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "kişi ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtKisi
            // 
            this.txtKisi.Location = new System.Drawing.Point(180, 27);
            this.txtKisi.Name = "txtKisi";
            this.txtKisi.Size = new System.Drawing.Size(100, 20);
            this.txtKisi.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(325, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(149, 251);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(12, 53);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(152, 37);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnSira
            // 
            this.btnSira.Location = new System.Drawing.Point(12, 96);
            this.btnSira.Name = "btnSira";
            this.btnSira.Size = new System.Drawing.Size(152, 41);
            this.btnSira.TabIndex = 4;
            this.btnSira.Text = "kaçıncı sıra";
            this.btnSira.UseVisualStyleBackColor = true;
            this.btnSira.Click += new System.EventHandler(this.btnSira_Click);
            // 
            // btnRemoveAt
            // 
            this.btnRemoveAt.Location = new System.Drawing.Point(12, 143);
            this.btnRemoveAt.Name = "btnRemoveAt";
            this.btnRemoveAt.Size = new System.Drawing.Size(152, 40);
            this.btnRemoveAt.TabIndex = 5;
            this.btnRemoveAt.Text = "RemoveAt ile silme";
            this.btnRemoveAt.UseVisualStyleBackColor = true;
            this.btnRemoveAt.Click += new System.EventHandler(this.btnRemoveAt_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(12, 189);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(152, 35);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove ile silme";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(12, 230);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(152, 36);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnArtan
            // 
            this.btnArtan.Location = new System.Drawing.Point(12, 272);
            this.btnArtan.Name = "btnArtan";
            this.btnArtan.Size = new System.Drawing.Size(152, 38);
            this.btnArtan.TabIndex = 8;
            this.btnArtan.Text = "artan sıralama";
            this.btnArtan.UseVisualStyleBackColor = true;
            this.btnArtan.Click += new System.EventHandler(this.btnArtan_Click);
            // 
            // btnazaltan
            // 
            this.btnazaltan.Location = new System.Drawing.Point(12, 316);
            this.btnazaltan.Name = "btnazaltan";
            this.btnazaltan.Size = new System.Drawing.Size(152, 37);
            this.btnazaltan.TabIndex = 9;
            this.btnazaltan.Text = "azalan sıralama";
            this.btnazaltan.UseVisualStyleBackColor = true;
            // 
            // btnOgrenciSayisi
            // 
            this.btnOgrenciSayisi.Location = new System.Drawing.Point(12, 359);
            this.btnOgrenciSayisi.Name = "btnOgrenciSayisi";
            this.btnOgrenciSayisi.Size = new System.Drawing.Size(152, 41);
            this.btnOgrenciSayisi.TabIndex = 10;
            this.btnOgrenciSayisi.Text = "5 harfli öğrenci sayısı";
            this.btnOgrenciSayisi.UseVisualStyleBackColor = true;
            this.btnOgrenciSayisi.Click += new System.EventHandler(this.btnOgrenciSayisi_Click);
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.Location = new System.Drawing.Point(12, 406);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(152, 39);
            this.btnOgrenci.TabIndex = 11;
            this.btnOgrenci.Text = "M harfli ile başlayan öğrenciler";
            this.btnOgrenci.UseVisualStyleBackColor = true;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(605, 505);
            this.Controls.Add(this.btnOgrenci);
            this.Controls.Add(this.btnOgrenciSayisi);
            this.Controls.Add(this.btnazaltan);
            this.Controls.Add(this.btnArtan);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnRemoveAt);
            this.Controls.Add(this.btnSira);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtKisi);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtKisi;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnSira;
        private System.Windows.Forms.Button btnRemoveAt;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnArtan;
        private System.Windows.Forms.Button btnazaltan;
        private System.Windows.Forms.Button btnOgrenciSayisi;
        private System.Windows.Forms.Button btnOgrenci;
    }
}

