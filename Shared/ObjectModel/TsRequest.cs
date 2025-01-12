namespace BCA.WerZaehltWo3.Shared.ObjectModel
{
    public class TsRequest
    {
        public TsRequest(Functions function, string args)
        {
            this.Function = function;
            this.Args = args;
        }

        public Functions Function { get; set; }

        public string Args { get; set; }

        public override string ToString()
        {
            return (int)this.Function + ";" + this.Args + ";";
        }
    }
}