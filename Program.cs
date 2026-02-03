using Homework5.Infrastructure;
using Homework5.Infrastructure.Repositories;
using Homework5.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
namespace Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new AppDbContext();
            context.Database.Migrate(); // dotnet ef database update
            var repo = new PlayerRepository(context);
            var repo2 = new SportRepository(context);
            var repo3 = new TeamRepository(context);
            var repo4 = new TrainerRepository(context);
            var repo5 = new SquadRepository(context);
            repo.AddUser(new Models.Player { Name = "aa" ,Number=10,});



        }
    }
}
