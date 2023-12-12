public class Swim: Exercise
{
    public int laps;
    private string date;
    private int time;

    public Swim(string eDate, int eTime, int eLaps): base(eDate,eTime)
    {
        date = eDate;
        time = eTime;
        laps = eLaps;
    }

    public override float GetDistance()
    {
        return laps * 50 / 1000;
    }

    public override float GetPace()
    {
        return time / GetDistance();
    }

    public override float GetSpeed()
    {
        return GetDistance() / time * 60;
    }

    public override string GetActivity()
    {
        return "Swimming";
    }

}