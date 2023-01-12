using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "Walmart";
        job1._jobTitle = "Cashier";
        job1._startYear = 2000;
        job1._endYear = 2005;
        
        //job1.Display();

        Job job2 = new Job();
        job2._company = "Nasa";
        job2._jobTitle = "Astronaught";
        job2._startYear = 2005;
        job2._endYear = 2010;

        //job2.Display();

        Resume resume = new Resume();
        resume._name = "Arnold Williams";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.Display();

        //string testResume = resume._jobs[0]._jobTitle;
        //Console.WriteLine(testResume);

    }
}