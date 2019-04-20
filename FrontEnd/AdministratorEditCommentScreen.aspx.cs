using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontEnd
{
    public partial class AdministratorEditCommentScreen : System.Web.UI.Page
    {
        //variable to store the primary key with page level scope
        Int32 Point_Of_Contact_ID;

        protected void Page_Load(object sender, EventArgs e)
        {
           //get the number of the comment to be processed
           Point_Of_Contact_ID = Convert.ToInt32(Session["Point_Of_Contact_ID"]);
           if (IsPostBack == false)
            {
               //populate the list of incident
               DisplayPointOfContact();
              //if this is not a new record
               if (Point_Of_Contact_ID != -1)
              {
                  //DisplayIncident the current data for the record
                DisplayPointOfContact();
               }
            }
        }

        //function for adding new records
        void PointOfContactAdd()
        {
            //create an instance of the equipment collecion
            clsPointOfContactCollection AddPointOfContact = new clsPointOfContactCollection();
            //validate the data on the web form
            String Error = AddPointOfContact.ThisPointOfContact.Valid(txtEditComment.Text);
            //i the data is ok then add it to the object
            if (Error == "")
            {
                //get the data entered by the user
                AddPointOfContact.ThisPointOfContact.Incident_ID = Convert.ToInt32(txtEditIncidentID.Text);
                AddPointOfContact.ThisPointOfContact.Point_Of_Contact_Comment = txtEditComment.Text;
                AddPointOfContact.ThisPointOfContact.Staff_ID = Convert.ToInt32(txtEditStaffID.Text);
                //add the record
                AddPointOfContact.PointOfContactAdd();
                //all done so redirect back to the main page
                Response.Redirect("AdministratorIncidentScreen.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
            }
        }

        //function for updating records
        void PointOfContactUpdate()
        {
            //create an instance of the PointOfContact
            clsPointOfContactCollection PointOfContact = new clsPointOfContactCollection();
            //validate the data entered by the user
            String Error = PointOfContact.ThisPointOfContact.Valid(txtEditComment.Text);
            //if the data is ok then add it to the object
            if (Error == "")
            {
                //find the record to update
                PointOfContact.ThisPointOfContact.Find(Point_Of_Contact_ID);
                //get the data entered by the user
                PointOfContact.ThisPointOfContact.Incident_ID = Convert.ToInt32(txtEditIncidentID.Text);
                PointOfContact.ThisPointOfContact.Point_Of_Contact_Comment = txtEditComment.Text;
                PointOfContact.ThisPointOfContact.Staff_ID = Convert.ToInt32(txtEditStaffID.Text);
                //update the record
                PointOfContact.PointOfContactUpdate();
                //all done so redirect back to the main page
                Response.Redirect("AdministratorIncidentScreen.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
            }
        }

        protected void btnEditComment_Click(object sender, EventArgs e)
        {
            if (Point_Of_Contact_ID == -1)
            {
                //add the new record
                PointOfContactAdd();
            }
            else
            {
                //update the new record
                PointOfContactUpdate();
            }
        }

        protected void btnEditCommentCancel_Click(object sender, EventArgs e)
        {
            //direct to home screen
            Response.Redirect("AdministratorIncidentScreen.aspx");
        }

        void DisplayPointOfContact()
        {
            //creat an instance of the incident
            clsPointOfContactCollection PointOfContact = new clsPointOfContactCollection();
            //find the record to update
            PointOfContact.ThisPointOfContact.Find(Point_Of_Contact_ID);
            //display the data for this record
            txtEditIncidentID.Text = PointOfContact.ThisPointOfContact.Incident_ID.ToString();
            txtEditComment.Text = PointOfContact.ThisPointOfContact.Point_Of_Contact_Comment.ToString();
            txtEditStaffID.Text = PointOfContact.ThisPointOfContact.Staff_ID.ToString();
        }
    }
}