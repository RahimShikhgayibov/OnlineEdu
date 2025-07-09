namespace OnlineEdu.Entity.Entities;

public class CourseCategory
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Icon { get; set; }
    public string Description { get; set; }
    public bool IsShown { get; set; }
    public IList<Course> Courses { get; set; }
}
