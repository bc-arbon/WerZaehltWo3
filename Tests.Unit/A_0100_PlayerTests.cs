using BCA.WerZaehltWo3.Shared.Helpers;
using BCA.WerZaehltWo3.Shared.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BCA.WerZaehltWo3.Tests.Unit
{
    [TestClass]
    public class A_0100_PlayerTests
    {
        public void A_Equals_Functional_00()
        {
            var object1 = InitializedObjects.CreateNewPlayer();
            var object2 = InitializedObjects.CreateNewPlayer();

            var actual = object1.Equals(object2);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void A_Equals_Functional_01()
        {
            var object1 = InitializedObjects.CreateNewPlayer();
            var object2 = new Player();

            var actual = object1.Equals(object2);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void B_Clear_Functional_00()
        {
            var object1 = InitializedObjects.CreateNewPlayer();
            var object2 = new Player();
            object1.Clear();

            var actual = object1.Equals(object2);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void C_GetHashCode_Functional_00()
        {
            var object1 = InitializedObjects.CreateNewPlayer();
            var object2 = InitializedObjects.CreateNewPlayer();

            var hash1 = object1.GetHashCode();
            var hash2 = object2.GetHashCode();
            Assert.AreEqual(hash1, hash2);
        }

        [TestMethod]
        public void C_GetHashCode_Functional_01()
        {
            var object1 = InitializedObjects.CreateNewPlayer();
            var object2 = InitializedObjects.CreateNewPlayer2();

            var hash1 = object1.GetHashCode();
            var hash2 = object2.GetHashCode();
            Assert.AreNotEqual(hash1, hash2);
        }

        [TestMethod]
        public void D_Clone_Functional_00()
        {
            var object1 = InitializedObjects.CreateNewPlayer();
            var object2 = object1.Clone();

            var actual = object1.Equals(object2);
            Assert.IsTrue(actual);
        }
        
        [TestMethod]
        public void E_SaveLoad_Functional_00()
        {
            var object1 = InitializedObjects.CreateNewPlayer();

            var json = JsonHelper.Save(object1);
            var object2 = (Player)JsonHelper.Load(json, typeof(Player));

            var actual = object1.Equals(object2);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void E_SaveLoad_Functional_01()
        {
            var object1 = new Player();

            var json = JsonHelper.Save(object1);
            var object2 = (Player)JsonHelper.Load(json, typeof(Player));

            var actual = object1.Equals(object2);
            Assert.IsTrue(actual);
        }
    }
}