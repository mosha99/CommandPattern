using System.Text;

public class ClearHistoryCommand : ClearNeedCommand
{
    public override string GetTitle() => nameof(ClearHistoryCommand);
    public override void Execute()
    {
        ClearCommand.Execute();
        History.history = new StringBuilder();
    }
}

