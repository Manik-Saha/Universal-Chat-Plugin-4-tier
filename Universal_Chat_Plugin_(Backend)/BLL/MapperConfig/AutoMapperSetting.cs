using AutoMapper;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.MapperConfig
{
    class AutoMapperSetting : Profile
    {
        public AutoMapperSetting()
        {
            CreateMap<Admin, AdminModel>();
            CreateMap<AdminModel, Admin>();
            CreateMap<AddAdminModel, Admin>();
            CreateMap<Admin, AddAdminModel>();
            CreateMap<Admin, AdminDetails>();
            CreateMap<AdminDetails, Admin>();

            CreateMap<User, UserModel>();
            CreateMap<UserModel, User>();
            CreateMap<User, AddUserModel>();
            CreateMap<AddUserModel, User>();
            CreateMap<UserDetails, User>();
            CreateMap<User, UserDetails>();
            CreateMap<LoginModel, Admin>();

            CreateMap<Organization, OrganizationModel>();
            CreateMap<Organization, AddOrganizationModel>();
            CreateMap<Organization, OrganizationDetails>();
            CreateMap<OrganizationModel, Organization>();
            CreateMap<AddOrganizationModel, Organization>();
            CreateMap<OrganizationDetails, Organization>();

            CreateMap<Payment, PaymentDetails>();
            CreateMap<PaymentDetails, Payment>();
            CreateMap<Payment, PaymentModel>();
            CreateMap<PaymentModel, Payment>();

            CreateMap<Salary, SalaryModel>();
            CreateMap<SalaryModel, Salary>();
        }
    }
}
