using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomLists;
using System.Collections.Generic;

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
            list.Add(4);

            // Assert
            Assert.AreEqual(expected, list.Count);
        }

        [TestMethod]
        public void Add2Test()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 2;

            // Act
            list.Add(4);
            list.Add(5);

            // Assert
            Assert.AreEqual(expected, list.Count);
        }

        [TestMethod]
        public void Add3Test()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 4;
            int actual;
            // Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            actual = list[3];
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add4Test()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            int expected = 1000;
            CustomList<int> actual = new CustomList<int>();
            // Act
            for (int i = 0; i < 1000; i++)
            {
                list.Add(i);
            }
            actual = list[1000];

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IndexOutOfRangeTest()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();

            // Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            int x = list[4];

            // Assert
        }

        [TestMethod]
        public void RemoveFromListTest()
        {
            /// TODO: FINISH TEST FOR COUNT
            // Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 2;
            int actual = list.count;

            // Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Remove[1];

            // Assert
            Assert.AreEqual
        }

        [TestMethod]
        public void RemoveFromListTest()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            bool expected = true;
            bool actual;

            // Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            
            actual = list.Remove(1);

            // Assert
            Assert.AreEqual
        }
    }
}
