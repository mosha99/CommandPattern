public static class CommandFinder
{
    public static IEnumerable<ICommand> GetAllCommand()
    {
        var type = typeof(ICommand);

        IEnumerable<ICommand> commands = AppDomain.CurrentDomain
            .GetAssemblies()
            .SelectMany(s => s.GetTypes())
            .Where(p => type.IsAssignableFrom(p) && p.IsClass)
            .Select(x=> (ICommand)Activator.CreateInstance(x));
       
        return commands;
    }
}
