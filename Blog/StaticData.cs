using Blog.Models.Domain;

namespace Blog
{
    public static class StaticData
    {
        public static List<Post> Posts = new();
        public static void AddPost(Post newPost)
        {
            Posts.Add(newPost);
        }
    }
}
