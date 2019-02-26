using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ADOImplementation
{
    public partial class Insert : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\asp.aptech\documents\visual studio 2013\Projects\ADOImplementation\ADOImplementation\App_Data\University.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = TextBox4.Text;
                string mail = TextBox1.Text;
                string add = TextBox2.Text;
                string cnt = TextBox3.Text;
                con.Open();
                string insert = "insert into Student(name,email,address,contact) value('" + name + "','" + mail + "','" + add + "','" + cnt + "')";
                SqlCommand sq = new SqlCommand(insert, con);
                sq.ExecuteNonQuery();
                errormsg.Text = "Record Inserted!!";                
            }
            catch (Exception ex)
            {
                errormsg.Text = ex.Message;                
            }
            finally
            {
                con.Close();
            }
        }
    }
}