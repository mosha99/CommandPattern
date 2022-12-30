using System.Text;

ICommand clearCommand = new ClearCommand();
while (true)
{
    clearCommand.Execute();
    printInfo();
    printHistory();
    ConsoleCommand command = ReadConsole();
    command.Run();
}

void printInfo()
{
    StringBuilder info = new StringBuilder();
    info.Append("WELLCOM");
    info.AppendLine("FOR CLEARHISTORY CONSOLE WRITE 'CLEAR' OR ENTER 'CTRL + L'");
    info.AppendLine("FOR TURNING RED CONSOLE WRITE 'TRED' OR ENTER 'CTRL + R'");
    info.AppendLine("FOR TURNING BLACK CONSOLE WRITE 'TBLACK' OR ENTER 'CTRL + B'");
    info.AppendLine("FOR CLOSE CONSOLE WRITE 'EXIT' OR ENTER 'CTRL + E'");
    info.AppendLine("****************************************************************************");
    Console.WriteLine(info);
}
void printHistory()
{
    if (string.IsNullOrWhiteSpace(History.history.ToString())) return;
    Console.WriteLine("History :");
    Console.WriteLine(History.history);
    Console.WriteLine("****************************************************************************");
}
ConsoleCommand ReadConsole()
{
    var key = Console.ReadKey();
    ConsoleCommand consoleCommand;
    if (key.Modifiers == ConsoleModifiers.Control)
    {
        consoleCommand = new ShortCutCommand(key.Key.ToString());
    }
    else
    {
        StringBuilder stringBuilder = new StringBuilder();
        do
        {
            stringBuilder.Append(key.KeyChar);
            key = Console.ReadKey();
        } while (key.Key != ConsoleKey.Enter);

        consoleCommand = new WritedCommand(stringBuilder.ToString());
    }
    History.history.AppendLine(consoleCommand.GetTitle());
    return consoleCommand;
}

