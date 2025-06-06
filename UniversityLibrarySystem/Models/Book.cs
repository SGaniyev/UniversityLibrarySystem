﻿namespace UniversityLibrarySystem.Models;
using System.Collections.Generic;

public class Book
{
    public int Id { get; set; }
    public string Title  { get; set; }
    public string Author  { get; set; }
    public long BarCode { get; set; }
    public int CategoryId  { get; set; }
    public int DepartmentId  { get; set; }
    public int SectionId { get; set; }
    public int PublisherYear  { get; set; }
    public int AvalableCopies  { get; set; }
    public DateTime CreatedAt { get; set; }
    public Category Category { get; set; }
    public Department Department { get; set; }
    public Section Section { get; set; }
    public ICollection<Loan> Loans { get; set; }

}