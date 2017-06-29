using System;

namespace resume_testing_api.Models.BlogModel.Interfaces
{
    /// <summary>
    /// Interface used to wrap Blog Post domain model objects in generic functionality
    /// </summary>
    public interface IBlogPost
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        int ID { get; set; }

        /// <summary>
        /// Gets or sets the title heading.
        /// </summary>
        /// <value>
        /// The title heading.
        /// </value>
        string TitleHeading { get; set; }

        /// <summary>
        /// Gets or sets the title description.
        /// </summary>
        /// <value>
        /// The title description.
        /// </value>
        string TitleDescription { get; set; }

        /// <summary>
        /// Gets or sets the posted date.
        /// </summary>
        /// <value>
        /// The posted date.
        /// </value>
        DateTime PostedDate { get; set; }

        /// <summary>
        /// Gets or sets the blog body.
        /// </summary>
        /// <value>
        /// The blog body.
        /// </value>
        string BlogBody { get; set; }

        /// <summary>
        /// Gets or sets the blog comments.
        /// </summary>
        /// <value>
        /// The blog comments.
        /// </value>
        int BlogComments { get; set; }

    }
}