// WritingAssignment.cs
public class WritingAssignment : Assignment
{
    private string _title;

    // Constructor for the WritingAssignment class
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic) // Calls the base class constructor
    {
        _title = title;
    }

    // Method to get the writing information
    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}
