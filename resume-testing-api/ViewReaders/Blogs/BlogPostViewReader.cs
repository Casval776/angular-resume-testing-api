﻿using resume_testing_api.ViewReaders.Blogs.Interfaces;
using System;
using System.Linq;
using System.Collections.Generic;
using resume_testing_api.Models.BlogModel.Interfaces;
using resume_testing_api.Models.BlogModel;

namespace resume_testing_api.ViewReaders.Blogs
{
    /// <summary>
    /// Implementation of the IBlogPostViewReader interface, supports basic interaction with DB/Mock Layer
    /// </summary>
    /// <seealso cref="resume_testing_api.ViewReaders.Blogs.Interfaces.IBlogPostViewReader" />
    public class BlogPostViewReader : IBlogPostViewReader
    {
        private readonly List<IBlogPost> mockPosts =
            new List<IBlogPost>()
            {
                { new BlogPost
                {
                    ID = 1,
                    BlogBody = "This is a blog body",
                    BlogComments = 0,
                    TitleDescription = "This is a description",
                    TitleHeading = "This is a title heading",
                    PostedDate = DateTime.Today,
                    ThumbnailImage = @"assets/images/banner1.jpg"
                } },
                { new BlogPost
                {
                    ID = 2,
                    BlogBody = "This is yet another blog body",
                    BlogComments = 1,
                    TitleDescription = "And another title description",
                    TitleHeading = "Woot! Another title heading!",
                    PostedDate = new DateTime(1990, 1, 23),
                    ThumbnailImage = @"assets/images/banner2.jpg"
                } }
            };
        /// <summary>
        /// Gets the posts matching the passed criteria.
        /// </summary>
        /// <param name="post">The post containing search criteria.</param>
        /// <returns>
        /// IEnumerable of IBlogPost containing results.
        /// </returns>
        /// <exception cref="NotImplementedException"></exception>
        public IEnumerable<IBlogPost> GetPosts(IBlogPost post)
        {
            if (post == null) return mockPosts;
            else
            {
                return mockPosts.Where(x => x.ID == post.ID);
            }
        }
    }
}