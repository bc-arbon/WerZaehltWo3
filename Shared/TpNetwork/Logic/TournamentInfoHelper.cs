using BCA.WerZaehltWo3.Shared.TpNetwork.Data;
using System.Collections.Generic;
using System.Linq;

namespace BCA.WerZaehltWo3.Shared.TpNetwork.Logic
{
    public static class TournamentInfoHelper
    {
        public static List<Player> GetPlayerByEntryId(VisualXmlResponse response, int entryId)
        {
            var result = new List<Player>();
            var playerId1 = response.Entries.FirstOrDefault(p => p.ID == entryId).Player1ID;
            var playerId2 = response.Entries.FirstOrDefault(p => p.ID == entryId).Player2ID;
            result.Add(response.Players.FirstOrDefault(p => p.ID == playerId1));
            result.Add(response.Players.FirstOrDefault(p => p.ID == playerId2));

            return result;
        }

        public static Club GetClubById(VisualXmlResponse response, int clubId)
        {
            return response.Clubs.FirstOrDefault(c => c.ID == clubId);
        }

        public static int GetBHZFromPlanningId(VisualXmlResponse response, int drawId, int planningId)
        {
            var bhz = 0;

            // This shit currently doesn't work

            // Get all player matches
            var matches = response.Matches.Where(m => m.DrawID == drawId && m.PlanningID > planningId && m.PlanningID < planningId + 10).ToList();

            // Get all opponent planning ids
            foreach (var match in matches)
            {
                var value = response.Matches.FirstOrDefault(m => m.DrawID == drawId && m.PlanningID == match.From2 && match.IsMatch == false)?.MatchesWon;
                bhz += value ?? 0;
            }

            return bhz;
        }
    }
}