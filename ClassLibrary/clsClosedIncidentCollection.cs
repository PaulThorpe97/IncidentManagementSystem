using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsClosedIncidentCollection
    {
        //private data member for the list
        List<clsClosedIncident> mClosedIncidentList = new List<clsClosedIncident>();
        //private data member forThisClosedIncident
        clsClosedIncident mThisClosedIncident = new clsClosedIncident();
        //public property for the ClosedIncident list
        public List<clsClosedIncident> ClosedIncidentList
        {
            get
            {
                //return the private data
                return mClosedIncidentList;
            }
            set
            {
                //set the private data
                mClosedIncidentList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mClosedIncidentList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        //public property for ThisClosedIncident
        public clsClosedIncident ThisClosedIncident
        {
            get
            {
                //return the private data
                return mThisClosedIncident;
            }
            set
            {
                //set the private data
                mThisClosedIncident = value;
            }
        }

        //constructor for the class
        public clsClosedIncidentCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tbl_Closed_Incident_Select_All");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a new record to the database based on the values of ThisClosedIncident
            //conect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Closed_Incident_Date_Closed", mThisClosedIncident.Closed_Incident_Date_Closed);
            DB.AddParameter("@Closed_Incident_Description", mThisClosedIncident.Closed_Incident_Description);
            DB.AddParameter("@Closed_Incident_ID", mThisClosedIncident.Closed_Incident_ID);
            DB.AddParameter("@Incident_ID", mThisClosedIncident.Incident_ID);
            DB.AddParameter("@Staff_ID", mThisClosedIncident.Staff_ID);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tbl_Closed_Incident_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by ThisClosedIncident
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Closed_Incident_ID", mThisClosedIncident.Closed_Incident_ID);
            //execute the stored procedure
            DB.Execute("sproc_tbl_Closed_Incident_ID_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of ThisClosedIncident
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Closed_Incident_Date_Closed", mThisClosedIncident.Closed_Incident_Date_Closed);
            DB.AddParameter("@Closed_Incident_Description", mThisClosedIncident.Closed_Incident_Description);
            DB.AddParameter("@Closed_Incident_ID", mThisClosedIncident.Closed_Incident_ID);
            DB.AddParameter("@Incident_ID", mThisClosedIncident.Incident_ID);
            DB.AddParameter("@Staff_ID", mThisClosedIncident.Staff_ID);
            //execute the stored procedure
            DB.Execute("sproc_tbl_Closed_Incident_Update");
        }

        //filters the records based on Incident_ID
        public void FilterByIncident_ID(string Incident_ID)
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Incident_ID parameter to the database
            DB.AddParameter("@Incident_ID", Incident_ID);
            //execute the stored procedure
            DB.Execute("sproc_tbl_Closed_Incident_Filter_By_Incident_ID");
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
            mClosedIncidentList = new List<clsClosedIncident>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank equipment
                clsClosedIncident AnClosedIncident = new clsClosedIncident();
                //read in the fields from the current record
                AnClosedIncident.Closed_Incident_Date_Closed = Convert.ToDateTime(DB.DataTable.Rows[Index]["Closed_Incident_Date_Closed "]);
                AnClosedIncident.Closed_Incident_Description = Convert.ToString(DB.DataTable.Rows[Index]["Closed_Incident_Description"]);
                AnClosedIncident.Closed_Incident_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Closed_Incident_ID"]);
                AnClosedIncident.Incident_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Incident_ID"]);
                AnClosedIncident.Staff_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Staff_ID"]);
                //add the record to the private data member
                mClosedIncidentList.Add(AnClosedIncident);
                //point at the next record
                Index++;
            }
        }
    }
}