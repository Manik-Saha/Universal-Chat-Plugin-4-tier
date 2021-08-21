using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Universal_Chat_Plugin__Backend_.Controllers
{
    public class UserController : ApiController
    {
        [Route("api/User/All")]
        [HttpGet]
        public List<UserModel> GetAllUser()
        {
            return UserService.GetAllUser();
        }
        [Route("api/User/Add")]
        [HttpPost]
        public void AddUser(AddUserModel user)
        {
            UserService.AddUser(user);
        }
        [Route("api/User/{id}/Details")]
        [HttpGet]
        public UserDetails GetUserDetails(int id)
        {
            return UserService.GetUserDetails(id);
        }
        [Route("api/User/{id}/Delete")]
        [HttpGet]
        public UserModel GetDeleteUser(int id)
        {
            return UserService.GetUser(id);
        }
        [Route("api/User/{id}/Delete")]
        [HttpPost]
        public void DeleteUser(int id)
        {
            UserService.DeleteUser(id);
        }
        [Route("api/User/{id}/Edit")]
        [HttpGet]
        public UserModel GetEditUser(int id)
        {
            return UserService.GetUser(id);
        }
        [Route("api/User/{id}/Edit")]
        [HttpPost]
        public void EditUser(UserModel user, int id)
        {
            UserService.SaveUser(user, id);
        }
    }
}
