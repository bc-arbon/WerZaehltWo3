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

        public string RabbitServer { get; set; }
        public string RabbitUser { get; set; }
        public string RabbitPassword { get; set; }
        public string RabbitVhost { get; set; }

        private void InternalClear()
        {
            this.WindowSize = new Size(651, 604);
        }
    }
}