

namespace ConsoleAppLearnEF.Commands;

public class DeleteRowCommand : ICommand
{
    public void Execute(MyDbContext db)
    {
        Console.Write("Enter the UserID to delete: ");
        Guid userIdToDelete = Guid.Parse(Console.ReadLine());

        UserModel userToDelete = db.User.FirstOrDefault(u => u.UserID == userIdToDelete);
        if (userToDelete != null)
        {
            db.User.Remove(userToDelete);
            db.SaveChanges();
            Console.WriteLine($"User ID {userIdToDelete} has been deleted.");
        }
        else
        {
            Console.WriteLine($"User ID {userIdToDelete} does not exist.");
        }
    }
}