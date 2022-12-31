public abstract class ConsoleCommand
{
    protected IEnumerable<ICommand> commands = new List<ICommand>();

    public ConsoleCommand()
    {
        commands = CommandFinder.GetAllCommand();
    }

    private ICommand _command = new NoCommand();
    public string GetTitle() => _command.GetTitle();
    protected void SetCommand(ICommand command)
    {
        _command = command ?? new NoCommand();
    }

    public void Run()
    {
        _command.Execute();
        Console.WriteLine(_command.GetTitle());
    }
}

