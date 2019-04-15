using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsIncidentCollection
    {
        //private data member for the list
        List<clsIncident> mIncidentList = new List<clsIncident>();
        //private data member forThisIncident
        clsIncident mThisIncident = new clsIncident();
        //public property for the Incident list
        public List<clsIncident> IncidentList
        {
            get
            {
                //return the private data
                return mIncidentList;
            }
            set
            {
                //set the private data
                mIncidentList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mIncidentList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        //public property for ThisIncident
        public clsIncident ThisIncident
        {
            get
            {
                //return the private data
                return mThisIncident;
            }
            set
            {
                //set the private data
                mThisIncident = value;
            }
        }

        //constructor for the class
        public clsIncidentCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tbl_Incident_Select_All");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a new record to the database based on the values of ThisIncident
            //conect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Incident_Date_Occured", mThisIncident.Incident_Date_Occured);
            DB.AddParameter("@Equipment_ID", mThisIncident.Equipment_ID);
            DB.AddParameter("@Incident_Description", mThisIncident.Incident_Description);
            DB.AddParameter("@Incident_High", mThisIncident.Incident_High);
            DB.AddParameter("@Incident_In_Progress", mThisIncident.Incident_In_Progress);
            DB.AddParameter("@Incident_Low", mThisIncident.Incident_Low);
            DB.AddParameter("@Incident_Medium", mThisIncident.Incident_Medium);
            DB.AddParameter("@Incident_Pending", mThisIncident.Incident_Pending);
            DB.AddParameter("@Staff_ID", mThisIncident.Staff_ID);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tbl_Incident_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by ThisEquipment
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Incident_ID", mThisIncident.Incident_ID);
            //execute the stored procedure
            DB.Execute("sproc_tbl_Incident_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of ThisEquipment
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Incident_Date_Occured", mThisIncident.Incident_Date_Occured);
            DB.AddParameter("@Equipment_ID", mThisIncident.Equipment_ID);
            DB.AddParameter("@Incident_Description", mThisIncident.Incident_Description);
            DB.AddParameter("@Incident_High", mThisIncident.Incident_High);
            DB.AddParameter("@Incident_In_Progress", mThisIncident.Incident_In_Progress);
            DB.AddParameter("@Incident_Low", mThisIncident.Incident_Low);
            DB.AddParameter("@Incident_Medium", mThisIncident.Incident_Medium);
            DB.AddParameter("@Incident_ID", mThisIncident.Incident_ID);
            DB.AddParameter("@Incident_Pending", mThisIncident.Incident_Pending);
            DB.AddParameter("@Staff_ID", mThisIncident.Staff_ID);
            //execute the stored procedure
            DB.Execute("sproc_tbl_Incident_Update");
        }

        //filters the records based on equipment name
        public void FilterByStaff_ID(string Staff_ID)
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Staff_ID parameter to the database
            DB.AddParameter("@Staff_ID", Staff_ID);
            //execute the stored procedure
            DB.Execute("sproc_tbl_Incident_Filter_By_Staff_ID");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        //populates the array list based on the data table in the parameter DB
        void PopulateArray(clsDataConnection DB)
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            //get the count of records
            RecordCount = DB.Count;
            //clear the priate array list
            mIncidentList = new List<clsIncident>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank equipment
                clsIncident AnIncident = new clsIncident();
                //read in the fields from the current record
                AnIncident.Incident_Date_Occured = Convert.ToDateTime(DB.DataTable.Rows[Index]["Incident_Date_Occured"]);
                AnIncident.Equipment_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Equipment_ID"]);
                AnIncident.Incident_Description = Convert.ToString(DB.DataTable.Rows[Index]["Incident_Description"]);
                AnIncident.Incident_High = Convert.ToBoolean(DB.DataTable.Rows[Index]["Incident_High"]);
                AnIncident.Incident_In_Progress = Convert.ToBoolean(DB.DataTable.Rows[Index]["Incident_In_Progress"]);
                AnIncident.Incident_Low = Convert.ToBoolean(DB.DataTable.Rows[Index]["Incident_Low"]);
                AnIncident.Incident_Medium = Convert.ToBoolean(DB.DataTable.Rows[Index]["Incident_Medium"]);
                AnIncident.Incident_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Incident_ID"]);
                AnIncident.Incident_Pending= Convert.ToBoolean(DB.DataTable.Rows[Index]["Incident_Pending"]);
                AnIncident.Staff_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Staff_ID"]);
                //add the record to the private data member
                mIncidentList.Add(AnIncident);
                //point at the next record
                Index++;
            }
        }
    }
}
