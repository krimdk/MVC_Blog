using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepoBlog.Models.BaseModels;
using RepoBlog.Models.ViewModels;

namespace RepoBlog.Factories
{
    public class PostFac:AutoFac<Post>
    {
        BilledeFac billedfac = new BilledeFac();
        public List<BlogIndex> GetIndexData()
        {
            List<BlogIndex> ListBlogIndex = new List<BlogIndex>(); 
            foreach (var post in GetAll())
            {
                BlogIndex blogIndex = new BlogIndex();
                blogIndex.Post = post;
                blogIndex.Billeder = billedfac.GetBy("PostID", post.ID);
                ListBlogIndex.Add(blogIndex);
            }
            return ListBlogIndex;
        } 
    }
}
