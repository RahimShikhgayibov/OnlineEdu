﻿namespace OnlineEdu.Entity.Entities;

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public decimal Price { get; set; }
    public bool IsShown { get; set; }
    public int CourseCategoryId { get; set; }
    public CourseCategory CourseCategory { get; set; }
}
