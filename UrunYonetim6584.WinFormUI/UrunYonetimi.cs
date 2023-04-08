using System;
using System.Windows.Forms;
using UrunYonetim6584.BL;
using UrunYonetim6584.Entities;

namespace UrunYonetim6584.WinFormUI
{
    public partial class UrunYonetimi : Form
    {
        public UrunYonetimi()
        {
            InitializeComponent();
        }
        ProductManager manager = new ProductManager(); // 1. yöntem ProductManager kullanarak
        Repository<Category> repository = new Repository<Category>(); // 2. yöntem Repository e Category classını yollayarak
        private void UrunYonetimi_Load(object sender, EventArgs e)
        {
            DataLoad();
        }

        void DataLoad()
        {
            dgvUrunler.DataSource = manager.GetAll(); // dgvUrunler i 1. yöntemle doldur
            cmbKategoriler.DataSource = repository.GetAll(); // 2. yöntemle kategorileri doldur
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Ürün Adı Boş Geçilemez!");
                return;
            }
            var urun = new Product()
            {
                Name = txtName.Text,
                Description = txtDescription.Text,
                Brand = txtBrand.Text,
                IsActive = cbIsActive.Checked,
                Price = Convert.ToDecimal(txtPrice.Text),
                Stock = Convert.ToInt32(txtStock.Text),
                CreateDate = DateTime.Now,
                CategoryId = Convert.ToInt32(cmbKategoriler.SelectedValue)
            };
            manager.Add(urun);
            try
            {
                int sonuc = manager.Save();
                if (sonuc > 0)
                {
                    DataLoad();
                    MessageBox.Show("Kayıt Başarılı!");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu!" + hata.Message);
            }
            
        }
    }
}
