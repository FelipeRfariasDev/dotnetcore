using dotnetcore.Model.Entity;

namespace dotnetcore.Model.Repository
{
    public class PostRepository
    {
        private List<Posts> listPosts = new List<Posts>();
        public void setListPosts(Posts post)
        {
            this.listPosts.Add(post);
        }
        public List<Posts> getListPosts()
        {
            return this.listPosts;
        }
    }
}