using BCA.WerZaehltWo3.Shared.Helpers;
using BCA.WerZaehltWo3.Shared.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BCA.WerZaehltWo3.Tests.Unit
{
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
        public void E_SaveLoad_Functional_00()
        {
            var object1 = InitializedObjects.CreateNewAppSettings();

            var json = JsonHelper.Save(object1);
            var object2 = (AppSettings)JsonHelper.Load(json, typeof(AppSettings));

            var actual = object1.Equals(object2);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void E_SaveLoad_Functional_01()
        {
            var object1 = new AppSettings();

            var json = JsonHelper.Save(object1);
            var object2 = (AppSettings)JsonHelper.Load(json, typeof(AppSettings));

            var actual = object1.Equals(object2);
            Assert.IsTrue(actual);
        }
    }
}