namespace LBPUnion.LighthouseRichPresence;

public enum RoomState {
    /// <summary>
    ///     The room isn't doing anything in particular.
    /// </summary>
    Idle = 0,

    /// <summary>
    ///     The room is hosting a room on a slot for others to join.
    /// </summary>
    PlayingLevel = 1,

    /// <summary>
    ///     ???
    /// </summary>
    Unknown = 2,

    /// <summary>
    ///     The room is looking for other rooms to join.
    /// </summary>
    DivingIn = 3,

    /// <summary>
    ///     The room is waiting for players to join their room.
    /// </summary>
    DivingInWaiting = 4,
}