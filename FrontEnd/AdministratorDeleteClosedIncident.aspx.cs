using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontEnd
{
    public partial class AdministratorDeleteClosedIncident : System.Web.UI.Page
    {
        //var to store the primary key value of the record to be deleted
        Int32 Closed_Incident_ID;

        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the staff to be deleted from the session object
            Closed_Incident_ID = Convert.ToInt32(Session["Closed_Incident_ID"]);
        }

        //function to delete the selected record
        void Delete()
        {
            //create a new instance of the equipment
            clsClosedIncidentCollection ClosedIncident = new clsClosedIncidentCollection();
            //find the record to delete
            ClosedIncident.ThisClosedIncident.Find(Closed_Incident_ID);
            //delete the record
            ClosedIncident.Delete();
        }

        protected void btnDeleteClosedIncidentYes_Click(object sender, EventArgs e)
        {
            //delete the record
            Delete();
            //redirect to the main page
            Response.Redirect("AdministratorClosedIncidentScreen.aspx");
        }

        protected void btnDeleteClosedncidentNo_Click(object sender, EventArgs e)
        {
            //redirect to the main page
            Response.Redirect("AdministratorClosedIncidentScreen.aspx");
        }
    }
}