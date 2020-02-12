﻿using System.Text;

namespace BCA.WerZaehltWo3.ObjectModel.TournamentSoftware
{
    public class Team
    {
        public int Id { get; set; }
        public TsPlayer Player1 { get; set; }

        public TsPlayer Player2 { get; set; }
                
        public string ToStringShort()
        {
            var sb = new StringBuilder();
            sb.Append(this.Player1.FirstName).Append(" ").Append(this.Player1.LastName).Append("");
            if (this.Player2 != null)
            {
                sb.Append(" / ");
                sb.Append(this.Player2.FirstName).Append(" ").Append(this.Player2.LastName).Append("");
            }            
            return sb.ToString();
        }
    }
}
