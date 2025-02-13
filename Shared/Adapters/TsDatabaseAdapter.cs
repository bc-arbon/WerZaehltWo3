﻿using BCA.WerZaehltWo3.Shared.TournamentSoftware;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace BCA.WerZaehltWo3.Shared.Adapters
{
    public class TsDatabaseAdapter
    {
        private OleDbConnection connection;
        private readonly string tsConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ts.tp;Jet OLEDB:Database Password=d4R2GY76w2qzZ;";

        private readonly List<KeyValuePair<int, Team>> teamById = new List<KeyValuePair<int, Team>>();
        private readonly List<KeyValuePair<int, Draw>> drawById = new List<KeyValuePair<int, Draw>>();
        private readonly List<KeyValuePair<int, Event>> eventById = new List<KeyValuePair<int, Event>>();

        public void Connect(string databaseFilepath)
        {
            //if (databaseFilepath != Path.Combine(Application.StartupPath, "ts.tp"))
            //{
            //    File.Copy(databaseFilepath, Path.Combine(Application.StartupPath, "ts.tp"), true);
            //}

            var conString = this.tsConnectionString.Replace("|DataDirectory|\\ts.tp", databaseFilepath);

            this.connection = new OleDbConnection(conString);
            this.connection.Open();
        }

        public void Close()
        {
            if (this.connection != null && this.connection.State == ConnectionState.Open)
            {
                this.connection.Close();
            }
        }

        public List<Match> GetMatches()
        {
            if (this.teamById.Count == 0)
            {
                this.FillTeams();
            }

            if (this.drawById.Count == 0)
            {
                this.FillDraws();
            }

            var result = new List<Match>();
            var query = "SELECT id, van1, van2, team1set1, team2set1, team1set2, team2set2, team1set3, team2set3, matchnr, roundnr, draw, winner, court, plandate, matchorder "
                    + "FROM PlayerMatch thematch "
                    + "WHERE reversehomeaway = FALSE AND roundnr >= 0 AND plandate > #2000-01-01 00:00:00# "
                    + "ORDER BY plandate, court";

            try
            {
                var reader = this.ExecuteSql(query);
                while (reader.Read())
                {
                    var draw = Convert.ToInt32(reader["draw"]);
                    var van1 = Convert.ToInt32(reader["van1"]);
                    var van2 = Convert.ToInt32(reader["van2"]);
                    var entry1 = this.GetEntryFromPlaning(van1, draw);
                    var entry2 = this.GetEntryFromPlaning(van2, draw);

                    var id = reader["id"].ToString();

                    var match = new Match();

                    match.Id = Convert.ToInt64(id);
                    match.Team1 = this.teamById.Find(x => x.Key == entry1).Value;
                    match.Team2 = this.teamById.Find(x => x.Key == entry2).Value;
                    match.Set1 = this.BuildSet(reader, 3, 4);
                    match.Set2 = this.BuildSet(reader, 5, 6);
                    match.Set3 = this.BuildSet(reader, 7, 8);
                    match.Winner = this.teamById.Find(x => x.Key == Convert.ToInt32(reader["winner"])).Value;
                    match.Draw = this.drawById.Find(x => x.Key == draw).Value;
                    match.Matchnr = reader.GetInt32(9);
                    match.Roundnr = reader.GetInt32(10);
                    var blubb = reader.GetValue(13);
                    if (!(blubb is DBNull))
                    {
                        match.Court = reader.GetInt32(13);
                    }

                    match.PlanDate = reader.GetDateTime(14);
                    match.Order = reader.GetInt32(15);
                    match.OrderSorting = match.PlanDate.ToString() + " " + match.Order;

                    // Check if match already added
                    try
                    {
                        if (match.Team1 != null && match.Team2 != null)
                        {
                            var bla = result.Find(x => x.Draw.Id == match.Draw.Id && x.Team1.Id == match.Team2.Id && x.Team2.Id == match.Team1.Id);
                            result.Add(match);
                        }
                    }
                    catch (Exception)
                    {
                        // Maybe the a draw was added or something. Reload draws and teams and try again next time.
                        this.FillDraws();
                        this.FillTeams();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong: " + e);
            }

            return result;
        }

        public List<Match> GetCurrentMatches()
        {
            var result = new List<Match>();
            var query = "SELECT name, playermatch FROM Court ORDER BY name";

            try
            {
                var reader = this.ExecuteSql(query);
                var matches = this.GetMatches();
                while (reader.Read())
                {
                    var court = Convert.ToInt32(reader["name"]);
                    var matchId = reader["playermatch"];
                    if (!(matchId is DBNull))
                    {
                        var match = matches.Find(x => x.Id == Convert.ToInt64(matchId));
                        if (match != null)
                        {
                            result.Add(match);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong: " + e);
            }

            return result;
        }

        public List<Match> GetPlannedMatches()
        {
            var result = new List<Match>();

            var currentMatches = this.GetCurrentMatches();
            var matches = this.GetMatches();
            foreach (var match in matches)
            {
                // Skip if no court present
                if (match.Court == 0)
                {
                    continue;
                }

                // Skip if order is zero
                if (match.Order == 0)
                {
                    continue;
                }

                // Skip if a result was entered
                if (match.Set1 != null)
                {
                    continue;
                }

                // Check if this match is the same but with reversed teams (Schoch matches)
                var schochMatchInReverse = currentMatches.Find(x => x.Draw.Id == match.Draw.Id && x.Team1.Id == match.Team2.Id && x.Team2.Id == match.Team1.Id);
                if (schochMatchInReverse != null)
                {
                    continue;
                }

                var schochMatchInReverse2 = result.Find(x => x.Draw.Id == match.Draw.Id && x.Team1.Id == match.Team2.Id && x.Team2.Id == match.Team1.Id);
                if (schochMatchInReverse2 != null)
                {
                    continue;
                }

                var koMatchInReverse = result.Find(x => x.Draw.Id == match.Draw.Id && x.Team1.Id == match.Team1.Id && x.Team2.Id == match.Team2.Id);
                if (koMatchInReverse != null)
                {
                    continue;
                }

                // Check if match is currently on a court
                var actualPlayingMatch = currentMatches.Find(x => x.Id == match.Id);
                if (actualPlayingMatch != null)
                {
                    continue;
                }

                result.Add(match);
            }

            return result;
        }

        private void FillTeams()
        {
            var reader = this.ExecuteSql("SELECT DISTINCT player1.name, player1.firstname, player1.memberid, "
                    + "player2.name, player2.firstname, player2.memberid, entry.id, club1.name, club2.name "
                    + "FROM (((((Draw INNER JOIN PlayerMatch ON Draw.id = PlayerMatch.draw) "
                    + "INNER JOIN Entry ON PlayerMatch.entry = Entry.id) "
                    + "INNER JOIN Player AS player1 ON Entry.player1 = player1.id) "
                    + "LEFT JOIN Player AS player2 ON Entry.player2 = player2.id) "
                    + "LEFT JOIN Club AS club1 ON club1.id = player1.club) "
                    + "LEFT JOIN Club AS club2 ON club2.id = player2.club ;");
            try
            {
                this.ConvertTeams(reader);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong: " + e);
            }
        }

        private int GetEntryFromPlaning(int planning, int draw)
        {
            var query1 = "SELECT entry FROM PlayerMatch WHERE planning = @planning AND draw = @draw";
            var com = new OleDbCommand(query1, this.connection);
            com.Parameters.AddWithValue("planning", planning);
            com.Parameters.AddWithValue("draw", draw);

            var result = Convert.ToInt32(com.ExecuteScalar());
            return result;
        }

        private void ConvertTeams(OleDbDataReader reader)
        {
            if (reader == null)
            {
                return;
            }

            while (reader.Read())
            {
                var currentTeam = new Team();
                var teamid = reader.GetInt32(6);
                currentTeam.Id = teamid;

                var player1 = new TsPlayer
                {
                    LastName = reader["player1.name"].ToString(),
                    FirstName = reader["player1.firstname"].ToString(),
                    MemberId = reader["player1.memberid"].ToString(),
                    ClubName = reader["club1.name"].ToString()
                };

                TsPlayer player2 = null;
                var name2 = reader["player2.name"].ToString();
                if (!string.IsNullOrEmpty(name2))
                {
                    player2 = new TsPlayer
                    {
                        LastName = reader["player2.name"].ToString(),
                        FirstName = reader["player2.firstname"].ToString(),
                        MemberId = reader["player2.memberid"].ToString(),
                        ClubName = reader["club2.name"].ToString()

                    };
                }

                currentTeam.Player1 = player1;
                currentTeam.Player2 = player2;

                this.teamById.Add(new KeyValuePair<int, Team>(teamid, currentTeam));
            }
        }

        private string BuildSet(OleDbDataReader reader, int team1Column, int team2Column)
        {
            var homePoints = reader.GetInt32(team1Column);
            var awayPoints = reader.GetInt32(team2Column);
            string result = null;
            if (homePoints > 0 || awayPoints > 0)
            {
                result = homePoints + "-" + awayPoints;
            }

            return result;
        }

        private void FillDraws()
        {
            if (this.eventById.Count == 0)
            {
                this.FillEvents();
            }

            var reader = this.ExecuteSql("SELECT id, name, event, drawtype, drawsize from Draw;");
            try
            {
                while (reader.Read())
                {
                    //var draw = toDraw(reader.getInt("drawtype"));
                    var draw = new Draw
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Name = reader["name"].ToString(),
                        Event = this.eventById.Find(x => x.Key == Convert.ToInt32(reader["event"])).Value,
                        Size = Convert.ToInt32(reader["drawsize"]),
                        Type = this.GetDrawType(Convert.ToInt32(reader["drawtype"])),
                    };

                    draw.TypeName = this.GetDrawTypeName(draw.Type);

                    this.drawById.Add(new KeyValuePair<int, Draw>(draw.Id, draw));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong: " + e);
            }
        }

        private void FillEvents()
        {
            var reader = this.ExecuteSql("SELECT id, name, gender, eventtype from Event;");
            try
            {
                while (reader.Read())
                {
                    var evnt = new Event
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Name = reader["name"].ToString(),
                        Gender = this.EventToGender(Convert.ToInt32(reader["gender"])),
                        EventType = this.GetEventType(Convert.ToInt32(reader["eventtype"]))

                    };
                    this.eventById.Add(new KeyValuePair<int, Event>(evnt.Id, evnt));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong: " + e);
            }
        }

        private EventType GetEventType(int eventTypeId)
        {
            switch (eventTypeId)
            {
                case 1:
                    return EventType.Singles;
                case 2:
                    return EventType.Doubles;
                case 3:
                    return EventType.Mixed;
                default:
                    throw new ArgumentException("Unknown eventtype " + eventTypeId);
            }
        }

        private Gender EventToGender(int gender)
        {
            switch (gender)
            {
                case 1:
                    return Gender.Men;
                case 2:
                    return Gender.Women;
                case 4:
                    return Gender.Boys;
                case 5:
                    return Gender.Girls;
                default:
                    return Gender.Unknown;
            }
        }

        private DrawType GetDrawType(int id)
        {
            if (Enum.TryParse(id.ToString(), out DrawType drawType))
            {
                return drawType;
            }
            else
            {
                return DrawType.Unknown;
            }
        }

        private string GetDrawTypeName(DrawType drawType)
        {
            switch (drawType)
            {
                case DrawType.SwissLadder:
                    return "Schoch";
                case DrawType.FullGroupsystem:
                    return "Vollständiges Gruppensystem";
                case DrawType.Groupsystem:
                    return "Gruppensystem";
                case DrawType.DoubleEliminiation:
                    return "Double Eliminiation";
                case DrawType.KoSystem:
                    return "KO-System";
                default:
                    return string.Empty;
            }
        }

        private OleDbDataReader ExecuteSql(string sql)
        {
            try
            {
                var com = new OleDbCommand(sql, this.connection);
                if (this.connection.State == ConnectionState.Closed)
                {
                    this.connection.Open();
                }

                return com.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong: " + e);
            }
            finally
            {
                //this.connection.Close();
            }

            return null;
        }

        // -----------------------------------------------------------------------
        public List<string> GetPlayers()
        {
            try
            {
                var reader = this.ExecuteSql("SELECT firstname, name FROM Player");

                if (reader != null)
                {
                    var players = new List<string>();
                    while (reader.Read())
                    {
                        players.Add(reader["firstname"] + " " + reader["name"]);
                    }

                    return players;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return new List<string>();
        }

        //public List<Event> GetEvents()
        //{
        //    try
        //    {
        //        var com = new OleDbCommand("SELECT id, name FROM Event", this.connection);
        //        var reader = com.ExecuteReader();

        //        if (reader != null)
        //        {
        //            var events = new List<Event>();
        //            while (reader.Read())
        //            {
        //                var ev = new Event
        //                {
        //                    Id = Convert.ToInt32(reader["id"]),
        //                    Name = reader["name"].ToString()
        //                };
        //                events.Add(ev);
        //            }

        //            return events;
        //        }
        //    }
        //    catch
        //    {
        //    }

        //    return new List<Event>();
        //}

        //public List<Entry> GetEntries(int eventId)
        //{
        //    try
        //    {
        //        // Get players first
        //        var players = new List<Player>();
        //        var com1 = new OleDbCommand("SELECT id, name, firstname FROM Player", this.connection);
        //        var reader1 = com1.ExecuteReader();
        //        if (reader1 != null)
        //        {
        //            while (reader1.Read())
        //            {
        //                var player = new Player
        //                {
        //                    Id = reader1["id"].ToString(),
        //                    Name = reader1["firstname"] + " " + reader1["name"]
        //                };
        //                players.Add(player);
        //            }
        //        }

        //        // Get entries
        //        var entries = new List<Entry>();
        //        var com2 = new OleDbCommand("SELECT id, player1, player2 FROM Entry WHERE event = @eventid", this.connection);
        //        com2.Parameters.AddWithValue("eventId", eventId);
        //        var reader2 = com2.ExecuteReader();
        //        if (reader2 != null)
        //        {
        //            while (reader2.Read())
        //            {
        //                var entry = new Entry
        //                {
        //                    Id = Convert.ToInt32(reader2["id"]),
        //                    Player1Id = Convert.ToInt32(reader2["player1"]),
        //                    Player2Id = Convert.ToInt32(reader2["player2"]),
        //                    EventId = eventId
        //                };
        //                entry.Player1 = this.GetPlayerName(players, entry.Player1Id);
        //                entry.Player2 = this.GetPlayerName(players, entry.Player2Id);
        //                entries.Add(entry);
        //            }
        //        }

        //        // TODO get planning id from PlayerMatch table
        //        var com3 = new OleDbCommand("SELECT planning, entry FROM PlayerMatch WHERE event = @eventid", this.connection);
        //        com3.Parameters.AddWithValue("eventId", eventId);
        //        var reader3 = com3.ExecuteReader();
        //        if (reader3 != null)
        //        {
        //            while (reader3.Read())
        //            {
        //                var entryId = reader3["entry"];
        //                if (!(entryId is DBNull))
        //                {
        //                    var planningId = Convert.ToInt32(reader3["planning"]);
        //                    foreach (var entry in entries)
        //                    {
        //                        if (entry.Id == Convert.ToInt32(entryId))
        //                        {
        //                            entry.PlanningId = planningId;
        //                            break;
        //                        }
        //                    }
        //                }
        //            }
        //        }

        //        return entries;
        //    }
        //    catch
        //    {
        //    }

        //    return new List<Entry>();
        //}

        //public List<PlayerMatch> GetCurrentMatches(List<Entry> entries)
        //{
        //    try
        //    {
        //        var com = new OleDbCommand("SELECT event, court, van1, van2, starttime FROM PlayerMatch", this.connection);
        //        var reader = com.ExecuteReader();

        //        if (reader != null)
        //        {
        //            var matches = new List<PlayerMatch>();
        //            while (reader.Read())
        //            {
        //                var entryId = reader["starttime"];
        //                if (!(entryId is DBNull))
        //                {
        //                    var startdate = Convert.ToDateTime(entryId);
        //                    if (startdate > new DateTime(1899, 12, 30))
        //                    {
        //                        var evnt = Convert.ToInt32(reader["event"]);
        //                        var match = new PlayerMatch
        //                        {
        //                            Event = evnt,
        //                            Court = Convert.ToInt32(reader["court"]),
        //                            Player1 = this.GetPlayerName(entries, Convert.ToInt32(reader["van1"]), evnt),
        //                            Player2 = this.GetPlayerName(entries, Convert.ToInt32(reader["van2"]), evnt),
        //                            StartTime = reader["starttime"].ToString()
        //                        };
        //                        matches.Add(match);
        //                    }
        //                }
        //            }

        //            return matches;
        //        }
        //    }
        //    catch
        //    {
        //    }

        //    return new List<PlayerMatch>();
        //}

        //private string GetPlayerName(List<Player> players, int id)
        //{
        //    foreach (var player in players)
        //    {
        //        if (player.Id == id.ToString())
        //        {
        //            return player.Name;
        //        }
        //    }

        //    return string.Empty;
        //}

        //private string GetPlayerName(List<Entry> entries, int id, int eventId)
        //{
        //    foreach (var entry in entries)
        //    {
        //        if (entry.PlanningId == id && entry.EventId == eventId)
        //        {
        //            return entry.PlayerNameDoubles;
        //        }
        //    }

        //    return string.Empty;
        //}
    }
}