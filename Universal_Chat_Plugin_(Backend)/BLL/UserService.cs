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
    public class UserService
    {
        static UserService()
        {
            AutoMapper.Mapper.Reset();
            AutoMapper.Mapper.Initialize(config => config.AddProfile<AutoMapperSetting>());
        }
        public static List<UserModel> GetAllUser()
        {
            var data = UserRepo.GetAllUser();
            var users = AutoMapper.Mapper.Map<List<User>, List<UserModel>>(data);
            return users;
        }

        public static void AddUser(AddUserModel user)
        {
            var data = AutoMapper.Mapper.Map<AddUserModel, User>(user);
            UserRepo.AddUser(data);
        }

        public static UserDetails GetUserDetails(int id)
        {
            var data = UserRepo.GetUserDetails(id);
            var user = AutoMapper.Mapper.Map<User, UserDetails>(data);
            return user;
        }
        public static UserModel GetUser(int id)
        {
            var data = UserRepo.GetUserDetails(id);
            var user = AutoMapper.Mapper.Map<User, UserModel>(data);
            return user;
        }

        public static void DeleteUser(int id)
        {
            UserRepo.DeleteUser(id);
        }

        public static void SaveUser(UserModel user, int id)
        {
            var data = AutoMapper.Mapper.Map<UserModel, User>(user);
            UserRepo.SaveUser(data, id);
        }
    }
}
