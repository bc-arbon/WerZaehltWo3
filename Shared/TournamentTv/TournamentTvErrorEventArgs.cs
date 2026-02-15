using System;

namespace BCA.WerZaehltWo3.Shared.TournamentTv
{
    public class TournamentTvErrorEventArgs
    {
        public string Message { get; set; }
        public Exception Exception { get; set; }

        public TournamentTvErrorEventArgs(string message, Exception exception)
        {
            this.Message = message;
            this.Exception = exception;
        }
    }
}
