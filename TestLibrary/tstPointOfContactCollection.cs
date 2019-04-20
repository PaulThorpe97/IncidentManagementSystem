using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestLibrary
{
    [TestClass]
    public class tstPointOfContactCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsPointOfContactCollection APointOfContact = new clsPointOfContactCollection();
            //test to see that it exists
            Assert.IsNotNull(APointOfContact);
        }

        [TestMethod]
        public void PointOfContactListOK()
        {
            //create an instance of the class we want to create
            clsPointOfContactCollection AllPointOfContact = new clsPointOfContactCollection();
            //create some test data to assign to the property
            //in this case the data needs  to be a list of objects
            List<clsPointOfContact> TestList = new List<clsPointOfContact>();
            //add an item to the list
            //create the item of test data
            clsPointOfContact TestItem = new clsPointOfContact();
            //set its properties
            TestItem.Incident_ID = 1;
            TestItem.Point_Of_Contact_Comment = "I tried";
            TestItem.Point_Of_Contact_ID = 1;
            TestItem.Staff_ID = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllPointOfContact.PointOfContactList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllPointOfContact.PointOfContactList, TestList);
        }

        [TestMethod]
        public void ThisPointOfContactPropertyOK()
        {
            //create an instance of the class we want to create
            clsPointOfContactCollection AllPointOfContact = new clsPointOfContactCollection();
            //create some test data to assign to the property
            clsPointOfContact TestPointOfContact = new clsPointOfContact();
            //set the properties of the test object
            TestPointOfContact.Incident_ID= 1;
            TestPointOfContact.Point_Of_Contact_Comment = "I Tried";
            TestPointOfContact.Point_Of_Contact_ID = 1;
            TestPointOfContact.Incident_ID = 1;
            //assign the data to the property
            AllPointOfContact.ThisPointOfContact = TestPointOfContact;
            //test to see that the two values are the same
            Assert.AreEqual(AllPointOfContact.ThisPointOfContact, TestPointOfContact);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsPointOfContactCollection AllPointOfContact = new clsPointOfContactCollection();
            //create some test data to assign to the property
            //in this case the data needs  to be a list of objects
            List<clsPointOfContact> TestList = new List<clsPointOfContact>();
            //add an item to the list
            //create the item of test data
            clsPointOfContact TestItem = new clsPointOfContact();
            //set its properties
            TestItem.Incident_ID = 1;
            TestItem.Point_Of_Contact_Comment = "I tried";
            TestItem.Point_Of_Contact_ID = 1;
            TestItem.Staff_ID = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllPointOfContact.PointOfContactList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllPointOfContact.Count, TestList.Count);
        }

        [TestMethod]
        public void PointOfContactAddMethodOK()
        {
            //create an instance of the class we want to create
            clsPointOfContactCollection AllPointOfContact = new clsPointOfContactCollection();
            //create the item of test data
            clsPointOfContact TestItem = new clsPointOfContact();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Incident_ID = 1;
            TestItem.Point_Of_Contact_Comment = "I tried";
            TestItem.Point_Of_Contact_ID = 1;
            TestItem.Staff_ID = 1;
            //set ThisPointOfContact to the test data
            AllPointOfContact.ThisPointOfContact = TestItem;
            //add the record
            PrimaryKey = AllPointOfContact.PointOfContactAdd();
            //set the primary key of the test data
            TestItem.Point_Of_Contact_ID = PrimaryKey;
            //find the record
            AllPointOfContact.ThisPointOfContact.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllPointOfContact.ThisPointOfContact, TestItem);
        }

        [TestMethod]
        public void PointOfContactDeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsPointOfContactCollection AllPointOfContact = new clsPointOfContactCollection();
            //create the item of test data 
            clsPointOfContact TestItem = new clsPointOfContact();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Incident_ID = 1;
            TestItem.Point_Of_Contact_Comment = "I tried";
            TestItem.Point_Of_Contact_ID = 1;
            TestItem.Staff_ID = 1;
            //set ThisPointOfContact to the test data
            AllPointOfContact.ThisPointOfContact = TestItem;
            //add the record
            PrimaryKey = AllPointOfContact.PointOfContactAdd();
            //set the primary key of the test data
            TestItem.Point_Of_Contact_ID = PrimaryKey;
            //find the record
            AllPointOfContact.ThisPointOfContact.Find(PrimaryKey);
            //delete the record
            AllPointOfContact.PointOfContactDelete();
            //now find the record
            Boolean Found = AllPointOfContact.ThisPointOfContact.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void PointOfContactUpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsPointOfContactCollection AllPointOfContact = new clsPointOfContactCollection();
            //create the item of test data 
            clsPointOfContact TestItem = new clsPointOfContact();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Incident_ID = 1;
            TestItem.Point_Of_Contact_Comment = "I tried";
            TestItem.Staff_ID = 1;
            //set ThisEquipment to the test data
            AllPointOfContact.ThisPointOfContact = TestItem;
            //add the record
            PrimaryKey = AllPointOfContact.PointOfContactAdd();
            //set the primary key of the test data
            TestItem.Point_Of_Contact_ID = PrimaryKey;
            //modify the test data
            TestItem.Incident_ID = 1;
            TestItem.Point_Of_Contact_Comment = "I succeeded";
            TestItem.Staff_ID = 2;
            //set the record based on the new test data
            AllPointOfContact.ThisPointOfContact = TestItem;
            //update the record
            AllPointOfContact.PointOfContactUpdate();
            //find the record
            AllPointOfContact.ThisPointOfContact.Find(PrimaryKey);
            //test to see ThisEquipment matches the test data
            Assert.AreEqual(AllPointOfContact.ThisPointOfContact, TestItem);
        }

        [TestMethod]
        public void FilterByIncidentIDNameOK()
        {
            //create an instance of the class we want to create
            clsPointOfContactCollection AllPointOfContact = new clsPointOfContactCollection();
            //create an instance of the filtered data
            clsPointOfContactCollection FilteredPointOfContact = new clsPointOfContactCollection();
            //apply a blank string (should return all record)
            FilteredPointOfContact.FilterByIncident_ID("");
            //test to see that the two values are the same
            Assert.AreEqual(AllPointOfContact.Count, FilteredPointOfContact.Count);
        }

        [TestMethod]
        public void FilterByIncidentIDNoneFound()
        {
            //create an instance of the class we want to create
            clsPointOfContactCollection FilteredPointOfContact = new clsPointOfContactCollection();
            //apply an Staff ID that doesnt exist
            FilteredPointOfContact.FilterByIncident_ID("1000");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredPointOfContact.Count);
        }

        [TestMethod]
        public void FilterByStaffIDTestDataFound()
        {
            //create an instance of the class we want to create
            clsPointOfContactCollection FilteredPointOfContact = new clsPointOfContactCollection();
            //var to store outcome
            Boolean OK = true;
            //apply the Staff ID that doesn't exist
            FilteredPointOfContact.FilterByIncident_ID("1000");
            //check that the correct number of records are found
            if (FilteredPointOfContact.Count == 2)
            {
                //check that the rest record is ID 1
                if (FilteredPointOfContact.PointOfContactList[0].Point_Of_Contact_ID != 2)
                {
                    OK = false;
                }
                //check that the rest record is ID 2
                if (FilteredPointOfContact.PointOfContactList[1].Point_Of_Contact_ID != 3)
                {
                    OK = false;
                }
                else
                {
                    OK = false;
                }
                //test to see that there are no records
                Assert.IsTrue(OK);
            }
        }
    }
}