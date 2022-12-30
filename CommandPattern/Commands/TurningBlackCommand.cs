public class TurningBlackCommand : ClearNeedCommand
{
    public override string GetTitle() => nameof(TurningBlackCommand);

    public override void Execute()
    {
        Console.BackgroundColor = ConsoleColor.Black;
        ClearCommand.Execute();
    }
}

