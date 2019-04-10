using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestLibrary
{
    [TestClass]
    public class tstEquipmentCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsEquipmentCollection AEquipment = new clsEquipmentCollection();
            //test to see that it exists
            Assert.IsNotNull(AEquipment);
        }

        [TestMethod]
        public void EquipmentListOK()
        {
            //create an instance of the class we want to create
            clsEquipmentCollection AllEquipment = new clsEquipmentCollection();
            //create some test data to assign to the property
            //in this case the data needs  to be a list of objects
            List<clsEquipment> TestList = new List<clsEquipment>();
            //add an item to the list
            //create the item of test data
            clsEquipment TestItem = new clsEquipment();
            //set its properties
            TestItem.Equipment_ID = 1;
            TestItem.Equipment_Name = "Microsoft Word";
            TestItem.Equipment_Hardware = false;
            TestItem.Equipment_Software = true;
            TestItem.Equipment_Description = "Microsoft Office Application";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllEquipment.EquipmentList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllEquipment.EquipmentList, TestList);
        }

        [TestMethod]
        public void ThisEquipmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsEquipmentCollection AllEquipment = new clsEquipmentCollection();
            //create some test data to assign to the property
            clsEquipment TestEquipment = new clsEquipment();
            //set the properties of the test object
            TestEquipment.Equipment_ID = 1;
            TestEquipment.Equipment_Name = "Microsoft Word";
            TestEquipment.Equipment_Hardware = false;
            TestEquipment.Equipment_Software = true;
            TestEquipment.Equipment_Description = "Microsoft Office Application";
            //assign the data to the property
            AllEquipment.ThisEquipment = TestEquipment;
            //test to see that the two values are the same
            Assert.AreEqual(AllEquipment.ThisEquipment, TestEquipment);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsEquipmentCollection AllEquipment = new clsEquipmentCollection();
            //create some test data to assign to the property
            //in this case the data needs  to be a list of objects
            List<clsEquipment> TestList = new List<clsEquipment>();
            //add an item to the list
            //create the item of test data
            clsEquipment TestItem = new clsEquipment();
            //set its properties
            TestItem.Equipment_ID = 1;
            TestItem.Equipment_Name = "Microsoft Word";
            TestItem.Equipment_Hardware = false;
            TestItem.Equipment_Software = true;
            TestItem.Equipment_Description = "Microsoft Office Application";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllEquipment.EquipmentList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllEquipment.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsEquipmentCollection AllEquipment = new clsEquipmentCollection();
            //create the item of test data
            clsEquipment TestItem = new clsEquipment();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Equipment_ID = 1;
            TestItem.Equipment_Name = "Microsoft Word";
            TestItem.Equipment_Hardware = false;
            TestItem.Equipment_Software = true;
            TestItem.Equipment_Description = "Microsoft Office Application";
            //set ThisEquipment to the test data
            AllEquipment.ThisEquipment = TestItem;
            //add the record
            PrimaryKey = AllEquipment.Add();
            //set the primary key of the test data
            TestItem.Equipment_ID = PrimaryKey;
            //find the record
            AllEquipment.ThisEquipment.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllEquipment.ThisEquipment, TestItem);
        }
    }
}
