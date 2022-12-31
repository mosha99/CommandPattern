public class WritedCommand : ConsoleCommand
{
    public WritedCommand(string name)
    {
        ICommand command = commands.Single(c => c.CommandFullName.Equals(name, StringComparison.CurrentCultureIgnoreCase));
        SetCommand(command);
    }
}

