// ========================================
// Class: SimpleGoal.cs
// Description: Goal that is completed once
// ========================================

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }

    public override bool IsComplete() => _isComplete;

    public override string GetStatus() => (_isComplete ? "[X]" : "[ ]") + $" {_name} ({_description})";

    public override string GetStringRepresentation() => $"SimpleGoal:{_name}|{_description}|{_points}|{_isComplete}";
}
