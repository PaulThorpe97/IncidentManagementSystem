using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontEnd
{
    public partial class AdministratorEditClosedIncidentScreen : System.Web.UI.Page
    {
        //variable to store the primary key with page level scope
        Int32 Closed_Incident_ID;

        //event handler for the page load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the closed incident to be processed
            Closed_Incident_ID = Convert.ToInt32(Session["Closed_Incident_ID"]);
            if (IsPostBack == false)
            {
                //populate the list of equipment
                DisplayClosedIncident();
                //if this is not a new record
                if (Closed_Incident_ID != -1)
                {
                    //DisplayEquipment the current data for the record
                    DisplayClosedIncident();
                }
            }
        }

        //function for adding new records
        void Add()
        {
            //create an instance of the equipment collecion
            clsClosedIncidentCollection AddClosedIncident = new clsClosedIncidentCollection();
            //validate the data on the web form
            String Error = AddClosedIncident.ThisClosedIncident.Valid(txtEditDateClosed.Text, txtEditClosedIncidentDescription.Text);
            //i the data is ok then add it to the object
            if (Error == "")
            {
                //get the data entered by the user
                AddClosedIncident.ThisClosedIncident.Closed_Incident_Date_Closed = Convert.ToDateTime(txtEditDateClosed.Text);
                AddClosedIncident.ThisClosedIncident.Closed_Incident_Description = txtEditClosedIncidentDescription.Text;
                AddClosedIncident.ThisClosedIncident.Incident_ID = Convert.ToInt32(txtEditIncidentID.Text);
                AddClosedIncident.ThisClosedIncident.Staff_ID = Convert.ToInt32(txtEditStaffID.Text);
                //add the record
                AddClosedIncident.Add();
                //direct to home screen
                Response.Redirect("AdministratorClosedIncidentScreen.aspx");
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
            clsClosedIncidentCollection ClosedIncident = new clsClosedIncidentCollection();
            //validate the data entered by the user
            String Error = ClosedIncident.ThisClosedIncident.Valid(txtEditDateClosed.Text, txtEditClosedIncidentDescription.Text);
            //if the data is ok then add it to the object
            if (Error == "")
            {
                //find the record to update
                ClosedIncident.ThisClosedIncident.Find(Closed_Incident_ID);
                //get the data entered by the user
                ClosedIncident.ThisClosedIncident.Closed_Incident_Date_Closed = Convert.ToDateTime(txtEditDateClosed.Text);
                ClosedIncident.ThisClosedIncident.Closed_Incident_Description = txtEditClosedIncidentDescription.Text;
                ClosedIncident.ThisClosedIncident.Incident_ID = Convert.ToInt32(txtEditIncidentID.Text);
                ClosedIncident.ThisClosedIncident.Staff_ID = Convert.ToInt32(txtEditStaffID.Text);
                //update the record
                ClosedIncident.Update();
                //all done so redirect back to the main page
                Response.Redirect("AdministratorClosedIncidentScreen.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
            }
        }

        void DisplayClosedIncident()
        {
            //creat an instance of the equipment
            clsClosedIncidentCollection ClosedIncident = new clsClosedIncidentCollection();
            //find the record to update
            ClosedIncident.ThisClosedIncident.Find(Closed_Incident_ID);
            //display the data for this record
            txtEditDateClosed.Text = ClosedIncident.ThisClosedIncident.Closed_Incident_Date_Closed.ToString();
            txtEditClosedIncidentDescription.Text= ClosedIncident.ThisClosedIncident.Closed_Incident_Description;
            txtEditIncidentID.Text = ClosedIncident.ThisClosedIncident.Incident_ID.ToString();
            txtEditStaffID.Text = ClosedIncident.ThisClosedIncident.Staff_ID.ToString();
        }

        protected void btnEditClosedIncidentCancel_Click(object sender, EventArgs e)
        {
            //direct to home screen
            Response.Redirect("AdministratorClosedIncidentScreen.aspx");
        }

        protected void btnEditClosedIncident_Click(object sender, EventArgs e)
        {
            if (Closed_Incident_ID == -1)
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

        protected void btnHome_Click(object sender, EventArgs e)
        {
            //direct to home screen
            Response.Redirect("AdministratorClosedIncidentScreen.aspx");
        }
    }
}