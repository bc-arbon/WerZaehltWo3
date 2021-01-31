using BCA.WerZaehltWo3.Shared.Logic;
using BCA.WerZaehltWo3.Shared.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BCA.WerZaehltWo3.Tests.Unit.Logic
{
    [TestClass]
    public class PlayerboardLogicTests
    {
        [TestMethod]
        public void AddPlayerTest()
        {
            var sut = new Playerboard();
            var player = "Guguseli";

            Assert.AreEqual(0, sut.Players.Count);

            PlayerboardLogic.AddPlayer(sut, player);

            Assert.AreEqual(1, sut.Players.Count);
            Assert.AreEqual(player, sut.Players[0]);
        }

        [TestMethod]
        public void UpdatePlayerTest()
        {
            var sut = InitializedObjects.CreateNewPlayerboard();
            var oldPlayer = sut.Players[0];
            var newPlayer = "Guguseli";

            Assert.AreEqual(oldPlayer, sut.Players[0]);

            PlayerboardLogic.UpdatePlayer(sut, oldPlayer, newPlayer);

            Assert.AreEqual(newPlayer, sut.Players[0]);
        }

        [TestMethod]
        public void RemovePlayerTest()
        {
            var sut = InitializedObjects.CreateNewPlayerboard();
            var oldCount = sut.Players.Count;
            var player = sut.Players[0];

            PlayerboardLogic.RemovePlayer(sut, player);

            Assert.AreEqual(oldCount - 1, sut.Players.Count);
        }
    }
}
