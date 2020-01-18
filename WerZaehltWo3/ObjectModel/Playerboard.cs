using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.WerZaehltWo3.ObjectModel
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    /// <summary>
    /// Playerboard class
    /// </summary>
    public class Playerboard : BaseObject
    {
        /// <summary>
        /// The players
        /// </summary>
        private readonly List<Player> players = new List<Player>();

        /// <summary>
        /// The courts
        /// </summary>
        private readonly List<Court> courts = new List<Court>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Playerboard"/> class.
        /// </summary>
        public Playerboard()
        {
            this.InternalClear();
        }

        /// <summary>
        /// Gets the players.
        /// </summary>
        public List<Player> Players
        {
            get
            {
                return this.players;
            }
        }

        /// <summary>
        /// Gets the courts.
        /// </summary>
        public List<Court> Courts
        {
            get
            {
                return this.courts;
            }
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" /> is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            return this.Equals((Playerboard)obj);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" /> is equal to this instance.
        /// </summary>
        /// <param name="other">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
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

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            var result = 0;

            foreach (var player in this.Players)
            {
                result = result ^ player.GetHashCode();
            }

            foreach (var court in this.Courts)
            {
                result = result ^ court.GetHashCode();
            }

            return result;
        }

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>Cloned player</returns>
        public Playerboard Clone()
        {
            var result = new Playerboard();
            result.CopyFrom(this);
            return result;
        }

        /// <summary>
        /// Clears this instance.
        /// </summary>
        public override void Clear()
        {
            this.InternalClear();
        }

        /// <summary>
        /// Copies from.
        /// </summary>
        /// <param name="other">The other.</param>
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

        /// <summary>
        /// Loads this instance.
        /// </summary>
        /// <param name="node">The node.</param>
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

        /// <summary>
        /// Saves this instance.
        /// </summary>
        /// <returns> Xml string </returns>
        public override string Save()
        {
            var result = "<Playerboard>" + Environment.NewLine;

            result += "<Courts>" + Environment.NewLine;
            foreach (var court in this.Courts)
            {
                result += court.Save();
            }

            result += "</Courts>" + Environment.NewLine;
            result += "<Players>" + Environment.NewLine;
            foreach (var player in this.Players)
            {
                result += player.Save();
            }

            result += "</Players>" + Environment.NewLine  + "</Playerboard>";
            return result;
        }

        /// <summary>
        /// Internals the clear.
        /// </summary>
        private void InternalClear()
        {
            this.Players.Clear();
            this.Courts.Clear();
            this.Courts.Add(new Court { Number = 1 });
        }
    }
}
