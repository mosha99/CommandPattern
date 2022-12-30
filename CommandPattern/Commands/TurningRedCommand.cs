public class TurningRedCommand : ClearNeedCommand
{
    public override string GetTitle() => nameof(TurningRedCommand);

    public override void Execute()
    {
        Console.BackgroundColor = ConsoleColor.Red;
        ClearCommand.Execute();
    }
}

