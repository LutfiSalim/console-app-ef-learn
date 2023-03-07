
namespace ConsoleAppLearnEF.Commands;
public class GetRowListCommand : ICommand
{
    public void Execute(MyDbContext db)
    {
        Console.Write("Enter the UserID (leave blank to list all): ");
        var userId = Console.ReadLine();

        var query = db.User.AsQueryable();
        if (!string.IsNullOrEmpty(userId))
        {
            query = query.Where(u => u.UserID == Guid.Parse(userId));
        }

        var users = query.ToList();
        if (users.Count > 0)
        {
            foreach (var user in users)
            {
                Console.WriteLine($"User ID: {user.UserID}, Fullname: {user.FullName}, Password: {user.Password}, Username: {user.Username}");
            }
        }
        else
        {
            Console.WriteLine("No users found.");
        }
    }
}
