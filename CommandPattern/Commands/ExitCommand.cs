public class ExitCommand : ICommand
{
    public string CommandShortcut => "E";
    public string CommandFullName => "EXIT";

    public void Execute()
    {
        Environment.Exit(0);
    }

    public string GetTitle() => nameof(ExitCommand);
}

