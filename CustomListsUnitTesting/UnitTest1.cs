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

        //[TestMethod]
        public void Add4Test()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 1000;
            int actual;
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
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void IndexOutOfRangeTest()
        {
            /// TODO: FINISH TEST FOR COUNT
            // Arrange
            CustomList<int> list = new CustomList<int>();
            int actual;

            // Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Remove(8);
            actual = list[5];

        }

        [TestMethod]
        public void RemoveFromListTest()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 2;
            int actual;

            // Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Remove(1);
            actual = list.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove2FromListTest()
        {
            CustomList<int> list = new CustomList<int>();
            int expected = 1;
            int actual;

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Remove(1);
            list.Remove(2);
            actual = list.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertToString()
        {
            CustomList<int> list = new CustomList<int>();
            string expected = "1 ,2 ,3";
            string actual;

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.ToString();
            actual = list.ToString();

            Assert.AreEqual(expected, actual);
        }

        public void CustomListClassZip()
        {
            CustomList<int> list = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();

            list.Add(1);
            list.Add(2);
            list2.Add(3);
            list2.Add(4);
            list2.Add(5);
            list = list.Zipper(list2);
        }
    }
}
