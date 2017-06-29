using resume_testing_api.Models.BlogModel.Interfaces;
using System.Collections.Generic;

namespace resume_testing_api.ViewReaders.Blogs.Interfaces
{
    /// <summary>
    /// Interface for IBlogPost domain model objects used to wrap DB/Mock Layer interactions in generic functionality.
    /// </summary>
    public interface IBlogPostViewReader
    {
        /// <summary>
        /// Gets the posts matching the passed criteria.
        /// </summary>
        /// <param name="post">The post containing search criteria.</param>
        /// <returns>IEnumerable of IBlogPost containing results.</returns>
        IEnumerable<IBlogPost> GetPosts(IBlogPost post);
    }
}