﻿namespace UniversityLibrarySystem.Models;
using System.Collections.Generic;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    
    public ICollection<Book> Books { get; set; }
}