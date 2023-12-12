public class Reception : Event
{
    private string title;
    private string description;
    private string date;
    private string time;
    private string address;
    private string email;

    public Reception(string eventTitle, string eventDescription, string eventDate, string eventTime, string eventAddress, string rsvpEmail) : base(eventTitle, eventDescription, eventDate, eventTime, eventAddress)
    {
        title = eventTitle;
        description = eventDescription;
        date = eventDate;
        time = eventTime;
        address = eventAddress;
        email = rsvpEmail;
    }

    public override string FullDetails()
    {
        return $"Event: {title}\n{description}\n{date}: {time}\n{address}\nRSVP Email Address: {email}\n";
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