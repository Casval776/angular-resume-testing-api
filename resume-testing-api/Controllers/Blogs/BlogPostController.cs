using resume_testing_api.Controllers.Blogs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using resume_testing_api.Models.BlogModel;
using resume_testing_api.Models.BlogModel.Interfaces;
using resume_testing_api.Services.Blogs.Interfaces;
using resume_testing_api.Services.Blogs;

namespace resume_testing_api.Controllers.Blogs
{
    /// <summary>
    /// Public facing end-point to handle external blog-related requests.
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    /// <seealso cref="resume_testing_api.Controllers.Blogs.Interfaces.IBlogPostController" />
    public class BlogPostController : ApiController, IBlogPostController
    {
        private readonly IBlogPostService svc;
        /// <summary>
        /// Initializes a new instance of the <see cref="BlogPostController"/> class.
        /// </summary>
        public BlogPostController()
        {
            if (svc == null) svc = new BlogPostService();
        }

        /// <summary>
        /// Gets blog posts matching criteria specified in object properties
        /// </summary>
        /// <param name="post">The post.</param>
        /// <returns>
        /// Ok(IEnumerable of IBlogPost)
        /// </returns>
        [HttpPost]
        [Route("api/blog/")]
        public IHttpActionResult GetPost([FromBody]BlogPost post)
        {
            return Ok(new
            {
                res = svc.GetPosts(post)
            });
        }

        /// <summary>
        /// Gets a collection of blog posts.
        /// </summary>
        /// <returns>
        /// Ok(IEnumerable of IBlogPost)
        /// </returns>
        [HttpGet]
        [Route("api/blog/")]
        public IHttpActionResult GetPosts()
        {
            return Ok(new
            {
                res = svc.GetPosts()
            });
        }
    }
}
