using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrganizationRepo
    {
        static UniversalChatPluginEntities context;
        static OrganizationRepo()
        {
            context = new UniversalChatPluginEntities();
        }
        public static List<Organization> GetAllOrganization()
        {
            return context.Organizations.ToList();
        }

        public static void AddOrganization(Organization data)
        {
            context.Organizations.Add(data);
            context.SaveChanges();
        }

        public static Organization GetOrganizationDetails(int id)
        {
            return context.Organizations.FirstOrDefault(e => e.Id == id);      
        }

        public static void DeleteOrganization(int id)
        {
            var o = context.Organizations.FirstOrDefault(e => e.Id == id);
            context.Organizations.Remove(o);
            context.SaveChanges();
        }

        public static void SaveOrganization(Organization data, int id)
        {
            var oldOrganization = context.Organizations.FirstOrDefault(e => e.Id == id);
            context.Entry(oldOrganization).CurrentValues.SetValues(data);
            context.SaveChanges();
        }
    }
}
