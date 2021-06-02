using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class issuePromocode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void issue_btn_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            if (studentID_txt.Text == "" || promocode_txt.Text == "") {
                Response.Write("Error! Please fill in all fields!");
                return;
            }
            int sid = Int16.Parse(studentID_txt.Text);
            String code = promocode_txt.Text;

            SqlCommand issuePromo_proc = new SqlCommand("AdminIssuePromocodeToStudent", conn);
            issuePromo_proc.CommandType = System.Data.CommandType.StoredProcedure;

            issuePromo_proc.Parameters.Add(new SqlParameter("@sid", sid));
            issuePromo_proc.Parameters.Add(new SqlParameter("@pid", code));

            conn.InfoMessage += new SqlInfoMessageEventHandler(connection_InfoMessage);

            void connection_InfoMessage(object send, SqlInfoMessageEventArgs ev)
            {
                Response.Write(ev.Message);
            }

            conn.Open();
            try
            {
                issuePromo_proc.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException exception)
            {
                if (exception.Message.Contains("Cannot insert duplicate key"))
                {
                    Response.Write("This promocode has been issued to this student before.");
                }
                else if (exception.Message.Contains("The INSERT statement conflicted with the FOREIGN KEY constraint"))
                {
                    Response.Write("This promocode does not exsist.");
                }

            }
            conn.Close();
        }
    }
}