using AutoMapper;
using BackEnd.Business.Dto;
using BackEnd.Models.DB;

namespace BackEnd.Business.Managers
{
    public class PostsManager
    {
       
        internal List<PostDto> GetPosts(IMapper mapper, VacoDBContext context)
        {
            var postsList = context.Posts.ToList();
            var _mappedUser = mapper.Map<List<PostDto>>(postsList);
            return _mappedUser;
        }

        internal PostDto GetPostsById(IMapper mapper, VacoDBContext context, long id)
        {
            var post = context.Posts.FirstOrDefault(a => a.Id == id);
            if (post != null)
            {
                var _mappedUser = mapper.Map<PostDto>(post);
                             return _mappedUser;
            }
            else
            {
                return null;
            }
        }

        internal PostDto CreatePost(IMapper mapper, VacoDBContext context, PostDto value)
        {
            var _mappedUser = mapper.Map<Post>(value);
            context.Posts.Add(_mappedUser);
            context.SaveChanges();
            return mapper.Map<PostDto>(_mappedUser);
        }

        internal PostDto UpdatePost(IMapper mapper, VacoDBContext context, PostDto value)
        {
            //TODO validates
           
                var _mappedUser = mapper.Map<Post>(value);
                _mappedUser.Timestamp = DateTimeOffset.Now;
                context.Update(_mappedUser);
                context.SaveChanges();
                var response = mapper.Map<PostDto>(_mappedUser); ;
              
                return response;
           
        }

        internal bool DeleteAll(IMapper mapper, VacoDBContext context)
        {
            var post = context.Posts.ToList();
            context.RemoveRange(post);
            context.SaveChanges();
            return true;

        }

        internal bool DeleteById(IMapper mapper, VacoDBContext context,long id)
        {
            var post = context.Posts.FirstOrDefault(a => a.Id == id);

            if (post != null)
            {
                context.Remove(post);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
