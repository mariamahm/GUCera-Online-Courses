using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class InstructorViewFeedbacks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void viewF_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int instrid = Int16.Parse(Session["users"].ToString());
            int cid = Int16.Parse(courze.Text);
            SqlCommand viewFeedback = new SqlCommand("ViewFeedbacksAddedByStudentsOnMyCourse ", conn);
            viewFeedback.CommandType = CommandType.StoredProcedure;
            viewFeedback.Parameters.Add(new SqlParameter("@instrId", instrid));
            viewFeedback.Parameters.Add(new SqlParameter("@cid", cid));

            conn.Open();
            SqlDataReader rdr = viewFeedback.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {

                Int32 numbe = rdr.GetInt32(rdr.GetOrdinal("number"));
                Label number = new Label();
                number.Text = "<br/>"+"FeedBack: "+numbe.ToString()+"<br/>";
                form1.Controls.Add(number);

                String commen = rdr.GetString(rdr.GetOrdinal("comment"));
                Label comment = new Label();
                comment.Text = "Comment: "+commen.ToString() + "<br/>";
                form1.Controls.Add(comment);

                Int32 numberOfLike = rdr.GetInt32(rdr.GetOrdinal("numberOfLikes"));
                Label numberOfLikes = new Label();
                numberOfLikes.Text = "Number of Likes: "+numberOfLike.ToString() + "<br/>";
                form1.Controls.Add(numberOfLikes);

            }

        }
    }
}