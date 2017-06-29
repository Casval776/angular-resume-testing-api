using resume_testing_api.Models.BlogModel;
using resume_testing_api.Models.BlogModel.Interfaces;
using System.Collections.Generic;
using System.Web.Http;

namespace resume_testing_api.Controllers.Blogs.Interfaces
{
    /// <summary>
    /// BlogPostController interface used to wrap collections of controllers in generic functionality.
    /// </summary>
    public interface IBlogPostController
    {
        /// <summary>
        /// Gets a collection of blog posts.
        /// </summary>
        /// <returns>Ok(IEnumerable of IBlogPost)</returns>
        IHttpActionResult GetPosts();

        /// <summary>
        /// Gets blog posts matching criteria specified in object properties
        /// </summary>
        /// <param name="post">The post.</param>
        /// <returns>Ok(IEnumerable of IBlogPost)</returns>
        IHttpActionResult GetPost(BlogPost post);
    }
}