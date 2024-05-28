using AutoMapper;
using bolao10.api.DataBase.Entities;
using bolao10.api.Dto.Response;

namespace bolao10.api
{
    public class AutoMapperConfiguration : Profile
    {

        public AutoMapperConfiguration()
        {

            CreateMap<AuthenticationResponse, Usuario>().ReverseMap();
        }


    }
}
