using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata._7kyu;

namespace UnitTestProject
{
    [TestClass]
    public class _7kyu_Test
    {
        [TestMethod]
        public void Parts_of_a_list_Test()
        {
            String[] a = new String[] { "I", "wish", "I", "hadn't", "come" };            
            var actual = Parts_of_a_list.Partlist(a); // True
            String[][] expected = new String[][] {
                 new String[] { "I", "wish I hadn't come" },
                 new String[] { "I wish", "I hadn't come" },
                 new String[] { "I wish I", "hadn't come" },
                 new String[] { "I wish I hadn't", "come" }
            };
            Assert.AreEqual(TestHelper.Array2DToString(expected), TestHelper.Array2DToString(actual));
        }
        [TestMethod]
        public void Parts_of_a_list_Linq_Test()
        {
            String[] a = new String[] { "I", "wish", "I", "hadn't", "come" };
            var actual = Parts_of_a_list.Partlist_Linq(a); // True
            String[][] expected = new String[][] {
                 new String[] { "I", "wish I hadn't come" },
                 new String[] { "I wish", "I hadn't come" },
                 new String[] { "I wish I", "hadn't come" },
                 new String[] { "I wish I hadn't", "come" }
            };
            Assert.AreEqual(TestHelper.Array2DToString(expected), TestHelper.Array2DToString(actual));
        }
    }
}
