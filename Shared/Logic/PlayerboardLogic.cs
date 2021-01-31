namespace BCA.WerZaehltWo3.Shared.Logic
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using BCA.WerZaehltWo3.Shared.Helpers;
    using BCA.WerZaehltWo3.Shared;
    using BCA.WerZaehltWo3.Shared.ObjectModel;

    public static class PlayerboardLogic
    { 
        public static void Clear(Playerboard playerboard)
        {
            playerboard.Clear();
        }

        public static void UpdatePlayer(Playerboard playerboard, string oldPlayer, string newPlayer)
        {
            var index = playerboard.Players.FindIndex(player => player == oldPlayer);
            playerboard.Players[index] = newPlayer;
        }

        public static void SetCourtCount(Playerboard playerboard, int newCount)
        {
            var currentCount = playerboard.Courts.Count;
            var newCourts = new List<Court>();

            // Do nothing when its the same
            if (newCount == currentCount)
            {
                return;
            }

            // The new count is lower, just clone the existing courts
            if (newCount < currentCount)
            {
                for (var i = 0; i < newCount; i++)
                {
                    newCourts.Add(playerboard.Courts[i].Clone());
                }
            }
            else
            {
                // The new count is higher, clone all existing courts and add some new ones
                newCourts.AddRange(playerboard.Courts.Select(court => court.Clone()));

                for (var i = currentCount + 1; i <= newCount; i++)
                {
                    newCourts.Add(new Court { Number = i });
                }
            }

            playerboard.Courts.Clear();
            playerboard.Courts.AddRange(newCourts);
        }

        public static void Save(Playerboard playerboard)
        {
            JsonHelper.SaveToFile(playerboard, Constants.PlayerboardFilename);
        }

        public static Playerboard Load()
        {
            if (!File.Exists(Constants.PlayerboardFilename))
            {
                // Create 8 courts as default
                var playerboard1 = new Playerboard();
                SetCourtCount(playerboard1, 8);
                return playerboard1;
            }

            var playerboard2 = (Playerboard)JsonHelper.LoadFromFile(Constants.PlayerboardFilename, typeof(Playerboard));
            return playerboard2;
        }
    }
}