using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLibrary
{
    [TestClass]
    public class tstStaff
    {
        //good test data
        //create some test data to pass to the method
        String Staff_Forename = "Paul";
        String Staff_Phone = "07592115157";
        String Staff_Surname = "Thorpe";


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void Staff_IDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStaff.Staff_ID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Staff_ID, TestData);
        }

        [TestMethod]
        public void Staff_ForenamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "Paul";
            //assign the data to the property
            AStaff.Staff_Forename = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Staff_Forename, TestData);
        }

        [TestMethod]
        public void Staff_PhonePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "07592115157";
            //assign the data to the property
            AStaff.Staff_Phone = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Staff_Phone, TestData);
        }

        [TestMethod]
        public void Staff_SurnamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "Thorpe";
            //assign the data to the property
            AStaff.Staff_Surname = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Staff_Surname, TestData);
        }

        [TestMethod]
        public void Role_IDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStaff.Role_ID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Role_ID, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 Staff_ID = 1;
            //invoke the method
            Found = AStaff.Find(Staff_ID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void Staff_IDFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staff_ID = 1;
            //invoke the method
            Found = AStaff.Find(Staff_ID);
            //check the Equipment_ID
            if (AStaff.Staff_ID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Staff_ForenameFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staff_ID = 1;
            //invoke the method
            Found = AStaff.Find(Staff_ID);
            //check the Equipment_ID
            if (AStaff.Staff_Forename != "Paul")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Staff_PhoneFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staff_ID = 1;
            //invoke the method
            Found = AStaff.Find(Staff_ID);
            //check the Equipment_ID
            if (AStaff.Staff_Phone != "07592115157")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Staff_SurnameFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staff_ID = 1;
            //invoke the method
            Found = AStaff.Find(Staff_ID);
            //check the Equipment_ID
            if (AStaff.Staff_Surname != "Thorpe")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Role_IDFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staff_ID = 1;
            //invoke the method
            Found = AStaff.Find(Staff_ID);
            //check the Equipment_ID
            if (AStaff.Role_ID != 1)
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
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AStaff.Valid(Staff_Forename, Staff_Phone, Staff_Surname);
            //test to see that the result is corrct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void Staff_ForenameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //This should fail
            String Staff_Forename = "";
            //invoke the method
            Error = AStaff.Valid(Staff_Forename, Staff_Phone, Staff_Surname);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Staff_ForenameMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Staff_Forename = "a";
            //invoke the method
            Error = AStaff.Valid(Staff_Forename, Staff_Phone, Staff_Surname);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_ForenameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Staff_Forename = "aa";
            //invoke the method
            Error = AStaff.Valid(Staff_Forename, Staff_Phone, Staff_Surname);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_ForenameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Staff_Forename = "";
            Staff_Forename = Staff_Forename.PadRight(49, 'a');
            //invoke the method
            Error = AStaff.Valid(Staff_Forename, Staff_Phone, Staff_Surname);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_ForenameMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Staff_Forename = "";
            Staff_Forename = Staff_Forename.PadRight(50, 'a');
            //invoke the method
            Error = AStaff.Valid(Staff_Forename, Staff_Phone, Staff_Surname);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_ForenameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //This should fail
            String Staff_Forename = "";
            Staff_Forename = Staff_Forename.PadRight(51, 'a');
            //invoke the method
            Error = AStaff.Valid(Staff_Forename, Staff_Phone, Staff_Surname);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Staff_ForenameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Staff_Forename = "";
            Staff_Forename = Staff_Forename.PadRight(25, 'a');
            //invoke the method
            Error = AStaff.Valid(Staff_Forename, Staff_Phone, Staff_Surname);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_PhoneMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //This should fail
            String Staff_Phone = "";
            //invoke the method
            Error = AStaff.Valid(Staff_Forename, Staff_Phone, Staff_Surname);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Staff_PhoneMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Staff_Phone = "a";
            //invoke the method
            Error = AStaff.Valid(Staff_Forename, Staff_Phone, Staff_Surname);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_PhoneMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Staff_Phone = "aa";
            //invoke the method
            Error = AStaff.Valid(Staff_Forename, Staff_Phone, Staff_Surname);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_PhoneMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Staff_Phone = "";
            Staff_Phone = Staff_Phone.PadRight(10, 'a');
            //invoke the method
            Error = AStaff.Valid(Staff_Forename, Staff_Phone, Staff_Surname);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_PhoneMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Staff_Phone = "";
            Staff_Phone = Staff_Phone.PadRight(11, 'a');
            //invoke the method
            Error = AStaff.Valid(Staff_Forename, Staff_Phone, Staff_Surname);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_PhoneMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //This should fail
            String Staff_Phone = "";
            Staff_Phone = Staff_Phone.PadRight(12, 'a');
            //invoke the method
            Error = AStaff.Valid(Staff_Forename, Staff_Phone, Staff_Surname);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Staff_PhoneMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Staff_Phone = "";
            Staff_Phone = Staff_Phone.PadRight(5, 'a');
            //invoke the method
            Error = AStaff.Valid(Staff_Forename, Staff_Phone, Staff_Surname);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_SurnameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //This should fail
            String Staff_Surname = "";
            //invoke the method
            Error = AStaff.Valid(Staff_Forename, Staff_Phone, Staff_Surname);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Staff_SurnameMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Staff_Surname = "a";
            //invoke the method
            Error = AStaff.Valid(Staff_Forename, Staff_Phone, Staff_Surname);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_SurnameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Staff_Surname = "aa";
            //invoke the method
            Error = AStaff.Valid(Staff_Forename, Staff_Phone, Staff_Surname);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_SurnameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Staff_Surname = "";
            Staff_Surname = Staff_Surname.PadRight(49, 'a');
            //invoke the method
            Error = AStaff.Valid(Staff_Forename, Staff_Phone, Staff_Surname);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_SurnameMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Staff_Surname = "";
            Staff_Surname = Staff_Surname.PadRight(50, 'a');
            //invoke the method
            Error = AStaff.Valid(Staff_Forename, Staff_Phone, Staff_Surname);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_SurnameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //This should fail
            String Staff_Phone = "";
            Staff_Surname = Staff_Surname.PadRight(51, 'a');
            //invoke the method
            Error = AStaff.Valid(Staff_Forename, Staff_Phone, Staff_Surname);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Staff_SurnameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Staff_Surname = "";
            Staff_Surname = Staff_Surname.PadRight(25, 'a');
            //invoke the method
            Error = AStaff.Valid(Staff_Forename, Staff_Phone, Staff_Surname);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
