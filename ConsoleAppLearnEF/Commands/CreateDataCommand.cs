namespace ConsoleAppLearnEF.Commands;
    public class CreateDataCommand : ICommand
    {
        public void Execute(MyDbContext db)
        {
            var newUser = new UserModel();


            Console.Write("Enter the FullName: ");
            newUser.FullName = Console.ReadLine();
            Console.Write("Enter the Username: ");
            newUser.Username = Console.ReadLine();
            Console.Write("Enter the Password: ");
            newUser.Password = Console.ReadLine();

            db.User.Add(newUser);
            db.SaveChanges();
            Console.WriteLine($"User ID: {newUser.UserID}");
        }
    }