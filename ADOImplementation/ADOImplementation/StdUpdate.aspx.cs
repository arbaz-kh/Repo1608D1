using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace ADOImplementation
{
    public partial class StdUpdate : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\asp.aptech\documents\visual studio 2013\Projects\ADOImplementation\ADOImplementation\App_Data\University.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(DropDownList1.SelectedValue);

            try
            {

                con.Open();
                string insert = "select * from Student where stdid = '" + id + "'";
                SqlCommand sq = new SqlCommand(insert, con);
                SqlDataReader data = sq.ExecuteReader();
                if (data.Read())
                {
                    txtUser.Text = data.GetString(1);
                    txtEmail.Text = data.GetString(2);
                    txtAdd.Text = data.GetString(3);
                    txtCnt.Text = data.GetString(4);
                }
                else
                {
                    errormsg.Text = "Record not Found";
                }

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

        protected void Button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(DropDownList1.SelectedValue);
            try
            {
                string name = txtUser.Text;
                string mail = txtEmail.Text;
                string add = txtAdd.Text;
                string cnt = txtCnt.Text;
                con.Open();
                string insert = "update Student set Name='" + name + "', email='" + mail + "',address='" + add + "',contact='" + cnt + "' where StdId = '" + id + "';";
                SqlCommand sq = new SqlCommand(insert, con);
                sq.ExecuteNonQuery();
                errormsg.Text = "Record Updated!!";
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