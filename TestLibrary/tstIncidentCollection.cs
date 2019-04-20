using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestLibrary
{
    [TestClass]
    public class tstIncidentCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsIncidentCollection AIncident = new clsIncidentCollection();
            //test to see that it exists
            Assert.IsNotNull(AIncident);
        }

        [TestMethod]
        public void IncidentListOK()
        {
            //create an instance of the class we want to create
            clsIncidentCollection AllIncident = new clsIncidentCollection();
            //create some test data to assign to the property
            //in this case the data needs  to be a list of objects
            List<clsIncident> TestList = new List<clsIncident>();
            //add an item to the list
            //create the item of test data
            clsIncident TestItem = new clsIncident();
            //set its properties
            TestItem.Incident_Assign_Incident_To = 1;
            TestItem.Incident_Date_Occured = DateTime.Now.Date;
            TestItem.Equipment_ID = 1;
            TestItem.Incident_Description = "Microsoft Word keeps crashing";
            TestItem.Incident_High = false;
            TestItem.Incident_In_Progress = true;
            TestItem.Incident_Low = true;
            TestItem.Incident_Medium = false;
            TestItem.Incident_ID = 1;
            TestItem.Incident_Pending = false;
            TestItem.Staff_ID = 1;
            TestItem.Incident_Close = false;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllIncident.IncidentList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllIncident.IncidentList, TestList);
        }

        [TestMethod]
        public void ThisIncidentPropertyOK()
        {
            //create an instance of the class we want to create
            clsIncidentCollection AllIncident = new clsIncidentCollection();
            //create some test data to assign to the property
            clsIncident TestIncident = new clsIncident();
            //set the properties of the test object
            TestIncident.Incident_Assign_Incident_To = 1;
            TestIncident.Incident_Date_Occured = DateTime.Now.Date;
            TestIncident.Equipment_ID = 1;
            TestIncident.Incident_Description = "Microsoft Word keeps crashing";
            TestIncident.Incident_High = false;
            TestIncident.Incident_In_Progress = true;
            TestIncident.Incident_Low = true;
            TestIncident.Incident_Medium = false;
            TestIncident.Incident_ID = 1;
            TestIncident.Incident_Pending = false;
            TestIncident.Staff_ID = 1;
            TestIncident.Incident_Close = false;
            //assign the data to the property
            AllIncident.ThisIncident = TestIncident;
            //test to see that the two values are the same
            Assert.AreEqual(AllIncident.ThisIncident, TestIncident);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsIncidentCollection AllIncident = new clsIncidentCollection();
            //create some test data to assign to the property
            //in this case the data needs  to be a list of objects
            List<clsIncident> TestList = new List<clsIncident>();
            //add an item to the list
            //create the item of test data
            clsIncident TestItem = new clsIncident();
            //set its properties
            TestItem.Incident_Assign_Incident_To = 1;
            TestItem.Incident_Date_Occured = DateTime.Now.Date;
            TestItem.Equipment_ID = 1;
            TestItem.Incident_Description = "Microsoft Word keeps crashing";
            TestItem.Incident_High = false;
            TestItem.Incident_In_Progress = true;
            TestItem.Incident_Low = true;
            TestItem.Incident_Medium = false;
            TestItem.Incident_ID = 1;
            TestItem.Incident_Pending = false;
            TestItem.Staff_ID = 1;
            TestItem.Incident_Close = false;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllIncident.IncidentList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllIncident.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsIncidentCollection AllIncident = new clsIncidentCollection();
            //create the item of test data
            clsIncident TestItem = new clsIncident();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Incident_Assign_Incident_To = 1;
            TestItem.Incident_Date_Occured = DateTime.Now.Date;
            TestItem.Equipment_ID = 1;
            TestItem.Incident_Description = "Microsoft Word keeps crashing";
            TestItem.Incident_High = false;
            TestItem.Incident_In_Progress = true;
            TestItem.Incident_Low = true;
            TestItem.Incident_Medium = false;
            TestItem.Incident_ID = 1;
            TestItem.Incident_Pending = false;
            TestItem.Staff_ID = 1;
            TestItem.Incident_Close = false;
            //set ThisIncidentto the test data
            AllIncident.ThisIncident = TestItem;
            //add the record
            PrimaryKey = AllIncident.Add();
            //set the primary key of the test data
            TestItem.Incident_ID = PrimaryKey;
            //find the record
            AllIncident.ThisIncident.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllIncident.ThisIncident, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsIncidentCollection AllIncident = new clsIncidentCollection();
            //create the item of test data 
            clsIncident TestItem = new clsIncident();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Incident_Assign_Incident_To = 1;
            TestItem.Incident_Date_Occured = DateTime.Now.Date;
            TestItem.Equipment_ID = 1;
            TestItem.Incident_Description = "Microsoft Word keeps crashing";
            TestItem.Incident_High = false;
            TestItem.Incident_In_Progress = true;
            TestItem.Incident_Low = true;
            TestItem.Incident_Medium = false;
            TestItem.Incident_ID = 1;
            TestItem.Incident_Pending = false;
            TestItem.Staff_ID = 1;
            TestItem.Incident_Close = false;
            //set ThisIncident to the test data
            AllIncident.ThisIncident = TestItem;
            //add the record
            PrimaryKey = AllIncident.Add();
            //set the primary key of the test data
            TestItem.Incident_ID = PrimaryKey;
            //find the record
            AllIncident.ThisIncident.Find(PrimaryKey);
            //delete the record
            AllIncident.Delete();
            //now find the record
            Boolean Found = AllIncident.ThisIncident.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsIncidentCollection AllIncident = new clsIncidentCollection();
            //create the item of test data 
            clsIncident TestItem = new clsIncident();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Incident_Assign_Incident_To = 1;
            TestItem.Incident_Date_Occured = DateTime.Now.Date;
            TestItem.Equipment_ID = 1;
            TestItem.Incident_Description = "Microsoft Word keeps crashing";
            TestItem.Incident_High = false;
            TestItem.Incident_In_Progress = true;
            TestItem.Incident_Low = true;
            TestItem.Incident_Medium = false;
            TestItem.Incident_Pending = false;
            TestItem.Staff_ID = 1;
            TestItem.Incident_Close = false;
            //set ThisIncident to the test data
            AllIncident.ThisIncident = TestItem;
            //add the record
            PrimaryKey = AllIncident.Add();
            //set the primary key of the test data
            TestItem.Equipment_ID = PrimaryKey;
            //modify the test data
            TestItem.Incident_Assign_Incident_To = 2;
            TestItem.Incident_Date_Occured = DateTime.Now.Date;
            TestItem.Equipment_ID = 1;
            TestItem.Incident_Description = "Microsoft Word keeps crashing";
            TestItem.Incident_High = true;
            TestItem.Incident_In_Progress = true;
            TestItem.Incident_Low = false;
            TestItem.Incident_Medium = false;
            TestItem.Incident_Pending = false;
            TestItem.Staff_ID = 2;
            TestItem.Incident_Close = true;
            //set the record based on the new test data
            AllIncident.ThisIncident = TestItem;
            //update the record
            AllIncident.Update();
            //find the record
            AllIncident.ThisIncident.Find(PrimaryKey);
            //test to see ThisEquipment matches the test data
            Assert.AreEqual(AllIncident.ThisIncident, TestItem);
        }

        [TestMethod]
        public void FilterByStaffIDOK()
        {
            //create an instance of the class we want to create
            clsIncidentCollection AllIncident = new clsIncidentCollection();
            //create an instance of the filtered data
            clsIncidentCollection FilteredIncident = new clsIncidentCollection();
            //apply a blank string (should return all record)
            FilteredIncident.FilterByStaff_ID("1");
            //test to see that the two values are the same
            Assert.AreEqual(AllIncident.Count, FilteredIncident.Count);
        }

        [TestMethod]
        public void FilterByStaffIDNoneFound()
        {
            //create an instance of the class we want to create
            clsIncidentCollection FilteredIncident = new clsIncidentCollection();
            //apply an equipment name that doesnt exist
            FilteredIncident.FilterByStaff_ID("100");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredIncident.Count);
        }

        [TestMethod]
        public void FilterByStaffIDTestDataFound()
        {
            //create an instance of the class we want to create
            clsIncidentCollection FilteredIncident = new clsIncidentCollection();
            //var to store outcome
            Boolean OK = true;
            //apply the equipment that doesn't exist
            FilteredIncident.FilterByStaff_ID("100");
            //check that the correct number of records are found
            if (FilteredIncident.Count == 2)
            {
                //check that the rest record is ID 1
                if (FilteredIncident.IncidentList[0].Incident_ID != 1)
                {
                    OK = false;
                }
                //check that the rest record is ID 2
                if (FilteredIncident.IncidentList[1].Incident_ID != 2)
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

