namespace BCA.WerZaehltWo3.Shared.ObjectModel
{
    using System;
    using System.Xml;

    using BCA.WerZaehltWo3.Shared;

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

            return this.PlayersPlay.Equals(other.PlayersPlay);
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

        private void InternalClear()
        {
            this.Number = -1;
            this.PlayersReady.Clear();
            this.PlayersCount.Clear();
            this.PlayersPlay.Clear();
        }
    }
}