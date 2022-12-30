public abstract class ClearNeedCommand : ICommand
{
    public abstract string GetTitle();
    public ICommand ClearCommand = new ClearCommand();
    public abstract void Execute();
}

