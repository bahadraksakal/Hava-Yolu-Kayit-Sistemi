using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace havayolu
{
    public partial class Form1 : Form
    {
        public string secilenHaraketYeri;
        public string secilenVarisYeri;
        public int secilenIdUcak;
        public int secilenIdUcus;
        public int secilenIdBilet;
        public int yolcuid;
        public Form1()
        {
            InitializeComponent();
            kalkisYerleriCek();
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }
        public void kalkisYerleriCek()
        {
            try
            {
                mySqlConnection1.Open();
                MySqlCommand command = mySqlConnection1.CreateCommand();
                command.CommandText = "SELECT hareket_yeri FROM ucus group by hareket_yeri;";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string hareket_yeri = reader.GetString(0);
                    comboBox1.Items.Add(hareket_yeri);

                }
                mySqlConnection1.Close();
            }
            catch
            {
                Console.WriteLine(" kalkisYerleriCek-Hata ");
            }
        }
        public void VarisYerleriCek()
        {
            try
            {
                mySqlConnection1.Open();
                MySqlCommand command = mySqlConnection1.CreateCommand();
                command.CommandText = "SELECT varis_yeri FROM ucus where hareket_yeri=@hareket_yeri group by varis_yeri;";
                command.Parameters.AddWithValue("@hareket_yeri", secilenHaraketYeri);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string hareket_yeri = reader.GetString(0);
                    comboBox2.Items.Add(hareket_yeri);
                   

                }
                mySqlConnection1.Close();
            }
            catch
            {
                Console.WriteLine(" VarisYerleriCek-Hata ");
            }
        }
        public void ucaklarCek()
        {
            try
            {
                mySqlConnection1.Open();
                MySqlCommand command = mySqlConnection1.CreateCommand();
                command.CommandText = "SELECT ucak.iducak,tur,havayolu_sirketi.isim as \"havayolu_isim\",kayit_no,hareket_yeri,varis_yeri,hareket_tarihi,varis_tarihi,ucus.iducus " +
                    "FROM (((((ucak inner join ucak_has_hava_alani on ucak.iducak = ucak_has_hava_alani.iducak)" +
                    "inner join havayolu_sirketi on ucak.havasirketi_id=havayolu_sirketi.idhavayolu_sirketi)" +
                    "inner join hava_alani on ucak_has_hava_alani.idhava_alani = hava_alani.idhava_alani)" +
                    "inner join ucak_has_ucus on ucak.iducak=ucak_has_ucus.iducak)" +
                    "inner join ucus on ucak_has_ucus.iducus=ucus.iducus)" +
                    "where hareket_yeri=@hareket_yeri and varis_yeri=@varis_yeri;";
                command.Parameters.AddWithValue("@hareket_yeri", secilenHaraketYeri);
                command.Parameters.AddWithValue("@varis_yeri", secilenVarisYeri);
                MySqlDataReader reader = command.ExecuteReader();
                int i = 0;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                while (reader.Read())
                {

                    dataGridView1.Rows.Add();
                    int iducak = reader.GetInt32(0);
                    string tur = reader.GetString(1);
                    string havayolu_isim = reader.GetString(2);
                    int kayit_no = reader.GetInt32(3);
                    string hareket_yeri = reader.GetString(4); 
                    string varis_yeri = reader.GetString(5);
                    DateTime hareket_tarihi = reader.GetDateTime(6);
                    DateTime varis_tarihi = reader.GetDateTime(7);
                    int iducus = reader.GetInt32(8);
                    dataGridView1.Rows[i].Cells[0].Value = iducak;
                    dataGridView1.Rows[i].Cells[1].Value = tur;
                    dataGridView1.Rows[i].Cells[2].Value = havayolu_isim;
                    dataGridView1.Rows[i].Cells[3].Value = kayit_no;
                    dataGridView1.Rows[i].Cells[4].Value = hareket_yeri;
                    dataGridView1.Rows[i].Cells[5].Value = varis_yeri;
                    dataGridView1.Rows[i].Cells[6].Value = hareket_tarihi;
                    dataGridView1.Rows[i].Cells[7].Value = varis_tarihi;
                    dataGridView1.Rows[i].Cells[8].Value = iducus;
                    i++;
                    

                }
                mySqlConnection1.Close();
            }
            catch
            {
                Console.WriteLine(" ucaklarCek-Hata ");
            }
        }
        public void biletlerCek()
        {
            try
            {
                mySqlConnection1.Open();
                MySqlCommand command = mySqlConnection1.CreateCommand();
                command.CommandText = "select ucak.iducak,bilet.idbilet,bilet.koltukno,bilet.ucret from"+
                    "((ucak inner join ucak_has_bilet on ucak.iducak = ucak_has_bilet.iducak)"+
                    "inner join bilet on bilet.idbilet=ucak_has_bilet.idbilet)"+
                    "where ucak.iducak=@iducak;";
                command.Parameters.AddWithValue("@iducak", secilenIdUcak);
                MySqlDataReader reader = command.ExecuteReader();
                int i = 0;
                dataGridView2.Rows.Clear();
                dataGridView2.Refresh();
                while (reader.Read())
                {

                    dataGridView2.Rows.Add();
                    int iducak = reader.GetInt32(0);
                    int idbilet = reader.GetInt32(1);
                    int koltukno = reader.GetInt32(2);
                    double ucret = reader.GetDouble(3);
                    dataGridView2.Rows[i].Cells[0].Value = iducak;
                    dataGridView2.Rows[i].Cells[1].Value = idbilet;
                    dataGridView2.Rows[i].Cells[2].Value = koltukno;
                    dataGridView2.Rows[i].Cells[3].Value = ucret;
                    i++;
                }
                mySqlConnection1.Close();
            }
            catch
            {
                Console.WriteLine(" biletlerCek-Hata ");
            }
        }
        public void yolcuKayit(string isim,string soyisim,int yas,string cinsiyet,string adres,string email,string heskodu,string tcno)
        {
            try
            {
                mySqlConnection1.Open();
                MySqlCommand command = mySqlConnection1.CreateCommand();
                command.CommandText = "INSERT INTO `yolcu` "+
                    "(`isim`, `soyisim`, `yas`, `cinsiyet`, `adres`, `email`, `heskodu`, `tcno`) " +
                    "VALUES (@isim, @soyisim, @yas , @cinsiyet, @adres, @email, @heskodu, @tcno );";
                command.Parameters.AddWithValue("@isim", isim);
                command.Parameters.AddWithValue("@soyisim", soyisim);
                command.Parameters.AddWithValue("@yas", yas);
                command.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                command.Parameters.AddWithValue("@adres", adres);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@heskodu", heskodu);
                command.Parameters.AddWithValue("@tcno", tcno); //command 1

                MySqlCommand command2 = mySqlConnection1.CreateCommand();
                command2.CommandText = "SELECT count(idyolcu) FROM yolcu where tcno=@tcno;";
                command2.Parameters.AddWithValue("@tcno", tcno);
                int adet = -1;
                using (MySqlDataReader reader = command2.ExecuteReader()) {
                    
                    while (reader.Read())
                    {
                        adet = reader.GetInt32(0);

                    }
                }
                if (adet != 0)
                {
                    yolcuKayitAsama2(tcno);
                    string uyari = "bu tc ile daha önceden kayıt olunmuştur.\nKayıt açma işlemi atlandı.\nBiletiniz başarıyla alınmıştır !";
                    MessageBox.Show(uyari, "TC NO UYARI");
                    mySqlConnection1.Close();
                    return;
                }
                command.ExecuteNonQuery();
                yolcuKayitAsama2(tcno);
                string bilgi = "başarıyla kayıt oldunuz.\nBiletiniz başarıyla alınmıştır !";
                MessageBox.Show(bilgi, "Başarılı");
                //tabloyu değiştir
                //ucus bilgisi 
                //ucak id
                //yolcuya ekle
                //MySqlCommand command2 = mySqlConnection1.CreateCommand();
                //command2.CommandText = "INSERT INTO `ucus_has_yolcu` (`idyolcu`, `iducus`) "+ 
                //    "VALUES ( @idyolcu , @iducus);";
                //command2.Parameters.AddWithValue("@idyolcu", idbilet);
                //command2.Parameters.AddWithValue("@idbilet", idbilet);
                //command2.ExecuteNonQuery();
                mySqlConnection1.Close();
            }
            catch
            {
                Console.WriteLine(" yolcuKayit-Hata ");
            }
        }
        public void yolcuKayitAsama2(string tcno)
        {
            // iş tablosuna ekleme yap

            MySqlCommand command3 = mySqlConnection1.CreateCommand();
            command3.CommandText = "select * from yolcu where tcno=@tcno;";
            command3.Parameters.AddWithValue("@tcno", tcno);
            //MessageBox.Show("tcno:" + tcno, "5");
            MySqlDataReader reader2 = command3.ExecuteReader();
            //Console.WriteLine(reader2.GetInt32(0).ToString());
            //MessageBox.Show("reader2 basarili", "onay");
            while (reader2.Read())
            {
                yolcuid = reader2.GetInt32(0);
                //MessageBox.Show("yolcuid:" + yolcuid, "3");
            }
            reader2.Close();

            MySqlCommand command4 = mySqlConnection1.CreateCommand();
            command4.CommandText = "INSERT INTO `ucus_has_yolcu` (`idyolcu`, `iducus`, `iducak`, `idbilet`) " +
                "VALUES (@idyolcu,@iducus,@iducak,@idbilet);";
            command4.Parameters.AddWithValue("@idyolcu", yolcuid);
            command4.Parameters.AddWithValue("@iducus", secilenIdUcus);
            command4.Parameters.AddWithValue("@iducak", secilenIdUcak);
            command4.Parameters.AddWithValue("@idbilet", secilenIdBilet);
            command4.ExecuteNonQuery();
        }
        public void biletAlanYolculariCek()
        {
            try
            {
                mySqlConnection1.Open();
                MySqlCommand command = mySqlConnection1.CreateCommand();
                command.CommandText = "select " +
                                    "ucus_has_yolcu.islem_tarihi," +
                                    "yolcu.isim,yolcu.soyisim,yolcu.cinsiyet,yolcu.tcno," +
                                    "bilet.koltukno,bilet.ucret," +
                                    "ucak.tur,ucak.kayit_no," +
                                    "havayolu_sirketi.isim as \"havayolu_isim\" ," +
                                    "ucus.hareket_yeri,ucus.varis_yeri,ucus.hareket_tarihi,ucus.varis_tarihi " +
                                    "from (((((ucus_has_yolcu " +
                                    "inner join yolcu on ucus_has_yolcu.idyolcu=yolcu.idyolcu) " +
                                    "inner join bilet on ucus_has_yolcu.idbilet=bilet.idbilet) " +
                                    "inner join ucak on ucus_has_yolcu.iducak=ucak.iducak) " +
                                    "inner join havayolu_sirketi on ucak.havasirketi_id=havayolu_sirketi.idhavayolu_sirketi) " +
                                    "inner join ucus on ucus_has_yolcu.iducus=ucus.iducus) order by ucus_has_yolcu.islem_tarihi desc; ";
                MySqlDataReader reader = command.ExecuteReader();
                int i = 0;
                dataGridView3.Rows.Clear();
                dataGridView3.Refresh();
                while (reader.Read())
                {

                    dataGridView3.Rows.Add();
                    dataGridView3.Rows[i].Cells[0].Value = reader.GetDateTime(0);
                    dataGridView3.Rows[i].Cells[1].Value = reader.GetString(1);
                    dataGridView3.Rows[i].Cells[2].Value = reader.GetString(2);
                    dataGridView3.Rows[i].Cells[3].Value = reader.GetString(3);
                    dataGridView3.Rows[i].Cells[4].Value = reader.GetString(4);
                    dataGridView3.Rows[i].Cells[5].Value = reader.GetInt32(5);
                    dataGridView3.Rows[i].Cells[6].Value = reader.GetDouble(6);
                    dataGridView3.Rows[i].Cells[7].Value = reader.GetString(7);
                    dataGridView3.Rows[i].Cells[8].Value = reader.GetInt32(8);
                    dataGridView3.Rows[i].Cells[9].Value = reader.GetString(9);
                    dataGridView3.Rows[i].Cells[10].Value = reader.GetString(10);
                    dataGridView3.Rows[i].Cells[11].Value = reader.GetString(11);
                    dataGridView3.Rows[i].Cells[12].Value = reader.GetDateTime(12);
                    dataGridView3.Rows[i].Cells[13].Value = reader.GetDateTime(13);
                    i++;
                }
                reader.Close();
                mySqlConnection1.Close();
            }
            catch
            {
                Console.WriteLine(" biletalanyolculariCek-Hata ");
            }
        }
        public bool test()
        {
            try
            {
                mySqlConnection1.Open();                           

                mySqlConnection1.Close();

                return true;
            }
            catch
            {
                Console.WriteLine("Hata");
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (test())
            {
                label1.Text = "Bağlantı kuruldu.";
            }
            else
            {
                label1.Text = "Bağlantı kurulamadı.";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            secilenHaraketYeri=comboBox1.SelectedItem.ToString();
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            panel2.Visible = false;
            VarisYerleriCek();
            comboBox2.Text = "Seçiniz...";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           secilenVarisYeri = comboBox2.SelectedItem.ToString();
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            panel2.Visible = false;
            ucaklarCek();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenIdUcak = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            secilenIdUcus = Convert.ToInt32(dataGridView1.CurrentRow.Cells[8].Value.ToString());
            //MessageBox.Show(secilenIdUcus.ToString(), "test");
            dataGridView2.Visible = true;
            panel2.Visible = false;
            biletlerCek();

            //MessageBox.Show(secilenIdUcak.ToString(), "iducus");
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenIdBilet = Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value.ToString());
            panel2.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string isim=textBox1.Text;
            string soyisim=textBox2.Text;
            string yasSTR=textBox3.Text;
            int yas=-1;
            try
            {
                yas = Convert.ToInt32(yasSTR);
            }
            catch (FormatException)
            {
                MessageBox.Show("yaş kısmına sayı giriniz!", "Hata");
                return;
            }            
            string cinsiyet=textBox4.Text;
            string adress= richTextBox1.Text;
            string email = textBox5.Text;
            string heskodu = textBox6.Text;
            string tcno=textBox7.Text;

            yolcuKayit(isim,soyisim,yas,cinsiyet,adress,email,heskodu,tcno);
            dataGridView2.Visible = false;
            dataGridView1.Visible = false;
            panel2.Visible = false;
            //kaydet ve bileti al
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible=false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            biletAlanYolculariCek();
        }
    }
}
//MySqlCommand command = mySqlConnection1.CreateCommand();   
//for (int i = 1; i <= 8; i++)
//{
//    for (int j = 1; j <= 14; j++)

//    {

//        string Query = "INSERT INTO `ucak_has_bilet` (`iducak`, `idbilet`) VALUES(" + i + ", " + j + ");";

//        command.CommandText = Query;
//        command.ExecuteNonQuery();

//        Console.WriteLine("test j-2:");
//        command.CommandText = "INSERT INTO `ucak_has_bilet` (`iducak`, `idbilet`) VALUES(" + i + ", " + j + ");";
//        Console.WriteLine(command.CommandText.ToString());
//        command.ExecuteNonQuery();
//        Console.WriteLine("test j-3:");

//    }
//}