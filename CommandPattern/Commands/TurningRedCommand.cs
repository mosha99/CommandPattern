public class TurningRedCommand : ICommand
{
    public string CommandShortcut => "R";
    public string CommandFullName => "TRED";

    public string GetTitle() => nameof(TurningRedCommand);

    public void Execute()
    {
        Console.BackgroundColor = ConsoleColor.Red;
    }
}

