public class NoCommand : ICommand
{
    public string GetTitle() => throw new NotImplementedException();
    public void Execute()
    {
        throw new NotImplementedException();
    }
}

