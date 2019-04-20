using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontEnd
{
    public partial class AdministratorHomeScreen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIncidents_Click(object sender, EventArgs e)
        {
            //direct to incident screen
            Response.Redirect("AdministratorIncidentScreen.aspx");
        }

        protected void btnStaff_Click(object sender, EventArgs e)
        {
            //direct to staff screen
            Response.Redirect("AdministratorStaffScreen.aspx");
        }

        protected void btnEquipment_Click(object sender, EventArgs e)
        {
            //direct to equipment screen
            Response.Redirect("AdministratorEquipmentScreen.aspx");
        }

        protected void btnClosedIncidents_Click(object sender, EventArgs e)
        {
            //direct to  ClosedIncident screen
            Response.Redirect("AdministratorClosedIncidentScreen.aspx");
        }

        protected void btnRoles_Click(object sender, EventArgs e)
        {
            //direct to  ClosedIncident screen
            Response.Redirect("AdministratorRoleScreen.aspx");
        }

        protected void btnSignOut_Click(object sender, EventArgs e)
        {
            //go to sign out
            Response.Redirect("SignOut.aspx");
        }
    }
}