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
    public class OrganizationController : ApiController
    {
        [Route("api/Organization/All")]
        [HttpGet]
        public List<OrganizationModel> GetAllOrganization()
        {
            return OrganizationService.GetAllOrganization();
        }
        [Route("api/Organization/Add")]
        [HttpPost]
        public void AddOrganization(AddOrganizationModel o)
        {
            OrganizationService.AddOrganization(o);
        }
        [Route("api/Organization/{id}/Details")]
        [HttpGet]
        public OrganizationDetails GetOrganizationDetails(int id)
        {
            return OrganizationService.GetOrganizationDetails(id);
        }
        [Route("api/Organization/{id}/Delete")]
        [HttpGet]
        public OrganizationModel GetDeleteOrganization(int id)
        {
            return OrganizationService.GetOrganization(id);
        }
        [Route("api/Organization/{id}/Delete")]
        [HttpPost]
        public void DeleteOrganization(int id)
        {
            OrganizationService.DeleteOrganization(id);
        }
        [Route("api/Organization/{id}/Edit")]
        [HttpGet]
        public OrganizationModel GetEditOrganization(int id)
        {
            return OrganizationService.GetOrganization(id);
        }
        [Route("api/Organization/{id}/Edit")]
        [HttpPost]
        public void EditOrganization(OrganizationModel organization, int id)
        {
            OrganizationService.SaveOrganization(organization, id);
        }
    }
}
