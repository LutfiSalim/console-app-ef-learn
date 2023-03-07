namespace ConsoleAppLearnEF.Interfaces;
public interface ICommand
{
    void Execute(MyDbContext db);
}
