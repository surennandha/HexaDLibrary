using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HexadLibrary;

namespace HexaDTest
{
    [TestClass]
    public class HexaDLibraryTest
    {
       
        [TestMethod]
        public void WriteUserDataShouldPass()
        {
            TestReadWriteDeleteClass t = new TestReadWriteDeleteClass();
            bool val = t.TestWriteUserData();
            Assert.AreEqual(val, true);
        }
        [TestMethod]
        public void ReadUserDataShouldPass()
        {
            TestReadWriteDeleteClass t = new TestReadWriteDeleteClass();
            bool val = t.TestReadUserData();
            Assert.AreEqual(val, true);
        }
        [TestMethod]
        public void UpdateUserDataShouldPass()
        {
            TestReadWriteDeleteClass t = new TestReadWriteDeleteClass();
            bool val = t.TestUpdateUserData();
            Assert.AreEqual(val, true);
        }
        [TestMethod]
        public void DeleteUserDataShouldPass()
        {
            TestReadWriteDeleteClass t = new TestReadWriteDeleteClass();
            bool val = t.TestDeleteUserData();
            Assert.AreEqual(val, true);
        }
        [TestMethod]
        public void WriteBookDataShouldPass()
        {
            TestReadWriteDeleteClass t = new TestReadWriteDeleteClass();
            bool val = t.TestWritebookData();
            Assert.AreEqual(val, true);
        }
        [TestMethod]
        public void ReadBookDataShouldPass()
        {
            TestReadWriteDeleteClass t = new TestReadWriteDeleteClass();
            bool val = t.TestReadbookData();
            Assert.AreEqual(val, true);
        }
        [TestMethod]
        public void UpdateBookDataShouldPass()
        {
            TestReadWriteDeleteClass t = new TestReadWriteDeleteClass();
            bool val = t.TestUpdateBookData();
            Assert.AreEqual(val, true);
        }
        [TestMethod]
        public void DeleteBookDataShouldPass()
        {
            TestReadWriteDeleteClass t = new TestReadWriteDeleteClass();
            bool val = t.TestDeleteBookData();
            Assert.AreEqual(val, true);
        }
        [TestMethod]
        public void WriteUserDataNullValueShouldFail()
        {

            TestReadWriteDeleteClass t = new TestReadWriteDeleteClass();
            bool val = t.TestWriteUserDataNullCheck();
            Assert.AreEqual(val, false);

        }
        [TestMethod]
        public void ReadUserDataNullValueShouldFail()
        {
            TestReadWriteDeleteClass t = new TestReadWriteDeleteClass();
            bool val = t.TestReadUserDataNullCheck();
            Assert.AreEqual(val, false);
        }
        [TestMethod]
        public void DeleteUserNullValueShouldFail()
        {
            TestReadWriteDeleteClass t = new TestReadWriteDeleteClass();
            bool val = t.TestDeleteUserDataNullCheck();
            Assert.AreEqual(val, false);
        }
        [TestMethod]
        public void WriteBookDataNullValueShouldFail()
        {
            TestReadWriteDeleteClass t = new TestReadWriteDeleteClass();
            bool val = t.TestWritebookDataNullCheck();
            Assert.AreEqual(val, false);
        }
        [TestMethod]
        public void ReadBookDataNullValueShouldFail()
        {
            TestReadWriteDeleteClass t = new TestReadWriteDeleteClass();
            bool val = t.TestReadbookDataNullCheck();
            Assert.AreEqual(val, false);
        }
        [TestMethod]
        public void DeleteBookDataNullValueShouldFail()
        {
            TestReadWriteDeleteClass t = new TestReadWriteDeleteClass();
            bool val = t.TestDeleteBookDataNullCheck();
            Assert.AreEqual(val, false);
        }
    }
}
