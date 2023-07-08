using System;
using UrunYonetim6584.BL;
using UrunYonetim6584.Entities;

namespace UrunYonetim.WebFormUI.Admin
{
    public partial class SliderYonetimi : System.Web.UI.Page
    {
        Repository<Slide> repository = new Repository<Slide>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                dgvSlider.DataSource = repository.GetAll();
                dgvSlider.DataBind();
            }
        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {
            var slide = new Slide
            {
                Description = txtDescription.Text,
                Title = txtTitle.Text
            };
            if (fuImage.HasFile)
            {
                fuImage.SaveAs(Server.MapPath("/Images/" + fuImage.FileName));
                slide.Image = fuImage.FileName;
            }
            repository.Add(slide);
            var sonuc = repository.Save();
            if (sonuc > 0)
            {
                Response.Redirect("SliderYonetimi.aspx");
            }
        }

        protected void dgvSlider_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgvSlider.SelectedRow.Cells[1].Text);
            var kayit = repository.Find(id);
            if (kayit != null)
            {
                txtDescription.Text = kayit.Description;
                txtTitle.Text = kayit.Title;
                Image1.ImageUrl = "/Images/" + kayit.Image;
                Image1.Height = 75;
            }
            btnEkle.Enabled = false;
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgvSlider.SelectedRow.Cells[1].Text);
            var slide = repository.Find(id);
            slide.Description = txtDescription.Text;
            slide.Title = txtTitle.Text;
            if (fuImage.HasFile)
            {
                fuImage.SaveAs(Server.MapPath("/Images/" + fuImage.FileName));
                slide.Image = fuImage.FileName;
            }
            repository.Update(slide);
            var sonuc = repository.Save();
            if (sonuc > 0)
            {
                Response.Redirect("SliderYonetimi.aspx");
            }
        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgvSlider.SelectedRow.Cells[1].Text);
            var kayit = repository.Find(id);
            repository.Delete(kayit);
            var sonuc = repository.Save();
            if (sonuc > 0)
            {
                Response.Redirect("SliderYonetimi.aspx");
            }
        }
    }
}