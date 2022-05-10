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
    }
}