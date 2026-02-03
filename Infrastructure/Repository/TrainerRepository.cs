using Homework5.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5.Infrastructure.Repository
{
    public class TrainerRepository
    {
        private AppDbContext context;

        public TrainerRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void AddUser(Trainer t)
        {
            context.Trainer.Add(t);
            context.SaveChanges();
        }

        public void AddUsers(List<Trainer> t)
        {
            context.Trainer.AddRange(t);
            context.SaveChanges();
        }

        public void UpdateUser(int id, int newage)
        {
            var t = context.Trainer.FirstOrDefault(u => u.TrainerId == id);
            if (t != null)
            {
                t.Age = newage;
                context.SaveChanges();
            }
        }

        public void UpdateAllUsers(int newage)
        {
            var t = context.Trainer?.Where(u => true).ToList();
            if (t != null)
            {
                foreach (var tr in t)
                {
                    tr.Age = newage;
                }
                context.SaveChanges();
            }
        }

        public void DeleteUser(int id)
        {
            var user = context.Trainer?.FirstOrDefault(u => u.TrainerId == id);
            if (user != null)
            {
                context.Trainer?.Remove(user);
                context.SaveChanges();
            }
        }

        public void DeleteAllUsers()
        {
            var users = context.Trainer?.ToList();
            if (users != null && users.Any())
            {
                context.Trainer?.RemoveRange(users);
                context.SaveChanges();
            }
        }

        public void ShowUser(int id)
        {
            var user = context.Trainer?.FirstOrDefault(u => u.TrainerId == id);
            if (user != null)
            {
                Console.WriteLine($"ID: {user.TrainerId}, Name: {user.Name}, Age: {user.Age}");
            }
        }

        public void ShowUser(Trainer t)
        {
            var result = context.Trainer?.FirstOrDefault(u => u == t);
            if (result != null)
            {
                Console.WriteLine($"ID: {t.TrainerId}, Name: {t.Name}, Age: {t.Age}");
            }
        }

        public void ShowAllUsers()
        {
            var users = context.Trainer?.ToList();
            if (users != null && users.Any())
            {
                foreach (var user in users)
                {
                    Console.WriteLine($"ID: {user.TrainerId}, Name: {user.Name}, Age: {user.Age}");
                }
            }
        }
    }
}
