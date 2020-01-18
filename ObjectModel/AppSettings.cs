namespace BCA.WerZaehltWo3.ObjectModel
{
    using BCA.WerZaehltWo3.Common;
    using System;
    using System.Drawing;
    using System.Xml;

    public class AppSettings : BaseObject
    {
        public AppSettings()
        {
            this.InternalClear();
        }

        public Size WindowSize { get; set; }

        public override bool Equals(object obj)
        {
            return this.Equals((AppSettings)obj);
        }

        public bool Equals(AppSettings other)
        {
            if (other == null)
            {
                return false;
            }

            if (this.WindowSize != other.WindowSize)
            {
                return false;
            }
            
            return true;
        }

        public override int GetHashCode()
        {
            var result = 0;

            result ^= this.WindowSize.GetHashCode();

            return result;
        }
        
        public override void Clear()
        {
            this.InternalClear();
        }
        
        public override void Load(XmlNode node)
        {
            if (node == null) throw new ArgumentNullException("node");

            this.InternalClear();

            var windowSizeNode = node.SelectSingleNode("WindowSize");
            if (windowSizeNode != null)
            {
                var width = XmlHelper.LoadAttribute(windowSizeNode, "width", this.WindowSize.Width);
                var height = XmlHelper.LoadAttribute(windowSizeNode, "height", this.WindowSize.Height);
                this.WindowSize = new Size(width, height);
            }
        }

        public override string Save()
        {
            var result = "<AppSettings>";

            result += "<WindowSize ";
            result += XmlHelper.SaveAttribute("width", this.WindowSize.Width) + " ";
            result += XmlHelper.SaveAttribute("height", this.WindowSize.Height) + " ";
            result += " />";

            result += "</AppSettings>";
            return result;
        }

        private void InternalClear()
        {
            this.WindowSize = new Size(651, 604);
        }
    }
}