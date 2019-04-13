using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ClassLibrary
{
    public class clsStaff
    {
        //private data member for the Staff_Forename property
        private String mStaff_Forename;
        //private data member for the Staff_ID property
        private Int32 mStaff_ID;
        //private data member for the Staff_Phone property
        private String mStaff_Phone;
        //private data member for the Staff_Surname property
        private String mStaff_Surname;
        //private data member for the Role_ID property
        private Int32 mRole_ID;

        //public property for Staff_Forename
        public string Staff_Forename
        {
            get
            {
                //return the private data
                return mStaff_Forename;
            }
            set
            {
                //set the value of the private data member
                mStaff_Forename = value;
            }
        }

        public int Staff_ID
        {
            get
            {
                //return the private data
                return mStaff_ID;
            }
            set
            {
                //set the value of the private data member
                mStaff_ID = value;
            }
        }

        public string Staff_Phone
        {
            get
            {
                //return the private data
                return mStaff_Phone;
            }
            set
            {
                //set the value of the private data member
                mStaff_Phone = value;
            }
        }

        public string Staff_Surname
        {
            get
            {
                //return the private data
                return mStaff_Surname;
            }
            set
            {
                //set the value of the private data member
                mStaff_Surname = value;
            }

        }

        public int Role_ID
        {
            get
            {
                //return the private data
                return mRole_ID;
            }
            set
            {
                //set the value of the private data member
                mRole_ID = value;
            }
        }


        public bool Find(int Staff_ID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Equipment_ID to search for
            DB.AddParameter("@Staff_ID", Staff_ID);
            //execute the stored procedure
            DB.Execute("sproc_tbl_Staff_Filter_By_Staff_ID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaff_Forename = Convert.ToString(DB.DataTable.Rows[0]["Staff_Forename"]);
                mStaff_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Staff_ID"]);
                mStaff_Phone = Convert.ToString(DB.DataTable.Rows[0]["Staff_Phone"]);
                mStaff_Surname = Convert.ToString(DB.DataTable.Rows[0]["Staff_Surname"]);
                mRole_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Role_ID"]);
                //return that everything worked ok
                return true;
            }
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string staff_Forename, string staff_Phone, string staff_Surname)
        {
            //create a string to store the error
            String Error = "";
            //if the Staff_Forename is blank
            if (staff_Forename.Length == 0)
            {
                //record the error
                Error = Error + "The Staff Forename cannot be blank: ";
            }
            //if the Staff_Forename is too long
            if (staff_Forename.Length > 50)
            {
                //record the error
                Error = Error + "The Staff Forename must be less than 50 characters: ";
            }
            //if the Staff_Phone is blank
            if (staff_Phone.Length == 0)
            {
                //record the error
                Error = Error + "The Staff Phone cannot be blank: ";
            }
            //if the Staff_Phone is too long
            if (staff_Phone.Length > 11)
            {
                //record the error
                Error = Error + "The Staff Phone must be less than 50 characters: ";
            }
            //if the Staff_Surname is blank
            if (staff_Surname.Length == 0)
            {
                //record the error
                Error = Error + "The Staff Surname cannot be blank: ";
            }
            //if the Staff_Surname is too long
            if (staff_Surname.Length > 50)
            {
                //record the error
                Error = Error + "The Staff Surname  must be less than 50 characters: ";
            }
            //return any error messages
            return Error;
        }
    }
}
