using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontEnd
{
    public partial class AdministratorClosedIncidentScreen : System.Web.UI.Page
    {
        //this function handles he load event for the page
        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the first ime the page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplayClosedIncident();
            }
        }

        void DisplayClosedIncident()
        {
            //create an instance of the equipment collecion
            clsClosedIncidentCollection ClosedIncident = new clsClosedIncidentCollection();
            //set the data source to the list of the equipment in the collection
            lstClosedIncident.DataSource = ClosedIncident.ClosedIncidentList;
            //set the name of the primary key
            lstClosedIncident.DataValueField = "Closed_Incident_ID";
            //set the data field to display
            lstClosedIncident.DataTextField = "Incident_ID";
            //bind the data to the list
            lstClosedIncident.DataBind();
        }

        //event handler for the delete button
        protected void btnDeleteClosedIncidentDetails_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted 
            Int32 Closed_Incident_ID;
            //if a record has been selected from the list
            if (lstClosedIncident.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                Closed_Incident_ID = Convert.ToInt32(lstClosedIncident.SelectedValue);
                //store the data in the session object
                Session["Closed_Incident_ID"] = Closed_Incident_ID;
                //redirect to the delete page
                Response.Redirect("AdministratorDeleteClosedIncident.aspx");
            }
            else //if no record has been selected 
            {
                //display an error
                lblError.Text = "Please select a record to delete from the list";
            }
        }

        //event handler for the edit button
        protected void btnEditEquipmentDetails_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to edit 
            Int32 Closed_Incident_ID;
            //if a record has been selected from the list
            if (lstClosedIncident.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                Closed_Incident_ID = Convert.ToInt32(lstClosedIncident.SelectedValue);
                //store the data in the session object
                Session["Closed_Incident_ID"] = Closed_Incident_ID;
                //redirect to the edit page
                Response.Redirect("AdministratorEditClosedIncidentScreen.aspx");
            }
            else //if no record has been selected 
            {
                //display an error
                lblError.Text = "Please select a record to edit from the list";
            }
        }

        protected void btnFilterByIncidentID_Click(object sender, EventArgs e)
        {
            //display only closed incidents matching the text in the search text box
            DisplayClosedIncident(txtFilterByIncidentID.Text);
        }

        Int32 DisplayClosedIncident(string ClosedIncidentFilter)
        {
            //var to store the primary key
            Int32 Closed_Incident_ID;
            //var to store the Incident ID
            Int32 Incident_ID;
            //var to store the Staff ID
            Int32 Staff_ID;
            //var to store the Closed Incident Description
            string Closed_Incident_Description;
            //create an instance of the equipment collecion
            clsClosedIncidentCollection ClosedIncident = new clsClosedIncidentCollection();
            ClosedIncident.FilterByIncident_ID(ClosedIncidentFilter);
            //var to store the count of records
            Int32 RecordCount;
            //var to store the index for the loop
            Int32 Index = 0;
            //get the count of records
            RecordCount = ClosedIncident.Count;
            //clear the list box
            lstClosedIncident.Items.Clear();
            //while there are records to process
            while (Index < RecordCount)
            {
                //get the primary key
                Closed_Incident_ID = ClosedIncident.ClosedIncidentList[Index].Closed_Incident_ID;
                //get the Incident ID
                Incident_ID = ClosedIncident.ClosedIncidentList[Index].Incident_ID;
                //get the Staff ID
                Staff_ID = ClosedIncident.ClosedIncidentList[Index].Staff_ID;
                //get the Closed Incident Description
                Closed_Incident_Description = ClosedIncident.ClosedIncidentList[Index].Closed_Incident_Description;
                //create an entry for the list box
                //create a new entry for the list box
                ListItem NewEntry = new ListItem(Incident_ID + " " + Staff_ID + " " + Closed_Incident_Description, Closed_Incident_ID.ToString());
                //add the equipment to the list 
                lstClosedIncident.Items.Add(NewEntry);
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

        protected void btnFilterByStaffID_Click(object sender, EventArgs e)
        {
            //display only closed incidents matching the text in the search text box
            DisplayClosedIncidentStaffID(txtFilterByStaffID.Text);
        }

        Int32 DisplayClosedIncidentStaffID(string ClosedIncidentStaffFilter)
        {
            //var to store the primary key
            Int32 Closed_Incident_ID;
            //var to store the Incident ID
            Int32 Incident_ID;
            //var to store the Staff ID
            Int32 Staff_ID;
            //var to store the Closed Incident Description
            string Closed_Incident_Description;
            //create an instance of the equipment collecion
            clsClosedIncidentCollection ClosedIncident = new clsClosedIncidentCollection();
            ClosedIncident.FilterByStaff_ID(ClosedIncidentStaffFilter);
            //var to store the count of records
            Int32 RecordCount;
            //var to store the index for the loop
            Int32 Index = 0;
            //get the count of records
            RecordCount = ClosedIncident.Count;
            //clear the list box
            lstClosedIncident.Items.Clear();
            //while there are records to process
            while (Index < RecordCount)
            {
                //get the primary key
                Closed_Incident_ID = ClosedIncident.ClosedIncidentList[Index].Closed_Incident_ID;
                //get the Incident ID
                Incident_ID = ClosedIncident.ClosedIncidentList[Index].Incident_ID;
                //get the Staff ID
                Staff_ID = ClosedIncident.ClosedIncidentList[Index].Staff_ID;
                //get the Closed Incident Description
                Closed_Incident_Description = ClosedIncident.ClosedIncidentList[Index].Closed_Incident_Description;
                //create an entry for the list box
                //create a new entry for the list box
                ListItem NewEntry = new ListItem(Incident_ID + " " + Staff_ID + " " + Closed_Incident_Description, Closed_Incident_ID.ToString());
                //add the equipment to the list 
                lstClosedIncident.Items.Add(NewEntry);
                //move the index to the next record
                Index++;
            }
            //return the count of records found
            return RecordCount;
        }

        protected void btnSignOut_Click(object sender, EventArgs e)
        {
            //go to sign out
            Response.Redirect("SignOut.aspx");
        }
    }
}