using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLibrary
{
    [TestClass]
    public class tstRole
    {
        //good test data
        //create some test data to mpass to the method
        String Role_Description = "Administrator";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsRole ARole = new clsRole();
            //test to see that it exists
            Assert.IsNotNull(ARole);
        }

        [TestMethod]
        public void Role_IDPropertyOK()
        {
            //create an instance of the class we want to create
            clsRole ARole = new clsRole();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ARole.Role_ID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ARole.Role_ID, TestData);
        }

        [TestMethod]
        public void Role_DescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsRole ARole = new clsRole();
            //create some test data to assign to the property
            String TestData = "Administrator";
            //assign the data to the property
            ARole.Role_Description = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ARole.Role_Description, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsRole ARole = new clsRole();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 Role_ID = 1;
            //invoke the method
            Found = ARole.Find(Role_ID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void Role_IDFound()
        {
            //create an instance of the class we want to create
            clsRole ARole = new clsRole();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Role_ID = 1;
            //invoke the method
            Found = ARole.Find(Role_ID);
            //check the Equipment_ID
            if (ARole.Role_ID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Role_DescriptionFound()
        {
            //create an instance of the class we want to create
            clsRole ARole = new clsRole();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Equipment_ID = 1;
            //invoke the method
            Found = ARole.Find(Equipment_ID);
            //check the Equipment_ID
            if (ARole.Role_Description != "Administrator")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidOK()
        {
            //create an instance of the class we want to create
            clsRole ARole = new clsRole();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = ARole.Valid(Role_Description);
            //test to see that the result is corrct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void Role_DescriptionMinLessOne()
        {
            //create an instance of the class we want to create
            clsRole ARole = new clsRole();
            //String variable to store any error message
            String Error = "";
            //This should fail
            String Role_Description = "";
            //invoke the method
            Error = ARole.Valid(Role_Description);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Role_DescriptionMin()
        {
            //create an instance of the class we want to create
            clsRole ARole = new clsRole();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Role_Description = "a";
            //invoke the method
            Error = ARole.Valid(Role_Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Role_DescriptionMinPlusOne()
        {
            //create an instance of the class we want to create
            clsRole ARole = new clsRole();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Role_Description = "aa";
            //invoke the method
            Error = ARole.Valid(Role_Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Role_DescriptionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsRole ARole = new clsRole();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Role_Description = "";
            Role_Description = Role_Description.PadRight(49, 'a');
            //invoke the method
            Error = ARole.Valid(Role_Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Role_DescriptionMax()
        {
            //create an instance of the class we want to create
            clsRole ARole = new clsRole();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Role_Description = "";
            Role_Description = Role_Description.PadRight(50, 'a');
            //invoke the method
            Error = ARole.Valid(Role_Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Role_DescriptionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsRole ARole = new clsRole();
            //String variable to store any error message
            String Error = "";
            //This should fail
            String Role_Description = "";
            Role_Description = Role_Description.PadRight(51, 'a');
            //invoke the method
            Error = ARole.Valid(Role_Description);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Role_DescriptionMid()
        {
            //create an instance of the class we want to create
            clsRole ARole = new clsRole();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Role_Description = "";
            Role_Description = Role_Description.PadRight(25, 'a');
            //invoke the method
            Error = ARole.Valid(Role_Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

    }
}
