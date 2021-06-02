using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gucera
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitassign_Click(object sender, EventArgs e)
        {
            Response.Redirect("Submitassignment.aspx");
        }

        protected void Viewassigncontent_Click(object sender, EventArgs e)
        {
            Response.Redirect("Viewassignmentscontent.aspx");
        }
        
        protected void viewgradesofassign_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewassignmentsgrades.aspx");
        }

        protected void addfeedbackforcourse_Click(object sender, EventArgs e)
        {
            Response.Redirect("addfeedbackforcourse.aspx");
        }

        protected void viewmycertificates_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewmycertificate.aspx");
        }

        protected void viewMyProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }

        protected void courses_Click(object sender, EventArgs e)
        {
            Response.Redirect("Courses.aspx");
        }

        protected void creditcard_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddCreditCard.aspx");
        }

        protected void promos_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewPromocodes.aspx");
        }
    }
}