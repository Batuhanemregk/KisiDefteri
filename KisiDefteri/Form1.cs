using System.Security.Cryptography;
using System.Windows.Forms;

namespace KisiDefteri
{
    public partial class Form1 : Form
    {
        List<Kisi> kisiler;
        public Form1()
        {
            InitializeComponent();
            kisiler = OrnekVerileriYukle();
            KisileriListele();
        }

        private void KisileriListele()
        {
            lstKisiler.Items.Clear();
            foreach (Kisi kisi in kisiler)
            {
                lstKisiler.Items.Add(kisi);
            }
        }

        private List<Kisi> OrnekVerileriYukle()
        {
            return
            new List<Kisi>()
              {
              new Kisi() { Ad = "Ali", Soyad = "Yýlmaz" },
              new Kisi() { Ad = "Can", Soyad = "Öztürk" },
              new Kisi() { Ad = "Cem", Soyad = "Þahin" },
              new Kisi() { Ad = "Ece", Soyad = "Doðan" }
              };
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Emin Misin", "Uyarý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int sid = lstKisiler.SelectedIndex;

                if (lstKisiler.SelectedIndex == null)
                {
                    MessageBox.Show("silinmesini istediðiniz kiþiyi seçiniz");
                    return;
                }

                Kisi k = (Kisi)lstKisiler.SelectedItem;
                kisiler.Remove(k);
                KisileriListele();
                lstKisiler.SelectedIndex = Math.Min(sid, lstKisiler.Items.Count - 1);
                //lstKisiler.SelectedIndex = sid - 1;

            }
            else if (dr == DialogResult.No)
            {
                return;
            }
            
            
        }
       
        private void btnYukari_Click(object sender, EventArgs e)
        {
            int sid = lstKisiler.SelectedIndex;
            if (sid < 1) return;

            SeciliyiTasi(sid - 1);
        }

        private void btnAsagi_Click(object sender, EventArgs e)
        {
            int sid = lstKisiler.SelectedIndex;
            if (sid == -1 || sid == lstKisiler.Items.Count - 1) return;

            SeciliyiTasi(sid + 1);
        }

        private void SeciliyiTasi(int yeniIndeks)
        {
            Kisi k = (Kisi)lstKisiler.SelectedItem!;
            kisiler.Remove(k);
            kisiler.Insert(yeniIndeks, k);
            KisileriListele();
            lstKisiler.SelectedItem = k;
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedIndex == null)
            {
                MessageBox.Show("düzenlemek istediðiniz kiþiyi seçiniz");
                return;
            }

            Kisi k = (Kisi)lstKisiler.SelectedItem;
            Duzenle frmDuzenle = new Duzenle(k);
            frmDuzenle.ShowDialog();
            KisileriListele();
            lstKisiler.SelectedItem = k;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lstKisiler_KeyDown(object sender, KeyEventArgs e)
        {
            //int sid = lstKisiler.SelectedIndex;

            if (e.KeyCode == Keys.Delete && lstKisiler.SelectedIndex >= 0)
            {
                btnSil.PerformClick();
                //btnSil_Click(sender, e);                
                //lstKisiler.SelectedIndex = sid - 1;
            }
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();

            if (ad == "" || soyad == "")
            {
                MessageBox.Show("Ad ve Soyad zorunlu");
            }

            Kisi k = new Kisi() { Ad = ad, Soyad = soyad };
            kisiler.Add(k);
            KisileriListele();
            lstKisiler.SelectedItem = k;
            txtAd.Clear();
            txtSoyad.Clear();
            txtAd.Focus();
        }
    }

}