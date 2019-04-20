using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontEnd
{
    public partial class AdministratorEditRoleScreen : System.Web.UI.Page
    {
        //variable to store the primary key with page level scope
        Int32 Role_ID;

        //event handler for the page load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the role to be processed
            Role_ID = Convert.ToInt32(Session["Role_ID"]);
            if (IsPostBack == false)
            {
                //populate the list of equipment
                DisplayRole();
                //if this is not a new record
                if (Role_ID != -1)
                {
                    //DisplayEquipment the current data for the record
                    DisplayRole();
                }
            }
        }

        //function for adding new records
        void Add()
        {
            //create an instance of the equipment collecion
            clsRoleCollection AddRole = new clsRoleCollection();
            //validate the data on the web form
            String Error = AddRole.ThisRole.Valid(txtEditRoleDescription.Text);
            //i the data is ok then add it to the object
            if (Error == "")
            {
                //get the data entered by the user
                AddRole.ThisRole.Role_Description = txtEditRoleDescription.Text;
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

        //function for updating records
        void Update()
        {
            //create an instance of the equipment
            clsRoleCollection Role = new clsRoleCollection();
            //validate the data entered by the user
            String Error = Role.ThisRole.Valid(txtEditRoleDescription.Text);
            //if the data is ok then add it to the object
            if (Error == "")
            {
                //find the record to update
                Role.ThisRole.Find(Role_ID);
                //get the data entered by the user
                Role.ThisRole.Role_Description = txtEditRoleDescription.Text;
                //update the record
                Role.Update();
                //all done so redirect back to the main page
                Response.Redirect("AdministratorRoleScreen.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
            }
        }

        void DisplayRole()
        {
            //creat an instance of the equipment
            clsRoleCollection Role = new clsRoleCollection();
            //find the record to update
            Role.ThisRole.Find(Role_ID);
            //display the data for this record
            txtEditRoleDescription.Text = Role.ThisRole.Role_Description;
        }

        protected void btnEditRole_Click(object sender, EventArgs e)
        {
            if (Role_ID == -1)
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

        protected void btnEditRoleCancel_Click(object sender, EventArgs e)
        {
            //direct to home screen
            Response.Redirect("AdministratorRoleScreen.aspx");
        }
    }
}