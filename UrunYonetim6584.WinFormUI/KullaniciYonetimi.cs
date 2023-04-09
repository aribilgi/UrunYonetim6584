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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace UrunYonetim6584.WinFormUI
{
    public partial class KullaniciYonetimi : Form
    {
        public KullaniciYonetimi()
        {
            InitializeComponent();
        }
        Repository<User> repository = new Repository<User>(); // Repository üzerinden veritabanı işlemleri yapabilmek için önce bunu tanımlıyoruz.
        private void KullaniciYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        void Yukle()
        {
            dgvKullanicilar.DataSource = repository.GetAll();
            tabControl1.SelectedTab = tabPage1;
            Temizle();
        }
        void Temizle()
        {
            var nesneler = groupBox1.Controls.OfType<TextBox>();
            foreach (var item in nesneler) // bu nesnelerde dön
            {
                item.Clear(); // her nesneyi temizle
            }
            cbIsActive.Checked = false;
            cbIsAdmin.Checked = false;
            btnEkle.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Adı Alanı Boş Geçilemez!");
                return;
            }
            var kullanici = new User()
            {
                CreateDate = DateTime.Now,
                Email = txtEmail.Text,
                IsActive = cbIsActive.Checked,
                IsAdmin = cbIsAdmin.Checked,
                Name = txtName.Text,
                Surname = txtSurname.Text,
                Phone = txtPhone.Text,
                Password = txtPassword.Text,
                Username = txtUsername.Text
            };
            repository.Add(kullanici);
            try
            {
                var sonuc = repository.Save();
                if (sonuc > 0)
                {
                    Yukle();
                    MessageBox.Show("Kayıt Başarılı!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }

        private void dgvKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dgvKullanicilar.CurrentRow.Cells["Id"].Value);
            var kullanici = repository.Find(id);
            txtEmail.Text = kullanici.Email;
            txtName.Text = kullanici.Name;
            txtPassword.Text = kullanici.Password;
            txtPhone.Text = kullanici.Phone;
            txtSurname.Text = kullanici.Surname;
            txtUsername.Text = kullanici.Username;
            cbIsActive.Checked = kullanici.IsActive;
            cbIsAdmin.Checked = kullanici.IsAdmin;
            tabControl1.SelectedTab = tabPage2;
            btnEkle.Enabled = false;
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Adı Alanı Boş Geçilemez!");
                return;
            }
            var id = Convert.ToInt32(dgvKullanicilar.CurrentRow.Cells["Id"].Value);
            var kullanici = new User()
            {
                Id = id,
                CreateDate = DateTime.Now,
                Email = txtEmail.Text,
                IsActive = cbIsActive.Checked,
                IsAdmin = cbIsAdmin.Checked,
                Name = txtName.Text,
                Surname = txtSurname.Text,
                Phone = txtPhone.Text,
                Password = txtPassword.Text,
                Username = txtUsername.Text
            };
            repository.Update(kullanici);
            try
            {
                var sonuc = repository.Save();
                if (sonuc > 0)
                {
                    Yukle();
                    MessageBox.Show("Kayıt Başarılı!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgvKullanicilar.CurrentRow.Cells["Id"].Value);
            var kullanici = repository.Find(id);
            repository.Delete(kullanici);
            try
            {
                var sonuc = repository.Save();
                if (sonuc > 0)
                {
                    Yukle();
                    MessageBox.Show("Kayıt Silme Başarılı!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }
    }
}
