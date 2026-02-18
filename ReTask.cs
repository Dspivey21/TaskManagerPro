namespace TaskManagerPro;

public class ReTask : BaseTask
{
    public int Occurrences {get; private set; }
    public int ComCount {get; private set; } = 0;
    public ReTask(string title, int occurrences) : base(title)
    {
        Occurrences = occurrences;
    }

    public override void Complete()
    {
        ComCount++;
        if (ComCount >= Occurrences)
        {
            base.Complete();
        }
    }

    public override void Display()
    {
        Console.WriteLine($"[ReTask] {Title} ({ComCount}/{Occurrences} occurrences) - Completed: {IsCompleted}");
    }
}