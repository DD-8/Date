using Date.DateAccess;
using Date.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Date.Services
{
    public class UserService
    {
        public void AddUser(User user)
        {
            using (Context context = new Context())
            {
                var addedUser = context.Entry(user);
                addedUser.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void DeleteUser(User user)
        {
            using (Context context = new Context())
            {
                var deletedUser = context.Entry(user);
                deletedUser.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void UpdateUser(User user)
        {
            using (Context context = new Context())
            {
                var deletedUser = context.Entry(user);
                deletedUser.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public User GetUserById(int id)
        {
            using (Context context = new Context())
            {
                return context.Set<User>().SingleOrDefault(u => u.Id == id);
            }
        }

        public List<User> GetAllUsers()
        {
            using (Context context = new Context())
            {
                return context.Set<User>().ToList();
            }
        }
    }
}
