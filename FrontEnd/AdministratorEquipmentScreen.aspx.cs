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
        //this function handles he load event for the page
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


        //event handler for the add button
        protected void btnAddEquipment_Click(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate his is a new record
            Session["Equipment_ID"] = -1;
            //redirect to the data entry page
            Response.Redirect("AdministratorAddNewEquipmentScreen.aspx");
        }

        //event handler for the delete button
        protected void btnDeleteEquipmentDetails_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted 
            Int32 Equipment_ID;
            //if a record has been selected from the list
            if (lstEquipment.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                Equipment_ID = Convert.ToInt32(lstEquipment.SelectedValue);
                //store the data in the session object
                Session["Equipment_ID"] = Equipment_ID;
                //redirect to the delete page
                Response.Redirect("AdministratorDeleteEquipmentScreen.aspx");
            }
            else //if no record has been selected 
            {
                //display an error
                lblError.Text = "Please select a record to delete from the list";
            }

        }

        //Event Handler for the edit button
        protected void btnEditEquipmentDetails_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to edit 
            Int32 Equipment_ID;
            //if a record has been selected from the list
            if (lstEquipment.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                Equipment_ID = Convert.ToInt32(lstEquipment.SelectedValue);
                //store the data in the session object
                Session["Equipment_ID"] = Equipment_ID;
                //redirect to the edit page
                Response.Redirect("AdministratorEditEquipmentScreen.aspx");
            }
            else //if no record has been selected 
            {
                //display an error
                lblError.Text = "Please select a record to edit from the list";
            }
        }
    }
}