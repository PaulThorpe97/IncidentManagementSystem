using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontEnd
{
    public partial class AdministratorAddNewStaffScreen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //function for adding new records
        void Add()
        {
            //create an instance of the equipment collecion
            clsStaffCollection AddStaff = new clsStaffCollection();
            //validate the data on the web form
            String Error = AddStaff.ThisStaff.Valid(txtAddStaffSurname.Text, txtAddStaffForename.Text, txtAddStaffPhone.Text);
            //i the data is ok then add it to the object
            if (Error == "")
            {
                //get the data entered by the user
                AddStaff.ThisStaff.Staff_Surname = txtAddStaffSurname.Text;
                AddStaff.ThisStaff.Staff_Forename = txtAddStaffForename.Text;
                AddStaff.ThisStaff.Staff_Phone = txtAddStaffPhone.Text;
                AddStaff.ThisStaff.Role_ID = Convert.ToInt32(txtAddStaffRoleID.Text);
                //add the record
                AddStaff.Add();
                //all done so redirect back to the main page
                Response.Redirect("AdministratorStaffScreen.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
            }
        }

        protected void btnAddStaff_Click(object sender, EventArgs e)
        {
            //add the new record
            Add();
            //all done so redirect to the main page
            Response.Redirect("AdministratorStaffScreen.aspx");
        }

        protected void btnAddStaffCancel_Click(object sender, EventArgs e)
        {
            //direct to home screen
            Response.Redirect("AdministratorStaffScreen.aspx");
        }
    }
}