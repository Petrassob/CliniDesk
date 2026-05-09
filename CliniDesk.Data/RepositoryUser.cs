using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CliniDesk.Entity;
using BCrypt.Net;


namespace CliniDesk.Data
{
    public class RepositoryUser
    {
        private readonly AppDbContext context;
        public RepositoryUser(AppDbContext context)
        {
            this.context = context;
        }

        public User GetByUsername(string username)
        {
            return context.Users.FirstOrDefault(u => u.Username == username);
        }

        public void Save(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}
