using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;


namespace CvEntityProje
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        DBCVENTITYEntities1 db = new DBCVENTITYEntities1();
        protected void Button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.TBLADMIN
                        where x.KULLANIACIAD == TextBox1.Text && x.SIFRE == TextBox2.Text

                        select x;
            if (sorgu.Any())
            {
                Response.Redirect("Yeteneklerim.Aspx");
            }
            else
            {
                Response.Write("Hatalı Kullanıcı adı Yada Şifre");
            }
        }
    }
}