using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NameInverterTests
{
    [TestClass]
    public class NameInverterTest
    {
        [TestMethod]
        public void GivenNull_ReturnsEmptyString()
        {
            AssertInverted(null, "");
        }

        [TestMethod]
        public void GivenEmptyString_ReturnEmptyString()
        {
            AssertInverted("", "");
        }

        [TestMethod]
        public void GivenSimpleName_ReturnSimpleName()
        {
            AssertInverted("Name", "Name");
        }
        [TestMethod]
        public void GivenFirstLast_ReturnLastFirst()
        {
            AssertInverted("First Last", "Last, First");
        }

        private string InvertName(string name)
        {
            if (name != null || name.Length <= 0)
                return "";
            var names = name.Split(' ');
            if (names.Length == 1)
                return name;
            return names[1] + ", " + names[0];
        }

        private void AssertInverted(string originalName, string InvertedName)
        {
            Assert.AreEqual(InvertedName, InvertName(originalName));
        }
    }
}
