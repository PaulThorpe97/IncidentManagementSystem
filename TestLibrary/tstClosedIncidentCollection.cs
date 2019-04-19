using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestLibrary
{
    [TestClass]
    public class tstClosedIncidentCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsClosedIncidentCollection AClosedIncident = new clsClosedIncidentCollection();
            //test to see that it exists
            Assert.IsNotNull(AClosedIncident);
        }

        [TestMethod]
        public void ClosedIncidentListOK()
        {
            //create an instance of the class we want to create
            clsClosedIncidentCollection AllClosedIncident = new clsClosedIncidentCollection();
            //create some test data to assign to the property
            //in this case the data needs  to be a list of objects
            List<clsClosedIncident> TestList = new List<clsClosedIncident>();
            //add an item to the list
            //create the item of test data
            clsClosedIncident TestItem = new clsClosedIncident();
            //set its properties
            TestItem.Closed_Incident_Date_Closed = DateTime.Now.Date;
            TestItem.Closed_Incident_Description = "Test";
            TestItem.Closed_Incident_ID = 1;
            TestItem.Incident_ID = 1;
            TestItem.Staff_ID = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllClosedIncident.ClosedIncidentList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllClosedIncident.ClosedIncidentList, TestList);
        }

        [TestMethod]
        public void ThisClosedIncidentPropertyOK()
        {
            //create an instance of the class we want to create
            clsClosedIncidentCollection AllClosedIncident = new clsClosedIncidentCollection();
            //create some test data to assign to the property
            clsClosedIncident TestClosedIncident = new clsClosedIncident();
            //set the properties of the test object
            TestClosedIncident.Closed_Incident_Date_Closed = DateTime.Now.Date;
            TestClosedIncident.Closed_Incident_Description = "Test";
            TestClosedIncident.Closed_Incident_ID = 1;
            TestClosedIncident.Incident_ID = 1;
            TestClosedIncident.Staff_ID = 1;
            //assign the data to the property
            AllClosedIncident.ThisClosedIncident = TestClosedIncident;
            //test to see that the two values are the same
            Assert.AreEqual(AllClosedIncident.ThisClosedIncident, TestClosedIncident);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsClosedIncidentCollection AllClosedIncident = new clsClosedIncidentCollection();
            //create some test data to assign to the property
            //in this case the data needs  to be a list of objects
            List<clsClosedIncident> TestList = new List<clsClosedIncident>();
            //add an item to the list
            //create the item of test data
            clsClosedIncident TestItem = new clsClosedIncident();
            //set its properties
            TestItem.Closed_Incident_Date_Closed = DateTime.Now.Date;
            TestItem.Closed_Incident_Description = "Test";
            TestItem.Closed_Incident_ID = 1;
            TestItem.Incident_ID = 1;
            //add the item to the test list
            TestItem.Staff_ID = 1;
            TestList.Add(TestItem);
            //assign the data to the property
            AllClosedIncident.ClosedIncidentList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllClosedIncident.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsClosedIncidentCollection AllClosedIncident = new clsClosedIncidentCollection();
            //create the item of test data
            clsClosedIncident TestItem = new clsClosedIncident();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Closed_Incident_Date_Closed = DateTime.Now.Date;
            TestItem.Closed_Incident_Description = "Test";
            TestItem.Closed_Incident_ID = 1;
            TestItem.Incident_ID = 1;
            TestItem.Staff_ID = 1;
            //set ThisClosedIncident to the test data
            AllClosedIncident.ThisClosedIncident = TestItem;
            //add the record
            PrimaryKey = AllClosedIncident.Add();
            //set the primary key of the test data
            TestItem.Closed_Incident_ID = PrimaryKey;
            //find the record
            AllClosedIncident.ThisClosedIncident.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllClosedIncident.ThisClosedIncident, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsClosedIncidentCollection AllClosedIncident = new clsClosedIncidentCollection();
            //create the item of test data 
            clsClosedIncident TestItem = new clsClosedIncident();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Closed_Incident_Date_Closed = DateTime.Now.Date;
            TestItem.Closed_Incident_Description = "Test";
            TestItem.Closed_Incident_ID = 1;
            TestItem.Incident_ID = 1;
            TestItem.Staff_ID = 1;
            //set ThisClosedIncident to the test data
            AllClosedIncident.ThisClosedIncident = TestItem;
            //add the record
            PrimaryKey = AllClosedIncident.Add();
            //set the primary key of the test data
            TestItem.Closed_Incident_ID = PrimaryKey;
            //find the record
            AllClosedIncident.ThisClosedIncident.Find(PrimaryKey);
            //delete the record
            AllClosedIncident.Delete();
            //now find the record
            Boolean Found = AllClosedIncident.ThisClosedIncident.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsClosedIncidentCollection AllClosedIncident = new clsClosedIncidentCollection();
            //create the item of test data
            clsClosedIncident TestItem = new clsClosedIncident();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Closed_Incident_Date_Closed = DateTime.Now.Date;
            TestItem.Closed_Incident_Description = "Test";
            TestItem.Incident_ID = 1;
            TestItem.Staff_ID = 1;
            //set ThisClosedIncident to the test data
            AllClosedIncident.ThisClosedIncident = TestItem;
            //add the record
            PrimaryKey = AllClosedIncident.Add();
            //set the primary key of the test data
            TestItem.Closed_Incident_ID = PrimaryKey;
            //modify the test data
            TestItem.Closed_Incident_Date_Closed = DateTime.Now.Date;
            TestItem.Closed_Incident_Description = "NewTest";
            TestItem.Incident_ID = 1;
            TestItem.Staff_ID = 1;
            //set the record based on the new test data
            AllClosedIncident.ThisClosedIncident = TestItem;
            //update the record
            AllClosedIncident.Update();
            //find the record
            AllClosedIncident.ThisClosedIncident.Find(PrimaryKey);
            //test to see ThisEquipment matches the test data
            Assert.AreEqual(AllClosedIncident.ThisClosedIncident, TestItem);
        }

        [TestMethod]
        public void FilterByIncidentIDOK()
        {
            //create an instance of the class we want to create
            clsClosedIncidentCollection AllClosedIncident = new clsClosedIncidentCollection();
            //create an instance of the filtered data
            clsClosedIncidentCollection FilteredClosedIncident = new clsClosedIncidentCollection();
            //apply a blank string (should return all record)
            FilteredClosedIncident.FilterByIncident_ID("");
            //test to see that the two values are the same
            Assert.AreEqual(AllClosedIncident.Count, FilteredClosedIncident.Count);
        }

        [TestMethod]
        public void FilterByIncidentIDNoneFound()
        {
            //create an instance of the class we want to create
            clsClosedIncidentCollection FilteredClosedIncident = new clsClosedIncidentCollection();
            //apply an equipment name that doesnt exist
            FilteredClosedIncident.FilterByIncident_ID("5");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredClosedIncident.Count);
        }

        [TestMethod]
        public void FilterByIncidentIDTestDataFound()
        {
            //create an instance of the class we want to create
            clsClosedIncidentCollection FilteredClosedIncident = new clsClosedIncidentCollection();
            //var to store outcome
            Boolean OK = true;
            //apply the equipment that doesn't exist
            FilteredClosedIncident.FilterByIncident_ID("5");
            //check that the correct numnber of records are found
            if (FilteredClosedIncident.Count == 2)
            {
                //check that the rest record is ID 2
                if (FilteredClosedIncident.ClosedIncidentList[0].Closed_Incident_ID != 2)
                {
                    OK = false;
                }
                //check that the rest record is ID 3
                if (FilteredClosedIncident.ClosedIncidentList[1].Closed_Incident_ID != 3)
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

