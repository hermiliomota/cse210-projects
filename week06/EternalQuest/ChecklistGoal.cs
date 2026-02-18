public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _targetAmount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetAmount, int bonus, int amountCompleted = 0)
        : base(name, description, points)
    {
        _targetAmount = targetAmount;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {
        if (_amountCompleted < _targetAmount)
        {
            _amountCompleted++;
            int earned = GetPoints();

            if (_amountCompleted == _targetAmount)
            {
                earned += _bonus;
                Console.WriteLine("🎉 BONUS ACHIEVED! 🎉");
            }

            return earned;
        }

        return 0;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _targetAmount;
    }

    public override string GetStatus()
    {
        string status = _amountCompleted >= _targetAmount ? "X" : " ";
        return $"[{status}] Completed {_amountCompleted}/{_targetAmount}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetName()},{GetDescription()},{GetPoints()},{_targetAmount},{_bonus},{_amountCompleted}";
    }
}
