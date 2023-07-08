using System;
using UrunYonetim6584.BL;
using UrunYonetim6584.Entities;

namespace UrunYonetim.WebFormUI.Admin
{
    public partial class KategoriYonetimi : System.Web.UI.Page
    {
        CategoryManager manager = new CategoryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            dgvKategoriler.DataSource = manager.GetCategories();
            dgvKategoriler.DataBind(); // web de bu metodu çağırmazsak ekrana veri yüklenmiyor!
        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {
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
                Response.Redirect("KategoriYonetimi.aspx");
            }
        }

        protected void dgvKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgvKategoriler.SelectedRow.Cells[1].Text);
            var kategori = manager.GetCategory(id);
            txtName.Text = kategori.Name;
            txtDescription.Text = kategori.Description;
            cbIsActive.Checked = kategori.IsActive;
            btnEkle.Enabled = false;
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                Response.Write("<script>alert('Kategori Adı Giriniz!')</script>");
                return;
            }
            var id = Convert.ToInt32(dgvKategoriler.SelectedRow.Cells[1].Text); //
            var eklenmeTarihi = Convert.ToDateTime(dgvKategoriler.SelectedRow.Cells[5].Text);
            var kategori = new Category()
            {
                Id = id, //
                CreateDate = eklenmeTarihi,
                Description = txtDescription.Text,
                IsActive = cbIsActive.Checked,
                Name = txtName.Text
            };
            manager.Update(kategori); //
            var sonuc = manager.Save();
            if (sonuc > 0)
            {
                Response.Redirect("KategoriYonetimi.aspx");
            }
        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgvKategoriler.SelectedRow.Cells[1].Text);
            var kategori = manager.GetCategory(id);
            manager.Delete(kategori);
            var sonuc = manager.Save();
            if (sonuc > 0)
            {
                Response.Redirect("KategoriYonetimi.aspx");
            }
        }
    }
}