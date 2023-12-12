public class Lecture : Event
{
    private string title;
    private string description;
    private string date;
    private string time;
    private string address;
    private string speaker;
    private int capacity;

    public Lecture(string eventTitle, string eventDescription, string eventDate, string eventTime, string eventAddress, string eventSpeaker, int eventCapacity) : base(eventTitle, eventDescription, eventDate, eventTime, eventAddress)
    {
        title = eventTitle;
        description = eventDescription;
        date = eventDate;
        time = eventTime;
        address = eventAddress;
        speaker = eventSpeaker;
        capacity = eventCapacity;
    }

    public override string FullDetails()
    {
        return $"Event: {title}\n{description}\n{date}: {time}\n{address}\nSpeaker: {speaker}\nEvent capacity: {capacity}\n";
    }

    public string GetStandardDetails()
    {
        return StandardDetails();
    }

    public override string ShortDescription(Event eventType)
    {
        return $"{eventType}\n{title}\n{date}\n";
    }
}