using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLibrary
{
    [TestClass]
    public class tstClosedIncident
    {
        //good test data
        //create some test data to pass to the method
        String Closed_Incident_Date_Closed = DateTime.Now.Date.ToString();
        String Closed_Incident_Description = "Test";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsClosedIncident AClosedIncident = new clsClosedIncident();
            //test to see that it exists
            Assert.IsNotNull(AClosedIncident);
        }

        [TestMethod]
        public void Closed_Incident_Date_ClosedPropertyOK()
        {
            //create an instance of the class we want to create
            clsClosedIncident AClosedIncident = new clsClosedIncident();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AClosedIncident.Closed_Incident_Date_Closed = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AClosedIncident.Closed_Incident_Date_Closed, TestData);
        }

        [TestMethod]
        public void Closed_Incident_DescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsClosedIncident AClosedIncident = new clsClosedIncident();
            //create some test data to assign to the property
            String TestData = "Test";
            //assign the data to the property
            AClosedIncident.Closed_Incident_Description = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AClosedIncident.Closed_Incident_Description, TestData);
        }

        [TestMethod]
        public void Closed_Incident_IDPropertyOK()
        {
            //create an instance of the class we want to create
            clsClosedIncident AClosedIncident = new clsClosedIncident();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AClosedIncident.Closed_Incident_ID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AClosedIncident.Closed_Incident_ID, TestData);
        }

        [TestMethod]
        public void Incident_IDPropertyOK()
        {
            //create an instance of the class we want to create
            clsClosedIncident AClosedIncident = new clsClosedIncident();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AClosedIncident.Incident_ID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AClosedIncident.Incident_ID, TestData);
        }

        [TestMethod]
        public void Staff_IDPropertyOK()
        {
            //create an instance of the class we want to create
            clsClosedIncident AClosedIncident = new clsClosedIncident();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AClosedIncident.Staff_ID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AClosedIncident.Staff_ID, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsClosedIncident AClosedIncident = new clsClosedIncident();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 Closed_Incident_ID = 1;
            //invoke the method
            Found = AClosedIncident.Find(Closed_Incident_ID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void Closed_Incident_Date_ClosedFound()
        {
            //create an instance of the class we want to create
            clsClosedIncident AClosedIncident = new clsClosedIncident();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Closed_Incident_ID = 1;
            //invoke the method
            Found = AClosedIncident.Find(Closed_Incident_ID);
            //check the Equipment_ID
            if (AClosedIncident.Closed_Incident_Date_Closed != Convert.ToDateTime("19/04/2019"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Closed_Incident_DescriptionFound()
        {
            //create an instance of the class we want to create
            clsClosedIncident AClosedIncident = new clsClosedIncident();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Closed_Incident_ID = 1;
            //invoke the method
            Found = AClosedIncident.Find(Closed_Incident_ID);
            //check the Equipment_ID
            if (AClosedIncident.Closed_Incident_Description != "Test closure")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Closed_Incident_IDFound()
        {
            //create an instance of the class we want to create
            clsClosedIncident AClosedIncident = new clsClosedIncident();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Closed_Incident_ID = 1;
            //invoke the method
            Found = AClosedIncident.Find(Closed_Incident_ID);
            //check the Equipment_ID
            if (AClosedIncident.Closed_Incident_ID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Incident_IDFound()
        {
            //create an instance of the class we want to create
            clsClosedIncident AClosedIncident = new clsClosedIncident();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Closed_Incident_ID = 1;
            //invoke the method
            Found = AClosedIncident.Find(Closed_Incident_ID);
            //check the Equipment_ID
            if (AClosedIncident.Incident_ID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Staff_IDFound()
        {
            //create an instance of the class we want to create
            clsClosedIncident AClosedIncident = new clsClosedIncident();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Closed_Incident_ID = 1;
            //invoke the method
            Found = AClosedIncident.Find(Closed_Incident_ID);
            //check the Equipment_ID
            if (AClosedIncident.Staff_ID != 1)
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
            clsClosedIncident AClosedIncident = new clsClosedIncident();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AClosedIncident.Valid(Closed_Incident_Date_Closed, Closed_Incident_Description);
            //test to see that the result is corrct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void Closed_Incident_Date_ClosedExtremeMin()
        {
            //create an instance of the class we want to create
            clsClosedIncident AClosedIncident = new clsClosedIncident();
            //boolean variable to store the result of the validation
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable 
            String Closed_Incident_Date_Closed = TestDate.ToString();
            //invoke the method
            Error = AClosedIncident.Valid(Closed_Incident_Date_Closed, Closed_Incident_Description);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Closed_Incident_Date_ClosedMinLessOne()
        {
            //create an instance of the class we want to create
            clsClosedIncident AClosedIncident = new clsClosedIncident();
            //boolean variable to store the result of the validation
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable 
            String Closed_Incident_Date_Closed = TestDate.ToString();
            //invoke the method
            Error = AClosedIncident.Valid(Closed_Incident_Date_Closed, Closed_Incident_Description);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Closed_Incident_Date_ClosedMin()
        {
            //create an instance of the class we want to create
            clsClosedIncident AClosedIncident = new clsClosedIncident();
            //boolean variable to store the result of the validation
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable 
            String Closed_Incident_Date_Closed = TestDate.ToString();
            //invoke the method
            Error = AClosedIncident.Valid(Closed_Incident_Date_Closed, Closed_Incident_Description);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Closed_Incident_Date_ClosedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsClosedIncident AClosedIncident = new clsClosedIncident();
            //boolean variable to store the result of the validation
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable 
            String Closed_Incident_Date_Closed = TestDate.ToString();
            //invoke the method
            Error = AClosedIncident.Valid(Closed_Incident_Date_Closed, Closed_Incident_Description);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Closed_Incident_Date_ClosedExtremeMax()
        {
            //create an instance of the class we want to create
            clsClosedIncident AClosedIncident = new clsClosedIncident();
            //boolean variable to store the result of the validation
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable 
            String Closed_Incident_Date_Closed = TestDate.ToString();
            //invoke the method
            Error = AClosedIncident.Valid(Closed_Incident_Date_Closed, Closed_Incident_Description);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Closed_Incident_DescriptionMinLessOne()
        {
            //create an instance of the class we want to create
            clsClosedIncident AClosedIncident = new clsClosedIncident();
            //String variable to store any error message
            String Error = "";
            //This should fail
            String Closed_Incident_Description = "";
            //invoke the method
            Error = AClosedIncident.Valid(Closed_Incident_Date_Closed, Closed_Incident_Description);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Closed_Incident_DescriptionMin()
        {
            //create an instance of the class we want to create
            clsClosedIncident AClosedIncident = new clsClosedIncident();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Closed_Incident_Description = "a";
            //invoke the method
            Error = AClosedIncident.Valid(Closed_Incident_Date_Closed, Closed_Incident_Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Closed_Incident_DescriptionMinPlusOne()
        {
            //create an instance of the class we want to create
            clsClosedIncident AClosedIncident = new clsClosedIncident();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Closed_Incident_Description = "aa";
            //invoke the method
            Error = AClosedIncident.Valid(Closed_Incident_Date_Closed, Closed_Incident_Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Closed_Incident_DescriptionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsClosedIncident AClosedIncident = new clsClosedIncident();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Closed_Incident_Description = "";
            Closed_Incident_Description = Closed_Incident_Description.PadRight(49, 'a');
            //invoke the method
            Error = AClosedIncident.Valid(Closed_Incident_Date_Closed, Closed_Incident_Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Closed_Incident_DescriptionMax()
        {
            //create an instance of the class we want to create
            clsClosedIncident AClosedIncident = new clsClosedIncident();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Closed_Incident_Description = "";
            Closed_Incident_Description = Closed_Incident_Description.PadRight(50, 'a');
            //invoke the method
            Error = AClosedIncident.Valid(Closed_Incident_Date_Closed, Closed_Incident_Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Closed_Incident_DescriptionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsClosedIncident AClosedIncident = new clsClosedIncident();
            //String variable to store any error message
            String Error = "";
            //This should fail
            String Closed_Incident_Description = "";
            Closed_Incident_Description = Closed_Incident_Description.PadRight(51, 'a');
            //invoke the method
            Error = AClosedIncident.Valid(Closed_Incident_Date_Closed, Closed_Incident_Description);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Incident_DescriptionMid()
        {
            //create an instance of the class we want to create
            clsClosedIncident AClosedIncident = new clsClosedIncident();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Closed_Incident_Description = "";
            Closed_Incident_Description = Closed_Incident_Description.PadRight(25, 'a');
            //invoke the method
            Error = AClosedIncident.Valid(Closed_Incident_Date_Closed, Closed_Incident_Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
