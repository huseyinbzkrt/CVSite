﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        DBCVENTITYEntities1 db = new DBCVENTITYEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = db.TBLYETENEKLER.Count().ToString();
            Label2.Text = db.TBLILETISIM.Count().ToString();
            Label3.Text = db.TBLYETENEKLER.Average(x => x.DERECESI).ToString();
            Label4.Text = db.TBLYETENEKLER.Max(x => x.DERECESI).ToString();
           
        }
    }
}