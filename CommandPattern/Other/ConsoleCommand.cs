public abstract class ConsoleCommand
{

    private ICommand _command = new NoCommand();
    public string GetTitle() => _command.GetTitle();
    protected void SetCommand(ICommand command)
    {
        if (command == null) _command = new NoCommand();
        else _command = command;
    }

    public void Run()
    {
        _command.Execute();
        Console.WriteLine(_command.GetTitle());
    }
}

