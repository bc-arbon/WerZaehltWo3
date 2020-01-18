namespace BCA.WerZaehltWo3.Logic
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Xml;

    using BCA.WerZaehltWo3.ObjectModel;

    /// <summary>
    /// PlayerboardManager class
    /// </summary>
    public class PlayerboardManager
    {
        /// <summary>
        /// The playerboard
        /// </summary>
        private readonly Playerboard playerboard = new Playerboard();

        /// <summary>
        /// Gets the playerboard.
        /// </summary>
        public Playerboard Playerboard
        {
            get
            {
                return this.playerboard;
            }
        }

        /// <summary>
        /// Clears this instance.
        /// </summary>
        public void Clear()
        {
            this.playerboard.Clear();
        }

        /// <summary>
        /// Gets the players.
        /// </summary>
        /// <returns>The player list</returns>
        public List<Player> GetPlayers()
        {
            return this.playerboard.Players;
        }

        /// <summary>
        /// Gets the player.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>The player</returns>
        public Player GetPlayer(string name)
        {
            var player = this.playerboard.Players.FirstOrDefault(pl => pl.Name == name);
            if (player == null)
            {
                return new Player { Name = name };
            }

            return player;
        }

        /// <summary>
        /// Sets the court count.
        /// </summary>
        /// <param name="newCount">The new count.</param>
        public void SetCourtCount(int newCount)
        {
            var currentCount = this.playerboard.Courts.Count;
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
                    newCourts.Add(this.playerboard.Courts[i].Clone());
                }
            }
            else
            {
                // The new count is higher, clone all existing courts and add some new ones
                newCourts.AddRange(this.playerboard.Courts.Select(court => court.Clone()));

                for (var i = currentCount + 1; i <= newCount; i++)
                {
                    newCourts.Add(new Court { Number = i });
                }
            }

            this.playerboard.Courts.Clear();
            this.playerboard.Courts.AddRange(newCourts);
        }

        /// <summary>
        /// Saves this instance.
        /// </summary>
        public void Save()
        {
            var xmlString = this.playerboard.Save();

            // Quick and dirty
            File.WriteAllText("Playerboard.xml", xmlString);
        }

        /// <summary>
        /// Loads this instance.
        /// </summary>
        public void Load()
        {
            if (!File.Exists("Playerboard.xml"))
            {
                // Do nothing, when the file is not present
                return;
            }

            var doc = new XmlDocument();
            doc.Load("Playerboard.xml");
            var node = doc.SelectSingleNode("Playerboard");
            if (node != null)
            {
                this.playerboard.Load(node);
            }
        }
    }
}