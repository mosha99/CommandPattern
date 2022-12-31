
public class ShortCutCommand : ConsoleCommand
{
    public ShortCutCommand(string key)
    {
        ICommand command = commands.Single(c=>c.CommandShortcut.Equals(key,StringComparison.CurrentCultureIgnoreCase));
        SetCommand(command);
    }
}

