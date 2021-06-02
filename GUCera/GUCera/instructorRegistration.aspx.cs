using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class instructorRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void instructorReg_btn_Click(object sender, EventArgs e)
        {
            string connStr = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            if (fname_txt.Text == "" || lname_txt.Text == "" || pass_txt.Text == "" || mail_txt.Text == "" || gender_txt.Text == "" || address_txt.Text == "")
            {
                Response.Write("Please fill in all fields!");
                return;
            }
            String fname = fname_txt.Text;
            String lname = lname_txt.Text;
            String pass = pass_txt.Text;
            String email = mail_txt.Text;
            Int16 gender = Int16.Parse(gender_txt.Text);
            String address = address_txt.Text;

            SqlCommand instr_proc = new SqlCommand("InstructorRegister", conn);
            instr_proc.CommandType = System.Data.CommandType.StoredProcedure;

            instr_proc.Parameters.Add(new SqlParameter("@first_name", fname));
            instr_proc.Parameters.Add(new SqlParameter("@last_name", lname));
            instr_proc.Parameters.Add(new SqlParameter("@password", pass));
            instr_proc.Parameters.Add(new SqlParameter("@email", email));
            instr_proc.Parameters.Add(new SqlParameter("@gender", gender));
            instr_proc.Parameters.Add(new SqlParameter("@address", address));


            conn.Open();
            try
            {
                instr_proc.ExecuteNonQuery();
                Response.Redirect("Login.aspx");
            }
            catch (System.Data.SqlClient.SqlException exception)
            {
                Response.Write("User Already Exists!");
            }
            conn.Close();
        }
    }
}