using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member forThisStaff
        clsStaff mThisStaff = new clsStaff();
        //public property for the staff list
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        //public property for ThisStaff
        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }
        }

        //constructor for the class
        public clsStaffCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tbl_Staff_Select_All");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a new record to the database based on the values of ThisStaff
            //conect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Staff_Forename", mThisStaff.Staff_Forename);
            DB.AddParameter("@Staff_Phone", mThisStaff.Staff_Phone);
            DB.AddParameter("@Staff_Surname", mThisStaff.Staff_Surname);
            DB.AddParameter("@Role_ID", mThisStaff.Role_ID);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tbl_Staff_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by ThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Staff_ID", mThisStaff.Staff_ID);
            //execute the stored procedure
            DB.Execute("sproc_tbl_Staff_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of ThisStaff
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Staff_ID", mThisStaff.Staff_ID);
            DB.AddParameter("@Staff_Forename", mThisStaff.Staff_Forename);
            DB.AddParameter("@Staff_Phone", mThisStaff.Staff_Phone);
            DB.AddParameter("@Staff_Surname", mThisStaff.Staff_Surname);
            DB.AddParameter("@Role_ID", mThisStaff.Role_ID);
            //execute the stored procedure
            DB.Execute("sproc_tbl_Staff_Update");
        }

        //filters the records based on staff surname
        public void FilterByStaff_Surname(string Staff_Surname)
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Staff_Surname parameter to the database
            DB.AddParameter("@Staff_Surname", Staff_Surname);
            //execute the stored procedure
            DB.Execute("sproc_tbl_Staff_Filter_By_Staff_Surname");
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
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank equipment
                clsStaff AnStaff = new clsStaff();
                //read in the fields from the current record
                AnStaff.Staff_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Staff_ID"]);
                AnStaff.Staff_Forename = Convert.ToString(DB.DataTable.Rows[Index]["Staff_Forename"]);
                AnStaff.Staff_Phone = Convert.ToString(DB.DataTable.Rows[Index]["Staff_Phone"]);
                AnStaff.Staff_Surname = Convert.ToString(DB.DataTable.Rows[Index]["Staff_Surname"]);
                AnStaff.Role_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Role_ID"]);
                //add the record to the private data member
                mStaffList.Add(AnStaff);
                //point at the next record
                Index++;
            }
        }
    }
}
