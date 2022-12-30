public class WritedCommand : ConsoleCommand
{
    public WritedCommand(string name)
    {
        ICommand command = new NoCommand();
        switch (name)
        {
            case "CLEAR": command = new ClearHistoryCommand(); break;
            case "TRED": command = new TurningRedCommand(); break;
            case "TBLACK": command = new TurningBlackCommand(); break;
            case "EXIT": command = new ExitCommand(); break;
            default: throw new Exception();
        }
        SetCommand(command);
    }
}

