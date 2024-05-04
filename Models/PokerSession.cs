namespace AgilePokerBlazor.Models;

public class Participant
{
    public required string Name { get; set; }
    public required string ConnectionId { get; set; }
    public required string SessionId { get; set; }
    public string? Vote { get; set; }
}

public class PokerSession
{
    public required string SessionId { get; set; }
    public required Dictionary<string, Participant> Participants { get; set; }
    public required string SessionName { get; set; }
    public required string SessionOwner { get; set; }
    public required string SessionOwnerName { get; set; }


}

public class Room
{
    public required string RoomID { get; set; }
}