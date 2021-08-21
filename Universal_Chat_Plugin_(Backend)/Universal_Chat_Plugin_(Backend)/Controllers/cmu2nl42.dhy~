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
    public class AdminController : ApiController
    {
        [Route("api/Admin/All")]
        [HttpGet]
        public List<AdminModel> GetAllAdmin()
        {
            return AdminService.GetAllAdmin();
        }
        [Route("api/Admin/Add")]
        [HttpPost]
        public void AddAdmin(AddAdminModel a)
        {
            AdminService.AddAdmin(a);
        }
        [Route("api/Admin/{id}/Details")]
        [HttpGet]
        public AdminDetails GetAdminDetails(int id)
        {
            return AdminService.GetAdminDetails(id);
        }
        [Route("api/Admin/{id}/Delete")]
        [HttpGet]
        public AdminModel GetDeleteAdmin(int id)
        {
            return AdminService.GetAdmin(id);
        }
        [Route("api/Admin/{id}/Delete")]
        [HttpPost]
        public void DeleteAdmin(int id)
        {
            AdminService.DeleteAdmin(id);
        }
        [Route("api/Admin/{id}/Edit")]
        [HttpGet]
        public AdminModel GetEditAdmin(int id)
        {
            return AdminService.GetAdmin(id);
        }
        [Route("api/Admin/{id}/Edit")]
        [HttpPost]
        public void EditAdmin(AdminModel admin,int id)
        {
            AdminService.SaveAdmin(admin, id);
        }
    }
}
