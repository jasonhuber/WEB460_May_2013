using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DataAccess
/// </summary>
public class DataAccess
{
	public DataAccess()
	{
		
	}

    public System.Data.DataSet getDataSet(string connectionstring, string sqlstatement)
    {
        System.Data.SqlClient.SqlConnection conn = 
            new System.Data.SqlClient.SqlConnection();
        conn.ConnectionString = connectionstring;
        System.Data.DataSet ds = new System.Data.DataSet();
        conn.Open();
        System.Data.SqlClient.SqlCommand comm = 
            new System.Data.SqlClient.SqlCommand(sqlstatement, conn);

        System.Data.SqlClient.SqlDataAdapter da = 
            new System.Data.SqlClient.SqlDataAdapter();
        da.SelectCommand = comm;

        da.Fill(ds);

        return ds;
    }
}