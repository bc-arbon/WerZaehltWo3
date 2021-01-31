using BCA.WerZaehltWo3.Shared.Helpers;
using BCA.WerZaehltWo3.Shared.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BCA.WerZaehltWo3.Tests.Unit
{
    [TestClass]
    public class A_0300_CourtTests
    {       
        [TestMethod]
        public void B_Clear_Functional_00()
        {
            var object1 = InitializedObjects.CreateNewCourt();
            var object2 = new Court();
            object1.Clear();

            var actual = object1.Equals(object2);
            Assert.IsTrue(actual);
        }        

        [TestMethod]
        public void D_Clone_Functional_00()
        {
            var object1 = InitializedObjects.CreateNewCourt();
            var object2 = object1.Clone();

            var actual = object1.Equals(object2);
            Assert.IsTrue(actual);
        }
        
        [TestMethod]
        public void E_SaveLoad_Functional_00()
        {
            var object1 = InitializedObjects.CreateNewCourt();

            var json = JsonHelper.Save(object1);
            var object2 = (Court)JsonHelper.Load(json, typeof(Court));

            var actual = object1.Equals(object2);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void E_SaveLoad_Functional_01()
        {
            var object1 = new Court();

            var json = JsonHelper.Save(object1);
            var object2 = (Court)JsonHelper.Load(json, typeof(Court));

            var actual = object1.Equals(object2);
            Assert.IsTrue(actual);
        }
    }
}