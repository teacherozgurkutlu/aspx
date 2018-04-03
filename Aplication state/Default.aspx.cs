using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (Application["SayfaSayac"] != null && (int)Application["SayfaSayac"] >= 10)
        {
            Application.Remove("SayfaSayac");
        }

        if (Application["SayfaSayac"] == null)
        {
            Application["SayfaSayac"] = 1;
        }

        else
        {
            Application.Lock(); //Application kilitleniyor.
            Application["SayfaSayac"] = (int)Application["SayfaSayac"] + 1;
            Application.UnLock(); //Unlock ediliyor.
        }

        Label1.Text = Convert.ToString(Application["SayfaSayac"]);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}