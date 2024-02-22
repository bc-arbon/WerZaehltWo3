namespace BCA.WerZaehltWo3.Shared
{
    public enum Functions
    {
        GetPlayers = 0
    }

    public enum EventType
    {
        Single,
        Double,
        Mixed
    }

    public enum Gender
    {
        Male,
        Female,
        Boys,
        Girls,
        Unknown
    }

    public enum DrawType
    {
        KoSystem = 1,
        Groupsystem = 2,
        FullGroupsystem = 4,
        SwissLadder = 17,
        DoubleEliminiation = 18,
        Unknown = -1
    }

    public enum TsDataType
    {
        Play,
        Counting,
        Ready
    }
}
