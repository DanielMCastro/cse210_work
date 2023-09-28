public class Resume
{
    public string name;
    public List<Job> jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"{name}");
        Console.WriteLine($"Jobs:");

        foreach (Job job in jobs)
        {
            job.Display();
        }
    }
}