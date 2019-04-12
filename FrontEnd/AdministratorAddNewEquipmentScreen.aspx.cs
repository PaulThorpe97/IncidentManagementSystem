using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontEnd
{
    public partial class AdministratorAddNewEquipmentScreen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //function for adding new records
        void Add()
        {
            //create an instance of the equipment collecion
            clsEquipmentCollection AddEquipment = new clsEquipmentCollection();
            //validate the data on the web form
            String Error = AddEquipment.ThisEquipment.Valid(txtAddEquipmentName.Text, txtAddEquipmentDescription.Text);
            //i the data is ok then add it to the object
            if (Error == "")
            {
                //get the data entered by the user
                AddEquipment.ThisEquipment.Equipment_Name = txtAddEquipmentName.Text;
                AddEquipment.ThisEquipment.Equipment_Hardware = chkAddHardware.Checked;
                AddEquipment.ThisEquipment.Equipment_Software = chkAddSoftware.Checked;
                AddEquipment.ThisEquipment.Equipment_Description = txtAddEquipmentDescription.Text;
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


        //event handler for btnAddEquipment
        protected void btnAddEquipment_Click(object sender, EventArgs e)
        {
            //add the new record
            Add();
            //all done so redirect to the main page
            Response.Redirect("AdministratorEquipmentScreen.aspx");
        }

        protected void chkAddHardware_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAddHardware.Checked == true)
            {
                chkAddSoftware.Checked = false;
            }
            else
            {
                chkAddSoftware.Checked = true;
            }

        }

        protected void chkAddSoftware_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAddSoftware.Checked == true)
            {
                chkAddHardware.Checked = false;
            }
            else
            {
                chkAddHardware.Checked = true;
            }
        }


        //event handler for btnEquipmentCancel
        protected void btnAddEquipmentCancel_Click(object sender, EventArgs e)
        {
            //direct to home screen
            Response.Redirect("AdministratorEquipmentScreen.aspx");
        }
    }
}