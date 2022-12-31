public class NoCommand : ICommand
{
    public string CommandShortcut => "";
    public string CommandFullName => "";
    public string GetTitle() => throw new NotImplementedException();
    public void Execute() => throw new NotImplementedException();

}

