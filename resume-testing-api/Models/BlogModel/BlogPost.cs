using resume_testing_api.Models.BlogModel.Interfaces;
using System;

namespace resume_testing_api.Models.BlogModel
{
    /// <summary>
    /// BlogPost domain model object containing all relevant data to Blog Posts.
    /// </summary>
    /// <seealso cref="resume_testing_api.Models.BlogModel.Interfaces.IBlogPost" />
    public class BlogPost : IBlogPost
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the title heading.
        /// </summary>
        /// <value>
        /// The title heading.
        /// </value>
        public string TitleHeading { get; set; }

        /// <summary>
        /// Gets or sets the title description.
        /// </summary>
        /// <value>
        /// The title description.
        /// </value>
        public string TitleDescription { get; set; }

        /// <summary>
        /// Gets or sets the posted date.
        /// </summary>
        /// <value>
        /// The posted date.
        /// </value>
        public DateTime PostedDate { get; set; }

        /// <summary>
        /// Gets or sets the blog body.
        /// </summary>
        /// <value>
        /// The blog body.
        /// </value>
        public string BlogBody { get; set; }

        /// <summary>
        /// Gets or sets the blog comments.
        /// </summary>
        /// <value>
        /// The blog comments.
        /// </value>
        public int BlogComments { get; set; }
    }
}