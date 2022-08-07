using AutoMapper;
using BackEnd.Business.Dto;
using BackEnd.Models.DB;

namespace BackEnd.Business.Managers
{
    public class CategoriesManager
    {
        internal List<CategoryDto> GetCategories(IMapper mapper, VacoDBContext context)
        {
            var categoriesList = context.Categories.ToList();
            var _cattegories = mapper.Map<List<CategoryDto>>(categoriesList);
            return _cattegories;
        }
    }
}
