namespace BCA.WerZaehltWo3.Eventing
{
    using System;

    using BCA.WerZaehltWo3.ObjectModel;

    /// <summary>
    /// CourtEventArgs class
    /// </summary>
    public class CourtEventArgs : EventArgs
    {
        /// <summary>
        /// The court
        /// </summary>
        private readonly Court court;

        /// <summary>
        /// Initializes a new instance of the <see cref="CourtEventArgs"/> class.
        /// </summary>
        /// <param name="court">The court.</param>
        public CourtEventArgs(Court court)
        {
            this.court = court;
        }

        /// <summary>
        /// Gets the court.
        /// </summary>
        public Court Court
        {
            get
            {
                return this.court;
            }
        }
    }
}