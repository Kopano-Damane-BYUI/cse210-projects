using System;

public class Job
{
    // Member variables for the job details
    private string _jobTitle;
    private string _company;
    private int _startYear;
    private int _endYear;

    // Constructor to initialize the job details
    public Job(string jobTitle, string company, int startYear, int endYear)
    {
        _jobTitle = jobTitle;
        _company = company;
        _startYear = startYear;
        _endYear = endYear;
    }

    // Method to display the job details
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

    // Getters (optional, in case you need to access them in the future)
    public string JobTitle => _jobTitle;
    public string Company => _company;
}
