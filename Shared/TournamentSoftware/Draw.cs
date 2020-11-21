using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.WerZaehltWo3.Shared.TournamentSoftware
{
    public class Draw
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Event Event { get; set; }
        public int Size { get; set; }
        public List<Match> Matches { get; set; }

        //public List<Match> wonMatchesByTeamX(Team t)
        //{
        //    return this.Matches.Any((m)->t.equals(m.Winner()));
        //}

        //public abstract Boolean isValid();
        
        //public Set<Team> getAllTeams()
        //{
        //    return this.getMatches().stream()
        //            .flatMap(match->Arrays.asList(match.getTeam1(), match.getTeam2()).stream())
        //            .collect(Collectors.toSet());
        //}
        
        //public Team teamThatWonConfrontation(final Team t1, final Team t2)
        //{
        //    final Match match = this.getMatches().stream()
        //            .filter(m->m.isPlayedByTeams(t1, t2))
        //            .findAny().orElseThrow(()-> new IllegalArgumentException(String.format("No match was played between %s and %s in poule %s", t1.toStringShort(), t2.toStringShort(), this.getName())));
        
        //    return match.getWinner();
        //}
    }
}
