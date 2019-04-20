using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontEnd
{
    public partial class AdministratorStaffScreen : System.Web.UI.Page
    {
        //this function handles he load event for the page
        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the first ime the page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplayStaff();
            }
        }

        void DisplayStaff()
        {
            //create an instance of the equipment collecion
            clsStaffCollection Staff = new clsStaffCollection();
            //set the data source to the list of the equipment in the collection
            lstStaff.DataSource = Staff.StaffList;
            //set the name of the primary key
            lstStaff.DataValueField = "Staff_ID";
            //set the data field to display
            lstStaff.DataTextField = "Staff_Surname";
            //bind the data to the list
            lstStaff.DataBind();
        }

        protected void btnAddStaff_Click(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate his is a new record
            Session["Staff_ID"] = -1;
            //redirect to the data entry page
            Response.Redirect("AdministratorAddNewStaffScreen.aspx");
        }

        protected void btnDeleteStaffDetails_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted 
            Int32 Staff_ID;
            //if a record has been selected from the list
            if (lstStaff.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                Staff_ID = Convert.ToInt32(lstStaff.SelectedValue);
                //store the data in the session object
                Session["Staff_ID"] = Staff_ID;
                //redirect to the delete page
                Response.Redirect("AdministratorDeleteStaffScreen.aspx");
            }
            else //if no record has been selected 
            {
                //display an error
                lblError.Text = "Please select a record to delete from the list";
            }
        }

        protected void btnEditStaffDetails_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to edit 
            Int32 Staff_ID;
            //if a record has been selected from the list
            if (lstStaff.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                Staff_ID = Convert.ToInt32(lstStaff.SelectedValue);
                //store the data in the session object
                Session["Staff_ID"] = Staff_ID;
                //redirect to the edit page
                Response.Redirect("AdministratorEditStaffScreen.aspx");
            }
            else //if no record has been selected 
            {
                //display an error
                lblError.Text = "Please select a record to edit from the list";
            }
        }

        protected void btnSearchForStaffSurname_Click(object sender, EventArgs e)
        {
            //display only equipment matching the text in the search text box
            DisplayStaff(txtFilterByStaffSurname.Text);
        }

        Int32 DisplayStaff(string StaffFilter)
        {
            //var to store the primary key
            Int32 Staff_ID;
            //var to store the Staff_Surname
            string Staff_Surname;
            //var to store the Staff_Forename
            string Staff_Forename;
            //var to store the Staff_Phone
            string Staff_Phone;
            //var to store the Role_ID
            Int32 Role_ID;
            //create an instance of the staff collecion
            clsStaffCollection Staff = new clsStaffCollection();
            Staff.FilterByStaff_Surname(StaffFilter);
            //var to store the count of records
            Int32 RecordCount;
            //var to store the index for the loop
            Int32 Index = 0;
            //get the count of records
            RecordCount = Staff.Count;
            //clear the list box
            lstStaff.Items.Clear();
            //while there are records to process
            while (Index < RecordCount)
            {
                //get the primary key
                Staff_ID = Staff.StaffList[Index].Staff_ID;
                //get the  Staff_Surname
                Staff_Surname = Staff.StaffList[Index].Staff_Surname;
                //get the  Staff_Forename
                Staff_Forename = Staff.StaffList[Index].Staff_Forename;
                //get the  Staff_Phone
                Staff_Phone = Staff.StaffList[Index].Staff_Phone;
                //get the  Role_ID
                Role_ID = Staff.StaffList[Index].Role_ID;
                //create an entry for the list box
                //create a new entry for the list box
                ListItem NewEntry = new ListItem(Staff_Surname + " " + Staff_Forename + " " + Staff_Phone + " " + Role_ID, Staff_ID.ToString());
                //add the equipment to the list 
                lstStaff.Items.Add(NewEntry);
                //move the index to the next record
                Index++;
            }
            //return the count of records found
            return RecordCount;
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            //redirect to the home page
            Response.Redirect("AdministratorHomeScreen.aspx");
        }

        protected void btnSignOut_Click(object sender, EventArgs e)
        {
            //go to sign out
            Response.Redirect("SignOut.aspx");
        }
    }
}