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
    public class LoginController : ApiController
    {
        [Route("api/Login")]
        [HttpPost]
        public AdminModel CheckLogin(LoginModel l)
        {
            return LoginService.CheckLogin(l);
        }
    }
}
