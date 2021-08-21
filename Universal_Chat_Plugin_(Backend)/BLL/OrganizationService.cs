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
    public class OrganizationService
    {
        static OrganizationService()
        {
            AutoMapper.Mapper.Reset();
            AutoMapper.Mapper.Initialize(config => config.AddProfile<AutoMapperSetting>());
        }
        public static List<OrganizationModel> GetAllOrganization()
        {
            var data = OrganizationRepo.GetAllOrganization();
            var organizations = AutoMapper.Mapper.Map<List<Organization>, List<OrganizationModel>>(data);
            return organizations;
        }

        public static void AddOrganization(AddOrganizationModel o)
        {
            var data = AutoMapper.Mapper.Map<AddOrganizationModel, Organization>(o);
            OrganizationRepo.AddOrganization(data);
        }

        public static OrganizationDetails GetOrganizationDetails(int id)
        {
            var data = OrganizationRepo.GetOrganizationDetails(id);
            var organization = AutoMapper.Mapper.Map<Organization, OrganizationDetails>(data);
            return organization;
        }

        public static OrganizationModel GetOrganization(int id)
        {
            var data = OrganizationRepo.GetOrganizationDetails(id);
            var organization = AutoMapper.Mapper.Map<Organization, OrganizationModel>(data);
            return organization;
        }

        public static void DeleteOrganization(int id)
        {
            OrganizationRepo.DeleteOrganization(id);
        }

        public static void SaveOrganization(OrganizationModel organization, int id)
        {
            var data = AutoMapper.Mapper.Map<OrganizationModel, Organization>(organization);
            OrganizationRepo.SaveOrganization(data, id);
        }
    }
}
