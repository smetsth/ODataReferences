using System.Linq;
using ODataReferences.Contracts;

namespace ODataReferences.Services
{
    public class BlogDataResources : IBlogDataResources
    {
        private readonly BlogPost[] _blogPosts =
            new[]
                {
                    new BlogPost {Id = 1, Title = "OData.org: Data for everyone"},
                    new BlogPost {Id = 2, Title = "WCF Data Services: Don't generate that reference!"}
                };

        #region IBlogDataResources Members

        public IQueryable<BlogPost> Posts
        {
            get { return _blogPosts.AsQueryable(); }
        }

        #endregion
    }
}