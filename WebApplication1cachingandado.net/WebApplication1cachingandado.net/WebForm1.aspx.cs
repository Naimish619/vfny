using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
namespace WebApplication1cachingandado.net
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connstring = "Data Source=CELAB5;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
            String sql = "Update student set marks=@marks where sti_id=@id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", TextBox1.Text);
            cmd.Parameters.AddWithValue("@marks", TextBox2.Text);
            int added;


            added = cmd.ExecuteNonQuery();



            Label1.Text = added.ToString() + "record updated";
        }
    }
}