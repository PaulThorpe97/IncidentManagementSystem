using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontEnd
{
    public partial class AdministratorDeleteIncidentScreen : System.Web.UI.Page
    {
        //var to store the primary key value of the record to be deleted
        Int32 Incident_ID;

        //event handler for the load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the incident to be deleted from the session object
            Incident_ID = Convert.ToInt32(Session["Incident_ID"]);
        }

        //function to delete the selected record
        void DeleteIncident()
        {
            //create a new instance of the equipment
            clsIncidentCollection Incident = new clsIncidentCollection();
            //find the record to delete
            Incident.ThisIncident.Find(Incident_ID);
            //delete the record
            Incident.Delete();
        }

        protected void btnDeleteIncidentYes_Click(object sender, EventArgs e)
        {
            //delete the record
            DeleteIncident();
            //redirect to the main page
            Response.Redirect("AdministratorIncidentScreen.aspx");
        }

        protected void btnDeleteIncidentNo_Click(object sender, EventArgs e)
        {
            //redirect to the main page
            Response.Redirect("AdministratorIncidentScreen.aspx");
        }
    }
}