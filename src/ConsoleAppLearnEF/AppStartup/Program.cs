using var db = new MyDbContext();
if (args.Length < 1)
{
    Console.WriteLine("Please provide a command: -createdata, -deleterow, -getrow/list");
    return;
}

var commandName = args[0];

try
{
    ICommand command;
    switch (commandName)
    {
        case "-createdata":
            command = new CreateDataCommand();
            break;

        case "-deleterow":
            command = new DeleteRowCommand();
            break;

        case "-getrow/list":
            command = new GetRowListCommand();
            break;

        default:
            Console.WriteLine("Invalid command.");
            return;
    }

    command.Execute(db);
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}