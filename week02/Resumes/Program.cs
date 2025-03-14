using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of the Job class with job details
        Job job1 = new Job("Junior Software Developter", "Penguin Collective", 2018, 2020);
        Job job2 = new Job("Basic Programming Teacher", "CodeTelligence", 2020, 2022);

        // Create an instance of the Resume class with a name
        Resume myResume = new Resume("Kopano Damane");

        // Add the jobs to the resume
        myResume.AddJob(job1);
        myResume.AddJob(job2);

        // Display the resume
        myResume.DisplayResume();
    }
}

public class Resume
{
    // Member variables for name and list of jobs
    private string _name;
    private List<Job> _jobs;

    // Constructor to initialize the name and job list
    public Resume(string name)
    {
        _name = name;
        _jobs = new List<Job>();
    }

    // Method to add a job to the resume
    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }

    // Method to display the resume with name and job details
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Iterate through the list of jobs and display each one
        foreach (var job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}