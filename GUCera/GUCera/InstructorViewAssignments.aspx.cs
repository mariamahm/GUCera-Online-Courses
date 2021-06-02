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
    public partial class InstructorViewAssignments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void view_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int instid = Int16.Parse(Session["users"].ToString());
            int cid = Int16.Parse(course.Text);
            SqlCommand viewAssign = new SqlCommand("InstructorViewAssignmentsStudents", conn);
            viewAssign.CommandType = CommandType.StoredProcedure;
            viewAssign.Parameters.Add(new SqlParameter("@instrId", instid));
            viewAssign.Parameters.Add(new SqlParameter("@cid", cid));

            conn.Open();
            SqlDataReader rdr = viewAssign.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                Int32 sid = rdr.GetInt32(rdr.GetOrdinal("sid"));
                Label StudentID = new Label();
                StudentID.Text ="<br/>"+ "Student ID: "+sid.ToString()+"<br/>";
                form1.Controls.Add(StudentID);

                Int32 cid2 = rdr.GetInt32(rdr.GetOrdinal("cid"));
                Label CourseID = new Label();
                CourseID.Text = "Course ID: " + cid2.ToString()+"<br/>";
                form1.Controls.Add(CourseID);

                Int32 assNumber = rdr.GetInt32(rdr.GetOrdinal("assignmentNumber"));
                Label assignmentNumber = new Label();
                assignmentNumber.Text = "Assignment number: " + assNumber.ToString()+"<br/>";
                form1.Controls.Add(assignmentNumber);

                String asstype = rdr.GetString(rdr.GetOrdinal("assignmenttype"));
                Label assignmenttype = new Label();
                assignmenttype.Text = "Assignment type: " + asstype.ToString()+ "<br/>";
                form1.Controls.Add(assignmenttype);
                Decimal gradee;
                try
                {
                    gradee = rdr.GetDecimal(rdr.GetOrdinal("grade"));
                }
                catch (System.Data.SqlTypes.SqlNullValueException) {
                    gradee = 0;
                }
                Label grade = new Label();
                grade.Text = "Grade: " + gradee.ToString()+ "<br/>";
                form1.Controls.Add(grade);
            }
        }

       
    }
}