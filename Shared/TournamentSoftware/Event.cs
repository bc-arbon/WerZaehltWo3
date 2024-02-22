namespace BCA.WerZaehltWo3.Shared.TournamentSoftware
{
    public class Event
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public EventType EventType { get; set; }

        public Gender Gender { get; set; }

        public override string ToString()
        {
            return this.Name + " (" + this.EventType + " " + this.Gender + ")";
        }
    }
}
