using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class getemployees : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("{\"employees\": [");
       
        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
        string connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["HuberGoDaddy"].ConnectionString;
        conn.ConnectionString = connectionstring;
        string sql = "select employeeid, firstname, lastname from huber_employees";
        System.Data.DataSet ds = new System.Data.DataSet();
        conn.Open();
        System.Data.SqlClient.SqlCommand comm = new System.Data.SqlClient.SqlCommand(sql, conn);

        System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
        da.SelectCommand = comm;

        da.Fill(ds);

        //if there are no employees returned
        if (ds.Tables.Count <= 0 || ds.Tables[0].Rows.Count <= 0)
        {
            Response.Write("{}");
        }
        else
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {   
                Response.Write("{\"employeeid\": \"" + 
                    ds.Tables[0].Rows[i].ItemArray[0].ToString() + 
                    "\",\"firstname\":" + 
                    "\"" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "\"}");
                
                if (i<ds.Tables[0].Rows.Count-1)
                {
                    Response.Write(",");
                }

            }
        }

        Response.Write("]}");
    }
}