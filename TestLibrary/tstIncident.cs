using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLibrary
{
    [TestClass]
    public class tstIncident
    {
        //good test data
        //create some test data to pass to the method
        String Incident_Date_Occured = DateTime.Now.Date.ToString();
        String Incident_Description = "Microsoft Word keeps crashing";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsIncident AIncident = new clsIncident();
            //test to see that it exists
            Assert.IsNotNull(AIncident);
        }

        [TestMethod]
        public void Incident_Date_OccuredOK()
        {
            //create an instance of the class we want to create
            clsIncident AIncident = new clsIncident();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AIncident.Incident_Date_Occured = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AIncident.Incident_Date_Occured, TestData);
        }

        [TestMethod]
        public void Equipment_IDPropertyOK()
        {
            //create an instance of the class we want to create
            clsIncident AIncident = new clsIncident();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AIncident.Equipment_ID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AIncident.Equipment_ID, TestData);
        }

        [TestMethod]
        public void Incident_DescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsIncident AIncident = new clsIncident();
            //create some test data to assign to the property
            String TestData = "Microsoft Word keeps crashing";
            //assign the data to the property
            AIncident.Incident_Description = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AIncident.Incident_Description, TestData);
        }

        [TestMethod]
        public void Incident_HighPropertyOK()
        {
            //create an instance of the class we want to create
            clsIncident AIncident = new clsIncident();
            //create some test data to assign to the property
            Boolean TestData = false;
            //assign the data to the property
            AIncident.Incident_High = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AIncident.Incident_High, TestData);
        }

        [TestMethod]
        public void Incident_In_ProgressPropertyOK()
        {
            //create an instance of the class we want to create
            clsIncident AIncident = new clsIncident();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AIncident.Incident_In_Progress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AIncident.Incident_In_Progress, TestData);
        }

        [TestMethod]
        public void Incident_LowPropertyOK()
        {
            //create an instance of the class we want to create
            clsIncident AIncident = new clsIncident();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AIncident.Incident_Low = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AIncident.Incident_Low, TestData);
        }

        [TestMethod]
        public void Incident_MediumPropertyOK()
        {
            //create an instance of the class we want to create
            clsIncident AIncident = new clsIncident();
            //create some test data to assign to the property
            Boolean TestData = false;
            //assign the data to the property
            AIncident.Incident_Medium = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AIncident.Incident_Medium, TestData);
        }

        [TestMethod]
        public void Incident_IDPropertyOK()
        {
            //create an instance of the class we want to create
            clsIncident AIncident = new clsIncident();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AIncident.Incident_ID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AIncident.Incident_ID, TestData);
        }

        [TestMethod]
        public void Incident_PendingPropertyOK()
        {
            //create an instance of the class we want to create
            clsIncident AIncident = new clsIncident();
            //create some test data to assign to the property
            Boolean TestData = false;
            //assign the data to the property
            AIncident.Incident_Pending = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AIncident.Incident_Pending, TestData);
        }

        [TestMethod]
        public void Staff_IDPropertyOK()
        {
            //create an instance of the class we want to create
            clsIncident AIncident = new clsIncident();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AIncident.Staff_ID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AIncident.Staff_ID, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsIncident AIncident = new clsIncident();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 Incident_ID = 1;
            //invoke the method
            Found = AIncident.Find(Incident_ID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void Incident_Date_OccuredFound()
        {
            //create an instance of the class we want to create
            clsIncident AIncident = new clsIncident();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Incident_ID = 1;
            //invoke the method
            Found = AIncident.Find(Incident_ID);
            //check the Incident_Date_Occured
            if (AIncident.Incident_Date_Occured !=Convert.ToDateTime("15/04/2019"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Equipment_IDFound()
        {
            //create an instance of the class we want to create
            clsIncident AIncident = new clsIncident();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Incident_ID = 1;
            //invoke the method
            Found = AIncident.Find(Incident_ID);
            //check the Equipment_ID
            if (AIncident.Equipment_ID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Incident_DescriptionFound()
        {
            //create an instance of the class we want to create
            clsIncident AIncident = new clsIncident();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Incident_ID = 1;
            //invoke the method
            Found = AIncident.Find(Incident_ID);
            //check the Incident_Description
            if (AIncident.Incident_Description != "Microsoft Word keeps crashing")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Incident_HighFound()
        {
            //create an instance of the class we want to create
            clsIncident AIncident = new clsIncident();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Incident_ID = 1;
            //invoke the method
            Found = AIncident.Find(Incident_ID);
            //check the Incident_High
            if (AIncident.Incident_High != false)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Incident_In_ProgressFound()
        {
            //create an instance of the class we want to create
            clsIncident AIncident = new clsIncident();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Incident_ID = 1;
            //invoke the method
            Found = AIncident.Find(Incident_ID);
            //check the Incident_In_Progress
            if (AIncident.Incident_In_Progress != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void Incident_LowFound()
        {
            //create an instance of the class we want to create
            clsIncident AIncident = new clsIncident();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Incident_ID = 1;
            //invoke the method
            Found = AIncident.Find(Incident_ID);
            //check the Incident_Low
            if (AIncident.Incident_Low != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void Incident_MediumFound()
        {
            //create an instance of the class we want to create
            clsIncident AIncident = new clsIncident();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Incident_ID = 1;
            //invoke the method
            Found = AIncident.Find(Incident_ID);
            //check the Incident_Medium
            if (AIncident.Incident_Medium != false)
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
            clsIncident AIncident = new clsIncident();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Incident_ID = 1;
            //invoke the method
            Found = AIncident.Find(Incident_ID);
            //check the Incident_ID
            if (AIncident.Incident_ID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void Incident_PendingFound()
        {
            //create an instance of the class we want to create
            clsIncident AIncident = new clsIncident();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Incident_ID = 1;
            //invoke the method
            Found = AIncident.Find(Incident_ID);
            //check the Incident-Pending
            if (AIncident.Incident_Pending != false)
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
            clsIncident AIncident = new clsIncident();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Incident_ID = 1;
            //invoke the method
            Found = AIncident.Find(Incident_ID);
            //check the Incident_ID
            if (AIncident.Staff_ID != 1)
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
            clsIncident AIncident = new clsIncident();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AIncident.Valid(Incident_Date_Occured, Incident_Description);
            //test to see that the result is corrct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void Incident_Date_OccuredExtremeMin()
        {
            //create an instance of the class we want to create
            clsIncident AIncident = new clsIncident();
            //boolean variable to store the result of the validation
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable 
            String Incident_Date_Occured = TestDate.ToString();
            //invoke the method
            Error = AIncident.Valid(Incident_Date_Occured, Incident_Description);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Incident_Date_OccuredMinLessOne()
        {
            //create an instance of the class we want to create
            clsIncident AIncident = new clsIncident();
            //boolean variable to store the result of the validation
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable 
            String Incident_Date_Occured = TestDate.ToString();
            //invoke the method
            Error = AIncident.Valid(Incident_Date_Occured, Incident_Description);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Incident_Date_OccuredMin()
        {
            //create an instance of the class we want to create
            clsIncident AIncident = new clsIncident();
            //boolean variable to store the result of the validation
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable 
            String Incident_Date_Occured = TestDate.ToString();
            //invoke the method
            Error = AIncident.Valid(Incident_Date_Occured, Incident_Description);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Incident_Date_OccuredMinPlusOne()
        {
            //create an instance of the class we want to create
            clsIncident AIncident = new clsIncident();
            //boolean variable to store the result of the validation
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable 
            String Incident_Date_Occured = TestDate.ToString();
            //invoke the method
            Error = AIncident.Valid(Incident_Date_Occured, Incident_Description);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Incident_Date_OccuredExtremeMax()
        {
            //create an instance of the class we want to create
            clsIncident AIncident = new clsIncident();
            //boolean variable to store the result of the validation
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable 
            String Incident_Date_Occured = TestDate.ToString();
            //invoke the method
            Error = AIncident.Valid(Incident_Date_Occured, Incident_Description);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Incident_DescriptionMinLessOne()
        {
            //create an instance of the class we want to create
            clsIncident AIncident = new clsIncident();
            //String variable to store any error message
            String Error = "";
            //This should fail
            String Incident_Description = "";
            //invoke the method
            Error = AIncident.Valid(Incident_Date_Occured, Incident_Description);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Incident_DescriptionMin()
        {
            //create an instance of the class we want to create
            clsIncident AIncident = new clsIncident();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Incident_Description = "a";
            //invoke the method
            Error = AIncident.Valid(Incident_Date_Occured, Incident_Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Incident_DescriptionMinPlusOne()
        {
            //create an instance of the class we want to create
            clsIncident AIncident = new clsIncident();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Incident_Description = "aa";
            //invoke the method
            Error = AIncident.Valid(Incident_Date_Occured, Incident_Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Incident_DescriptionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsIncident AIncident = new clsIncident();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Incident_Description = "";
            Incident_Description = Incident_Description.PadRight(49, 'a');
            //invoke the method
            Error = AIncident.Valid(Incident_Date_Occured, Incident_Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Equipment_DescriptionMax()
        {
            //create an instance of the class we want to create
            clsIncident AIncident = new clsIncident();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Incident_Description = "";
            Incident_Description = Incident_Description.PadRight(50, 'a');
            //invoke the method
            Error = AIncident.Valid(Incident_Date_Occured, Incident_Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Incident_DescriptionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsIncident AIncident = new clsIncident();
            //String variable to store any error message
            String Error = "";
            //This should fail
            String Incident_Description = "";
            Incident_Description = Incident_Description.PadRight(51, 'a');
            //invoke the method
            Error = AIncident.Valid(Incident_Date_Occured, Incident_Description);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Incident_DescriptionMid()
        {
            //create an instance of the class we want to create
            clsIncident AIncident = new clsIncident();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Incident_Description = "";
            Incident_Description = Incident_Description.PadRight(25, 'a');
            //invoke the method
            Error = AIncident.Valid(Incident_Date_Occured, Incident_Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
