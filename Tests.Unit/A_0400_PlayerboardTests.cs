namespace BCA.WerZaehltWo3.Tests.Unit
{
    using System;
    using System.Xml;
    using BCA.WerZaehltWo3.Common;
    using BCA.WerZaehltWo3.ObjectModel;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class A_0400_PlayerboardTests
    {
        [TestMethod]
        public void A_Equals_Functional_00()
        {
            var object1 = InitializedObjects.CreateNewPlayerboard();
            var object2 = InitializedObjects.CreateNewPlayerboard();

            var actual = object1.Equals(object2);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void A_Equals_Functional_01()
        {
            var object1 = InitializedObjects.CreateNewPlayerboard();
            var object2 = new Playerboard();

            var actual = object1.Equals(object2);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void B_Clear_Functional_00()
        {
            var object1 = InitializedObjects.CreateNewPlayerboard();
            var object2 = new Playerboard();
            object1.Clear();

            var actual = object1.Equals(object2);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void C_GetHashCode_Functional_00()
        {
            var object1 = InitializedObjects.CreateNewPlayerboard();
            var object2 = InitializedObjects.CreateNewPlayerboard();

            var hash1 = object1.GetHashCode();
            var hash2 = object2.GetHashCode();
            Assert.AreEqual(hash1, hash2);
        }

        [TestMethod]
        public void C_GetHashCode_Functional_01()
        {
            var object1 = InitializedObjects.CreateNewPlayerboard();
            var object2 = new Playerboard();

            var hash1 = object1.GetHashCode();
            var hash2 = object2.GetHashCode();
            Assert.AreNotEqual(hash1, hash2);
        }

        [TestMethod]
        public void D_Clone_Functional_00()
        {
            var object1 = InitializedObjects.CreateNewPlayerboard();
            var object2 = object1.Clone();

            var actual = object1.Equals(object2);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void E_SaveLoad_Functional_00()
        {
            var object1 = InitializedObjects.CreateNewPlayerboard();

            var json = JsonHelper.Save(object1);
            var object2 = (Playerboard)JsonHelper.Load(json, typeof(Playerboard));

            var actual = object1.Equals(object2);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void E_SaveLoad_Functional_01()
        {
            var object1 = new Playerboard();

            var json = JsonHelper.Save(object1);
            var object2 = (Playerboard)JsonHelper.Load(json, typeof(Playerboard));

            var actual = object1.Equals(object2);
            Assert.IsTrue(actual);
        }
    }
}