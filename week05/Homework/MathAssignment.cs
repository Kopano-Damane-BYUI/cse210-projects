// MathAssignment.cs
public class MathAssignment : Assignment
{
    private string _section;
    private string _problems;

    // Constructor for the MathAssignment class
    public MathAssignment(string studentName, string topic, string section, string problems)
        : base(studentName, topic) // Calls the base class constructor
    {
        _section = section;
        _problems = problems;
    }

    // Method to get the homework list
    public string GetHomeworkList()
    {
        return $"Section {_section} Problems {_problems}";
    }
}
