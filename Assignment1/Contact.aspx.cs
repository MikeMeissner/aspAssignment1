using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment1
{
    public partial class Contact1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            //Cancel button returns to home page
            Response.Redirect("Default.aspx");
        }

        protected void SendButton_Click(object sender, EventArgs e)
        {
            //Displays popup and returns to home page
            Response.Redirect("Default.aspx");
        }
    }
}