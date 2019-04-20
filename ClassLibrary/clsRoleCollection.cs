using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsRoleCollection
    {
        //private data member for the list
        List<clsRole> mRoleList = new List<clsRole>();
        //private data member forThisRole
        clsRole mThisRole = new clsRole();
        //public property for the role list
        public List<clsRole> RoleList
        {
            get
            {
                //return the private data
                return mRoleList;
            }
            set
            {
                //set the private data
                mRoleList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mRoleList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        //public property for ThisRole
        public clsRole ThisRole
        {
            get
            {
                //return the private data
                return mThisRole;
            }
            set
            {
                //set the private data
                mThisRole = value;
            }
        }

        //constructor for the class
        public clsRoleCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tbl_Role_Title_Select_All");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a new record to the database based on the values of ThisRole
            //conect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Role_Description", mThisRole.Role_Description);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tbl_Role_Title_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by ThisRole
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Role_ID", mThisRole.Role_ID);
            //execute the stored procedure
            DB.Execute("sproc_tbl_Role_Title_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of ThisEquipment
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Role_ID", mThisRole.Role_ID);
            DB.AddParameter("@Role_Description", mThisRole.Role_Description);
            //execute the stored procedure
            DB.Execute("sproc_tbl_Role_Title_Update");
        }

        //filters the records based on role description
        public void FilterByRole_Description(string Role_Description)
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Equipment_Name parameter to the database
            DB.AddParameter("@Role_Description", Role_Description);
            //execute the stored procedure
            DB.Execute("sproc_tbl_Role_Title_Filter_By_Role_Description");
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
            mRoleList = new List<clsRole>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank equipment
                clsRole AnRole = new clsRole();
                //read in the fields from the current record
                AnRole.Role_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Role_ID"]);
                AnRole.Role_Description = Convert.ToString(DB.DataTable.Rows[Index]["Role_Description"]);
                //add the record to the private data member
                mRoleList.Add(AnRole);
                //point at the next record
                Index++;
            }
        }
    }
}
