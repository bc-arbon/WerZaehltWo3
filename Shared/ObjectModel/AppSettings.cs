using System.Drawing;

namespace BCA.WerZaehltWo3.Shared.ObjectModel
{
    public class AppSettings : BaseObject
    {
        public AppSettings()
        {
            this.InternalClear();
        }

        public Size WindowSize { get; set; }
        public string TsMonitorDatabase { get; set; }
        public string RabbitServer { get; set; }
        public string RabbitUser { get; set; }
        public string RabbitPassword { get; set; }
        public string RabbitVhost { get; set; }
        public int TsMonitorInterval { get; set; }

        public bool Equals(AppSettings other)
        {
            if (other == null)
            {
                return false;
            }

            return this.WindowSize == other.WindowSize;
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