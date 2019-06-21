using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace OtomatProjesi
{
    public partial class OtomatProje : DevExpress.XtraEditors.XtraForm      //görünüşü güzelleştirmek için
    {
        public OtomatProje()
        {
            InitializeComponent();
        }
        List<TextBox> textboxlar = new List<TextBox>();       //array list içerisinde oluşturduğumuz textboxları tutuyoruz
        List<int> Xkonum = new List<int>();     //arama  işlemi yapmak için textboxların x eksenindeki lokasyonlarını tutuyoruz
        int ArananDeger; //aranacak değeri tuttuğumuz değişken
        int Txtkonum = 0, a = 0, arama = 0,txtsayisi=0;   
        bool Txtkontrol = false, bulundumu = false;
        private void btnTextSayisi_Click(object sender, EventArgs e)
        {
            btnSıfırla.Enabled = true;
            int TextboxSayisi = Convert.ToInt32(txtTextSayisi.Text); //girilen değeri değişkene atıyoruz

            for (int i = 0; i <TextboxSayisi+1; i++)//girilen sayı kadar textbox oluşturulur
            {
                if (i==0)//ilk değeri sabit başlangıç indisi yapıyorum 
                {
                    TextBox txt1 = new TextBox();
                    txt1.Location = new System.Drawing.Point(15 + Txtkonum, 130);
                    Xkonum.Add(15 + Txtkonum);

                    txt1.Size = new System.Drawing.Size(40, 40);
                    txt1.BackColor = Color.Red;
                    txt1.Font = new Font(txt1.Font, txt1.Font.Style ^ FontStyle.Bold);
                    txt1.Name = "" + i;
                    txt1.Text = "◊";
                    txt1.Enabled = false;

                    this.Controls.Add(txt1);
                    textboxlar.Add(txt1);
                    Txtkonum += 40;
                }
                else // textboxları sırasıyla oluşturuyoruz
                {
                    TextBox txt = new TextBox();
                    txt.Location = new System.Drawing.Point(15 + Txtkonum, 130);
                    Xkonum.Add(15 + Txtkonum); //aramada kullanacağımız için textboxun konumunu listeye atarız

                    txt.Size = new System.Drawing.Size(40, 40);
                    txt.BackColor = Color.Aqua;
                    txt.Font = new Font(txt.Font, txt.Font.Style ^ FontStyle.Bold);
                    txt.Name = "" + i;
                    txt.KeyPress += new KeyPressEventHandler(txtTextSayisi_KeyPress); //sadece integer sayı girilsin diye eventi oluşturduk
                    this.Controls.Add(txt); //textboxı forma ekledik
                    textboxlar.Add(txt);  // textboxı listeye ekledik
                    Txtkonum += 40;//texboxlar üst üste gelmesin diye konumunu her seferde arttırdık
                }
               
            }
            Okİsareti.Visible = true; //başlangıçta görünmesini istemedğimiz için gizledik
            Okİsareti.Location = new System.Drawing.Point(23, 152);
            btnTextSayisi.Enabled = false; //butonların tıklanmasını kapattık
            txtTextSayisi.Enabled = false;
            btnTuringOlustur.Visible = true;
            btnTuringOlustur.Visible = true;
        }

        private void txtTextSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//textboxa sadece sayı girilmesini sağlayan fonksiyonumuz
        }
//
        private void btnSıfırla_Click(object sender, EventArgs e)
        {//oluşturulan her şeyi silme butonu
            DialogResult secenek = MessageBox.Show("Makineyi Silmek İstiyor musunuz?", "Uyarı Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)//evet yanıtına tıklarsa oluşturulan her şeyi siliyoruz
            {
                foreach (TextBox item in textboxlar)
                {
                    this.Controls.Remove(item);//oluşturulan textboxlar siliniyor
                    item.Dispose();
                }
                //program ilk açıldığında açık olan butonlar hariç diğerleri gizleniyor
                //Değişkenler ve listeler sıfırlanıyor
                Txtkonum = 0;
                btnTextSayisi.Enabled = true;
                txtTextSayisi.Enabled = true;
                txtDegerAra.Text = "";
                Okİsareti.Visible = false;
                btnTuringOlustur.Visible = false;
                lblNot.Visible = false;
                lblNot2.Visible = false;
                txtDegerAra.Visible = false;
                BtnAra.Visible = false;
                lblAranan.Visible = false;
                lblOkunanDeger.Visible = false;
                a = 0;
                arama = 0;
                bulundumu = false;
                textboxlar.Clear();
                Xkonum.Clear();
                txtsayisi = 0;
                listBulunanlar.Items.Clear();
                listBulunanlar.Visible = false;
                btnOtomatYavaslat.Visible = false;
                btnOtomatHizlandir.Visible = false;
                timer1.Stop();
                txtTextSayisi.Text = "";
                txtTextSayisi.Focus();
                btnSıfırla.Enabled = false;
            }
           
        }

        private void txtTextSayisi_Leave(object sender, EventArgs e)
        {//boş değer girilmemesini ve girilen değerin 1-25 aralığında olmasını sağlıyoruz
             if (txtTextSayisi.Text == "")
            {
                MessageBox.Show("Değer 1-25 arasında olmalı");
                txtTextSayisi.Text = "";
                txtTextSayisi.Focus();
            }
            else if (Convert.ToInt32(txtTextSayisi.Text) < 1 || Convert.ToInt32(txtTextSayisi.Text) > 25)
            {
                MessageBox.Show("Değer 1-25 arasında olmalı");
                txtTextSayisi.Text = "";
                txtTextSayisi.Focus();
            }
           
        }

        private void btnTuringOlustur_Click(object sender, EventArgs e)
        {//textboxları doldurduktan sonra makineyi oluşturduğumuz buton
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {//tek tek textboxları geziyoruz
                    TextBox tbox = (TextBox)item;
                    if (tbox.Text=="")
                    {//varsa boş bırakılan textboxu gösteriyoruz
                        MessageBox.Show("" +(Convert.ToInt32(tbox.Name) + 1) + " Numaralı Bandı Boş bıraktınız!");
                        Txtkontrol = true;
                    }
                    else
                    
                    {
                        //bütün textboxlar doluysa listeye ekleyip tıklanmasını kapatıyoruz
                        tbox.Enabled = false;
                        textboxlar.Add(tbox);
                    }
                    
                }
            }
            if (Txtkontrol==false)
            {//boş textbox yok ise bir sonraki adımda kullanılacak butonları gösteriyoruz
                btnTuringOlustur.Visible = false;
                txtDegerAra.Visible = true;
                BtnAra.Visible = true;
            }
            btnOtomatHizlandir.Visible = true;
            btnOtomatYavaslat.Visible = true;
        }

        private void btnOtomatHizlandir_Click(object sender, EventArgs e)
        {
            timer1.Interval -= 250;//otomatin adımlarını hızlandırıyor
        }

        private void btnOtomatYavaslat_Click(object sender, EventArgs e)
        {
            timer1.Interval += 250;//otomatın adımlarını yavaşlatıyor
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {//textboxa girilen değeri makina da arıyoruz
            if (txtDegerAra.Text == "" || txtDegerAra.Text == null)
            {
                //boş ise uyarı verir
                MessageBox.Show("Düzgün Değer Giriniz");
                txtDegerAra.Text = "";
                txtDegerAra.Focus();
            }
            else
            {//arama işleminde kullanılacak butonlar açılır ve timer çalıştırılır.
                txtsayisi = textboxlar.Count;
                Okİsareti.Visible = true;
                listBulunanlar.Visible = true;
                lblNot.Visible = true;
                lblNot2.Visible = true;
                timer1.Enabled = true;
                timer1.Start();
                ArananDeger = Convert.ToInt32(txtDegerAra.Text);
                lblAranan.Visible = true;
                lblAranan.Text = "Aranan Değer : " + ArananDeger.ToString();
                lblOkunanDeger.Visible = true;
                arama = 1;
            }
            
        }
        private void txtDegerAra_KeyPress(object sender, KeyPressEventArgs e)
        {//textboxa sadece int değer girilmesini sağlayan fonksiyon
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
//
        private void timer1_Tick(object sender, EventArgs e)
        {//belirli bir süre içerisinde makinenin adımlarının ilerletildiği ve aramanın yapıldığı bölüm
            if (a<=Xkonum.Count-1)//son elemana kadar bu işlemler gerçekleşecek aksi takdirde timer durmaz
            {
                Okİsareti.Visible = true;//Turing Makinesinin kafası
                if (a>1)
                {//Turing makinesinde ◊ sembolü ile yer değiştirerek makinenin kafasına getirme işlemi
                    textboxlar[0].Location = new System.Drawing.Point(Xkonum[a], 130);
                    textboxlar[a].Location = new System.Drawing.Point(Xkonum[a-1], 130);
                    Okİsareti.Location = new System.Drawing.Point(Xkonum[a-1] + 8, 152);
                }
                else
                {//Turing makinesinde ◊ sembolünün yerinin belirtilmesi
                    textboxlar[0].Location = new System.Drawing.Point(Xkonum[1], 130);
                    textboxlar[1].Location = new System.Drawing.Point(Xkonum[0], 130);
                }
                    
                    lblOkunanDeger.Text = "Okunan Deger : " + textboxlar[a].Text;

                if (a != 0)
                {
                    if (Convert.ToInt32(textboxlar[a].Text) == ArananDeger)
                    {//Kafadaki değer aranan değer ise Listeye ekliyoruz
                        textboxlar[a].BackColor = Color.DarkCyan;
                        listBulunanlar.Items.Add("" + ArananDeger + " Değeri " + a + ".adımda bulundu!");
                        bulundumu = true;

                    }
                }
                
                if (a == Xkonum.Count - 1 && Convert.ToInt32(textboxlar[a].Text) != ArananDeger)
                {//Makinenin son elemanı için yapılan kontrollerin olduğu kısım
                    if (bulundumu == false)
                    {
                        listBulunanlar.Items.Add("Aranan Değer Bulunamadı!.");
                        //makinenin sonuna ulaşılıp değer bulunmadıysa bulunamadı yazılması...
                    }
                    if (arama == 1)
                    {//Makinenin sonuna ulaşıldıktan sonra kafayı başa alma ve textboxları ilk haline döndürme işlemi
                        a = 0;
                        Okİsareti.Location = new System.Drawing.Point(Xkonum[a] + 8, 152);
                        txtsayisi = (textboxlar.Count - 2) / 2;
                        for (int i = 0; i <= txtsayisi; i++)
                        {
                        
                            textboxlar[i].Location = new System.Drawing.Point(Xkonum[i], 130);
                        }
                        txtDegerAra.Focus();
                        foreach (var item in textboxlar)
                        {
                            if (item.Text== "◊")
                            {
                                item.BackColor = Color.Red;
                            }
                            else
                            {

                                item.BackColor = Color.Aqua;
                            }
                        }
                        
                    }
                timer1.Stop();
                }
                a++;
            }
           
        }
    }
}