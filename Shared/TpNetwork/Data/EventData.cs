using BCA.WerZaehltWo3.Shared.TournamentSoftware;
using BCA.WerZaehltWo3.Shared.TPNetwork.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Xml;

namespace BCA.WerZaehltWo3.Shared.TPNetwork.Data
{
    public class EventData : TpDataObject
    {
        public enum EventTypes { Singles = 1, Doubles = 2 }
        public enum Genders { Unknown = 0, Men = 1, Women = 2, Mixed = 3, Boys = 4, Girls = 5 }

        public int ID { get; set; }
        public int TournamentInformationID { get; set; }
        public string Name { get; set; }
        public EventTypes EventType { get; set; } = EventTypes.Doubles;
        public Genders Gender { get; set; } = Genders.Unknown;

        public List<PlayerMatchData> PlayerMatches { get; set; }
        public List<EntryData> Entries { get; set; }
        public List<DrawData> Draws { get; set; }

        public EventData() { }

        public EventData(EventData cpy)
        {
            ID = cpy.ID;
            TournamentInformationID = cpy.TournamentInformationID;
            Name = cpy.Name;
            EventType = cpy.EventType;
            Gender = cpy.Gender;
        }

        public EventData(IDataReader reader)
        {
            ID = GetInt(reader, "id");
            Name = GetString(reader, "name");
            Gender = (Genders)GetInt(reader, "gender");
            EventType = (EventTypes)GetInt(reader, "eventtype");
            TournamentInformationID = GetInt(reader, "tournamentinformationid");
        }

        public EventData(XmlReader reader)
        {
            ID = GetInt(reader, "ID");
            Name = GetString(reader, "NAME");

            this.PlayerMatches = new List<PlayerMatchData>();
            if (reader.ReadToFollowing("MATCHES"))
            {
                using (var matchesReader = reader.ReadSubtree())
                {
                    while (matchesReader.Read())
                    {
                        if (matchesReader.Name.Equals("MATCH") && (matchesReader.NodeType == XmlNodeType.Element))
                        {
                            this.PlayerMatches.Add(new PlayerMatchData(matchesReader));
                        }
                    }
                }
            }
        }

        public EventData(XmlNode node)
        {
            ID = GetInt(node, "ID");
            Name = GetString(node, "NAME");

            var entriesNode = node.SelectSingleNode("ENTRIES");
            this.Entries = new List<EntryData>();
            foreach (XmlNode entryNode in entriesNode.ChildNodes)
            {
                this.Entries.Add(new EntryData(entryNode));
            }

            var drawsNode = node.SelectSingleNode("DRAWS");
            this.Draws = new List<DrawData>();
            foreach (XmlNode drawNode in drawsNode.SelectNodes("DRAW"))
            {
                this.Draws.Add(new DrawData(drawNode));
            }

            var matchesNode = drawsNode.SelectSingleNode("MATCH");
            this.PlayerMatches = new List<PlayerMatchData>();
            foreach (XmlNode matchNode in matchesNode.ChildNodes)
            {
                //this.PlayerMatches.Add(new PlayerMatchData(matchNode));
            }
        }
    }
}