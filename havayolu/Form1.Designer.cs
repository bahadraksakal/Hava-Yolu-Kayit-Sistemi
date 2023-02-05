namespace havayolu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mySqlConnection1 = new MySqlConnector.MySqlConnection();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idbilet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.koltukno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iducak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.havayolu_isim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayit_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hareket_yeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varis_yeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hareket_tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varis_tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iducus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Secim = new System.Windows.Forms.DataGridViewButtonColumn();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.islemtarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.koltukno2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucret2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tur2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayit_no2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.havasirketi_isim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hareket_yeri2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varis_yeri2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hareket_tarihi2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varis_tarihi2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // mySqlConnection1
            // 
            this.mySqlConnection1.ConnectionString = "server=localhost;port=3306;database=havayoludb;uid=root;";
            this.mySqlConnection1.ProvideClientCertificatesCallback = null;
            this.mySqlConnection1.ProvidePasswordCallback = null;
            this.mySqlConnection1.RemoteCertificateValidationCallback = null;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "test durumu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(38, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1412, 779);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(719, 302);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(559, 445);
            this.panel2.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(202, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 31);
            this.button3.TabIndex = 15;
            this.button3.Text = "Kaydet Ve Bileti Al";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(305, 118);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(234, 68);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox6.Location = new System.Drawing.Point(305, 268);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(140, 28);
            this.textBox6.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox5.Location = new System.Drawing.Point(305, 208);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(140, 28);
            this.textBox5.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(14, 346);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(140, 28);
            this.textBox4.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(16, 259);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 28);
            this.textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(16, 191);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 28);
            this.textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(14, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 28);
            this.textBox1.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(302, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "Hes Kodu";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(302, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(302, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Adres";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Cinsiyet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Yaş";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Soy İsim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "İsim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(149, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 44);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yolcu Bilgileri";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.idbilet,
            this.koltukno,
            this.ucret,
            this.button});
            this.dataGridView2.Location = new System.Drawing.Point(23, 346);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(595, 195);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "iducak";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // idbilet
            // 
            this.idbilet.HeaderText = "idbilet";
            this.idbilet.MinimumWidth = 6;
            this.idbilet.Name = "idbilet";
            this.idbilet.ReadOnly = true;
            this.idbilet.Visible = false;
            this.idbilet.Width = 125;
            // 
            // koltukno
            // 
            this.koltukno.HeaderText = "Koltuk Numarası";
            this.koltukno.MinimumWidth = 6;
            this.koltukno.Name = "koltukno";
            this.koltukno.ReadOnly = true;
            this.koltukno.Width = 125;
            // 
            // ucret
            // 
            this.ucret.HeaderText = "Ücret";
            this.ucret.MinimumWidth = 6;
            this.ucret.Name = "ucret";
            this.ucret.ReadOnly = true;
            this.ucret.Width = 125;
            // 
            // button
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.NullValue = "Seçiniz";
            this.button.DefaultCellStyle = dataGridViewCellStyle15;
            this.button.HeaderText = "Buton";
            this.button.MinimumWidth = 6;
            this.button.Name = "button";
            this.button.Width = 125;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iducak,
            this.tur,
            this.havayolu_isim,
            this.kayit_no,
            this.hareket_yeri,
            this.varis_yeri,
            this.hareket_tarihi,
            this.varis_tarihi,
            this.iducus,
            this.Secim});
            this.dataGridView1.Location = new System.Drawing.Point(23, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1386, 195);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // iducak
            // 
            this.iducak.HeaderText = "iducak";
            this.iducak.MinimumWidth = 6;
            this.iducak.Name = "iducak";
            this.iducak.ReadOnly = true;
            this.iducak.Visible = false;
            this.iducak.Width = 125;
            // 
            // tur
            // 
            this.tur.HeaderText = "Uçak Türü";
            this.tur.MinimumWidth = 6;
            this.tur.Name = "tur";
            this.tur.ReadOnly = true;
            this.tur.Width = 125;
            // 
            // havayolu_isim
            // 
            this.havayolu_isim.HeaderText = "Hava Yolu Firması";
            this.havayolu_isim.MinimumWidth = 6;
            this.havayolu_isim.Name = "havayolu_isim";
            this.havayolu_isim.ReadOnly = true;
            this.havayolu_isim.Width = 125;
            // 
            // kayit_no
            // 
            this.kayit_no.HeaderText = "Kayıt Numarası";
            this.kayit_no.MinimumWidth = 6;
            this.kayit_no.Name = "kayit_no";
            this.kayit_no.ReadOnly = true;
            this.kayit_no.Width = 125;
            // 
            // hareket_yeri
            // 
            this.hareket_yeri.HeaderText = "Hareket Yeri";
            this.hareket_yeri.MinimumWidth = 6;
            this.hareket_yeri.Name = "hareket_yeri";
            this.hareket_yeri.ReadOnly = true;
            this.hareket_yeri.Width = 125;
            // 
            // varis_yeri
            // 
            this.varis_yeri.HeaderText = "Varış Yeri";
            this.varis_yeri.MinimumWidth = 6;
            this.varis_yeri.Name = "varis_yeri";
            this.varis_yeri.ReadOnly = true;
            this.varis_yeri.Width = 125;
            // 
            // hareket_tarihi
            // 
            this.hareket_tarihi.HeaderText = "Hareket Tarihi";
            this.hareket_tarihi.MinimumWidth = 6;
            this.hareket_tarihi.Name = "hareket_tarihi";
            this.hareket_tarihi.ReadOnly = true;
            this.hareket_tarihi.Width = 125;
            // 
            // varis_tarihi
            // 
            this.varis_tarihi.HeaderText = "Varış Tarihi";
            this.varis_tarihi.MinimumWidth = 6;
            this.varis_tarihi.Name = "varis_tarihi";
            this.varis_tarihi.ReadOnly = true;
            this.varis_tarihi.Width = 125;
            // 
            // iducus
            // 
            this.iducus.HeaderText = "iducus";
            this.iducus.MinimumWidth = 6;
            this.iducus.Name = "iducus";
            this.iducus.ReadOnly = true;
            this.iducus.Visible = false;
            this.iducus.Width = 125;
            // 
            // Secim
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.NullValue = "Seç";
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.Secim.DefaultCellStyle = dataGridViewCellStyle16;
            this.Secim.HeaderText = "Buton";
            this.Secim.MinimumWidth = 6;
            this.Secim.Name = "Secim";
            this.Secim.Text = "Seç";
            this.Secim.Width = 125;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(216, 41);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(141, 24);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Seçiniz...";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Varış Yeri";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kalkış Yeri";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(388, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Bilet Alan Yolcular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(302, 327);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "Tc No";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox7.Location = new System.Drawing.Point(305, 346);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(140, 28);
            this.textBox7.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.dataGridView3);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(118, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1271, 642);
            this.panel3.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(412, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(436, 44);
            this.label13.TabIndex = 1;
            this.label13.Text = "Bilet Alan Yolcu Bilgileri";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.islemtarihi,
            this.isim,
            this.soyisim,
            this.cinsiyet,
            this.tcno,
            this.koltukno2,
            this.ucret2,
            this.tur2,
            this.kayit_no2,
            this.havasirketi_isim,
            this.hareket_yeri2,
            this.varis_yeri2,
            this.hareket_tarihi2,
            this.varis_tarihi2});
            this.dataGridView3.Location = new System.Drawing.Point(37, 133);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1200, 458);
            this.dataGridView3.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(1210, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 41);
            this.button4.TabIndex = 7;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // islemtarihi
            // 
            this.islemtarihi.HeaderText = "İşlem Tarihi";
            this.islemtarihi.MinimumWidth = 6;
            this.islemtarihi.Name = "islemtarihi";
            this.islemtarihi.ReadOnly = true;
            this.islemtarihi.Width = 125;
            // 
            // isim
            // 
            this.isim.HeaderText = "İsim";
            this.isim.MinimumWidth = 6;
            this.isim.Name = "isim";
            this.isim.ReadOnly = true;
            this.isim.Width = 125;
            // 
            // soyisim
            // 
            this.soyisim.HeaderText = "Soyisim";
            this.soyisim.MinimumWidth = 6;
            this.soyisim.Name = "soyisim";
            this.soyisim.ReadOnly = true;
            this.soyisim.Width = 125;
            // 
            // cinsiyet
            // 
            this.cinsiyet.HeaderText = "Cinsiyet";
            this.cinsiyet.MinimumWidth = 6;
            this.cinsiyet.Name = "cinsiyet";
            this.cinsiyet.ReadOnly = true;
            this.cinsiyet.Width = 125;
            // 
            // tcno
            // 
            this.tcno.HeaderText = "Tc Numarası";
            this.tcno.MinimumWidth = 6;
            this.tcno.Name = "tcno";
            this.tcno.ReadOnly = true;
            this.tcno.Width = 125;
            // 
            // koltukno2
            // 
            this.koltukno2.HeaderText = "Koltuk Numarası";
            this.koltukno2.MinimumWidth = 6;
            this.koltukno2.Name = "koltukno2";
            this.koltukno2.ReadOnly = true;
            this.koltukno2.Width = 125;
            // 
            // ucret2
            // 
            this.ucret2.HeaderText = "Bilet Fiyatı";
            this.ucret2.MinimumWidth = 6;
            this.ucret2.Name = "ucret2";
            this.ucret2.ReadOnly = true;
            this.ucret2.Width = 125;
            // 
            // tur2
            // 
            this.tur2.HeaderText = "Uçak Türü";
            this.tur2.MinimumWidth = 6;
            this.tur2.Name = "tur2";
            this.tur2.ReadOnly = true;
            this.tur2.Width = 125;
            // 
            // kayit_no2
            // 
            this.kayit_no2.HeaderText = "Kayıt No";
            this.kayit_no2.MinimumWidth = 6;
            this.kayit_no2.Name = "kayit_no2";
            this.kayit_no2.ReadOnly = true;
            this.kayit_no2.Width = 125;
            // 
            // havasirketi_isim
            // 
            this.havasirketi_isim.HeaderText = "Hava Yolu Şirketi";
            this.havasirketi_isim.MinimumWidth = 6;
            this.havasirketi_isim.Name = "havasirketi_isim";
            this.havasirketi_isim.ReadOnly = true;
            this.havasirketi_isim.Width = 125;
            // 
            // hareket_yeri2
            // 
            this.hareket_yeri2.HeaderText = "Hareket Yeri";
            this.hareket_yeri2.MinimumWidth = 6;
            this.hareket_yeri2.Name = "hareket_yeri2";
            this.hareket_yeri2.ReadOnly = true;
            this.hareket_yeri2.Width = 125;
            // 
            // varis_yeri2
            // 
            this.varis_yeri2.HeaderText = "Varış Yeri";
            this.varis_yeri2.MinimumWidth = 6;
            this.varis_yeri2.Name = "varis_yeri2";
            this.varis_yeri2.ReadOnly = true;
            this.varis_yeri2.Width = 125;
            // 
            // hareket_tarihi2
            // 
            this.hareket_tarihi2.HeaderText = "Hareket Tarihi";
            this.hareket_tarihi2.MinimumWidth = 6;
            this.hareket_tarihi2.Name = "hareket_tarihi2";
            this.hareket_tarihi2.ReadOnly = true;
            this.hareket_tarihi2.Width = 125;
            // 
            // varis_tarihi2
            // 
            this.varis_tarihi2.HeaderText = "Varış Tarihi";
            this.varis_tarihi2.MinimumWidth = 6;
            this.varis_tarihi2.Name = "varis_tarihi2";
            this.varis_tarihi2.ReadOnly = true;
            this.varis_tarihi2.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 850);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MySqlConnector.MySqlConnection mySqlConnection1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbilet;
        private System.Windows.Forms.DataGridViewTextBoxColumn koltukno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucret;
        private System.Windows.Forms.DataGridViewButtonColumn button;
        private System.Windows.Forms.DataGridViewTextBoxColumn iducak;
        private System.Windows.Forms.DataGridViewTextBoxColumn tur;
        private System.Windows.Forms.DataGridViewTextBoxColumn havayolu_isim;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayit_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn hareket_yeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn varis_yeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn hareket_tarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn varis_tarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn iducus;
        private System.Windows.Forms.DataGridViewButtonColumn Secim;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemtarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn isim;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyisim;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcno;
        private System.Windows.Forms.DataGridViewTextBoxColumn koltukno2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucret2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tur2;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayit_no2;
        private System.Windows.Forms.DataGridViewTextBoxColumn havasirketi_isim;
        private System.Windows.Forms.DataGridViewTextBoxColumn hareket_yeri2;
        private System.Windows.Forms.DataGridViewTextBoxColumn varis_yeri2;
        private System.Windows.Forms.DataGridViewTextBoxColumn hareket_tarihi2;
        private System.Windows.Forms.DataGridViewTextBoxColumn varis_tarihi2;
    }
}

