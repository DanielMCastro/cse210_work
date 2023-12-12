public abstract class Event
{
    private string title;
    private string description;
    private string date;
    private string time;
    private string address;

    public Event(string eventTitle, string eventDescription, string eventDate, string eventTime, string eventAddress)
    {
        title = eventTitle;
        description = eventDescription;
        date = eventDate;
        time = eventTime;
        address = eventAddress;
    }

    public virtual string StandardDetails()
    {
        return $"Event: {title}\n{description}\n{date}: {time}\n{address}";
    }

    public abstract string FullDetails();

    public virtual string ShortDescription(Event eventType)
    {
        return $"{eventType}\n{title}\n{date}\n";
    }
}