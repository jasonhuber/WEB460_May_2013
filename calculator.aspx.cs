using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class calculator : System.Web.UI.Page
{
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Hub3r.com.CalculatorSoapClient myclient = 
            new Hub3r.com.CalculatorSoapClient();

        lblResult.Text = myclient.Add(txtNum1.Text, txtNum2.Text);
    }
}