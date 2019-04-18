using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsClosedIncident
    {
        //private data member for the Closed_Incident_Date_Closedproperty
        private DateTime mClosed_Incident_Date_Closed;
        //private data member for the Closed_Incident_Description property
        private String mClosed_Incident_Description;
        //private data member for the Closed_Incident_ID property
        private Int32 mClosed_Incident_ID;
        //private data member for the Incident_ID property
        private Int32 mIncident_ID;
        //private data member for the Staff_ID property
        private Int32 mStaff_ID;

        //public property for Closed_Incident_Date_Closed
        public DateTime Closed_Incident_Date_Closed
        {
            get
            {
                //return the private data
                return mClosed_Incident_Date_Closed;
            }
            set
            {
                //set the value of the private data member
                mClosed_Incident_Date_Closed = value;
            }
        }

        //public property for Closed_Incident_Description
        public String Closed_Incident_Description
        {
            get
            {
                //return the private data
                return mClosed_Incident_Description;
            }
            set
            {
                //set the value of the private data member
                mClosed_Incident_Description = value;
            }
        }

        //public property for Closed_Incident_ID
        public Int32 Closed_Incident_ID
        {
            get
            {
                //return the private data
                return mClosed_Incident_ID;
            }
            set
            {
                //set the value of the private data member
                mClosed_Incident_ID = value;
            }

        }

        //public property for Incident_ID
        public Int32 Incident_ID
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

        //public property for Staff_ID
        public Int32 Staff_ID
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


        public bool Find(int Closed_Incident_ID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Equipment_ID to search for
            DB.AddParameter("@Closed_Incident_ID", Closed_Incident_ID);
            //execute the stored procedure
            DB.Execute("sproc_tbl_Equipment_Filter_By_Incident_ID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mClosed_Incident_Date_Closed = Convert.ToDateTime(DB.DataTable.Rows[0]["Closed_Incident_Date_Closed"]);
                mClosed_Incident_Description = Convert.ToString(DB.DataTable.Rows[0]["Closed_Incident_Description"]);
                mClosed_Incident_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Closed_Incident_ID"]);
                mIncident_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Incident_ID"]);
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

        public string Valid(string closed_Incident_Date_Closed, string closed_Incident_Description)
        {
            //create a string to store the error
            String Error = "";
            //create a temporary variable to store data values
            DateTime DateTemp;
            //copy the incident_Date_Occured value to the DateTemp variable
            DateTemp = Convert.ToDateTime(closed_Incident_Date_Closed);
            //if the Closed_Incident_Date_Closed, is blank
            if (closed_Incident_Date_Closed.Length == 0)
            {
                //record the error
                Error = Error + "The Closed Incident Date Occured cannot be blank: ";
            }
            if (DateTemp < DateTime.Now.Date)
            {
                //record the error
                Error = Error + "The Closed Incident Date cannot be in the past: ";
            }
            if (DateTemp > DateTime.Now.Date)
            {
                //record the error
                Error = Error + "The Closed Incident Date cannot be in the future: ";
            }
            //if the Incident_Description is blank
            if (closed_Incident_Description.Length == 0)
            {
                //record the error
                Error = Error + "The Closed Incident Description cannot be blank: ";
            }
            //if the Incident Description is too long
            if (closed_Incident_Description.Length > 50)
            {
                //record the error
                Error = Error + "The Closed Incident Description must be less than 50 characters: ";
            }
            //return any error messages
            return Error;
        }
    }
}
