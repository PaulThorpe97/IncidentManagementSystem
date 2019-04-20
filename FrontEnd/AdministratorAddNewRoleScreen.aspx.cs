using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontEnd
{
    public partial class AdministratorAddNewRoleScreen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //function for adding new records
        void Add()
        {
            //create an instance of the role collecion
            clsRoleCollection AddRole = new clsRoleCollection();
            //validate the data on the web form
            String Error = AddRole.ThisRole.Valid(txtAddRoleDescription.Text);
            //i the data is ok then add it to the object
            if (Error == "")
            {
                //get the data entered by the user
                AddRole.ThisRole.Role_Description = txtAddRoleDescription.Text;
                //add the record
                AddRole.Add();
                //all done so redirect back to the main page
                Response.Redirect("AdministratorRoleScreen.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
            }
        }

        //event handler for btnAddRole
        protected void btnAddRole_Click(object sender, EventArgs e)
        {
            //add the new record
            Add();
            //all done so redirect to the main page
            Response.Redirect("AdministratorRoleScreen.aspx");
        }

        //event handler for btnAddRoleCancel
        protected void btnAddRoleCancel_Click(object sender, EventArgs e)
        {
            //direct to home screen
            Response.Redirect("AdministratorRoleScreen.aspx");
        }
    }
}