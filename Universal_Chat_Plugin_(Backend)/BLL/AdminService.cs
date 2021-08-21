using BEL;
using BLL.MapperConfig;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AdminService
    {
        static AdminService()
        {
            AutoMapper.Mapper.Reset();
            AutoMapper.Mapper.Initialize(config => config.AddProfile<AutoMapperSetting>());
        }
        public static List<AdminModel> GetAllAdmin()
        {
            var data = AdminRepo.GetAllAdmin();
            var admins = AutoMapper.Mapper.Map<List<Admin>, List<AdminModel>>(data);
            return admins;
        }

        public static void AddAdmin(AddAdminModel a)
        {
            var data = AutoMapper.Mapper.Map<AddAdminModel, Admin>(a);
            AdminRepo.AddAdmin(data);
        }

        public static AdminDetails GetAdminDetails(int id)
        {
            var data = AdminRepo.GetAdminDetails(id);
            var admin = AutoMapper.Mapper.Map<Admin, AdminDetails>(data);
            return admin;
        }
        public static AdminModel GetAdmin(int id)
        {
            var data = AdminRepo.GetAdminDetails(id);
            var admin = AutoMapper.Mapper.Map<Admin, AdminModel>(data);
            return admin;
        }

        public static void DeleteAdmin(int id)
        {
            AdminRepo.DeleteAdmin(id);
        }

        public static void SaveAdmin(AdminModel admin, int id)
        {
            var data = AutoMapper.Mapper.Map<AdminModel, Admin>(admin);
            AdminRepo.SaveAdmin(data, id);
        }
    }
}
