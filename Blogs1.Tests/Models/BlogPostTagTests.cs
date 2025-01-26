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

          
            var blogPostId = Guid.NewGuid(); 
            var tagId = Guid.NewGuid(); 

          
            var blogPostTag = new BlogPostTag
            {
                BlogPostId = blogPostId,
                TagId = tagId
            };

        
            Assert.Equal(blogPostId, blogPostTag.BlogPostId); 
            Assert.Equal(tagId, blogPostTag.TagId); 
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

            var newBlogPostId = Guid.NewGuid(); 
            var newTagId = Guid.NewGuid(); 

           
            blogPostTag.BlogPostId = newBlogPostId;
            blogPostTag.TagId = newTagId;

            Assert.Equal(newBlogPostId, blogPostTag.BlogPostId); 
            Assert.Equal(newTagId, blogPostTag.TagId);
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
                BlogPost = null, 
                Tag = null
            };

           
            Assert.Equal(blogPostId, blogPostTag.BlogPostId);
            Assert.Equal(tagId, blogPostTag.TagId);
            Assert.Null(blogPostTag.BlogPost);
            Assert.Null(blogPostTag.Tag);
        }

    }
}
