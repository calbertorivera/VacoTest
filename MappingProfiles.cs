using AutoMapper;
using BackEnd.Business.Dto;
using BackEnd.Models.DB;

namespace BackEnd
{
    //public class MappingProfiles
    //{
    //    public void ConfigureServices(IServiceCollection services)
    //    {
    //        services.AddAutoMapper(typeof(PostsMapper));
    //    }
    //}
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Post, PostDto>().ForMember(dest=>dest.Category, act=>act.Ignore());
            CreateMap<PostDto, Post>().ForMember(dest => dest.Category, act => act.Ignore());
            CreateMap<Category, CategoryDto>().ForMember(dest => dest.Posts, act => act.Ignore());
        }
    }
}
