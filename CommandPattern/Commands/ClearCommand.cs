public class ClearCommand : ICommand
{
    public string GetTitle() => nameof(ClearCommand);

    public void Execute()
    {
        Console.Clear();
    }
}

