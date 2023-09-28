using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        {
            job1.company = "Tidal";
            job1.jobTitle = "Software Engineer";
            job1.startYear = 2007;
            job1.endYear = 2019;
        }
        Job job2 = new Job();
        {
            job2.company = "Spotify";
            job2.jobTitle = "Software Engineer";
            job2.startYear = 2010;
            job2.endYear = 2012;
        }

        Resume resume = new Resume();
        {
            resume.jobs.Add(job1);
            resume.jobs.Add(job2);
        }

        resume.Display();
    }
}