using System;

namespace BCA.WerZaehltWo3.Shared.ObjectModel
{
    public class Court : BaseObject
    {
        public Court()
        {
            this.InternalClear();
        }

        public int Number { get; set; }

        public string PlayerReady1 { get; set; }
        public string PlayerReady2 { get; set; }
        public string PlayerCount1 { get; set; }
        public string PlayerCount2 { get; set; }
        public string PlayerPlay1 { get; set; }
        public string PlayerPlay2 { get; set; }

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

            if (!string.Equals(this.PlayerReady1, other.PlayerReady1))
            {
                return false;
            }

            if (!string.Equals(this.PlayerReady2, other.PlayerReady2))
            {
                return false;
            }

            if (!string.Equals(this.PlayerCount1, other.PlayerCount1))
            {
                return false;
            }

            if (!string.Equals(this.PlayerCount2, other.PlayerCount2))
            {
                return false;
            }

            if (!string.Equals(this.PlayerPlay1, other.PlayerPlay1))
            {
                return false;
            }

            if (!string.Equals(this.PlayerPlay2, other.PlayerPlay2))
            {
                return false;
            }

            return true;
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
            this.PlayerReady1 = other.PlayerReady1;
            this.PlayerReady2 = other.PlayerReady2;
            this.PlayerCount1 = other.PlayerCount1;
            this.PlayerCount2 = other.PlayerCount2;
            this.PlayerPlay1 = other.PlayerPlay1;
            this.PlayerPlay2 = other.PlayerPlay2;
        }

        private void InternalClear()
        {
            this.Number = -1;
            this.PlayerReady1 = null;
            this.PlayerReady2 = null;
            this.PlayerCount1 = null;
            this.PlayerCount2 = null;
            this.PlayerPlay1 = null;
            this.PlayerPlay2 = null;
        }
    }
}