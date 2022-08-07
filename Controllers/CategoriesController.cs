using AutoMapper;
using BackEnd.Business.Dto;
using BackEnd.Business.Managers;
using BackEnd.Models.DB;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ILogger<PostsController> _logger;
        private readonly VacoDBContext _context;
        private readonly IMapper _mapper;
        private readonly CategoriesManager manager;

        public CategoriesController(ILogger<PostsController> logger, VacoDBContext ctx, IMapper mapper)
        {
            _logger = logger;
            _context = ctx;
            _mapper = mapper;
            manager = new CategoriesManager();
        }


        [HttpGet(Name = "/GetCategories")]
        public List<CategoryDto> Get()
        {
            List<CategoryDto> categories = manager.GetCategories(_mapper, _context);
            return categories;
        }

    }
}
