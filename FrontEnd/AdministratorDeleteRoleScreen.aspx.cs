using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontEnd
{
    public partial class AdministratorDeleteRoleScreen : System.Web.UI.Page
    {
        //var to store the primary key value of the record to be deleted
        Int32 Role_ID;

        //event handler for the load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the role to be deleted from the session object
            Role_ID = Convert.ToInt32(Session["Role_ID"]);
        }

        //function to delete the selected record
        void DeleteRole()
        {
            //create a new instance of the equipment
            clsRoleCollection Role = new clsRoleCollection();
            //find the record to delete
            Role.ThisRole.Find(Role_ID);
            //delete the record
            Role.Delete();
        }

        //event handler for the yes button
        protected void btnDeleteRoleYes_Click(object sender, EventArgs e)
        {
            //delete the record
            DeleteRole();
            //redirect to the main page
            Response.Redirect("AdministratorRoleScreen.aspx");
        }

        //event handler for the no button
        protected void btnDeleteRoleNo_Click(object sender, EventArgs e)
        {
            //redirect to the main page
            Response.Redirect("AdministratorRoleScreen.aspx");
        }
    }
}