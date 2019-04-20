using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontEnd
{
    public partial class AdministratorEditEquipmentScreen : System.Web.UI.Page
    {
        //variable to store the primary key with page level scope
        Int32 Equipment_ID;

        //event handler for the page load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the equipment to be processed
            Equipment_ID = Convert.ToInt32(Session["Equipment_ID"]);
            if (IsPostBack == false)
            {
                //populate the list of equipment
                DisplayEquipment();
                //if this is not a new record
                if (Equipment_ID != -1)
                {
                    //DisplayEquipment the current data for the record
                    DisplayEquipment();
                }
            }
        }


        //function for adding new records
        void Add()
        {
            //create an instance of the equipment collecion
            clsEquipmentCollection AddEquipment = new clsEquipmentCollection();
            //validate the data on the web form
            String Error = AddEquipment.ThisEquipment.Valid(txtEditEquipmentName.Text, txtEditEquipmentDescription.Text);
            //if the data is ok then add it to the object
            if (Error == "")
            {
                //get the data entered by the user
                AddEquipment.ThisEquipment.Equipment_Name = txtEditEquipmentName.Text;
                AddEquipment.ThisEquipment.Equipment_Hardware = chkEditEquipmentHardware.Checked;
                AddEquipment.ThisEquipment.Equipment_Software = chkEditEquipmentSoftware.Checked;
                AddEquipment.ThisEquipment.Equipment_Description = txtEditEquipmentDescription.Text;
                //add the record
                AddEquipment.Add();
                //all done so redirect back to the main page
                Response.Redirect("AdministratorEquipmentScreen.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
            }
        }


        //function for updating records
        void Update()
        {
            //create an instance of the equipment
            clsEquipmentCollection Equipment = new clsEquipmentCollection();
            //validate the data entered by the user
            String Error = Equipment.ThisEquipment.Valid(txtEditEquipmentName.Text, txtEditEquipmentDescription.Text);
            //if the data is ok then add it to the object
            if (Error == "")
            {
                //find the record to update
                Equipment.ThisEquipment.Find(Equipment_ID);
                //get the data entered by the user
                Equipment.ThisEquipment.Equipment_Name = txtEditEquipmentName.Text;
                Equipment.ThisEquipment.Equipment_Hardware = chkEditEquipmentHardware.Checked;
                Equipment.ThisEquipment.Equipment_Software = chkEditEquipmentSoftware.Checked;
                Equipment.ThisEquipment.Equipment_Description = txtEditEquipmentDescription.Text;
                //update the record
                Equipment.Update();
                //all done so redirect back to the main page
                Response.Redirect("AdministratorEquipmentScreen.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
            }
        }

        void DisplayEquipment()
        {
            //creat an instance of the equipment
            clsEquipmentCollection Equipment = new clsEquipmentCollection();
            //find the record to update
            Equipment.ThisEquipment.Find(Equipment_ID);
            //display the data for this record
            txtEditEquipmentName.Text = Equipment.ThisEquipment.Equipment_Name;
            chkEditEquipmentHardware.Checked = Equipment.ThisEquipment.Equipment_Hardware;
            chkEditEquipmentSoftware.Checked = Equipment.ThisEquipment.Equipment_Software;
            txtEditEquipmentDescription.Text = Equipment.ThisEquipment.Equipment_Description;
        }

        protected void btnEditEquipmentCancel_Click(object sender, EventArgs e)
        {
            //direct to home screen
            Response.Redirect("AdministratorEquipmentScreen.aspx");
        }

        //event handler for the edit equipment button
        protected void btnEditEquipment_Click(object sender, EventArgs e)
        {
            if (Equipment_ID == -1)
            {
                //add the new record
                Add();
            }
            else
            {
                //update the new record
                Update();
            }
        }
    }   
}
    
