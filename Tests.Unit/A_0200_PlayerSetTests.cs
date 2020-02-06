namespace BCA.WerZaehltWo3.Tests.Unit
{
    using BCA.WerZaehltWo3.Common;
    using BCA.WerZaehltWo3.ObjectModel;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class A_0200_PlayerSetTests
    {
        [TestMethod]
        public void A_Equals_Functional_00()
        {
            var object1 = InitializedObjects.CreateNewPlayerSet();
            var object2 = InitializedObjects.CreateNewPlayerSet();

            var actual = object1.Equals(object2);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void A_Equals_Functional_01()
        {
            var object1 = InitializedObjects.CreateNewPlayerSet();
            var object2 = new PlayerSet();

            var actual = object1.Equals(object2);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void B_Clear_Functional_00()
        {
            var object1 = InitializedObjects.CreateNewPlayerSet();
            var object2 = new PlayerSet();
            object1.Clear();

            var actual = object1.Equals(object2);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void C_GetHashCode_Functional_00()
        {
            var object1 = InitializedObjects.CreateNewPlayerSet();
            var object2 = InitializedObjects.CreateNewPlayerSet();

            var hash1 = object1.GetHashCode();
            var hash2 = object2.GetHashCode();
            Assert.AreEqual(hash1, hash2);
        }

        [TestMethod]
        public void C_GetHashCode_Functional_01()
        {
            var object1 = InitializedObjects.CreateNewPlayerSet();
            var object2 = new PlayerSet();

            var hash1 = object1.GetHashCode();
            var hash2 = object2.GetHashCode();
            Assert.AreNotEqual(hash1, hash2);
        }

        [TestMethod]
        public void D_Clone_Functional_00()
        {
            var object1 = InitializedObjects.CreateNewPlayerSet();
            var object2 = object1.Clone();

            var actual = object1.Equals(object2);
            Assert.IsTrue(actual);
        }
        
        [TestMethod]
        public void E_SaveLoad_Functional_00()
        {
            var object1 = InitializedObjects.CreateNewPlayerSet();

            var json = JsonHelper.Save(object1);
            var object2 = (PlayerSet)JsonHelper.Load(json, typeof(PlayerSet));

            var actual = object1.Equals(object2);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void E_SaveLoad_Functional_01()
        {
            var object1 = new PlayerSet();

            var json = JsonHelper.Save(object1);
            var object2 = (PlayerSet)JsonHelper.Load(json, typeof(PlayerSet));

            var actual = object1.Equals(object2);
            Assert.IsTrue(actual);
        }
    }
}