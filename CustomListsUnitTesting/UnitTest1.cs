using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomLists;

namespace CustomListsUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add1Test()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 1;

            // Act
            list.add(4);

            // Assert
            Assert.AreEqual(expected, list.count);
        }

        [TestMethod]
        public void Add2Test()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 2;

            // Act
            list.add(4);
            list.add(5);

            // Assert
            Assert.AreEqual()
        }
    }
}
