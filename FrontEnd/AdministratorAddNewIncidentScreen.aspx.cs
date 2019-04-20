using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace FrontEnd
{
    public partial class AdministratorAddNewIncidentScreen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //function for adding new records
        void Add()
        {
            //create an instance of the equipment collecion
            clsIncidentCollection AddIncident = new clsIncidentCollection();
            //validate the data on the web form
            String Error = AddIncident.ThisIncident.Valid(txtAddIncidentDateOccured.Text, txtAddIncidentDescription.Text);
            //i the data is ok then add it to the object
            if (Error == "")
            {
                //get the data entered by the user
                AddIncident.ThisIncident.Incident_Assign_Incident_To = Convert.ToInt32(txtAssignIncidentTo.Text);
                AddIncident.ThisIncident.Incident_Date_Occured = Convert.ToDateTime(txtAddIncidentDateOccured.Text);
                AddIncident.ThisIncident.Equipment_ID = Convert.ToInt32(txtAddEquipmentID.Text);
                AddIncident.ThisIncident.Incident_Description = txtAddIncidentDescription.Text;
                AddIncident.ThisIncident.Incident_High = chkAddHigh.Checked;
                AddIncident.ThisIncident.Incident_In_Progress = chkAddInProgress.Checked;
                AddIncident.ThisIncident.Incident_Low = chkAddLow.Checked;
                AddIncident.ThisIncident.Incident_Medium = chkAddMedium.Checked;
                AddIncident.ThisIncident.Incident_Pending = chkAddPending.Checked;
                AddIncident.ThisIncident.Staff_ID = Convert.ToInt32(txtAddStaffID.Text);
                AddIncident.ThisIncident.Incident_Close = chkAddClose.Checked;
                //add the record
                AddIncident.Add();
                //direct to home screen
                Response.Redirect("AdministratorIncidentScreen.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
            }
        }

        protected void btnAddIncident_Click(object sender, EventArgs e)
        {
            //add the new record
            Add();
        }

        protected void btnAddCancel_Click(object sender, EventArgs e)
        {
            //all done so redirect to the main page
            Response.Redirect("AdministratorIncidentScreen.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            //direct to home screen
            Response.Redirect("AdministratorIncidentScreen.aspx");
        }
    }
}