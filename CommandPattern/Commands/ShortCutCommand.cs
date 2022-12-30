public class ShortCutCommand : ConsoleCommand
{
    public ShortCutCommand(string key)
    {
        ICommand command = new NoCommand();
        switch (key.ToUpper())
        {
            case "L": command = new ClearHistoryCommand(); break;
            case "R": command = new TurningRedCommand(); break;
            case "B": command = new TurningBlackCommand(); break;
            case "E": command = new ExitCommand(); break;
            default: throw new Exception();
        }
        SetCommand(command);
    }
}

