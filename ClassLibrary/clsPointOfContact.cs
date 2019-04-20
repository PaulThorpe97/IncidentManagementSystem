using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsPointOfContact
    {
        //private data member for the Incident_ID property
        private Int32 mIncident_ID;
        //private data member for the Point_Of_Contact_Comment property
        private String mPoint_Of_Contact_Comment;
        //private data member for the Point_Of_Contact_ID property
        private Int32 mPoint_Of_Contact_ID;
        //private data member for the Staff_ID property
        private Int32 mStaff_ID;


        //public property for Incident_ID
        public int Incident_ID
        {
            get
            {
                //return the private data
                return mIncident_ID;
            }
            set
            {
                //set the value of the private data member
                mIncident_ID = value;
            }
        }

        //public property for Point_Of_Contact_Comment
        public string Point_Of_Contact_Comment
        {
            get
            {
                //return the private data
                return mPoint_Of_Contact_Comment;
            }
            set
            {
                //set the value of the private data member
                mPoint_Of_Contact_Comment = value;
            }
        }

        //public property for Point_Of_Contact_ID
        public int Point_Of_Contact_ID
        {
            get
            {
                //return the private data
                return mPoint_Of_Contact_ID;
            }
            set
            {
                //set the value of the private data member
                mPoint_Of_Contact_ID = value;
            }
        }

        //public property for Staff_ID
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


        public bool Find(int Point_Of_Contact_ID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Equipment_ID to search for
            DB.AddParameter("@Point_Of_Contact_ID", Point_Of_Contact_ID);
            //execute the stored procedure
            DB.Execute("sproc_tbl_Point_Of_Contact_Filter_By_Point_Of_Contact_ID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mIncident_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Incident_ID"]);
                mPoint_Of_Contact_Comment = Convert.ToString(DB.DataTable.Rows[0]["Point_Of_Contact_Comment"]);
                mPoint_Of_Contact_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Point_Of_Contact_ID"]);
                mStaff_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Staff_ID"]);
                //return that everything worked ok
                return true;
            }
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string point_Of_Contact_Comment)
        {
            //create a string to store the error
            String Error = "";
            //if the Equipment_Name is blank
            if (point_Of_Contact_Comment.Length == 0)
            {
                //record the error
                Error = Error + "The comment cannot be blank: ";
            }
            //if the Equipment_Name is too long
            if (point_Of_Contact_Comment.Length > 50)
            {
                //record the error
                Error = Error + "The comment must be less than 50 characters: ";
            }
            //return any error messages
            return Error;
        }
    }
}
