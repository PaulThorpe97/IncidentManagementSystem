using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontEnd
{
    public partial class AdministratorDeleteEquipmentScreen : System.Web.UI.Page
    {
        //var to store the primary key value of the record to be deleted
        Int32 Equipment_ID;

        //event handler for the load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the equipment to be deleted from the session object
            Equipment_ID = Convert.ToInt32(Session["Equipment_ID"]);
        }

        //function to delete the selected record
        void DeleteEquipment()
        {
            //create a new instance of the equipment
            clsEquipmentCollection Equipment = new clsEquipmentCollection();
            //find the record to delete
            Equipment.ThisEquipment.Find(Equipment_ID);
            //delete the record
            Equipment.Delete();
        }

        //event handler for the yes button
        protected void btnDeleteEquipmentYes_Click(object sender, EventArgs e)
        {
            //delete the record
            DeleteEquipment();
            //redirect to the main page
            Response.Redirect("AdministratorEquipmentScreen.aspx");
        }

        //event handler for the no button
        protected void btnDeleteEquipmentNo_Click(object sender, EventArgs e)
        {
            //redirect to the main page
            Response.Redirect("AdministratorEquipmentScreen.aspx");
        }
    }
}