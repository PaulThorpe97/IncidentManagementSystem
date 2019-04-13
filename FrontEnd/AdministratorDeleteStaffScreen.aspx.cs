using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontEnd
{
    public partial class AdministratorDeleteStaffScreen : System.Web.UI.Page
    {
        //var to store the primary key value of the record to be deleted
        Int32 Staff_ID;

        //event handler for the load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the staff to be deleted from the session object
            Staff_ID = Convert.ToInt32(Session["Staff_ID"]);
        }

        //function to delete the selected record
        void DeleteStaff()
        {
            //create a new instance of the equipment
            clsStaffCollection Staff = new clsStaffCollection();
            //find the record to delete
            Staff.ThisStaff.Find(Staff_ID);
            //delete the record
            Staff.Delete();
        }

        //event handler for the yes button
        protected void btnDeleteStaffYes_Click(object sender, EventArgs e)
        {
            //delete the record
            DeleteStaff();
            //redirect to the main page
            Response.Redirect("AdministratorStaffScreen.aspx");
        }

        //event handler for the no button
        protected void btnDeleteStaffNo_Click(object sender, EventArgs e)
        {
            //redirect to the main page
            Response.Redirect("AdministratorStaffScreen.aspx");
        }
    }
}