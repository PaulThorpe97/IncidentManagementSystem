using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLibrary
{
    [TestClass]
    public class tstEquipment
    {
        //good test data
        //create some test data to pass to the method
        String Equipment_Name = "Microsoft Word";
        String Equipment_Description = "Microsoft Office Application";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsEquipment AEquipment = new clsEquipment();
            //test to see that it exists
            Assert.IsNotNull(AEquipment);
        }

        [TestMethod]
        public void Equipment_IDPropertyOK()
        {
            //create an instance of the class we want to create
            clsEquipment AEquipment = new clsEquipment();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AEquipment.Equipment_ID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AEquipment.Equipment_ID, TestData);
        }

        [TestMethod]
        public void Equipment_DescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsEquipment AEquipment = new clsEquipment();
            //create some test data to assign to the property
            String TestData = "Microsoft Office Application";
            //assign the data to the property
            AEquipment.Equipment_Description = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AEquipment.Equipment_Description, TestData);
        }

        [TestMethod]
        public void Equipment_HardwarePropertyOK()
        {
            //create an instance of the class we want to create
            clsEquipment AEquipment = new clsEquipment();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AEquipment.Equipment_Hardware = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AEquipment.Equipment_Hardware, TestData);
        }

        [TestMethod]
        public void Equipment_NamePropertyOK()
        {
            //create an instance of the class we want to create
            clsEquipment AEquipment = new clsEquipment();
            //create some test data to assign to the property
            String TestData = "Microsoft Word";
            //assign the data to the property
            AEquipment.Equipment_Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AEquipment.Equipment_Name, TestData);
        }

        [TestMethod]
        public void Equipment_SoftwarePropertyOK()
        {
            //create an instance of the class we want to create
            clsEquipment AEquipment = new clsEquipment();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AEquipment.Equipment_Software = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AEquipment.Equipment_Software, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsEquipment AEquipment = new clsEquipment();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 Equipment_ID = 1;
            //invoke the method
            Found = AEquipment.Find(Equipment_ID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void Equipment_IDFound()
        {
            //create an instance of the class we want to create
            clsEquipment AEquipment = new clsEquipment();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Equipment_ID = 1;
            //invoke the method
            Found = AEquipment.Find(Equipment_ID);
            //check the Equipment_ID
            if (AEquipment.Equipment_ID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Equipment_NameFound()
        {
            //create an instance of the class we want to create
            clsEquipment AEquipment = new clsEquipment();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Equipment_ID = 1;
            //invoke the method
            Found = AEquipment.Find(Equipment_ID);
            //check the Equipment_ID
            if (AEquipment.Equipment_Name != "Microsoft Word")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Equipment_HardwareFound()
        {
            //create an instance of the class we want to create
            clsEquipment AEquipment = new clsEquipment();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Equipment_ID = 1;
            //invoke the method
            Found = AEquipment.Find(Equipment_ID);
            //check the Equipment_ID
            if (AEquipment.Equipment_Hardware != false)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Equipment_SoftwareFound()
        {
            //create an instance of the class we want to create
            clsEquipment AEquipment = new clsEquipment();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Equipment_ID = 1;
            //invoke the method
            Found = AEquipment.Find(Equipment_ID);
            //check the Equipment_ID
            if (AEquipment.Equipment_Software != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Equipment_DescriptionFound()
        {
            //create an instance of the class we want to create
            clsEquipment AEquipment = new clsEquipment();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Equipment_ID = 1;
            //invoke the method
            Found = AEquipment.Find(Equipment_ID);
            //check the Equipment_ID
            if (AEquipment.Equipment_Description != "Microsoft Office Application")
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
            clsEquipment AEquipment = new clsEquipment();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AEquipment.Valid(Equipment_Name,Equipment_Description);
            //test to see that the result is corrct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void Equipment_NameMinLessOne()
        {
            //create an instance of the class we want to create
            clsEquipment AEquipment = new clsEquipment();
            //String variable to store any error message
            String Error = "";
            //This should fail
            String Equipment_Name = "";
            //invoke the method
            Error = AEquipment.Valid(Equipment_Name, Equipment_Description);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Equipment_NameMin()
        {
            //create an instance of the class we want to create
            clsEquipment AEquipment = new clsEquipment();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Equipment_Name = "a";
            //invoke the method
            Error = AEquipment.Valid(Equipment_Name, Equipment_Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Equipment_NameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsEquipment AEquipment = new clsEquipment();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Equipment_Name = "aa";
            //invoke the method
            Error = AEquipment.Valid(Equipment_Name, Equipment_Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Equipment_NameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsEquipment AEquipment = new clsEquipment();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Equipment_Name = "";
            Equipment_Name = Equipment_Name.PadRight(49, 'a');
            //invoke the method
            Error = AEquipment.Valid(Equipment_Name, Equipment_Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Equipment_NameMax()
        {
            //create an instance of the class we want to create
            clsEquipment AEquipment = new clsEquipment();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Equipment_Name = "";
            Equipment_Name = Equipment_Name.PadRight(50, 'a');
            //invoke the method
            Error = AEquipment.Valid(Equipment_Name, Equipment_Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Equipment_NameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsEquipment AEquipment = new clsEquipment();
            //String variable to store any error message
            String Error = "";
            //This should fail
            String Equipment_Name = "";
            Equipment_Name = Equipment_Name.PadRight(51, 'a');
            //invoke the method
            Error = AEquipment.Valid(Equipment_Name, Equipment_Description);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Equipment_NameMid()
        {
            //create an instance of the class we want to create
            clsEquipment AEquipment = new clsEquipment();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Equipment_Name = "";
            Equipment_Name = Equipment_Name.PadRight(25, 'a');
            //invoke the method
            Error = AEquipment.Valid(Equipment_Name, Equipment_Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void Equipment_DescriptionMinLessOne()
        {
            //create an instance of the class we want to create
            clsEquipment AEquipment = new clsEquipment();
            //String variable to store any error message
            String Error = "";
            //This should fail
            String Equipment_Description = "";
            //invoke the method
            Error = AEquipment.Valid(Equipment_Name, Equipment_Description);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Equipment_DescriptionMin()
        {
            //create an instance of the class we want to create
            clsEquipment AEquipment = new clsEquipment();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Equipment_Description = "a";
            //invoke the method
            Error = AEquipment.Valid(Equipment_Name, Equipment_Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Equipment_DescriptionMinPlusOne()
        {
            //create an instance of the class we want to create
            clsEquipment AEquipment = new clsEquipment();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Equipment_Description = "aa";
            //invoke the method
            Error = AEquipment.Valid(Equipment_Name, Equipment_Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Equipment_DescriptionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsEquipment AEquipment = new clsEquipment();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Equipment_Description = "";
            Equipment_Description = Equipment_Description.PadRight(49, 'a');
            //invoke the method
            Error = AEquipment.Valid(Equipment_Name, Equipment_Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Equipment_DescriptionMax()
        {
            //create an instance of the class we want to create
            clsEquipment AEquipment = new clsEquipment();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Equipment_Description = "";
            Equipment_Description = Equipment_Description.PadRight(50, 'a');
            //invoke the method
            Error = AEquipment.Valid(Equipment_Name, Equipment_Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Equipment_DescriptionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsEquipment AEquipment = new clsEquipment();
            //String variable to store any error message
            String Error = "";
            //This should fail
            String Equipment_Description = "";
            Equipment_Description = Equipment_Description.PadRight(51, 'a');
            //invoke the method
            Error = AEquipment.Valid(Equipment_Name, Equipment_Description);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Equipment_DescriptionMid()
        {
            //create an instance of the class we want to create
            clsEquipment AEquipment = new clsEquipment();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Equipment_Description = "";
            Equipment_Description = Equipment_Description.PadRight(25, 'a');
            //invoke the method
            Error = AEquipment.Valid(Equipment_Name, Equipment_Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}