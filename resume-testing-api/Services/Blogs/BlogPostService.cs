using resume_testing_api.Services.Blogs.Interfaces;
using System.Collections.Generic;
using resume_testing_api.Models.BlogModel.Interfaces;
using resume_testing_api.ViewReaders.Blogs.Interfaces;
using resume_testing_api.ViewReaders.Blogs;

namespace resume_testing_api.Services.Blogs
{
    /// <summary>
    /// Implementation of the IBlogPostService interface, supports basic CRUD functionality for the IBlogPost domain model object.
    /// </summary>
    /// <seealso cref="resume_testing_api.Services.Blogs.Interfaces.IBlogPostService" />
    /// <seealso cref="resume_testing_api.Models.BlogModel.BlogPost "/> 
    public class BlogPostService : IBlogPostService
    {
        private readonly IBlogPostViewReader svc;

        /// <summary>
        /// Initializes a new instance of the <see cref="BlogPostService"/> class.
        /// </summary>
        public BlogPostService()
        {
            if (svc == null) svc = new BlogPostViewReader();
        }

        /// <summary>
        /// Gets one or more Blog Posts from the mock layer.
        /// </summary>
        /// <param name="post">Optional Param to specify a single blog post or null for many</param>
        /// <returns>
        /// Collection of blog posts matching criteria
        /// </returns>
        public IEnumerable<IBlogPost> GetPosts(IBlogPost post = null) =>
            svc.GetPosts(post);
    }
}