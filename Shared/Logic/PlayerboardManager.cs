namespace BCA.WerZaehltWo3.Shared.Logic
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using BCA.WerZaehltWo3.Shared.Helpers;
    using BCA.WerZaehltWo3.Shared;
    using BCA.WerZaehltWo3.Shared.ObjectModel;

    public class PlayerboardManager
    {
        public Playerboard Playerboard { get; private set; }

        public void Clear()
        {
            this.Playerboard.Clear();
        }

        public List<Player> GetPlayers()
        {
            return this.Playerboard.Players;
        }

        public Player GetPlayer(string name)
        {
            var player = this.Playerboard.Players.FirstOrDefault(pl => pl.Name == name);
            return player ?? new Player { Name = name };
        }

        public void SetCourtCount(int newCount)
        {
            var currentCount = this.Playerboard.Courts.Count;
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
                    newCourts.Add(this.Playerboard.Courts[i].Clone());
                }
            }
            else
            {
                // The new count is higher, clone all existing courts and add some new ones
                newCourts.AddRange(this.Playerboard.Courts.Select(court => court.Clone()));

                for (var i = currentCount + 1; i <= newCount; i++)
                {
                    newCourts.Add(new Court { Number = i });
                }
            }

            this.Playerboard.Courts.Clear();
            this.Playerboard.Courts.AddRange(newCourts);
        }

        public void Save()
        {
            JsonHelper.SaveToFile(this.Playerboard, Constants.PlayerboardFilename);
        }

        public void Load()
        {
            if (!File.Exists(Constants.PlayerboardFilename))
            {
                // Create 8 courts as default
                this.Playerboard = new Playerboard();
                this.SetCourtCount(8);
                return;
            }

            this.Playerboard = (Playerboard)JsonHelper.LoadFromFile(Constants.PlayerboardFilename, typeof(Playerboard));
        }
    }
}