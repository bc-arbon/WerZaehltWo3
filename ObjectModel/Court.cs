namespace BCA.WerZaehltWo3.ObjectModel
{
    using System;
    using System.Xml;

    using BCA.WerZaehltWo3.Common;

    public class Court : BaseObject
    {
        public Court()
        {
            this.InternalClear();
        }

        public int Number { get; set; }

        public PlayerSet PlayersReady { get; } = new PlayerSet();

        public PlayerSet PlayersCount { get; } = new PlayerSet();

        public PlayerSet PlayersPlay { get; } = new PlayerSet();

        public override bool Equals(object obj)
        {
            return this.Equals((Court)obj);
        }

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

        public override int GetHashCode()
        {
            var result = 0;

            result ^= this.Number.GetHashCode();
            result ^= this.PlayersReady.GetHashCode();
            result ^= this.PlayersCount.GetHashCode();
            result ^= this.PlayersPlay.GetHashCode();

            return result;
        }

        public Court Clone()
        {
            var result = new Court();
            result.CopyFrom(this);
            return result;
        }

        public override void Clear()
        {
            this.InternalClear();
        }

        public void CopyFrom(Court other)
        {
            if (other == null) throw new ArgumentNullException("other");

            this.Number = other.Number;
            this.PlayersReady.CopyFrom(other.PlayersReady);
            this.PlayersCount.CopyFrom(other.PlayersCount);
            this.PlayersPlay.CopyFrom(other.PlayersPlay);
        }

        public void LoadXml(string xmlString)
        {
            if (string.IsNullOrEmpty(xmlString)) throw new ArgumentNullException("xmlString");

            var doc = new XmlDocument();
            doc.LoadXml(xmlString);
            this.Load(doc.SelectSingleNode("Court"));
        }

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

        private void InternalClear()
        {
            this.Number = -1;
            this.PlayersReady.Clear();
            this.PlayersCount.Clear();
            this.PlayersPlay.Clear();
        }
    }
}