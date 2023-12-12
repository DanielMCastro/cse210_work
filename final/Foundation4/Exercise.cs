public abstract class Exercise
{
    private string date;
    private int time;

    public Exercise(string eDate, int eTime)
    {
        date = eDate;
        time = eTime;
    }

    public abstract float GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace();
    public abstract string GetActivity();

    public string GetSummary()
    {
        return $"{date} {GetActivity()} - Distance: {GetDistance()} kilometers, Speed: {GetSpeed()}km/hour, Pace: {GetPace()} min/km.";
    }
}