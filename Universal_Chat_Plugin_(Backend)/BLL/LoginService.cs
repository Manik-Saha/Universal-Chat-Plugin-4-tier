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
    public class LoginService
    {
        static LoginService()
        {
            AutoMapper.Mapper.Reset();
            AutoMapper.Mapper.Initialize(config => config.AddProfile<AutoMapperSetting>());
        }
        public static AdminModel CheckLogin(LoginModel l)
        {
            var data = AutoMapper.Mapper.Map<LoginModel, Admin>(l);
            var admin = AdminRepo.CheckLogin(data);
            var data2 = AutoMapper.Mapper.Map<Admin, AdminModel>(admin);
            return data2;
        }
    }
}
