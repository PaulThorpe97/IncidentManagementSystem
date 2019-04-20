using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontEnd
{
    public partial class HomeScreen : System.Web.UI.Page
    {
        //this function handles he load event for the page
        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the first ime the page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplayIncident();
            }
        }

        void DisplayIncident()
        {
            //create an instance of the Incident collecion
            clsIncidentCollection Incident = new clsIncidentCollection();
            //set the data source to the list of the Incident in the collection
            lstIncidents.DataSource = Incident.IncidentList;
            //set the name of the primary key
            lstIncidents.DataValueField = "Incident_ID";
            //set the data field to display
            lstIncidents.DataTextField = "Incident_Description";
            //bind the data to the list
            lstIncidents.DataBind();
        }

        //Event Handler for the add button
        protected void btnAddNewIncident_Click(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate his is a new record
            Session["Incident_ID"] = -1;
            //redirect to the data entry page
            Response.Redirect("AddNewIncidentScreen.aspx");
        }

        //Event Handler for the edit button
        protected void btnEditIncidentDetails_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to edit 
            Int32 Incident_ID;
            //if a record has been selected from the list
            if (lstIncidents.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                Incident_ID = Convert.ToInt32(lstIncidents.SelectedValue);
                //store the data in the session object
                Session["Incident_ID"] = Incident_ID;
                //redirect to the edit page
                Response.Redirect("EditIncidentScreen.aspx");
            }
            else //if no record has been selected 
            {
                //display an error
                lblError.Text = "Please select a record to edit from the list";
            }
        }

        protected void btnSearchForIncident_Click(object sender, EventArgs e)
        {
            //display only equipment matching the text in the search text box
            DisplayIncident(txtFilterByStaffID.Text);
        }

        Int32 DisplayIncident(string IncidentFilter)
        {
            //var to store the primary key
            Int32 Incident_ID;
            //var to store the Staff_ID
            Int32 Staff_ID;
            //var to store the Incident_Date_Occured
            DateTime Incident_Date_Occured;
            //var to store the Incident_Description
            String Incident_Description;
            //create an instance of the equipment collecion
            clsIncidentCollection Incident = new clsIncidentCollection();
            Incident.FilterByStaff_ID(IncidentFilter);
            //var to store the count of records
            Int32 RecordCount;
            //var to store the index for the loop
            Int32 Index = 0;
            //get the count of records
            RecordCount = Incident.Count;
            //clear the list box
            lstIncidents.Items.Clear();
            //while there are records to process
            while (Index < RecordCount)
            {
                //get the primary key
                Incident_ID = Incident.IncidentList[Index].Incident_ID;
                //get the Staff_ID
                Staff_ID = Incident.IncidentList[Index].Staff_ID;
                //get the Incident_Date_Occured
                Incident_Date_Occured = Incident.IncidentList[Index].Incident_Date_Occured;
                //get the Incident_Description
                Incident_Description = Incident.IncidentList[Index].Incident_Description;
                //create an entry for the list box
                //create a new entry for the list box
                ListItem NewEntry = new ListItem(Incident_ID + " " + Staff_ID + " " + Incident_Description + " " + Incident_Date_Occured, Incident_ID.ToString());
                //add the equipment to the list 
                lstIncidents.Items.Add(NewEntry);
                //move the index to the next record
                Index++;
            }
            //return the count of records found
            return RecordCount;
        }

        protected void btnFilterByHigh_Click(object sender, EventArgs e)
        {
            //display only incident matching the text in the search text box
            DisplayHighIncident(txtFilterByHigh.Text);
        }

        Int32 DisplayHighIncident(string HighIncidentFilter)
        {
            //var to store the primary key
            Int32 Incident_ID;
            //var to store the Staff_ID
            Int32 Staff_ID;
            //var to store the Incident_Date_Occured
            DateTime Incident_Date_Occured;
            //var to store the Incident_Description
            String Incident_Description;
            //create an instance of the equipment collecion
            clsIncidentCollection Incident = new clsIncidentCollection();
            Incident.FilterByIncident_High(HighIncidentFilter);
            //var to store the count of records
            Int32 RecordCount;
            //var to store the index for the loop
            Int32 Index = 0;
            //get the count of records
            RecordCount = Incident.Count;
            //clear the list box
            lstIncidents.Items.Clear();
            //while there are records to process
            while (Index < RecordCount)
            {
                //get the primary key
                Incident_ID = Incident.IncidentList[Index].Incident_ID;
                //get the Staff_ID
                Staff_ID = Incident.IncidentList[Index].Staff_ID;
                //get the Incident_Date_Occured
                Incident_Date_Occured = Incident.IncidentList[Index].Incident_Date_Occured;
                //get the Incident_Description
                Incident_Description = Incident.IncidentList[Index].Incident_Description;
                //create an entry for the list box
                //create a new entry for the list box
                ListItem NewEntry = new ListItem(Incident_ID + " " + Staff_ID + " " + Incident_Description + " " + Incident_Date_Occured, Incident_ID.ToString());
                //add the equipment to the list 
                lstIncidents.Items.Add(NewEntry);
                //move the index to the next record
                Index++;
            }
            //return the count of records found
            return RecordCount;
        }

        protected void btnFilterByEquipmentID_Click(object sender, EventArgs e)
        {
            //display only incident matching the text in the search text box
            DisplayIncidentEquipmentID(txtFilterByEquipmentID.Text);
        }

        Int32 DisplayIncidentEquipmentID(string EquipmentIncidentFilter)
        {
            //var to store the primary key
            Int32 Incident_ID;
            //var to store the Staff_ID
            Int32 Staff_ID;
            //var to store the Incident_Date_Occured
            DateTime Incident_Date_Occured;
            //var to store the Incident_Description
            String Incident_Description;
            //create an instance of the equipment collecion
            clsIncidentCollection Incident = new clsIncidentCollection();
            Incident.FilterByEquipment_ID(EquipmentIncidentFilter);
            //var to store the count of records
            Int32 RecordCount;
            //var to store the index for the loop
            Int32 Index = 0;
            //get the count of records
            RecordCount = Incident.Count;
            //clear the list box
            lstIncidents.Items.Clear();
            //while there are records to process
            while (Index < RecordCount)
            {
                //get the primary key
                Incident_ID = Incident.IncidentList[Index].Incident_ID;
                //get the Staff_ID
                Staff_ID = Incident.IncidentList[Index].Staff_ID;
                //get the Incident_Date_Occured
                Incident_Date_Occured = Incident.IncidentList[Index].Incident_Date_Occured;
                //get the Incident_Description
                Incident_Description = Incident.IncidentList[Index].Incident_Description;
                //create an entry for the list box
                //create a new entry for the list box
                ListItem NewEntry = new ListItem(Incident_ID + " " + Staff_ID + " " + Incident_Description + " " + Incident_Date_Occured, Incident_ID.ToString());
                //add the equipment to the list 
                lstIncidents.Items.Add(NewEntry);
                //move the index to the next record
                Index++;
            }
            //return the count of records found
            return RecordCount;
        }

        protected void btnFilterByAssignTo_Click(object sender, EventArgs e)
        {
            //display only incident matching the text in the search text box
            DisplayIncidentAssignIncidentTo(txtFilterByAssignIncidentTo.Text);
        }

        Int32 DisplayIncidentAssignIncidentTo(string AssignIncidentToFilter)
        {
            //var to store the primary key
            Int32 Incident_ID;
            //var to store the Staff_ID
            Int32 Staff_ID;
            //var to store the Incident_Date_Occured
            DateTime Incident_Date_Occured;
            //var to store the Incident_Description
            String Incident_Description;
            //create an instance of the equipment collecion
            clsIncidentCollection Incident = new clsIncidentCollection();
            Incident.FilterByIncident_Assign_Incident_To(AssignIncidentToFilter);
            //var to store the count of records
            Int32 RecordCount;
            //var to store the index for the loop
            Int32 Index = 0;
            //get the count of records
            RecordCount = Incident.Count;
            //clear the list box
            lstIncidents.Items.Clear();
            //while there are records to process
            while (Index < RecordCount)
            {
                //get the primary key
                Incident_ID = Incident.IncidentList[Index].Incident_ID;
                //get the Staff_ID
                Staff_ID = Incident.IncidentList[Index].Staff_ID;
                //get the Incident_Date_Occured
                Incident_Date_Occured = Incident.IncidentList[Index].Incident_Date_Occured;
                //get the Incident_Description
                Incident_Description = Incident.IncidentList[Index].Incident_Description;
                //create an entry for the list box
                //create a new entry for the list box
                ListItem NewEntry = new ListItem(Incident_ID + " " + Staff_ID + " " + Incident_Description + " " + Incident_Date_Occured, Incident_ID.ToString());
                //add the equipment to the list 
                lstIncidents.Items.Add(NewEntry);
                //move the index to the next record
                Index++;
            }
            //return the count of records found
            return RecordCount;
        }

        protected void btnFilterByClosedIncident_Click(object sender, EventArgs e)
        {
            //display only incident matching the text in the search text box
            DisplayClosedIncidents(txtFilterByClosedIncident.Text);
        }

        Int32 DisplayClosedIncidents(string ClosedIncidentFilter)
        {
            //var to store the primary key
            Int32 Incident_ID;
            //var to store the Staff_ID
            Int32 Staff_ID;
            //var to store the Incident_Date_Occured
            DateTime Incident_Date_Occured;
            //var to store the Incident_Description
            String Incident_Description;
            //create an instance of the equipment collecion
            clsIncidentCollection Incident = new clsIncidentCollection();
            Incident.FilterByIncident_Close(ClosedIncidentFilter);
            //var to store the count of records
            Int32 RecordCount;
            //var to store the index for the loop
            Int32 Index = 0;
            //get the count of records
            RecordCount = Incident.Count;
            //clear the list box
            lstIncidents.Items.Clear();
            //while there are records to process
            while (Index < RecordCount)
            {
                //get the primary key
                Incident_ID = Incident.IncidentList[Index].Incident_ID;
                //get the Staff_ID
                Staff_ID = Incident.IncidentList[Index].Staff_ID;
                //get the Incident_Date_Occured
                Incident_Date_Occured = Incident.IncidentList[Index].Incident_Date_Occured;
                //get the Incident_Description
                Incident_Description = Incident.IncidentList[Index].Incident_Description;
                //create an entry for the list box
                //create a new entry for the list box
                ListItem NewEntry = new ListItem(Incident_ID + " " + Staff_ID + " " + Incident_Description + " " + Incident_Date_Occured, Incident_ID.ToString());
                //add the equipment to the list 
                lstIncidents.Items.Add(NewEntry);
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