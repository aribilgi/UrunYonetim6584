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
        Repository<Product> repository = new Repository<Product>(); // 2. yöntem Repository e Product classını yollayarak
        private void UrunYonetimi_Load(object sender, EventArgs e)
        {
            //dgvUrunler.DataSource = manager.GetAll(); // dgvUrunler i 1. yöntemle doldur
            dgvUrunler.DataSource = repository.GetAll(); // 2. yöntemle doldur
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
        }
    }
}
