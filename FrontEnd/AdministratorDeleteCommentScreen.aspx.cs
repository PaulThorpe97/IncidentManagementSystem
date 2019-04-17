using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontEnd
{
    public partial class AdministratorDeleteCommentScreen : System.Web.UI.Page
    {
        //var to store the primary key value of the record to be deleted
        Int32 Point_Of_Contact_ID;

        //event handler for the load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the staff to be deleted from the session object
            Point_Of_Contact_ID = Convert.ToInt32(Session["Point_Of_Contact_ID"]);
        }

        //function to delete the selected record
        void DeleteComment()
        {
            //create a new instance of the equipment
            clsPointOfContactCollection PointOfContact = new clsPointOfContactCollection();
            //find the record to delete
            PointOfContact.ThisPointOfContact.Find(Point_Of_Contact_ID);
            //delete the record
            PointOfContact.PointOfContactDelete();
        }

        protected void btnDeleteCommentYes_Click(object sender, EventArgs e)
        {
            //delete the record
            DeleteComment();
            //redirect to the main page
            Response.Redirect("AdministratorIncidentScreen.aspx");
        }

        protected void btnDeleteCommentNo_Click(object sender, EventArgs e)
        {
            //redirect to the main page
            Response.Redirect("AdministratorIncidentScreen.aspx");
        }
    }
}