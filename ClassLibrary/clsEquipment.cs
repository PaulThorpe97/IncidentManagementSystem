using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsEquipment
    {
        //private data member for the Equipment_ID property
        private Int32 mEquipment_ID;
        //private data member for the Equipment_Name property
        private String mEquipment_Name;
        //private data member for the Equipment_Hardware property
        private Boolean mEquipment_Hardware;
        //private data member for the Equipment_Software property
        private Boolean mEquipment_Software;
        //private data member for the Equipment_Description property
        private String mEquipment_Description;

        //public property for Equipment_ID
        public int Equipment_ID
        {
            get
            {
                //return the private data
                return mEquipment_ID;
            }
            set
            {
                //set the value of the private data member
                mEquipment_ID = value;
            }
        }

        public string Equipment_Name
        {
            get
            {
                //return the private data
                return mEquipment_Name;
            }
            set
            {
                //set the value of the private data member
                mEquipment_Name = value;
            }
        }

        public bool Equipment_Hardware
        {
            get
            {
                //return the private data
                return mEquipment_Hardware;
            }
            set
            {
                //set the value of the private data member
                mEquipment_Hardware = value;
            }

        }

        public bool Equipment_Software
        {
            get
            {
                //return the private data
                return mEquipment_Software;
            }
            set
            {
                //set the value of the private data member
                mEquipment_Software = value;
            }

        }

        public string Equipment_Description
        {
            get
            {
                //return the private data
                return mEquipment_Description;
            }
            set
            {
                //set the value of the private data member
                mEquipment_Description = value;
            }
        }

        public bool Find (int Equipment_ID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Equipment_ID to search for
            DB.AddParameter("@Equipment_ID", Equipment_ID);
            //execute the stored procedure
            DB.Execute("sproc_tbl_Equipment_Filter_By_Equipment_ID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count==1)
            {
                //copy the data from the database to the private data members
                mEquipment_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Equipment_ID"]);
                mEquipment_Name = Convert.ToString(DB.DataTable.Rows[0]["Equipment_Name"]);
                mEquipment_Hardware = Convert.ToBoolean(DB.DataTable.Rows[0]["Equipment_Hardware"]);
                mEquipment_Software = Convert.ToBoolean(DB.DataTable.Rows[0]["Equipment_Software"]);
                mEquipment_Description = Convert.ToString(DB.DataTable.Rows[0]["Equipment_Description"]);
                //return that everything worked ok
                return true;
            }
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string equipment_Name, string equipment_Description)
        {
            //create a string to store the error
            String Error = "";
            //if the Equipment_Name is blank
            if (equipment_Name.Length == 0)
            {
                //record the error
                Error = Error + "The Equipment Name cannot be blank: ";
            }
            //if the Equipment_Name is too long
            if (equipment_Name.Length > 50)
            {
                //record the error
                Error = Error + "The Equipment Name must be less than 50 characters: ";
            }
            //if the Equipment_Description is blank
            if (equipment_Description.Length == 0)
            {
                //record the error
                Error = Error + "The Equipment Description cannot be blank: ";
            }
            //if the Equipment_Description is too long
            if (equipment_Description.Length > 50)
            {
                //record the error
                Error = Error + "The Equipment Description must be less than 50 characters: ";
            }
            //return any error messages
            return Error;
        }
    }
}