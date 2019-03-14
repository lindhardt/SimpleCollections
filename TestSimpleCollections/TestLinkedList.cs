using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCollections;

namespace TestSimpleCollections
{
    [TestClass]
    public class TestLinkedList
    {
        [TestMethod]
        public void Test_LinkedList_Length()
        {
            LinkedList ll = new LinkedList();

            ll.Add("A");
            ll.Add("B");
            ll.Add("C");
            ll.Add("D");

            Assert.AreEqual(4, ll.Length);
        }
    }
}
