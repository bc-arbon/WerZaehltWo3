namespace BCA.WerZaehltWo3.Shared.TournamentSoftware
{
    public class TsPlayer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MemberId { get; set; }

        public string ClubName { get; set; }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " (" + this.ClubName + ")";
        }
    }
}
