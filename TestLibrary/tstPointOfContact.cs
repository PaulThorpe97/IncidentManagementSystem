using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLibrary
{
    [TestClass]
    public class tstPointOfContact
    {
        //good test data
        //create some test data to pass to the method
        String Point_Of_Contact_Comment = "I tried";


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsPointOfContact APointOfContact = new clsPointOfContact();
            //test to see that it exists
            Assert.IsNotNull(APointOfContact);
        }

        [TestMethod]
        public void Incident_IDPropertyOK()
        {
            //create an instance of the class we want to create
            clsPointOfContact APointOfContact = new clsPointOfContact();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            APointOfContact.Incident_ID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(APointOfContact.Incident_ID, TestData);
        }

        [TestMethod]
        public void Point_Of_Contact_CommentPropertyOK()
        {
            //create an instance of the class we want to create
            clsPointOfContact APointOfContact = new clsPointOfContact();
            //create some test data to assign to the property
            String TestData = "I tried";
            //assign the data to the property
            APointOfContact.Point_Of_Contact_Comment = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(APointOfContact.Point_Of_Contact_Comment, TestData);
        }

        [TestMethod]
        public void Point_Of_Contact_IDPropertyOK()
        {
            //create an instance of the class we want to create
            clsPointOfContact APointOfContact = new clsPointOfContact();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            APointOfContact.Point_Of_Contact_ID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(APointOfContact.Point_Of_Contact_ID, TestData);
        }


        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsPointOfContact APointOfContact = new clsPointOfContact();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 Point_Of_Contact_ID = 1;
            //invoke the method
            Found = APointOfContact.Find(Point_Of_Contact_ID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void Incident_IDFound()
        {
            //create an instance of the class we want to create
            clsPointOfContact APointOfContact = new clsPointOfContact();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Point_Of_Contact_ID = 1;
            //invoke the method
            Found = APointOfContact.Find(Point_Of_Contact_ID);
            //check the Incident_ID
            if (APointOfContact.Incident_ID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Point_Of_Contact_CommentFound()
        {
            //create an instance of the class we want to create
            clsPointOfContact APointOfContact = new clsPointOfContact();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Point_Of_Contact_ID = 1;
            //invoke the method
            Found = APointOfContact.Find(Point_Of_Contact_ID);
            //check the Point_Of_Contact_Comment
            if (APointOfContact.Point_Of_Contact_Comment != "Done")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Point_Of_Contact_IDFound()
        {
            //create an instance of the class we want to create
            clsPointOfContact APointOfContact = new clsPointOfContact();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Point_Of_Contact_ID = 1;
            //invoke the method
            Found = APointOfContact.Find(Point_Of_Contact_ID);
            //check the Point_Of_Contact_ID
            if (APointOfContact.Point_Of_Contact_ID != 1)
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
            clsPointOfContact APointOfContact = new clsPointOfContact();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Point_Of_Contact_ID = 1;
            //invoke the method
            Found = APointOfContact.Find(Point_Of_Contact_ID);
            //check the Staff_ID
            if (APointOfContact.Staff_ID != 1)
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
            clsPointOfContact APointOfContact = new clsPointOfContact();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = APointOfContact.Valid(Point_Of_Contact_Comment);
            //test to see that the result is corrct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Point_Of_Contact_CommentMinLessOne()
        {
            //create an instance of the class we want to create
            clsPointOfContact APointOfContact = new clsPointOfContact();
            //String variable to store any error message
            String Error = "";
            //This should fail
            String Point_Of_Contact_Comment = "";
            //invoke the method
            Error = APointOfContact.Valid(Point_Of_Contact_Comment);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Point_Of_Contact_CommentMin()
        {
            //create an instance of the class we want to create
            clsPointOfContact APointOfContact = new clsPointOfContact();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Point_Of_Contact_Comment = "a";
            //invoke the method
            Error = APointOfContact.Valid(Point_Of_Contact_Comment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Point_Of_Contact_CommentMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPointOfContact APointOfContact = new clsPointOfContact();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Point_Of_Contact_Comment = "aa";
            //invoke the method
            Error = APointOfContact.Valid(Point_Of_Contact_Comment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Point_Of_Contact_CommentMaxLessOne()
        {
            //create an instance of the class we want to create
            clsPointOfContact APointOfContact = new clsPointOfContact();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Point_Of_Contact_Comment = "";
            Point_Of_Contact_Comment = Point_Of_Contact_Comment.PadRight(49, 'a');
            //invoke the method
            Error = APointOfContact.Valid(Point_Of_Contact_Comment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Point_Of_Contact_CommentMax()
        {
            //create an instance of the class we want to create
            clsPointOfContact APointOfContact = new clsPointOfContact();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Point_Of_Contact_Comment = "";
            Point_Of_Contact_Comment = Point_Of_Contact_Comment.PadRight(50, 'a');
            //invoke the method
            Error = APointOfContact.Valid(Point_Of_Contact_Comment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Point_Of_Contact_CommentMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsPointOfContact APointOfContact = new clsPointOfContact();
            //String variable to store any error message
            String Error = "";
            //This should fail
            String Point_Of_Contact_Comment = "";
            Point_Of_Contact_Comment = Point_Of_Contact_Comment.PadRight(51, 'a');
            //invoke the method
            Error = APointOfContact.Valid(Point_Of_Contact_Comment);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Equipment_NameMid()
        {
            //create an instance of the class we want to create
            clsPointOfContact APointOfContact = new clsPointOfContact();
            //String variable to store any error message
            String Error = "";
            //This should pass
            String Point_Of_Contact_Comment = "";
            Point_Of_Contact_Comment = Point_Of_Contact_Comment.PadRight(25, 'a');
            //invoke the method
            Error = APointOfContact.Valid(Point_Of_Contact_Comment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}