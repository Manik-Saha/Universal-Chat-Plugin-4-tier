using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AdminRepo
    {
        static UniversalChatPluginEntities context;
        static AdminRepo()
        {
            context = new UniversalChatPluginEntities();
        }
        public static List<Admin> GetAllAdmin()
        {
            return context.Admins.ToList();
        }
        public static void AddAdmin(Admin data)
        {
            context.Admins.Add(data);
            context.SaveChanges();
        }

        public static Admin CheckLogin(Admin data)
        {
           var u = context.Admins.FirstOrDefault(e => e.Username == data.Username);
            if(u != null)
            {
                if(u.Password == data.Password)
                {
                    return u;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public static Admin GetAdminDetails(int id)
        {
            return context.Admins.FirstOrDefault(e => e.Id == id);
        }
        public static void DeleteAdmin(int id)
        {
            var o = context.Admins.FirstOrDefault(e => e.Id == id);
            context.Admins.Remove(o);
            context.SaveChanges();
        }

        public static void SaveAdmin(Admin data, int id)
        {
            var oldAdmin = context.Admins.FirstOrDefault(e => e.Id == id);
            context.Entry(oldAdmin).CurrentValues.SetValues(data);
            context.SaveChanges();
        }
    }
}
