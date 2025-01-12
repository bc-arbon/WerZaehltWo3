namespace BCA.WerZaehltWo3.Shared
{
    public enum Functions
    {
        GetPlayers = 0
    }

    public enum EventType
    {
        Singles = 1,
        Doubles = 2,
        Mixed = 3
    }

    public enum Gender
    {
        Unknown = 0,
        Men = 1,
        Women = 2,
        Mixed = 3,
        Boys = 4,
        Girls = 5
    }

    public enum DrawType
    {
        KoSystem = 1,
        Groupsystem = 2,
        FullGroupsystem = 4,
        QualifierCups = 6,
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
