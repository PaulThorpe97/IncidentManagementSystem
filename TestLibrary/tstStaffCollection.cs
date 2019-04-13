using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestLibrary
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AStaff = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs  to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Staff_ID = 1;
            TestItem.Staff_Forename = "Paul";
            TestItem.Staff_Phone = "07592115157";
            TestItem.Staff_Surname = "Thorpe";
            TestItem.Role_ID = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test object
            TestStaff.Staff_ID = 1;
            TestStaff.Staff_Forename = "Paul";
            TestStaff.Staff_Phone = "07592115157";
            TestStaff.Staff_Surname = "Thorpe";
            TestStaff.Role_ID= 1;
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs  to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Staff_ID = 1;
            TestItem.Staff_Forename = "Paul";
            TestItem.Staff_Phone = "07592115157";
            TestItem.Staff_Surname = "Thorpe";
            TestItem.Role_ID = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Staff_ID = 1;
            TestItem.Staff_Forename = "Paul";
            TestItem.Staff_Phone = "07592115157";
            TestItem.Staff_Surname = "Thorpe";
            TestItem.Role_ID = 1;
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.Staff_ID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data 
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Staff_ID = 1;
            TestItem.Staff_Forename = "Paul";
            TestItem.Staff_Phone = "07592115157";
            TestItem.Staff_Surname = "Thorpe";
            TestItem.Role_ID = 1;
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.Staff_ID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaff.Delete();
            //now find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data 
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Staff_ID = 1;
            TestItem.Staff_Forename = "Paul";
            TestItem.Staff_Phone = "07592115157";
            TestItem.Staff_Surname = "Thorpe";
            TestItem.Role_ID = 1;
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.Staff_ID = PrimaryKey;
            //modify the test data
            TestItem.Staff_Forename = "Dylan";
            TestItem.Staff_Phone = "123456789123";
            TestItem.Staff_Surname = "Devlin";
            TestItem.Role_ID = 2;
            //set the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            //update the record
            AllStaff.Update();
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see ThisStaff matches the test data
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void FilterByStaffSurnameOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a blank string (should return all record)
            FilteredStaff.FilterByStaff_Surname("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }

        [TestMethod]
        public void FilterByStaffSurnameNoneFound()
        {
            //create an instance of the class we want to create
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a staff surname that doesnt exist
            FilteredStaff.FilterByStaff_Surname("Greaves");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStaff.Count);
        }

        [TestMethod]
        public void FilterByStaffSurnameTestDataFound()
        {
            //create an instance of the class we want to create
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //var to store outcome
            Boolean OK = true;
            //apply the staff surname  that doesn't exist
            FilteredStaff.FilterByStaff_Surname("Greaves");
            //check that the correct numnber of records are found
            if (FilteredStaff.Count == 2)
            {
                //check that the rest record is ID 1
                if (FilteredStaff.StaffList[0].Staff_ID != 2)
                {
                    OK = false;
                }
                //check that the rest record is ID 2
                if (FilteredStaff.StaffList[1].Staff_ID != 3)
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

