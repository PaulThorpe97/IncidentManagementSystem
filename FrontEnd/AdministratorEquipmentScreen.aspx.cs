using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontEnd
{
    public partial class AdministratorEquipmentScreen : System.Web.UI.Page
    {
        //this function handles he load eent for the page
        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the first ime the page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplayEquipment();
            }
        }

        void DisplayEquipment()
        {
            //create an instance of the equipment collecion
            clsEquipmentCollection Equipment = new clsEquipmentCollection();
            //set the data source to the list of the equipment in the collection
            lstEquipment.DataSource = Equipment.EquipmentList;
            //set the name of the primary key
            lstEquipment.DataValueField = "Equipment_ID";
            //set the data field to display
            lstEquipment.DataTextField = "Equipment_Name";
            //bind the data to the list
            lstEquipment.DataBind();
        }

        protected void btnAddEquipment_Click(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate his is a new record
            Session["Equipment_ID"] = -1;
            //redirect to the data entry page
            Response.Redirect("AdministratorAddNewEquipmentScreen.aspx");
        }
    }
}