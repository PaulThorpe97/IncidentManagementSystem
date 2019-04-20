using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsEquipmentCollection
    {
        //private data member for the list
        List<clsEquipment> mEquipmentList = new List<clsEquipment>();
        //private data member forThisEquipment
        clsEquipment mThisEquipment = new clsEquipment();
        //public property for the equipment list
        public List<clsEquipment> EquipmentList
        {
            get
            {
                //return the private data
                return mEquipmentList;
            }
            set
            {
                //set the private data
                mEquipmentList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mEquipmentList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        //public property for ThisEquipment
        public clsEquipment ThisEquipment
        {
            get
            {
                //return the private data
                return mThisEquipment;
            }
            set
            {
                //set the private data
                mThisEquipment = value;
            }
        }

        //constructor for the class
        public clsEquipmentCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tbl_Equipment_Select_All");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a new record to the database based on the values of ThisEquipment
            //conect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Equipment_Name", mThisEquipment.Equipment_Name);
            DB.AddParameter("@Equipment_Hardware", mThisEquipment.Equipment_Hardware);
            DB.AddParameter("@Equipment_Software", mThisEquipment.Equipment_Software);
            DB.AddParameter("@Equipment_Description", mThisEquipment.Equipment_Description);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tbl_Equipment_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by ThisEquipment
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Equipment_ID", mThisEquipment.Equipment_ID);
            //execute the stored procedure
            DB.Execute("sproc_tbl_Equipment_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of ThisEquipment
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Equipment_ID", mThisEquipment.Equipment_ID);
            DB.AddParameter("@Equipment_Name", mThisEquipment.Equipment_Name);
            DB.AddParameter("@Equipment_Hardware", mThisEquipment.Equipment_Hardware);
            DB.AddParameter("@Equipment_Software", mThisEquipment.Equipment_Software);
            DB.AddParameter("@Equipment_Description", mThisEquipment.Equipment_Description);
            //execute the stored procedure
            DB.Execute("sproc_tbl_Equipment_Update");
        }

        //filters the records based on equipment name
        public void FilterByEquipment_Name(string Equipment_Name)
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Equipment_Name parameter to the database
            DB.AddParameter("@Equipment_Name", Equipment_Name);
            //execute the stored procedure
            DB.Execute("sproc_tbl_Equipment_Filter_By_Equipment_Name");
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
            mEquipmentList = new List<clsEquipment>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank equipment
                clsEquipment AnEquipment = new clsEquipment();
                //read in the fields from the current record
                AnEquipment.Equipment_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Equipment_ID"]);
                AnEquipment.Equipment_Name = Convert.ToString(DB.DataTable.Rows[Index]["Equipment_Name"]);
                AnEquipment.Equipment_Hardware = Convert.ToBoolean(DB.DataTable.Rows[Index]["Equipment_Hardware"]);
                AnEquipment.Equipment_Software = Convert.ToBoolean(DB.DataTable.Rows[Index]["Equipment_Software"]);
                AnEquipment.Equipment_Description = Convert.ToString(DB.DataTable.Rows[Index]["Equipment_Description"]);
                //add the record to the private data member
                mEquipmentList.Add(AnEquipment);
                //point at the next record
                Index++;
            }
        }
    }
}