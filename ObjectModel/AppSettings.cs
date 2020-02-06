namespace BCA.WerZaehltWo3.ObjectModel
{
    using BCA.WerZaehltWo3.Common;
    using System;
    using System.Drawing;
    using System.Xml;

    public class AppSettings : BaseObject
    {
        public AppSettings()
        {
            this.InternalClear();
        }

        public Size WindowSize { get; set; }
        
        public bool Equals(AppSettings other)
        {
            if (other == null)
            {
                return false;
            }

            if (this.WindowSize != other.WindowSize)
            {
                return false;
            }
            
            return true;
        }

        public override int GetHashCode()
        {
            var result = 0;

            result ^= this.WindowSize.GetHashCode();

            return result;
        }

        public override void Clear()
        {
            this.InternalClear();
        }
                
        private void InternalClear()
        {
            this.WindowSize = new Size(651, 604);
        }
    }
}