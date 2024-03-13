using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Bartender";
        job1._company = "Umwero";
        job1._startYear = 2018;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._jobTitle = "Mechanization Lead";
        job2._company = "Pride Farms";
        job2._startYear = 2021;
        job2._endYear = 2023;

        Job job3 = new Job();
        job3._jobTitle = "Mechanization Lead";
        job3._company = "Pride Farms";
        job3._startYear = 2023;
        job3._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Mugisha Patrick";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        myResume.Display();
    }
}