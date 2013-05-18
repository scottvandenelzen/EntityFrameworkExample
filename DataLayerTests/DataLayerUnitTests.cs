using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataLayer;
using System.Data;
using System.Linq;

///
/// stole the unit test ideas from here --> http://www.arrangeactassert.com/code-first-entity-framework-unit-test-examples/
///
namespace DataLayerTests
{
    [TestClass]
    public class DataLayerUnitTests
    {
        /// <summary>
        /// Test Method to Connect to the repository and see if there are any records.
        /// This should fail if you have an empty table
        /// </summary>
        [TestMethod]
        public void ContactsRepositoryContainsData()
        {
            
            // arrange 
            // note connection string is in app.config
            ContactsDb db = new ContactsDb();

            // act -- go get the first record
            Contact savedContact = (from d in db.Contacts where d.id == 1 select d).Single();

            // assert
            Assert.AreEqual(savedContact.id, 1);

        }

        /// <summary>
        /// Test Method to Connect to the repository and add a record
        /// </summary>
        [TestMethod]
        public void SaveNewContactToRepository()
        {
            // arrange

            // note connection string is in app.config
            Contact con = new Contact();
            ContactsDb db = new ContactsDb();
            con.fname = "Adam";
            con.lname = "VandenElzen";
            con.phone = "867-5309";
            db.Contacts.AddObject(con);

            // act
            db.SaveChanges();


            // Assert -- see if the record retreived from the database matches the one i just added
            Contact savedContact = (from d in db.Contacts where d.id == con.id select d).Single();

            Assert.AreEqual(savedContact.fname, con.fname);
            Assert.AreEqual(savedContact.lname, con.lname);
            Assert.AreEqual(savedContact.phone, con.phone);

            // cleanup
            db.Contacts.DeleteObject(con);

        }


    }
}
