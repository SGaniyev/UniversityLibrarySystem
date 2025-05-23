﻿namespace UniversityLibrarySystem.Models;

public class Group
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
    
    public ICollection<User> Users { get; set; } = new List<User>();
}