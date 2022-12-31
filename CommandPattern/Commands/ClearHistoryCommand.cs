using System.Text;

public class ClearHistoryCommand : ICommand
{
    public string CommandShortcut => "L";
    public string CommandFullName => "CLEAR";
    public string GetTitle() => nameof(ClearHistoryCommand);
    public void Execute()
    {
        History.history = new StringBuilder();
    }
}

