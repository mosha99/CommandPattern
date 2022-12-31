public class TurningBlackCommand : ICommand
{
    public string CommandShortcut => "B";
    public string CommandFullName => "TBLACK";

    public string GetTitle() => nameof(TurningBlackCommand);

    public void Execute()
    {
        Console.BackgroundColor = ConsoleColor.Black;
    }
}

