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
    public partial class Instructor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void InstAddCourse_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int hrs=Int16.Parse(creditHours.Text);
            String name = courseName.Text;
            float cprice = float.Parse(price.Text);
            int instid = Int16.Parse(Session["users"].ToString());

            SqlCommand addCourse = new SqlCommand("InstAddCourse", conn);
            addCourse.CommandType = CommandType.StoredProcedure;
            addCourse.Parameters.Add(new SqlParameter("@creditHours", hrs));
            addCourse.Parameters.Add(new SqlParameter("@name", name));
            addCourse.Parameters.Add(new SqlParameter("@price", cprice));
            addCourse.Parameters.Add(new SqlParameter("@instructorId", instid));

            conn.Open();
            try
            {
                addCourse.ExecuteNonQuery();
                Response.Write("Course Added");
            }
            catch (System.Data.SqlClient.SqlException exception)
            {
                Response.Write("Already Done successfully");
            }
            conn.Close();
        }

        protected void DefineAssignmentOfCourseOfCertianType_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int instID = Int16.Parse(Session["users"].ToString());
            int cid = Int16.Parse(courseid.Text);
            int number = Int16.Parse(num.Text);
            String type = typ.Text;
            int fullGrade= Int16.Parse(grade.Text);
            float weight = float.Parse(weigh.Text);
            DateTime deadline = DateTime.Parse(deadlin.Text);
            String content = conten.Text;

            SqlCommand defineAssignment = new SqlCommand("DefineAssignmentOfCourseOfCertianType", conn);
            defineAssignment.CommandType = CommandType.StoredProcedure;
            defineAssignment.Parameters.Add(new SqlParameter("@instId", instID));
            defineAssignment.Parameters.Add(new SqlParameter("@cid", cid));
            defineAssignment.Parameters.Add(new SqlParameter("@number", number));
            defineAssignment.Parameters.Add(new SqlParameter("@type", type));
            defineAssignment.Parameters.Add(new SqlParameter("@fullGrade", fullGrade));
            defineAssignment.Parameters.Add(new SqlParameter("@weight", weight));
            defineAssignment.Parameters.Add(new SqlParameter("@deadline", deadline));
            defineAssignment.Parameters.Add(new SqlParameter("@content", content));

            conn.Open();
            try
            {
                defineAssignment.ExecuteNonQuery();
                Response.Write("Assignment Added");
            }
            catch (System.Data.SqlClient.SqlException exception)
            {
                Response.Write("Already Done successfully");
            }
            conn.Close();


        }

        protected void viewAssigns_Click(object sender, EventArgs e)
        {
            Response.Redirect("InstructorViewAssignments.aspx");
        }

        protected void gradeAssigns_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int instrId = Int16.Parse(Session["users"].ToString());
            int sid = Int16.Parse(sidd.Text);
            int cid = Int16.Parse(cidd.Text);
            int assignmentNumber = Int16.Parse(numm.Text);
            String type = typp.Text;
            float grade = float.Parse(gradd.Text);

            SqlCommand gradeAssignment = new SqlCommand("InstructorgradeAssignmentOfAStudent", conn);
            gradeAssignment.CommandType = CommandType.StoredProcedure;
            gradeAssignment.Parameters.Add(new SqlParameter("@instrId", instrId));
            gradeAssignment.Parameters.Add(new SqlParameter("@sid", sid));
            gradeAssignment.Parameters.Add(new SqlParameter("@cid", cid));
            gradeAssignment.Parameters.Add(new SqlParameter("@assignmentNumber", assignmentNumber));
            gradeAssignment.Parameters.Add(new SqlParameter("@type", type));
            gradeAssignment.Parameters.Add(new SqlParameter("@grade", grade));

            conn.Open();
            try
            {
                gradeAssignment.ExecuteNonQuery();
                Response.Write("Grade Added");
            }
            catch (System.Data.SqlClient.SqlException exception)
            {
                Response.Write("Already Done successfully");
            }
            conn.Close();

        }

        protected void viewFs_Click(object sender, EventArgs e)
        {
            Response.Redirect("InstructorViewFeedbacks.aspx");
        }

        protected void IssueC_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int insId = Int16.Parse(Session["users"].ToString());
            int sid = Int16.Parse(ssid.Text);
            int cid = Int16.Parse(ccid.Text);
            DateTime issueDate = DateTime.Parse(ddate.Text);

            SqlCommand issueCer = new SqlCommand("InstructorIssueCertificateToStudent", conn);
            issueCer.CommandType = CommandType.StoredProcedure;
            issueCer.Parameters.Add(new SqlParameter("@insId", insId));
            issueCer.Parameters.Add(new SqlParameter("@sid", sid));
            issueCer.Parameters.Add(new SqlParameter("@cid", cid));
            issueCer.Parameters.Add(new SqlParameter("@issueDate", issueDate));

            conn.Open();
            try
            {
                issueCer.ExecuteNonQuery();
                Response.Write("Certificate Issued");
            }
            catch (System.Data.SqlClient.SqlException exception)
            {
                Response.Write("Already Done successfully");
            }
            conn.Close();

        }
    }
}