using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsIncident
    {
        //private data member for the Incident_Date_Occured property
        private DateTime mIncident_Date_Occured;
        //private data member for the Equipment_ID property
        private Int32 mEquipment_ID;
        //private data member for the Incident_Description property
        private String mIncident_Description;
        //private data member for the Incident_High property
        private Boolean mIncident_High;
        //private data member for the Incident_In_Progress property
        private Boolean mIncident_In_Progress;
        //private data member for the Incident_Low property
        private Boolean mIncident_Low;
        //private data member for the Incident_Medium property
        private Boolean mIncident_Medium;
        //private data member for the Incident_ID property
        private Int32 mIncident_ID;
        //private data member for the Incident_Pending property
        private Boolean mIncident_Pending;
        //private data member for the Staff_ID property
        private Int32 mStaff_ID;

        //public property for Incident_Date_Occured
        public DateTime Incident_Date_Occured
        {
            get
            {
                //return the private data
                return mIncident_Date_Occured;
            }
            set
            {
                //set the value of the private data member
                mIncident_Date_Occured = value;
            }
        }

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


        //public property for Incident_Description
        public string Incident_Description
        {
            get
            {
                //return the private data
                return mIncident_Description;
            }
            set
            {
                //set the value of the private data member
                mIncident_Description = value;
            }
        }


        //public property for Incident_High
        public bool Incident_High
        {
            get
            {
                //return the private data
                return mIncident_High;
            }
            set
            {
                //set the value of the private data member
                mIncident_High = value;
            }
        }


        //public property for Incident_In_Progress
        public bool Incident_In_Progress
        {
            get
            {
                //return the private data
                return mIncident_In_Progress;
            }
            set
            {
                //set the value of the private data member
                mIncident_In_Progress = value;
            }
        }

        //public property for Incident_Low
        public bool Incident_Low
        {
            get
            {
                //return the private data
                return mIncident_Low;
            }
            set
            {
                //set the value of the private data member
                mIncident_Low = value;
            }
        }

        //public property for Incident_Medium
        public bool Incident_Medium
        {
            get
            {
                //return the private data
                return mIncident_Medium;
            }
            set
            {
                //set the value of the private data member
                mIncident_Medium = value;
            }
        }

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

        //public property for Incident_Pending
        public bool Incident_Pending
        {
            get
            {
                //return the private data
                return mIncident_Pending;
            }
            set
            {
                //set the value of the private data member
                mIncident_Pending = value;
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


        public bool Find(int Equipment_ID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Equipment_ID to search for
            DB.AddParameter("@Incident_ID", Incident_ID);
            //execute the stored procedure
            DB.Execute("sproc_tbl_Incident_Filter_By_Incident_ID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mIncident_Date_Occured = Convert.ToDateTime(DB.DataTable.Rows[0]["Incident_Date_Occured"]);
                mEquipment_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Equipment_ID"]);
                mIncident_Description = Convert.ToString(DB.DataTable.Rows[0]["Incident_Description"]);
                mIncident_High = Convert.ToBoolean(DB.DataTable.Rows[0]["Incident_High"]);
                mIncident_In_Progress = Convert.ToBoolean(DB.DataTable.Rows[0]["Incident_In_Progress"]);
                mIncident_Low = Convert.ToBoolean(DB.DataTable.Rows[0]["Incident_Low"]);
                mIncident_Medium = Convert.ToBoolean(DB.DataTable.Rows[0]["Incident_Medium"]);
                mIncident_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Incident_ID"]);
                mIncident_Pending = Convert.ToBoolean(DB.DataTable.Rows[0]["Incident_Pending"]);
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

        public string Valid(string incident_Date_Occured, string incident_Description)
        {
            //create a string to store the error
            String Error = "";
            //create a temporary variable to store data values
            DateTime DateTemp;
            //copy the incident_Date_Occured value to the DateTemp variable
            DateTemp = Convert.ToDateTime(incident_Date_Occured);
            //if the incident_Date_Occured is blank
            if (incident_Date_Occured.Length == 0)
            {
                //record the error
                Error = Error + "The Incident Date Occured cannot be blank: ";
            }
            if (DateTemp < DateTime.Now.Date)
            {
                //record the error
                Error = Error + "The Incident Date Occured cannot be in the past: ";
            }
            if (DateTemp > DateTime.Now.Date)
            {
                //record the error
                Error = Error + "The Incident Date Occured cannot be in the future: ";
            }
            //if the Incident_Description is blank
            if (incident_Description.Length == 0)
            {
                //record the error
                Error = Error + "The Incident Description cannot be blank: ";
            }
            //if the Incident Description is too long
            if (incident_Description.Length > 50)
            {
                //record the error
                Error = Error + "The Incident Description must be less than 50 characters: ";
            }
            //return any error messages
            return Error;
        }
    }
}


