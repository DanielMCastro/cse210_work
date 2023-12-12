public class Run : Exercise
{
    private string date;
    private int time;
    public float distance;

    public Run(string eDate, int eTime, float eDistance): base(eDate, eTime)
    {
        date = eDate;
        time = eTime;
        distance = eDistance;
    }

    public override float GetSpeed()
    {
        return distance / time;
    }

    public override float GetPace()
    {
        return time / distance;
    }
    public override float GetDistance()
    {
        return distance;
    }

    public override string GetActivity()
    {
        return "Running";
    }
    
}