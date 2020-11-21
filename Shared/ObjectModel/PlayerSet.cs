namespace BCA.WerZaehltWo3.Shared.ObjectModel
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
                result ^= this.Player1.GetHashCode();
            }

            if (this.Player2 != null)
            {
                result ^= this.Player2.GetHashCode();
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

        private void InternalClear()
        {
            this.Player1 = new Player();
            this.Player2 = new Player();
        }
    }
}