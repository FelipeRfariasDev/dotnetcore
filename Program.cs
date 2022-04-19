using dotnetcore.Model.Entity;
using dotnetcore.Model.Repository;

namespace dotnetcore
{
    class Program
    {

        static void Main(string[] args)
        {
            var post1 = new Posts();
            post1.Id = Guid.NewGuid();
            post1.Titulo="titulo1";
            post1.Descricao="descrição1";
            
            var post2 = new Posts();
            post2.Id = Guid.NewGuid();
            post2.Titulo="titulo2";
            post2.Descricao="descrição2";

            PostRepository postRepository = new PostRepository();
            postRepository.setListPosts(post1);
            postRepository.setListPosts(post2);

            foreach (Posts post in postRepository.getListPosts())
            {
                Console.WriteLine(post.ToString());
            }
            /*
            List<Posts> listPosts = new List<Posts>();
            
            listPosts.Add(post1);
            listPosts.Add(post2);

            foreach (Posts post in listPosts)
            {
                Console.WriteLine(post.ToString());
            }*/
        }
    }
}


