// ========================================
// Class: ChecklistGoal.cs
// Description: Goal completed after N times, with bonus
// ========================================

public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            return _points + (_currentCount == _targetCount ? _bonus : 0);
        }
        return 0;
    }

    public override bool IsComplete() => _currentCount >= _targetCount;

    public override string GetStatus() => $"{(_currentCount >= _targetCount ? "[X]" : "[ ]")} {_name} ({_description}) -- Completed: {_currentCount}/{_targetCount}";

    public override string GetStringRepresentation() => $"ChecklistGoal:{_name}|{_description}|{_points}|{_bonus}|{_targetCount}|{_currentCount}";
}
