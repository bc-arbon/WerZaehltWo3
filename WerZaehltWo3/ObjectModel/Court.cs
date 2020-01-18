using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.WerZaehltWo3.ObjectModel
{
    using System;
    using System.Xml;

    using BCA.WerZaehltWo3.Common;

    /// <summary>
    /// Court class
    /// </summary>
    public class Court : BaseObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Court"/> class.
        /// </summary>
        public Court()
        {
            this.InternalClear();
        }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Gets the players ready.
        /// </summary>
        public PlayerSet PlayersReady { get; } = new PlayerSet();

        /// <summary>
        /// Gets the players count.
        /// </summary>
        public PlayerSet PlayersCount { get; } = new PlayerSet();

        /// <summary>
        /// Gets the players play.
        /// </summary>
        public PlayerSet PlayersPlay { get; } = new PlayerSet();

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" /> is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            return this.Equals((Court)obj);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" /> is equal to this instance.
        /// </summary>
        /// <param name="other">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public bool Equals(Court other)
        {
            if (other == null)
            {
                return false;
            }

            if (this.Number != other.Number)
            {
                return false;
            }

            if (!this.PlayersReady.Equals(other.PlayersReady))
            {
                return false;
            }

            if (!this.PlayersCount.Equals(other.PlayersCount))
            {
                return false;
            }

            if (!this.PlayersPlay.Equals(other.PlayersPlay))
            {
                return false;
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

            result ^= this.Number.GetHashCode();
            result ^= this.PlayersReady.GetHashCode();
            result ^= this.PlayersCount.GetHashCode();
            result ^= this.PlayersPlay.GetHashCode();

            return result;
        }

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>Cloned player</returns>
        public Court Clone()
        {
            var result = new Court();
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
        public void CopyFrom(Court other)
        {
            if (other == null) throw new ArgumentNullException("other");

            this.Number = other.Number;
            this.PlayersReady.CopyFrom(other.PlayersReady);
            this.PlayersCount.CopyFrom(other.PlayersCount);
            this.PlayersPlay.CopyFrom(other.PlayersPlay);
        }

        /// <summary>
        /// Loads the XML.
        /// </summary>
        /// <param name="xmlString">The XML string.</param>
        public void LoadXml(string xmlString)
        {
            if (string.IsNullOrEmpty(xmlString)) throw new ArgumentNullException("xmlString");

            var doc = new XmlDocument();
            doc.LoadXml(xmlString);
            this.Load(doc.SelectSingleNode("Court"));
        }

        /// <summary>
        /// Loads this instance.
        /// </summary>
        /// <param name="node">The node.</param>
        public override void Load(XmlNode node)
        {
            if (node == null) throw new ArgumentNullException("node");

            this.InternalClear();

            this.Number = XmlHelper.LoadAttribute(node, "number", this.Number);

            var readyNode = node.SelectSingleNode("PlayersReady/PlayerSet");
            if (readyNode != null)
            {
                this.PlayersReady.Load(readyNode);
            }

            var countNode = node.SelectSingleNode("PlayersCount/PlayerSet");
            if (countNode != null)
            {
                this.PlayersCount.Load(countNode);
            }

            var playNode = node.SelectSingleNode("PlayersPlay/PlayerSet");
            if (playNode != null)
            {
                this.PlayersPlay.Load(playNode);
            }
        }

        /// <summary>
        /// Saves this instance.
        /// </summary>
        /// <returns> Xml string </returns>
        public override string Save()
        {
            var result = "<Court ";
            result += XmlHelper.SaveAttribute("number", this.Number) + " >";
            result += "<PlayersReady>" + this.PlayersReady.Save() + "</PlayersReady>";
            result += "<PlayersCount>" + this.PlayersCount.Save() + "</PlayersCount>";
            result += "<PlayersPlay>" + this.PlayersPlay.Save() + "</PlayersPlay>";
            result += "</Court>";
            return result;
        }

        /// <summary>
        /// Internals the clear.
        /// </summary>
        private void InternalClear()
        {
            this.Number = -1;
            this.PlayersReady.Clear();
            this.PlayersCount.Clear();
            this.PlayersPlay.Clear();
        }
    }
}
