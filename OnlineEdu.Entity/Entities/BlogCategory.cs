namespace OnlineEdu.Entity.Entities;

public class BlogCategory
{
    public int Id { get; set; }
    public string Name { get; set; }
    public IList<Blog> Blogs { get; set; }
}
