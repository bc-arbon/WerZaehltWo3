using BCA.WerZaehltWo3.Shared.TPNetwork.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BCA.WerZaehltWo3.Shared.TPNetwork.Models
{
    public class Link : LinkData
    {
        public DrawData Source { get; set; }
        protected Link(LinkData raw) : base(raw) { }
        public int GetSourcePlacement()
        {
            if (Source.DrawType == DrawData.DrawTypes.RoundRobin)
            {
                return SourcePosition;
            }
            return SourcePosition < 0 ? 2 : 1;
        }

        public int GetSourceClassIndex()
        {
            if (Source.DrawType == DrawData.DrawTypes.RoundRobin)
            {
                return 0;
            }

            return Math.Max(Math.Abs(SourcePosition) - 1, 0);
        }

        public static Link Parse(LinkData raw, IEnumerable<DrawData> draws)
        {
            return new Link(raw)
            {
                Source = draws.First(draw => draw.Id == raw.SourceDrawID)
            };
        }
    }
}
