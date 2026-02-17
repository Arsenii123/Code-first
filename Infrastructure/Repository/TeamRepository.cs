using Homework5.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Homework5.Infrastructure

namespace Homework5.Infrastructure.Repository
{
    public class TeamRepository
    {
        private AppDbContext context;

        public TeamRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void AddUser(Team t)
        {
            context.Team.Add(t);
            context.SaveChanges();
        }

        public void AddUsers(List<Team> t)
        {
            context.Team.AddRange(t);
            context.SaveChanges();
        }

        public void UpdateUser(int id, string newname)
        {
            var t = context.Team.FirstOrDefault(u => u.TeamId == id);
            if (t != null)
            {
                t.Name = newname;
                context.SaveChanges();
            }
        }

        public void UpdateAllUsers(string newname)
        {
            var t = context.Team?.Where(u => true).ToList();
            if (t != null)
            {
                foreach (var tr in t)
                {
                    tr.Name = newname;
                }
                context.SaveChanges();
            }
        }

        public void DeleteUser(int id)
        {
            var user = context.Team?.FirstOrDefault(u => u.TeamId == id);
            if (user != null)
            {
                context.Team?.Remove(user);
                context.SaveChanges();
            }
        }

        public void DeleteAllUsers()
        {
            var users = context.Team?.ToList();
            if (users != null && users.Any())
            {
                context.Team?.RemoveRange(users);
                context.SaveChanges();
            }
        }

        public void ShowUser(int id)
        {
            var user = context.Team?.FirstOrDefault(u => u.TeamId == id);
            var t = context.Team?.Where(u => true).ToList();
            if (user != null)
            {
                Console.WriteLine($"ID: {user.TeamId}, Name: {user.Name}");
                if (t != null)
                {
                    foreach (var i in t)
                    {
                        Console.WriteLine(i.Squads);
                    }
                }

            }

        }

        public void ShowUser(Trainer t)
        {
            var result = context.Trainer?.FirstOrDefault(u => u == t);
            var trainer = context.Team?.Where(u => true).ToList();
            if (result != null)
            {
                Console.WriteLine($"ID: {t.TrainerId}, Name: {t.Name}");
                if (trainer != null)
                {
                    foreach (var i in trainer)
                    {
                        Console.WriteLine(i.Squads);
                    }
                }
            }
        }

        public void ShowAllUsers()
        {
            var users = context.Trainer?.ToList();
            var t = context.Team?.Where(u => true).ToList();
            if (users != null && users.Any())
            {
                foreach (var user in users)
                {
                    Console.WriteLine($"ID: {user.TrainerId}, Name: {user.Name}");
                }
                if (t != null)
                {
                    foreach (var i in t)
                    {
                        Console.WriteLine(i.Squads);
                    }
                }

            }
        }
        public void GetAllTeamsWithAquads()
        {
            using var context = new AppDbContext();

            // завантажуємо людей без захоплень
            var people = context.Team?.ToList();

            // явне завантаження захоплень для кожної людини
            foreach (var person in people!)
            {
                // завантажуємо захоплення людини за допомогою явного завантаження
                context.Entry(person)
                       .Collection(p => p.Squads)
                       .Load(); // тут відбувається явне завантаження

                Console.WriteLine($"Name: {person.Name}");

                foreach (var hobby in person.Squads)
                {
                    Console.WriteLine($" Players: {hobby.Players}");
                }
            }
        }
    }
}
