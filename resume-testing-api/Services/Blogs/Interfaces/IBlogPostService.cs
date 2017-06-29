using resume_testing_api.Models.BlogModel.Interfaces;
using System.Collections.Generic;

namespace resume_testing_api.Services.Blogs.Interfaces
{
    /// <summary>
    /// Interface for the Blog Post Service to wrap the transformation of Blog Post data generic.
    /// </summary>
    public interface IBlogPostService
    {
        /// <summary>
        /// Gets one or more Blog Posts from the mock layer.
        /// </summary>
        /// <param name="post">Optional Param to specify a single blog post or null for many</param>
        /// <returns>Collection of blog posts matching criteria</returns>
        IEnumerable<IBlogPost> GetPosts(IBlogPost post = null);
    }
}