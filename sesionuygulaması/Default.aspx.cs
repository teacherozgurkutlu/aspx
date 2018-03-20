using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    int sayi = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default2.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        sayi = Int32.Parse(TextBox1.Text);
        Session["deger"] = sayi; 
        //Response.Redirect("http://www.meb.gov.tr");
        Response.Redirect("Default2.aspx");
    }
}