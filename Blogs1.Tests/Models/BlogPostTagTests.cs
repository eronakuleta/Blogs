using Xunit;
using System;
using Main.Models.Domain;

namespace Blogs1.Tests.Models
{
    // Ky test kontrollon inicializimin e saktë dhe sjelljet e klasës BlogPostTag
    public class BlogPostTagTests
    {
        [Fact]
        public void BlogPostTag_ShouldInitializeCorrectly()
        {
            // Ky test verifikon që objekti BlogPostTag inicializohet saktë

          
            var blogPostId = Guid.NewGuid(); // Krijon një GUID unik për BlogPostId
            var tagId = Guid.NewGuid(); // Krijon një GUID unik për TagId

          
            var blogPostTag = new BlogPostTag
            {
                BlogPostId = blogPostId,
                TagId = tagId
            };

        
            Assert.Equal(blogPostId, blogPostTag.BlogPostId); // Krahaso BlogPostId
            Assert.Equal(tagId, blogPostTag.TagId); // Krahaso TagId
        }
        [Fact]
        public void BlogPostTag_ShouldUpdatePropertiesCorrectly()
        {
            // Ky test kontrollon që vlerat e BlogPostId dhe TagId mund të përditësohen pas inicializimit

        
            var blogPostTag = new BlogPostTag
            {
                BlogPostId = Guid.NewGuid(),
                TagId = Guid.NewGuid()
            };

            var newBlogPostId = Guid.NewGuid(); // GUID i ri për BlogPostId
            var newTagId = Guid.NewGuid(); // GUID i ri për TagId

           
            blogPostTag.BlogPostId = newBlogPostId;
            blogPostTag.TagId = newTagId;

            Assert.Equal(newBlogPostId, blogPostTag.BlogPostId); // Krahaso BlogPostId të ri
            Assert.Equal(newTagId, blogPostTag.TagId); // Krahaso TagId të ri
        }

        [Fact]
        //Nëse klasa BlogPostTag mbështet lidhje opsionale me klasat BlogPost ose Tag,
        //mund të shtosh një test që siguron se inicializimi i tyre me null nuk shkakton ndonjë problem.
        public void BlogPostTag_ShouldInitializeCorrectly_WithNullReferences()
        {
            
            var blogPostId = Guid.NewGuid();
            var tagId = Guid.NewGuid();

           
            var blogPostTag = new BlogPostTag
            {
                BlogPostId = blogPostId,
                TagId = tagId,
                BlogPost = null, // Nuk ka lidhje me një BlogPost
                Tag = null // Nuk ka lidhje me një Tag
            };

            // Assert: Kontrollo që inicializimi ka ndodhur saktë
            Assert.Equal(blogPostId, blogPostTag.BlogPostId);
            Assert.Equal(tagId, blogPostTag.TagId);
            Assert.Null(blogPostTag.BlogPost);
            Assert.Null(blogPostTag.Tag);
        }

    }
}
