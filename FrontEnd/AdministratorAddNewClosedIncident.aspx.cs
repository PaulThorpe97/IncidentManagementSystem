using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontEnd
{
    public partial class AdministratorAddNewClosedIncident : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        //function for adding new records
        void Add()
        {
            //create an instance of the equipment collecion
            clsClosedIncidentCollection AddClosedIncident = new clsClosedIncidentCollection();
            //validate the data on the web form
            String Error = AddClosedIncident.ThisClosedIncident.Valid(txtAddDateClosed.Text, txtAddClosedIncidentDescription.Text);
            //i the data is ok then add it to the object
            if (Error == "")
            {
                //get the data entered by the user
                AddClosedIncident.ThisClosedIncident.Closed_Incident_Date_Closed = Convert.ToDateTime(txtAddDateClosed.Text);
                AddClosedIncident.ThisClosedIncident.Closed_Incident_Description= txtAddClosedIncidentDescription.Text;
                AddClosedIncident.ThisClosedIncident.Incident_ID = Convert.ToInt32(txtAddIncidentID.Text);
                AddClosedIncident.ThisClosedIncident.Staff_ID = Convert.ToInt32(txtAddStaffID.Text);
                //add the record
                AddClosedIncident.Add();
                //direct to home screen
                Response.Redirect("AdministratorIncidentScreen.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
            }
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            //direct to home screen
            Response.Redirect("AdministratorIncidentScreen.aspx");
        }

        protected void btnAddClosedIncident_Click(object sender, EventArgs e)
        {
            //add the new record
            Add();
        }

        protected void btnAddClosedIncidentCancel_Click(object sender, EventArgs e)
        {
            //direct to home screen
            Response.Redirect("AdministratorIncidentScreen.aspx");
        }
    }
}