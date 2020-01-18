using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.WerZaehltWo3.ObjectModel
{
    using System.Xml;

    /// <summary>
    /// BaseObject class
    /// </summary>
    public class BaseObject
    {
        /// <summary>
        /// Loads this instance.
        /// </summary>
        /// <param name="node">The node.</param>
        public virtual void Load(XmlNode node)
        {
        }

        /// <summary>
        /// Saves this instance.
        /// </summary>
        /// <returns>Xml string</returns>
        public virtual string Save()
        {
            return string.Empty;
        }

        /// <summary>
        /// Clears this instance.
        /// </summary>
        public virtual void Clear()
        {
        }
    }
}
