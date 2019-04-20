using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontEnd
{
    public partial class AdministratorEditStaffScreen : System.Web.UI.Page
    {
        //variable to store the primary key with page level scope
        Int32 Staff_ID;

        //event handler for the page load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the staff to be processed
            Staff_ID = Convert.ToInt32(Session["Staff_ID"]);
            if (IsPostBack == false)
            {
                //populate the list of equipment
                DisplayStaff();
                //if this is not a new record
                if (Staff_ID != -1)
                {
                    //DisplayEquipment the current data for the record
                    DisplayStaff();
                }
            }
        }

        //function for adding new records
        void Add()
        {
            //create an instance of the equipment collecion
            clsStaffCollection AddStaff = new clsStaffCollection();
            //validate the data on the web form
            String Error = AddStaff.ThisStaff.Valid(txtEditStaffSurname.Text, txtEditStaffForename.Text, txtEditStaffPhone.Text);
            //i the data is ok then add it to the object
            if (Error == "")
            {
                //get the data entered by the user
                AddStaff.ThisStaff.Staff_Surname = txtEditStaffSurname.Text;
                AddStaff.ThisStaff.Staff_Forename = txtEditStaffForename.Text;
                AddStaff.ThisStaff.Staff_Phone = txtEditStaffPhone.Text;
                AddStaff.ThisStaff.Role_ID = Convert.ToInt32(txtEditStaffRoleID.Text);
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

        //function for updating records
        void Update()
        {
            //create an instance of the equipment collecion
            clsStaffCollection Staff = new clsStaffCollection();
            //validate the data entered by the user
            String Error = Staff.ThisStaff.Valid(txtEditStaffSurname.Text, txtEditStaffForename.Text, txtEditStaffPhone.Text);
            //if the data is ok then add it to the object
            if (Error == "")
            {
                //find the record to update
                Staff.ThisStaff.Find(Staff_ID);
                //get the data entered by the user
                Staff.ThisStaff.Staff_Surname = txtEditStaffSurname.Text;
                Staff.ThisStaff.Staff_Forename = txtEditStaffForename.Text;
                Staff.ThisStaff.Staff_Phone = txtEditStaffPhone.Text;
                Staff.ThisStaff.Role_ID = Convert.ToInt32(txtEditStaffRoleID.Text);
                //add the record
                Staff.Update();
                //all done so redirect back to the main page
                Response.Redirect("AdministratorStaffScreen.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
            }
        }

        void DisplayStaff()
        {
            //creat an instance of the equipment
            clsStaffCollection Staff = new clsStaffCollection();
            //find the record to update
            Staff.ThisStaff.Find(Staff_ID);
            //display the data for this record
            txtEditStaffSurname.Text = Staff.ThisStaff.Staff_Surname;
            txtEditStaffForename.Text = Staff.ThisStaff.Staff_Forename;
            txtEditStaffPhone.Text = Staff.ThisStaff.Staff_Phone;
            txtEditStaffRoleID.Text = Staff.ThisStaff.Role_ID.ToString();
        }


        protected void btnEditStaffCancel_Click(object sender, EventArgs e)
        {
            //direct to home screen
            Response.Redirect("AdministratorStaffScreen.aspx");
        }

        protected void btnEditStaff_Click(object sender, EventArgs e)
        {
            if (Staff_ID == -1)
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
    }
}