namespace BCA.WerZaehltWo3.ObjectModel
{
    using System;
    using System.Xml;

    /// <summary>
    /// PlayerSet class
    /// </summary>
    public class PlayerSet : BaseObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerSet"/> class.
        /// </summary>
        public PlayerSet()
        {
            this.InternalClear();
        }

        /// <summary>
        /// Gets or sets the player1.
        /// </summary>
        public Player Player1 { get; set; }

        /// <summary>
        /// Gets or sets the player2.
        /// </summary>
        public Player Player2 { get; set; }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" /> is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            return this.Equals((PlayerSet)obj);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" /> is equal to this instance.
        /// </summary>
        /// <param name="other">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
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

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
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

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>Cloned player</returns>
        public PlayerSet Clone()
        {
            var result = new PlayerSet();
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

        /// <summary>
        /// Loads this instance.
        /// </summary>
        /// <param name="node">The node.</param>
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

        /// <summary>
        /// Saves this instance.
        /// </summary>
        /// <returns> Xml string </returns>
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

        /// <summary>
        /// Internals the clear.
        /// </summary>
        private void InternalClear()
        {
            this.Player1 = null;
            this.Player2 = null;
        }
    }
}