/*
 * Contact Page Backend
 * Michael Meissner
 * aspAssignment1
 * 
 * This page handles the click event for the submit button
 * 
 */

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
            alertLabel.Visible = false;
        }

        protected void SendButton_Click(object sender, EventArgs e)
        {
            //add email support here
            alertLabel.Visible = true;
        }
    }
}