namespace BCA.WerZaehltWo3.Tests.Unit
{
    using System;
    using System.Xml;
    using BCA.WerZaehltWo3.ObjectModel;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class A_0500_AppSettingsTests
    {
        [TestMethod]
        public void A_Equals_Functional_00()
        {
            var object1 = InitializedObjects.CreateNewAppSettings();
            var object2 = InitializedObjects.CreateNewAppSettings();

            var actual = object1.Equals(object2);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void A_Equals_Functional_01()
        {
            var object1 = InitializedObjects.CreateNewAppSettings();
            var object2 = new AppSettings();

            var actual = object1.Equals(object2);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void B_Clear_Functional_00()
        {
            var object1 = InitializedObjects.CreateNewAppSettings();
            var object2 = new AppSettings();
            object1.Clear();

            var actual = object1.Equals(object2);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void C_GetHashCode_Functional_00()
        {
            var object1 = InitializedObjects.CreateNewAppSettings();
            var object2 = InitializedObjects.CreateNewAppSettings();

            var hash1 = object1.GetHashCode();
            var hash2 = object2.GetHashCode();
            Assert.AreEqual(hash1, hash2);
        }

        [TestMethod]
        public void C_GetHashCode_Functional_01()
        {
            var object1 = InitializedObjects.CreateNewAppSettings();
            var object2 = new AppSettings();

            var hash1 = object1.GetHashCode();
            var hash2 = object2.GetHashCode();
            Assert.AreNotEqual(hash1, hash2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void E_SaveLoad_ArgumentNull_00()
        {
            var object1 = new AppSettings();
            object1.Load(null);
        }

        [TestMethod]
        public void E_SaveLoad_Functional_00()
        {
            var object1 = InitializedObjects.CreateNewAppSettings();
            var object2 = new AppSettings();

            var xml = object1.Save();
            var doc = new XmlDocument();
            doc.LoadXml(xml);
            object2.Load(doc.SelectSingleNode("AppSettings"));

            var actual = object1.Equals(object2);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void E_SaveLoad_Functional_01()
        {
            var object1 = new AppSettings();
            var object2 = new AppSettings();

            var xml = object1.Save();
            var doc = new XmlDocument();
            doc.LoadXml(xml);
            object2.Load(doc.SelectSingleNode("AppSettings"));

            var actual = object1.Equals(object2);
            Assert.IsTrue(actual);
        }
    }
}