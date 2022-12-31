public interface ICommand
{
    string CommandShortcut { get; }
    string CommandFullName { get; }
    string GetTitle();
    void Execute();
}

