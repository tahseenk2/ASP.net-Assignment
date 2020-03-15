using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace promact.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Postapp> Message { get; set; }

        public Postapp GetMessageById(int messageID)
        {
            return Message.FirstOrDefault(m => m.messageID == messageID);
        }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Postapp>().HasData(
                new Postapp { messageID = 1, username = "Ironman", message = " hello Ironman", likes = 0 });
            modelBuilder.Entity<Postapp>().HasData(
               new Postapp { messageID = 2, username = "Ironmannnn", message = " hellooooo Ironman", likes = 0 });


        }
    }
}
