namespace Pansiyon_Kayit_App
{
    partial class StokKontrolForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGida = new System.Windows.Forms.TextBox();
            this.txtAlkol = new System.Windows.Forms.TextBox();
            this.txtIcecekler = new System.Windows.Forms.TextBox();
            this.txtEt = new System.Windows.Forms.TextBox();
            this.txtTavuk = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.txtAtistir = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gıda Tutarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alkollü İçecekler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alkolsüz İçecekler";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Et Ürünleri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tavuk Ürünleri";
            // 
            // txtGida
            // 
            this.txtGida.Location = new System.Drawing.Point(262, 12);
            this.txtGida.Name = "txtGida";
            this.txtGida.Size = new System.Drawing.Size(100, 23);
            this.txtGida.TabIndex = 5;
            // 
            // txtAlkol
            // 
            this.txtAlkol.Location = new System.Drawing.Point(262, 41);
            this.txtAlkol.Name = "txtAlkol";
            this.txtAlkol.Size = new System.Drawing.Size(100, 23);
            this.txtAlkol.TabIndex = 6;
            // 
            // txtIcecekler
            // 
            this.txtIcecekler.Location = new System.Drawing.Point(262, 70);
            this.txtIcecekler.Name = "txtIcecekler";
            this.txtIcecekler.Size = new System.Drawing.Size(100, 23);
            this.txtIcecekler.TabIndex = 7;
            // 
            // txtEt
            // 
            this.txtEt.Location = new System.Drawing.Point(262, 99);
            this.txtEt.Name = "txtEt";
            this.txtEt.Size = new System.Drawing.Size(100, 23);
            this.txtEt.TabIndex = 8;
            // 
            // txtTavuk
            // 
            this.txtTavuk.Location = new System.Drawing.Point(262, 128);
            this.txtTavuk.Name = "txtTavuk";
            this.txtTavuk.Size = new System.Drawing.Size(100, 23);
            this.txtTavuk.TabIndex = 9;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(106, 222);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(288, 32);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.Location = new System.Drawing.Point(12, 260);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(475, 178);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Gıdalar";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Alkollü Içecekler";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Alkolsüz Içecekler";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Atıştırmalıklar";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Et Ürünleri";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tavuk Ürünleri";
            this.columnHeader6.Width = 80;
            // 
            // txtAtistir
            // 
            this.txtAtistir.Location = new System.Drawing.Point(262, 157);
            this.txtAtistir.Name = "txtAtistir";
            this.txtAtistir.Size = new System.Drawing.Size(100, 23);
            this.txtAtistir.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Atıştırmalıklar";
            // 
            // StokKontrolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(499, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAtistir);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtTavuk);
            this.Controls.Add(this.txtEt);
            this.Controls.Add(this.txtIcecekler);
            this.Controls.Add(this.txtAlkol);
            this.Controls.Add(this.txtGida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StokKontrolForm";
            this.Text = "StokKontrolForm";
            this.Load += new System.EventHandler(this.StokKontrolForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtGida;
        private TextBox txtAlkol;
        private TextBox txtIcecekler;
        private TextBox txtEt;
        private TextBox txtTavuk;
        private Button btnKaydet;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private TextBox txtAtistir;
        private Label label6;
    }
}