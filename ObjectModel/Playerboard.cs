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

        private void InternalClear()
        {
            this.Players.Clear();
            this.Courts.Clear();
        }
    }
}