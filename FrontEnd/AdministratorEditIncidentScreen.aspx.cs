using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontEnd
{
    public partial class AdministratorEditIncidentScreen : System.Web.UI.Page
    {
        //variable to store the primary key with page level scope
        Int32 Incident_ID;
        Int32 Point_Of_Contact_ID;

        //event handler for the page load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the incident to be processed
            Incident_ID = Convert.ToInt32(Session["Incident_ID"]);
            if (IsPostBack == false)
            {
                //populate the list of incident
                DisplayIncident();
                //if this is not a new record
                if (Incident_ID != -1)
                {
                    //DisplayIncident the current data for the record
                    DisplayIncident();
                }
            }

            //if this is the first ime the page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplayPointOfContact();
            }
        }

        void DisplayPointOfContact()
        {
            //create an instance of the Incident collecion
            clsPointOfContactCollection PointOfContact = new clsPointOfContactCollection();
            //set the data source to the list of the Incident in the collection
            lstComment.DataSource = PointOfContact.PointOfContactList;
            //set the name of the primary key
            lstComment.DataValueField = "Point_Of_Contact_ID";
            //set the data field to display
            lstComment.DataTextField = "Staff_ID";
            //set the data field to display
            lstComment.DataTextField = "Point_Of_Contact_Comment";
            //bind the data to the list
            lstComment.DataBind();
        }

        //function for adding new records
        void Add()
        {
            //create an instance of the equipment collecion
            clsIncidentCollection AddIncident = new clsIncidentCollection();
            //validate the data on the web form
            String Error = AddIncident.ThisIncident.Valid(txtEditIncidentDateOccured.Text, txtEditIncidentDescription.Text);
            //i the data is ok then add it to the object
            if (Error == "")
            {
                //get the data entered by the user
                AddIncident.ThisIncident.Incident_Assign_Incident_To = Convert.ToInt32(txtEditAssignIncidentTo.Text);
                AddIncident.ThisIncident.Incident_Date_Occured = Convert.ToDateTime(txtEditIncidentDateOccured.Text);
                AddIncident.ThisIncident.Equipment_ID = Convert.ToInt32(txtEditEquipmentID.Text);
                AddIncident.ThisIncident.Incident_Description = txtEditIncidentDescription.Text;
                AddIncident.ThisIncident.Incident_High = chkEditHigh.Checked;
                AddIncident.ThisIncident.Incident_In_Progress = chkEditInProgress.Checked;
                AddIncident.ThisIncident.Incident_Low = chkEditLow.Checked;
                AddIncident.ThisIncident.Incident_Medium = chkEditMedium.Checked;
                AddIncident.ThisIncident.Incident_Pending = chkEditPending.Checked;
                AddIncident.ThisIncident.Staff_ID = Convert.ToInt32(txtEditStaffID.Text);
                //add the record
                AddIncident.Add();
                //all done so redirect back to the main page
                Response.Redirect("HomeScreen.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
            }
        }

        //function for adding new records
        void PointOfContactAdd()
        {
            //create an instance of the equipment collecion
            clsPointOfContactCollection AddPointOfContact = new clsPointOfContactCollection();
            //validate the data on the web form
            String Error = AddPointOfContact.ThisPointOfContact.Valid(txtComment.Text);
            //i the data is ok then add it to the object
            if (Error == "")
            {
                //get the data entered by the user
                AddPointOfContact.ThisPointOfContact.Incident_ID = Convert.ToInt32(txtCommentIncidentID.Text);
                AddPointOfContact.ThisPointOfContact.Point_Of_Contact_Comment = txtComment.Text;
                AddPointOfContact.ThisPointOfContact.Staff_ID = Convert.ToInt32(txtCommentStaffID.Text);
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
        void Update()
        {
            //create an instance of the equipment
            clsIncidentCollection Incident = new clsIncidentCollection();
            //validate the data entered by the user
            String Error = Incident.ThisIncident.Valid(txtEditIncidentDateOccured.Text, txtEditIncidentDescription.Text);
            //if the data is ok then add it to the object
            if (Error == "")
            {
                //find the record to update
                Incident.ThisIncident.Find(Incident_ID);
                //get the data entered by the user
                Incident.ThisIncident.Incident_Assign_Incident_To = Convert.ToInt32(txtEditAssignIncidentTo.Text);
                Incident.ThisIncident.Incident_Date_Occured = Convert.ToDateTime(txtEditIncidentDateOccured.Text);
                Incident.ThisIncident.Equipment_ID = Convert.ToInt32(txtEditEquipmentID.Text);
                Incident.ThisIncident.Incident_Description = txtEditIncidentDescription.Text;
                Incident.ThisIncident.Incident_High = chkEditHigh.Checked;
                Incident.ThisIncident.Incident_In_Progress = chkEditInProgress.Checked;
                Incident.ThisIncident.Incident_Low = chkEditLow.Checked;
                Incident.ThisIncident.Incident_Medium = chkEditMedium.Checked;
                Incident.ThisIncident.Incident_Pending = chkEditPending.Checked;
                Incident.ThisIncident.Staff_ID = Convert.ToInt32(txtEditStaffID.Text);
                //update the record
                Incident.Update();
                //all done so redirect back to the main page
                Response.Redirect("HomeScreen.aspx");
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
            String Error = PointOfContact.ThisPointOfContact.Valid(txtComment.Text);
            //if the data is ok then add it to the object
            if (Error == "")
            {
                //find the record to update
                PointOfContact.ThisPointOfContact.Find(Point_Of_Contact_ID);
                //get the data entered by the user
                PointOfContact.ThisPointOfContact.Incident_ID = Convert.ToInt32(txtCommentIncidentID.Text);
                PointOfContact.ThisPointOfContact.Point_Of_Contact_Comment = txtComment.Text;
                PointOfContact.ThisPointOfContact.Staff_ID = Convert.ToInt32(txtCommentStaffID.Text);
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

        void DisplayIncident()
        {
            //creat an instance of the incident
            clsIncidentCollection Incident = new clsIncidentCollection();
            //find the record to update
            Incident.ThisIncident.Find(Incident_ID);
            //display the data for this record
            txtEditIncidentID.Text = Incident.ThisIncident.Incident_ID.ToString();
            txtEditAssignIncidentTo.Text = Incident.ThisIncident.Incident_Assign_Incident_To.ToString();
            txtEditIncidentDateOccured.Text = Incident.ThisIncident.Incident_Date_Occured.ToString();
            txtEditEquipmentID.Text = Incident.ThisIncident.Equipment_ID.ToString();
            txtEditIncidentDescription.Text = Incident.ThisIncident.Incident_Description;
            chkEditHigh.Checked = Incident.ThisIncident.Incident_High;
            chkEditInProgress.Checked = Incident.ThisIncident.Incident_In_Progress;
            chkEditLow.Checked = Incident.ThisIncident.Incident_Low;
            chkEditMedium.Checked = Incident.ThisIncident.Incident_Medium;
            chkEditPending.Checked = Incident.ThisIncident.Incident_Pending;
            txtEditStaffID.Text = Incident.ThisIncident.Staff_ID.ToString();
        }
   
        protected void btnEditIncident_Click(object sender, EventArgs e)
        {
            if (Incident_ID == -1)
            {
                //add the new record
                Add();
            }
            else
            {
                //update the new record
                Update();
            }
        }

        protected void btnEditCancel_Click(object sender, EventArgs e)
        {
            //direct to home screen
            Response.Redirect("HomeScreen.aspx");
        }

        protected void btnCommentAdd_Click(object sender, EventArgs e)
        {
            //add the new record
            PointOfContactAdd();
        }

        protected void btnDeleteComment_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted 
            Int32 Point_Of_Contact_ID;
            //if a record has been selected from the list
            if (lstComment.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                Point_Of_Contact_ID = Convert.ToInt32(lstComment.SelectedValue);
                //store the data in the session object
                Session["Point_Of_Contact_ID"] = Point_Of_Contact_ID;
                //redirect to the delete page
                Response.Redirect("AdministratorDeleteCommentScreen.aspx");
            }
            else //if no record has been selected 
            {
                //display an error
                lblError.Text = "Please select a record to delete from the list";
            }
        }

        protected void btnEditComment_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to edit 
            Int32 Point_Of_Contact_ID;
            //if a record has been selected from the list
            if (lstComment.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                Point_Of_Contact_ID = Convert.ToInt32(lstComment.SelectedValue);
                //store the data in the session object
                Session["Point_Of_Contact_ID"] = Point_Of_Contact_ID;
                //redirect to the edit page
                Response.Redirect("AdministratorEditCommentScreen.aspx");
            }
            else //if no record has been selected 
            {
                //display an error
                lblError.Text = "Please select a record to edit from the list";
            }
        }
    }
}