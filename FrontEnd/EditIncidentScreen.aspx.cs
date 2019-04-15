using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontEnd
{
    public partial class EditIncidentScreen : System.Web.UI.Page
    {
        //variable to store the primary key with page level scope
        Int32 Incident_ID;

        //event handler for the page load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the equipment to be processed
            Incident_ID = Convert.ToInt32(Session["Incident_ID"]);
            if (IsPostBack == false)
            {
                //populate the list of equipment
                DisplayIncident();
                //if this is not a new record
                if (Incident_ID != -1)
                {
                    //DisplayEquipment the current data for the record
                    DisplayIncident();
                }
            }
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

        void DisplayIncident()
        {
            //creat an instance of the equipment
            clsIncidentCollection Incident = new clsIncidentCollection();
            //find the record to update
            Incident.ThisIncident.Find(Incident_ID);
            //display the data for this record
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
    }
}