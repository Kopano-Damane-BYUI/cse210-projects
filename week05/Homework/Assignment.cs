// Assignment.cs
public class Assignment
{
    protected string _studentName;
    private string _topic;

    // Constructor for the base class
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Method to get the summary of the assignment
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}
