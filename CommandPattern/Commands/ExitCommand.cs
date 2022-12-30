public class ExitCommand : ICommand
{

    public void Execute()
    {
        Environment.Exit(0);
    }

    public string GetTitle() => nameof(ExitCommand);
}

