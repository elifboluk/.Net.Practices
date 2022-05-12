using AdminTemplate.Dtos;
using AdminTemplate.Models.Entities;
using AutoMapper;

namespace AdminTemplate.MappingProfiles
{
    public class EntityMappingProfile : Profile //System.Reflection kütüphanesi (Bir uygulama çalışırken gelen bilgileri o anki uygulamanıza göre yorumlamanızı sağlar.)
    {
    
        public EntityMappingProfile()
        {
            CreateMap<Category, CategoryDto>().ReverseMap(); //2 yönde de dönüşüm yapılır.
                                                              //CreateMap<CategoryDto, Category>();

            //productdto
            //CreateMap<Product, ProductDto>().ForMember(x => x.CategoryName, 
            //    src => 
            //        src.MapFrom(x=>x.Category.Name)
            //        );
            CreateMap<Product, ProductDto>().ReverseMap();

        }
    }
}