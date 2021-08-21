using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserRepo
    {
        static UniversalChatPluginEntities context;
        static UserRepo()
        {
            context = new UniversalChatPluginEntities();
        }
        public static List<User> GetAllUser()
        {
            return context.Users.ToList();
        }
        public static void AddUser(User data)
        {
            context.Users.Add(data);
            context.SaveChanges();
        }
        public static User GetUserDetails(int id)
        {
            return context.Users.FirstOrDefault(e => e.Id == id);
        }
        public static void DeleteUser(int id)
        {
            var o = context.Users.FirstOrDefault(e => e.Id == id);
            context.Users.Remove(o);
            context.SaveChanges();
        }

        public static void SaveUser(User data, int id)
        {
            var oldUser = context.Organizations.FirstOrDefault(e => e.Id == id);
            context.Entry(oldUser).CurrentValues.SetValues(data);
            context.SaveChanges();
        }

    }
}
