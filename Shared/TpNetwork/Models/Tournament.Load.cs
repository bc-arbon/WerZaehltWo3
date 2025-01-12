using BCA.WerZaehltWo3.Shared.TPNetwork.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace BCA.WerZaehltWo3.Shared.TPNetwork.Models
{
	public partial class Tournament
	{
		public async static Task<Tournament> LoadFromTP(TPFile file)
		{
			List<TournamentInformation> tournamentInformation = await file.LoadTournamentInformation();
			List<LocationData> locations = await file.LoadLocations();
			List<Court> courts = (await file.LoadCourts()).Select(cd => Court.Parse(cd, locations)).ToList();

			List<ClubData> clubs = await file.LoadClubs();
			List<Player> players = (await file.LoadPlayers()).Select(pd => Player.Parse(pd, clubs)).ToList();
			List<Entry> entries = (await file.LoadEntries()).Select(ed => Entry.Parse(ed, players)).ToList();
			List<PlayerMatchData> playerMatchData = await file.LoadPlayerMatches();

			List<DrawData> rawDraws = await file.LoadDraws();
			List<Link> links = (await file.LoadLinks()).Select(link => Link.Parse(link, rawDraws)).ToList();
			List<Draw> draws = rawDraws.Select(draw => Draw.Parse(draw, playerMatchData, entries, links)).ToList();


			List<Event> events = (await file.LoadEvents()).Select(ev => Event.Parse(ev, draws, tournamentInformation)).ToList();

			Tournament tournament = new Tournament()
			{
				TournamentInformation = tournamentInformation,
				Locations = locations,
				Courts = courts,
				Entries = entries,
				Events = events
			};

			return tournament;
		}

		public static Tournament LoadFromXML(XmlReader reader)
		{
			List<Event> events = new List<Event>();

			while (reader.ReadToFollowing("EVENT"))
			{
				events.Add(Event.Parse(reader.ReadSubtree()));
			}

			Tournament tournament = new Tournament()
			{
				Events = events
			};

			return tournament;
		}
	}
}