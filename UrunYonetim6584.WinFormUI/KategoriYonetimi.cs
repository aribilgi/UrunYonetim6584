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
    public partial class KategoriYonetimi : Form
    {
        public KategoriYonetimi()
        {
            InitializeComponent();
        }
        CategoryManager manager = new CategoryManager();
        private void KategoriYonetimi_Load(object sender, EventArgs e)
        {
            dgvKategoriler.DataSource = manager.GetCategories();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Kategori Adı Giriniz!");
                return;
            }
            var kategori = new Category()
            {
                CreateDate = DateTime.Now,
                Description = txtDescription.Text,
                IsActive = cbIsActive.Checked,
                Name = txtName.Text
            };
            manager.Add(kategori);
            var sonuc = manager.Save();
            if (sonuc > 0)
            {
                dgvKategoriler.DataSource = manager.GetCategories();
                txtName.Text = string.Empty;
                txtDescription.Text = string.Empty;
                MessageBox.Show("Kayıt Başarılı!");
            }
        }

        private void dgvKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dgvKategoriler.CurrentRow.Cells[0].Value);
            var kategori = manager.GetCategory(id);
            txtName.Text = kategori.Name;
            txtDescription.Text = kategori.Description;
            cbIsActive.Checked = kategori.IsActive;
            btnEkle.Enabled = false;
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Kategori Adı Giriniz!");
                return;
            }
            var id = Convert.ToInt32(dgvKategoriler.CurrentRow.Cells[0].Value); //
            var kategori = new Category()
            {
                Id = id, //
                CreateDate = DateTime.Now,
                Description = txtDescription.Text,
                IsActive = cbIsActive.Checked,
                Name = txtName.Text
            };
            manager.Update(kategori); //
            var sonuc = manager.Save();
            if (sonuc > 0)
            {
                dgvKategoriler.DataSource = manager.GetCategories();
                txtName.Text = string.Empty;
                txtDescription.Text = string.Empty;
                MessageBox.Show("Kayıt Başarılı!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgvKategoriler.CurrentRow.Cells[0].Value);
            var kategori = manager.GetCategory(id);
            manager.Delete(kategori);
            var sonuc = manager.Save();
            if (sonuc > 0)
            {
                dgvKategoriler.DataSource = manager.GetCategories();
                txtName.Text = string.Empty;
                txtDescription.Text = string.Empty;
                MessageBox.Show("Kayıt Silme Başarılı!");
            }
        }
    }
}
