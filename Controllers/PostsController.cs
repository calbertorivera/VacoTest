using AutoMapper;
using BackEnd.Business.Dto;
using BackEnd.Business.Managers;
using BackEnd.Models.DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BackEnd.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly ILogger<PostsController> _logger;
        private readonly VacoDBContext _context;
        private readonly IMapper _mapper;
        private readonly PostsManager manager;

        public PostsController(ILogger<PostsController> logger, VacoDBContext ctx, IMapper mapper)
        {
            _logger = logger;
            _context = ctx;
            _mapper = mapper;
            manager = new PostsManager();
        }

        [HttpGet(Name = "/GetPosts")]
        public List<PostDto> Get()
        {
            List<PostDto> posts = manager.GetPosts(_mapper,_context);           
            return posts;
        }

        [HttpGet("/Posts/{id:long}")]
        public PostDto GetPostById(long id)
        {

            PostDto post = manager.GetPostsById(_mapper, _context,id);
            return post;           
           
        }

        [HttpPost]
        public PostDto CreatePost(PostDto value)
        {
            PostDto post = manager.CreatePost(_mapper, _context, value);
            return post;           

        }

        [HttpPut("{id}")]
        public PostDto UpdatePost(PostDto value)
        {
            PostDto post = manager.UpdatePost(_mapper, _context, value);
            return post;

        }

        [HttpDelete]
        public bool DeleteAll()
        {
            return manager.DeleteAll(_mapper, _context); 
        }

        [HttpDelete("{id}")]
        public bool DeleteById(long id)
        {
            return manager.DeleteById(_mapper, _context,id);
        }
    }
}
