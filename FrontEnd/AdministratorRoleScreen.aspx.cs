using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontEnd
{
    public partial class AdministratorRoleScreen : System.Web.UI.Page
    {
        //this function handles he load event for the page
        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the first ime the page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplayRole();
            }
        }

        void DisplayRole()
        {
            //create an instance of the equipment collecion
            clsRoleCollection Role = new clsRoleCollection();
            //set the data source to the list of the equipment in the collection
            lstRole.DataSource = Role.RoleList;
            //set the name of the primary key
            lstRole.DataValueField = "Role_ID";
            //set the data field to display
            lstRole.DataTextField = "Role_Description";
            //bind the data to the list
            lstRole.DataBind();
        }

        //event handler for the add button
        protected void btnAddRole_Click(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate his is a new record
            Session["Role_ID"] = -1;
            //redirect to the data entry page
            Response.Redirect("AdministratorAddNewRoleScreen.aspx");
        }

        //event handler for the delete button
        protected void btnDeleteRoleDetails_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted 
            Int32 Role_ID;
            //if a record has been selected from the list
            if (lstRole.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                Role_ID = Convert.ToInt32(lstRole.SelectedValue);
                //store the data in the session object
                Session["Role_ID"] = Role_ID;
                //redirect to the delete page
                Response.Redirect("AdministratorDeleteRoleScreen.aspx");
            }
            else //if no record has been selected 
            {
                //display an error
                lblError.Text = "Please select a record to delete from the list";
            }
        }

        //event handler for the edit button
        protected void btnEditRoleDetails_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to edit 
            Int32 Role_ID;
            //if a record has been selected from the list
            if (lstRole.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                Role_ID = Convert.ToInt32(lstRole.SelectedValue);
                //store the data in the session object
                Session["Role_ID"] = Role_ID;
                //redirect to the edit page
                Response.Redirect("AdministratorEditRoleScreen.aspx");
            }
            else //if no record has been selected 
            {
                //display an error
                lblError.Text = "Please select a record to edit from the list";
            }
        }

        protected void btnSearchForRole_Click(object sender, EventArgs e)
        {
            //display only equipment matching the text in the search text box
            DisplayRole(txtFilterByRoleDescription.Text);
        }
        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {
            //display all Equipment
            DisplayRole("");
        }

        Int32 DisplayRole(string RoleFilter)
        {
            //var to store the primary key
            Int32 Role_ID;
            //var to store the Equipment_Description
            string Role_Description;
            //create an instance of the equipment collecion
            clsRoleCollection Role = new clsRoleCollection();
            Role.FilterByRole_Description(RoleFilter);
            //var to store the count of records
            Int32 RecordCount;
            //var to store the index for the loop
            Int32 Index = 0;
            //get the count of records
            RecordCount = Role.Count;
            //clear the list box
            lstRole.Items.Clear();
            //while there are records to process
            while (Index < RecordCount)
            {
                //get the primary key
                Role_ID = Role.RoleList[Index].Role_ID;
                //get the Role_Description
                Role_Description = Role.RoleList[Index].Role_Description;
                //create an entry for the list box
                //create a new entry for the list box
                ListItem NewEntry = new ListItem(Role_Description, Role_ID.ToString());
                //add the equipment to the list 
                lstRole.Items.Add(NewEntry);
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