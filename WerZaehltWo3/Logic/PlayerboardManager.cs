namespace BCA.WerZaehltWo3.Logic
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Xml;

    using BCA.WerZaehltWo3.ObjectModel;

    public class PlayerboardManager
    {
        public Playerboard Playerboard { get; } = new Playerboard();

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
            var xmlString = this.Playerboard.Save();

            var doc = new XmlDocument();
            doc.LoadXml(xmlString);
            doc.Save("Playerboard.xml");
        }

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
                this.Playerboard.Load(node);
            }
        }
    }
}