namespace ConsoleAppLearnEF.DbContext;
public class MyDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public DbSet<UserModel> User { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL("server=localhost;user=myusername;password=mypassword;database=mydatabase;");
    }
}
