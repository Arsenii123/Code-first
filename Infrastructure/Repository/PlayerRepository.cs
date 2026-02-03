using Homework5.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5.Infrastructure.Repository
{
    public class PlayerRepository
    {

            private AppDbContext context;

            public PlayerRepository(AppDbContext context)
            {
                this.context = context;
            }

            public void AddUser(Player p)
            {
                context.Player.Add(p);
                context.SaveChanges();
            }

            public void AddUsers(List<Player> p)
            {
                context.Player.AddRange(p);
                context.SaveChanges();
            }

            public void UpdateUser(int id, int newnumber)
            {
                var user = context.Player.FirstOrDefault(u => u.PlayerId == id);
                if (user != null)
                {
                    user.Number = newnumber;
                    context.SaveChanges();
                }
            }

            public void UpdateAllUsers(int newnumber)
            {
                var users = context.Player?.Where(u => true).ToList();
                if (users != null)
                {
                    foreach (var user in users)
                    {
                        user.Number = newnumber;
                    }
                    context.SaveChanges();
                }
            }

            public void DeleteUser(int id)
            {
                var user = context.Player?.FirstOrDefault(u => u.PlayerId == id);
                if (user != null)
                {
                    context.Player?.Remove(user);
                    context.SaveChanges();
                }
            }

            public void DeleteAllUsers()
            {
                var users = context.Player?.ToList();
                if (users != null && users.Any())
                {
                    context.Player?.RemoveRange(users);
                    context.SaveChanges();
                }
            }

            public void ShowUser(int id)
            {
                var user = context.Player?.FirstOrDefault(u => u.PlayerId == id);
                if (user != null)
                {
                    Console.WriteLine($"ID: {user.PlayerId}, Name: {user.Name}, Number: {user.Number}");
                }
            }

            public void ShowUser(Player pl)
            {
                var result = context.Player?.FirstOrDefault(u => u == pl);
                if (result != null)
                {
                    Console.WriteLine($"ID: {pl.PlayerId}, Name: {pl.Name}, Number: {pl.Number}");
                }
            }

            public void ShowAllUsers()
            {
                var users = context.Player.ToList();
                if (users != null && users.Any())
                {
                    foreach (var user in users)
                    {
                    Console.WriteLine($"ID: {user.PlayerId}, Name: {user.Name}, Number: {user.Number}");
                    }
                }
            }
        }
    }

