using System;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickTesting;

namespace QuickTestingTestProject
{
    /// <summary>
    /// Quick test using mock objects
    /// </summary>
    [TestClass]
    public class QuickMockUnitTest
    {
        #region Mock Object Testing

        [TestMethod()]
        public void TestDBClass()
        {
            // Test both concrete classes
            DBClass dbClass = new DBClass();
            PlainObject po = new PlainObject(dbClass);

            po.Id = 1;
            po.Name = "Homer";

            // Verify that the object saved successfully
            Assert.IsTrue(po.SaveToDb());

            // Verify that the object added is there and is the correct object
            Assert.AreEqual(dbClass.DataBase.Count, 1);
            Assert.ReferenceEquals(dbClass.DataBase[1], po);
        }

        [TestMethod()]
        public void MockTestOne()
        {
            var dbClassMock = new Mock<DBClass>();

            // Create the classs to be tested
            PlainObject poHomer = new PlainObject(dbClassMock.Object);
            poHomer.Id = 1;
            poHomer.Name = "Homer";

            PlainObject poMarge = new PlainObject(dbClassMock.Object);
            poMarge.Id = 2;
            poMarge.Name = "Marge";

            // Mock the DBClass return values. Setting a different result based on
            // the object being passed into it. This helps to test different code paths 
            // based on results.
            dbClassMock.Setup(db => db.Save(poMarge)).Returns(false);
            dbClassMock.Setup(db => db.Save(poHomer)).Returns(true);
            
            // The mock will return false no matter what for the poMarge Object
            Assert.IsFalse(poMarge.SaveToDb());

            // The mock will return true no matter what for the poHomer Object
            Assert.IsTrue(poHomer.SaveToDb());

            // Verify that save was called for all objects
            dbClassMock.Verify(v => v.Save(It.IsAny<PlainObject>()), Times.Exactly(2));

            // And verify that it was called for each object individually as well
            dbClassMock.Verify(v => v.Save(poMarge), Times.Once());
            dbClassMock.Verify(v => v.Save(poHomer), Times.Once());
        }

        #endregion

    }
}
