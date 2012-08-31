namespace BasicMVC4.Models
{
    public interface IPostRepository
    {
        int GetLatestVersion(string slug);

        Post GetVersion(string slug, int version);

        Post Save(string slug, Post content);
    }
}
