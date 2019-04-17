using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsPointOfContactCollection
    {
        //private data member for the list
        List<clsPointOfContact> mPointOfContactList = new List<clsPointOfContact>();
        //private data member forThisPointOfContact
        clsPointOfContact mThisPointOfContact = new clsPointOfContact();
        //public property for the PointOfContact list
        public List<clsPointOfContact> PointOfContactList
        {
            get
            {
                //return the private data
                return mPointOfContactList;
            }
            set
            {
                //set the private data
                mPointOfContactList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mPointOfContactList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        //public property for ThisPointOfContact
        public clsPointOfContact ThisPointOfContact
        {
            get
            {
                //return the private data
                return mThisPointOfContact;
            }
            set
            {
                //set the private data
                mThisPointOfContact = value;
            }
        }

        //constructor for the class
        public clsPointOfContactCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tbl_Point_Of_Contact_Select_All");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int PointOfContactAdd()
        {
            //adds a new record to the database based on the values of ThisPointOfContact
            //conect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Incident_ID", mThisPointOfContact.Incident_ID);
            DB.AddParameter("@Point_Of_Contact_Comment", mThisPointOfContact.Point_Of_Contact_Comment);
            DB.AddParameter("@Staff_ID", mThisPointOfContact.Staff_ID);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tbl_Point_Of_Contact_Insert");
        }

        public void PointOfContactDelete()
        {
            //deletes the record pointed to by ThisPointOfContact
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Point_Of_Contact_ID", mThisPointOfContact.Point_Of_Contact_ID);
            //execute the stored procedure
            DB.Execute("sproc_tbl_Point_Of_Contact_Delete");
        }

        public void PointOfContactUpdate()
        {
            //update an existing record based on the values of ThisPointOfContact
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Incident_ID", mThisPointOfContact.Incident_ID);
            DB.AddParameter("@Point_Of_Contact_Comment", mThisPointOfContact.Point_Of_Contact_Comment);
            DB.AddParameter("@Point_Of_Contact_ID", mThisPointOfContact.Point_Of_Contact_ID);
            DB.AddParameter("@Staff_ID", mThisPointOfContact.Staff_ID);
            //execute the stored procedure
            DB.Execute("sproc_tbl_Point_Of_Contact_Update");
        }

        //filters the records based on Staff_ID
        public void FilterByIncident_ID(string Incident_ID)
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Equipment_Name parameter to the database
            DB.AddParameter("@Incident_ID", Incident_ID);
            //execute the stored procedure
            DB.Execute("sproc_tbl_Point_Of_Contact_Filter_By_Incident_ID");
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
            mPointOfContactList = new List<clsPointOfContact>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank Point Of Contact
                clsPointOfContact AnPointOfContact = new clsPointOfContact();
                //read in the fields from the current record
                AnPointOfContact.Incident_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Incident_ID"]);
                AnPointOfContact.Point_Of_Contact_Comment = Convert.ToString(DB.DataTable.Rows[Index]["Point_Of_Contact_Comment"]);
                AnPointOfContact.Point_Of_Contact_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Point_Of_Contact_ID"]);
                AnPointOfContact.Staff_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Staff_ID"]);
                //add the record to the private data member
                mPointOfContactList.Add(AnPointOfContact);
                //point at the next record
                Index++;
            }
        }
    }
}
