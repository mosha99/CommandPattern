public class ClearCommand : ICommand
{
    public string CommandShortcut => "C";

    public string CommandFullName => "CLEARALL";

    public string GetTitle() => nameof(ClearCommand);

    public void Execute()
    {
        Console.Clear();
    }
}

