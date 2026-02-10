using Homework5.Infrastructure;
using Homework5.Infrastructure.Repositories;
using Homework5.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
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
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(repo);
            bool isValid = Validator.TryValidateObject(repo, validationContext, validationResults, true);
            var validationResults2 = new List<ValidationResult>();
            var validationContext2 = new ValidationContext(repo2);
            bool isValid2 = Validator.TryValidateObject(repo2, validationContext, validationResults, true);
            var validationResults3 = new List<ValidationResult>();
            var validationContext3 = new ValidationContext(repo3);
            bool isValid3 = Validator.TryValidateObject(repo3, validationContext, validationResults, true);
            var validationResults4 = new List<ValidationResult>();
            var validationContext4 = new ValidationContext(repo4);
            bool isValid4 = Validator.TryValidateObject(repo4, validationContext, validationResults, true);
            var validationResults5 = new List<ValidationResult>();
            var validationContext5 = new ValidationContext(repo5);
            bool isValid5 = Validator.TryValidateObject(repo5, validationContext, validationResults, true);
            if (!isValid || !isValid2 || !isValid3 || !isValid4 || !isValid5)
            {
                Console.WriteLine("Помилка валідації:");
                foreach (var validationResult in validationResults)
                {
                    Console.WriteLine("→ " + validationResult.ErrorMessage);
                }
                foreach (var validationResult2 in validationResults2)
                {
                    Console.WriteLine("→ " + validationResult2.ErrorMessage);
                }
                foreach (var validationResult3 in validationResults3)
                {
                    Console.WriteLine("→ " + validationResult3.ErrorMessage);
                }
                foreach (var validationResult4 in validationResults4)
                {
                    Console.WriteLine("→ " + validationResult4.ErrorMessage);
                }
                foreach (var validationResult5 in validationResults5)
                {
                    Console.WriteLine("→ " + validationResult5.ErrorMessage);
                }
                return;
            }



        }
    }
}
