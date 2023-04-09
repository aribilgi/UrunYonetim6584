using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrunYonetim6584.BL;
using UrunYonetim6584.Entities;

namespace UrunYonetim6584.WinFormUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Repository<User> repository = new Repository<User>();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Kullanıcı Adı ve Şifre Boş Geçilemez!");
                return;
            }
            var hesap = repository.Get(u => u.IsActive == true && u.IsAdmin && u.Username == txtKullaniciAdi.Text && u.Password == txtSifre.Text); // repository deki get metodu parametre olarak lambda expression alıyor. Lambda expression yazımı x=> veya u=> vb şeklindedir ve buradaki u veya x bizim verdiğimiz bir değişken ismidir, istediğimiz gibi isim verebiliriz. Bu verdiğimiz isim artık hangi nesneyi kast etmişsek o nesne oluyor. Bu örnekteki u => dedikten sonra artık buradaki u nesnesi bir user nesnesine dönüşüyor tıpkı var anahtar kelimesiyle değişken tanımlamadaki gibi. u.IsActive, u.IsAdmin vb ise bu user nesnesinin içindeki property ler oluyor. ve biz repository üzerinden veritabanına erişip ekrandan aldığımız kullanıcı adı, şifre ile birlikte kendi eklediğimiz isadmin, isactive alanları eşleşen bir kayıt var mı bunu sorguluyoruz. Eğer veritabanında bu şartlara uyan 1 kayıt varsa kullanıcıya giriş yetkisi vereceğiz, yoksa mesajla uyaracağız.
            if (hesap != null) // eğer bu şartlarda bir kayıt varsa
            {
                this.Hide(); // login ekranını gizle
                Main main = new Main(); // ana ekranı aç
                main.Show(); // ana ekranı göster
            }
            else
            {
                MessageBox.Show("Kullanıcı Bulunamadı!");
            }
        }
    }
}
