using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job
        {
            _jobTitle = "Accountant",
            _company = "Al shadai shopping mall",
            _startYear = 2016,
            _endYear = 2018
        };

        Job job2 = new Job
        {
            _jobTitle = "Junior Software Developer",
            _company = "Matrix Technologies",
            _startYear = 2019,
            _endYear = 2022
        };

        Resume myResume = new Resume
        {
            _personName = "Racheal Katono"
        };
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}