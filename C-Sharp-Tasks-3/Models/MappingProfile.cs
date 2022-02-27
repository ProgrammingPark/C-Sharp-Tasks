using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_3.Contstant;
using Task_3.ViewModels;

namespace Task_3.Models
{
    public class MappingProfile: AutoMapper.Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserViewModel>()
                .ForMember(m => m.UserId, o => o.MapFrom(f => f.Id))
                .ForMember(m => m.UserEmail, o => o.MapFrom(f => f.Email))
                .ForMember(m => m.CreateDate, o => o.MapFrom(f => f.CreateDate))
                .ForMember(m => m.UserStatus, o => o.Ignore())
                .AfterMap((src, dest, parameters) =>
                {
                    dest.UserStatus = (UserStatus)parameters.Items["Status"];
                });
        }
    }
}
