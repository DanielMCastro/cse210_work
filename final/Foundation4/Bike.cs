public class Bike: Exercise
{
    public float speed;
    private string date;
    private int time;

    public Bike(string eDate, int eTime, float eSpeed): base(eDate, eTime)
    {
        date = eDate;
        time = eTime;
        speed = eSpeed;
    }

        public override float GetDistance()
    {
        return speed * time;
    }

    public override float GetPace()
    {
        return time / GetDistance();
    }

    public override float GetSpeed()
    {
        return speed;
    }

    public override string GetActivity()
    {
        return "Biking";
    }
}