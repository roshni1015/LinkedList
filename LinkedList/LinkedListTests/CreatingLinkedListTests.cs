using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Tests
{
    [TestClass()]
    public class CreatingLinkedListTests
    {
        [TestMethod()]
        public void SearchTest()
        {
            CreatingLinkedList<int> test = new();
            test.AddToFirst(70);
            test.AddToFirst(30);
            test.AddToFirst(56);
            test.Search(30);
            Assert.AreEqual(true, test.Search(30));


        }

        [TestMethod()]
        public void SearchTest1()
        {
            CreatingLinkedList<int> Lvalue7 = new();
            Lvalue7.AddToFirst(56);
            Lvalue7.AddToFirst(30);
            Lvalue7.AddToFirst(70);
            Assert.AreEqual(1, Lvalue7.Insert40(30, 40));

        }

        [TestMethod()]
        public void Delete40Test()
        {
            CreatingLinkedList<int> Lvalue7 = new();
            Lvalue7.AddToFirst(56);
            Lvalue7.AddToFirst(30);
            Lvalue7.AddToFirst(40);
            Lvalue7.AddToFirst(70);
            Assert.AreEqual(1, Lvalue7.Delete40(40));
        }
    }
}