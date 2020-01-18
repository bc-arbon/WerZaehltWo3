namespace BCA.WerZaehltWo3.ObjectModel
{
    using System;
    using System.Xml;

    public class PlayerSet : BaseObject
    {
        public PlayerSet()
        {
            this.InternalClear();
        }

        public Player Player1 { get; set; }

        public Player Player2 { get; set; }

        public override bool Equals(object obj)
        {
            return this.Equals((PlayerSet)obj);
        }

        public bool Equals(PlayerSet other)
        {
            if (other == null)
            {
                return false;
            }

            if (this.Player1 == null)
            {
                if (other.Player1 != null)
                {
                    return false;
                }
            }
            else
            {
                if (!this.Player1.Equals(other.Player1))
                {
                    return false;
                }
            }

            if (this.Player2 == null)
            {
                if (other.Player2 != null)
                {
                    return false;
                }
            }
            else
            {
                if (!this.Player2.Equals(other.Player2))
                {
                    return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var result = 0;

            if (this.Player1 != null)
            {
                result = result ^ this.Player1.GetHashCode();
            }

            if (this.Player2 != null)
            {
                result = result ^ this.Player2.GetHashCode();
            }

            return result;
        }

        public PlayerSet Clone()
        {
            var result = new PlayerSet();
            result.CopyFrom(this);
            return result;
        }

        public override void Clear()
        {
            this.InternalClear();
        }

        public void CopyFrom(PlayerSet other)
        {
            if (other.Player1 != null)
            {
                this.Player1 = other.Player1.Clone();
            }

            if (other.Player2 != null)
            {
                this.Player2 = other.Player2.Clone();
            }
        }

        public override void Load(XmlNode node)
        {
            if (node == null) throw new ArgumentNullException("node");

            this.InternalClear();

            var player1Node = node.SelectSingleNode("Player1/Player");
            if (player1Node != null)
            {
                this.Player1 = new Player();
                this.Player1.Load(player1Node);
            }

            var player2Node = node.SelectSingleNode("Player2/Player");
            if (player2Node != null)
            {
                this.Player2 = new Player();
                this.Player2.Load(player2Node);
            }
        }

        public override string Save()
        {
            var result = "<PlayerSet>";

            if (this.Player1 != null)
            {
                result += "<Player1>";
                result += this.Player1.Save();
                result += "</Player1>";
            }

            if (this.Player2 != null)
            {
                result += "<Player2>";
                result += this.Player2.Save();
                result += "</Player2>";
            }

            result += "</PlayerSet>";
            return result;
        }

        private void InternalClear()
        {
            this.Player1 = null;
            this.Player2 = null;
        }
    }
}