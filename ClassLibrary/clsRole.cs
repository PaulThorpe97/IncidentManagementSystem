using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ClassLibrary
{
    public class clsRole
    {
        //private data member for the Role_ID property
        private Int32 mRole_ID;
        //private data member for the Role_Description property
        private String mRole_Description;

        //public property for Equipment_ID
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

        public string Role_Description
        {
            get
            {
                //return the private data
                return mRole_Description;
            }
            set
            {
                //set the value of the private data member
                mRole_Description = value;
            }
        }

       

        public bool Find(int Role_ID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Role_ID to search for
            DB.AddParameter("@Role_ID", Role_ID);
            //execute the stored procedure
            DB.Execute("sproc_tbl_Role_Title_Filter_By_Role_ID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mRole_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Role_ID"]);
                mRole_Description = Convert.ToString(DB.DataTable.Rows[0]["Role_Description"]);
                //return that everything worked ok
                return true;
            }
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string role_Description)
        {
            //create a string to store the error
            String Error = "";
            //if the Role_Description is blank
            if (role_Description.Length == 0)
            {
                //record the error
                Error = Error + "The Role Description cannot be blank: ";
            }
            //if the Role_Description is too long
            if (role_Description.Length > 50)
            {
                //record the error
                Error = Error + "The Role Description must be less than 50 characters: ";
            }
            //return any error messages
            return Error;
        }
    }
}
