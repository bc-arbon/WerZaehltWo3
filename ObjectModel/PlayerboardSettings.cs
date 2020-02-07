namespace BCA.WerZaehltWo3.ObjectModel
{
    public class PlayerboardSettings
    {
        public float FontSize { get; set; }

        public string FontName { get; set; }

        public PlayerboardSettings()
        {
            this.InternalClear();
        }

        private void InternalClear()
        {
            this.FontSize = 18;

            this.FontName = "Microsoft Sans Serif";
        }
    }
}
