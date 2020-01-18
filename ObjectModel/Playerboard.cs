namespace BCA.WerZaehltWo3.ObjectModel
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public class Playerboard : BaseObject
    {
        public Playerboard()
        {
            this.InternalClear();
        }

        public List<Player> Players { get; } = new List<Player>();

        public List<Court> Courts { get; } = new List<Court>();

        public override bool Equals(object obj)
        {
            return this.Equals((Playerboard)obj);
        }

        public bool Equals(Playerboard other)
        {
            if (other == null)
            {
                return false;
            }

            if (this.Players.Count != other.Players.Count)
            {
                return false;
            }

            for (var i = 0; i < this.Players.Count; i++)
            {
                if (!this.Players[i].Equals(other.Players[i]))
                {
                    return false;
                }
            }

            if (this.Courts.Count != other.Courts.Count)
            {
                return false;
            }

            for (var i = 0; i < this.Courts.Count; i++)
            {
                if (!this.Courts[i].Equals(other.Courts[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var result = 0;

            foreach (var player in this.Players)
            {
                result ^= player.GetHashCode();
            }

            foreach (var court in this.Courts)
            {
                result ^= court.GetHashCode();
            }

            return result;
        }

        public Playerboard Clone()
        {
            var result = new Playerboard();
            result.CopyFrom(this);
            return result;
        }

        public override void Clear()
        {
            this.InternalClear();
        }

        public void CopyFrom(Playerboard other)
        {
            this.InternalClear();

            foreach (var player in other.Players)
            {
                this.Players.Add(player.Clone());
            }

            this.Courts.Clear();
            foreach (var court in other.Courts)
            {
                this.Courts.Add(court.Clone());
            }
        }

        public override void Load(XmlNode node)
        {
            if (node == null) throw new ArgumentNullException("node");

            this.InternalClear();

            var courtNodes = node.SelectNodes("Courts/Court");
            if (courtNodes != null)
            {
                this.Courts.Clear();
                foreach (XmlNode courtNode in courtNodes)
                {
                    var court = new Court();
                    court.Load(courtNode);
                    this.Courts.Add(court);
                }
            }

            var playerNodes = node.SelectNodes("Players/Player");
            if (playerNodes != null)
            {
                foreach (XmlNode playerNode in playerNodes)
                {
                    var player = new Player();
                    player.Load(playerNode);
                    this.Players.Add(player);
                }
            }
        }

        public override string Save()
        {
            var result = "<Playerboard>";

            result += "<Courts>";
            foreach (var court in this.Courts)
            {
                result += court.Save();
            }

            result += "</Courts>";
            result += "<Players>";
            foreach (var player in this.Players)
            {
                result += player.Save();
            }

            result += "</Players></Playerboard>";
            return result;
        }

        private void InternalClear()
        {
            this.Players.Clear();
            this.Courts.Clear();
            this.Courts.Add(new Court { Number = 1 });
        }
    }
}