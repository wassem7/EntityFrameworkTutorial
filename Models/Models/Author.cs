﻿namespace Entity_Models.Models;

public class Author
{
    public int Id { get; set; }

    public List<Book> Books { get; set; }
    public string Name { get; set; }
}
