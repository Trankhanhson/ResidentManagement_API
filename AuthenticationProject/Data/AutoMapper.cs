using AuthenticationProject.Models;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace AuthenticationProject.Data
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Address, AddressDTO>().ReverseMap();
            CreateMap<Resident, ResidentDTO>().ReverseMap();
            CreateMap<ResidentApartment, ResidentApartmentDTO>().ReverseMap();
            CreateMap<UrbanArea, UrbanAreaDTO>().ReverseMap();
            CreateMap<BuildingCategory, BuildingCategoryDTO>().ReverseMap();
            CreateMap<Apartment, ApartmentDTO>().ReverseMap();
        }
    }
}
