// <copyright file="Player.cs" company="Danisoft">
// © 2016 Danisoft
// </copyright>

namespace BCA.WerZaehltWo3.ObjectModel
{
    using System;
    using System.Xml;

    using BCA.WerZaehltWo3.Common;

    /// <summary>
    /// Player class
    /// </summary>
    public class Player : BaseObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Player"/> class.
        /// </summary>
        public Player()
        {
            this.InternalClear();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Player" /> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public Player(string name) : this()
        {
            this.Name = name;
        }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the club.
        /// </summary>
        public string Club { get; set; }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" /> is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            return this.Equals((Player)obj);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" /> is equal to this instance.
        /// </summary>
        /// <param name="other">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public bool Equals(Player other)
        {
            if (other == null)
            {
                return false;
            }

            if (!string.Equals(this.Name, other.Name))
            {
                return false;
            }

            if (!string.Equals(this.Club, other.Club))
            {
                return false;
            }

            if (!string.Equals(this.Category, other.Category))
            {
                return false;
            }

            if (!string.Equals(this.Id, other.Id))
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

            if (this.Name != null)
            {
                result = result ^ this.Name.GetHashCode();
            }

            if (this.Club != null)
            {
                result = result ^ this.Club.GetHashCode();
            }

            if (this.Category != null)
            {
                result = result ^ this.Category.GetHashCode();
            }

            if (this.Id != null)
            {
                result = result ^ this.Id.GetHashCode();
            }

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
        /// Clones this instance.
        /// </summary>
        /// <returns>Cloned player</returns>
        public Player Clone()
        {
            var result = new Player();
            result.CopyFrom(this);
            return result;
        }

        /// <summary>
        /// Copies from.
        /// </summary>
        /// <param name="other">The other.</param>
        public void CopyFrom(Player other)
        {
            this.Name = other.Name;
            this.Club = other.Club;
            this.Category = other.Category;
            this.Id = other.Id;
        }

        /// <summary>
        /// Loads this instance.
        /// </summary>
        /// <param name="node">The node.</param>
        public override void Load(XmlNode node)
        {
            if (node == null) throw new ArgumentNullException("node");

            this.InternalClear();

            this.Id = XmlHelper.LoadAttribute(node, "id", this.Id);
            this.Name = XmlHelper.LoadAttribute(node, "name", this.Name);
            this.Club = XmlHelper.LoadAttribute(node, "club", this.Club);
            this.Category = XmlHelper.LoadAttribute(node, "category", this.Category);
        }

        /// <summary>
        /// Saves this instance.
        /// </summary>
        /// <returns> Xml string </returns>
        public override string Save()
        {
            var result = "<Player ";
            result += XmlHelper.SaveAttribute("id", this.Id) + " ";
            result += XmlHelper.SaveAttribute("name", this.Name) + " ";
            result += XmlHelper.SaveAttribute("category", this.Category) + " ";
            result += XmlHelper.SaveAttribute("club", this.Club) + " />";
            return result;
        }

        /// <summary>
        /// Internals the clear.
        /// </summary>
        private void InternalClear()
        {
            this.Id = null;
            this.Name = null;
            this.Club = null;
            this.Category = null;
        }
    }
}