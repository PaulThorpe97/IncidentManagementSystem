using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestLibrary
{
    [TestClass]
    public class tstRoleCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsRoleCollection ARole = new clsRoleCollection();
            //test to see that it exists
            Assert.IsNotNull(ARole);
        }

    
    [TestMethod]
    public void RoleListOK()
    {
        //create an instance of the class we want to create
        clsRoleCollection AllRole = new clsRoleCollection();
        //create some test data to assign to the property
        //in this case the data needs  to be a list of objects
        List<clsRole> TestList = new List<clsRole>();
        //add an item to the list
        //create the item of test data
        clsRole TestItem = new clsRole();
        //set its properties
        TestItem.Role_ID = 1;
        TestItem.Role_Description = "Administrator";
        //add the item to the test list
        TestList.Add(TestItem);
        //assign the data to the property
        AllRole.RoleList = TestList;
        //test to see that the two values are the same
        Assert.AreEqual(AllRole.RoleList, TestList);
    }

    [TestMethod]
    public void ThisRolePropertyOK()
    {
        //create an instance of the class we want to create
        clsRoleCollection AllRole = new clsRoleCollection();
        //create some test data to assign to the property
        clsRole TestRole = new clsRole();
        //set the properties of the test object
        TestRole.Role_ID = 1;
        TestRole.Role_Description = "Administrator";
        //assign the data to the property
        AllRole.ThisRole = TestRole;
        //test to see that the two values are the same
        Assert.AreEqual(AllRole.ThisRole, TestRole);
    }

    [TestMethod]
    public void ListAndCountOK()
    {
        //create an instance of the class we want to create
        clsRoleCollection AllRole = new clsRoleCollection();
        //create some test data to assign to the property
        //in this case the data needs  to be a list of objects
        List<clsRole> TestList = new List<clsRole>();
        //add an item to the list
        //create the item of test data
        clsRole TestItem = new clsRole();
        //set its properties
        TestItem.Role_ID = 1;
        TestItem.Role_Description = "Administrator";
        //add the item to the test list
        TestList.Add(TestItem);
        //assign the data to the property
        AllRole.RoleList = TestList;
        //test to see that the two values are the same
        Assert.AreEqual(AllRole.Count, TestList.Count);
    }

    [TestMethod]
    public void AddMethodOK()
    {
        //create an instance of the class we want to create
        clsRoleCollection AllRole = new clsRoleCollection();
        //create the item of test data
        clsRole TestItem = new clsRole();
        //var to store the primary key
        Int32 PrimaryKey = 0;
        //set its properties
        TestItem.Role_ID = 1;
        TestItem.Role_Description = "Administrator";
        //set ThisEquipment to the test data
        AllRole.ThisRole = TestItem;
        //add the record
        PrimaryKey = AllRole.Add();
        //set the primary key of the test data
        TestItem.Role_ID = PrimaryKey;
        //find the record
        AllRole.ThisRole.Find(PrimaryKey);
        //test to see that the two values are the same
        Assert.AreEqual(AllRole.ThisRole, TestItem);
    }

    [TestMethod]
    public void DeleteMethodOK()
    {
        //create an instance of the class we want to create
        clsRoleCollection AllRole = new clsRoleCollection();
        //create the item of test data 
        clsRole TestItem = new clsRole();
        //var to store the primary key
        Int32 PrimaryKey = 0;
        //set its properties
        TestItem.Role_ID = 1;
        TestItem.Role_Description = "Administrator";
        //set ThisEquipment to the test data
        AllRole.ThisRole = TestItem;
        //add the record
        PrimaryKey = AllRole.Add();
        //set the primary key of the test data
        TestItem.Role_ID = PrimaryKey;
        //find the record
        AllRole.ThisRole.Find(PrimaryKey);
        //delete the record
        AllRole.Delete();
        //now find the record
        Boolean Found = AllRole.ThisRole.Find(PrimaryKey);
        //test to see that the record was not found
        Assert.IsFalse(Found);
    }

    [TestMethod]
    public void UpdateMethodOK()
    {
        //create an instance of the class we want to create
        clsRoleCollection AllRole = new clsRoleCollection();
        //create the item of test data 
        clsRole TestItem = new clsRole();
        //var to store the primary key
        Int32 PrimaryKey = 0;
        //set its properties
        TestItem.Role_Description = "Administrator";
        //set ThisEquipment to the test data
        AllRole.ThisRole = TestItem;
        //add the record
        PrimaryKey = AllRole.Add();
        //set the primary key of the test data
        TestItem.Role_ID = PrimaryKey;
        //modify the test data
        TestItem.Role_Description = "TestDescription";
        //set the record based on the new test data
        AllRole.ThisRole = TestItem;
        //update the record
        AllRole.Update();
        //find the record
        AllRole.ThisRole.Find(PrimaryKey);
        //test to see ThisEquipment matches the test data
        Assert.AreEqual(AllRole.ThisRole, TestItem);
    }

    [TestMethod]
    public void FilterByRoleDescriptionOK()
    {
        //create an instance of the class we want to create
        clsRoleCollection AllRole = new clsRoleCollection();
        //create an instance of the filtered data
        clsRoleCollection FilteredRole = new clsRoleCollection();
        //apply a blank string (should return all record)
        FilteredRole.FilterByRole_Description("");
        //test to see that the two values are the same
        Assert.AreEqual(AllRole.Count, FilteredRole.Count);
    }

    [TestMethod]
    public void FilterByRoleDescriptionNoneFound()
    {
        //create an instance of the class we want to create
        clsRoleCollection FilteredRole = new clsRoleCollection();
        //apply a role description that doesnt exist
        FilteredRole.FilterByRole_Description("Manager");
        //test to see that there are no records
        Assert.AreEqual(0, FilteredRole.Count);
    }

        [TestMethod]
        public void FilterByRoleDescriptionTestDataFound()
        {
            //create an instance of the class we want to create
            clsRoleCollection FilteredRole = new clsRoleCollection();
            //var to store outcome
            Boolean OK = true;
            //apply the role that doesn't exist
            FilteredRole.FilterByRole_Description("Manager");
            //check that the correct numnber of records are found
            if (FilteredRole.Count == 2)
            {
                //check that the rest record is ID 1
                if (FilteredRole.RoleList[0].Role_ID != 1)
                {
                    OK = false;
                }
                //check that the rest record is ID 22
                if (FilteredRole.RoleList[1].Role_ID != 4)
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

    

